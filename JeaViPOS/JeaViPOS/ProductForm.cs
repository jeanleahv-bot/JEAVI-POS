using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace JeaViPOS
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
            Theme.StyleInputs(this);
            Theme.StylePrimary(btnAdd);
            Theme.StylePrimary(btnSearch);
            Theme.StyleSecondary(btnEdit);
            Theme.StyleSecondary(btnRefresh);
            Theme.StyleDanger(btnDelete);
            Theme.StyleGrid(grid);
            Theme.SetPlaceholder(txtSearch, "Search by SKU, name or barcode");
        }

        private void ProductForm_Load(object sender, EventArgs e) { LoadRows(); }
        private void btnSearch_Click(object sender, EventArgs e) { LoadRows(); }
        private void btnRefresh_Click(object sender, EventArgs e) { txtSearch.Clear(); LoadRows(); }
        private void btnAdd_Click(object sender, EventArgs e) { OpenEditor(0); }
        private void btnEdit_Click(object sender, EventArgs e) { EditSelected(); }
        private void btnDelete_Click(object sender, EventArgs e) { DeleteSelected(); }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { LoadRows(); e.SuppressKeyPress = true; }
        }

        private void grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) EditSelected();
        }

        private void LoadRows()
        {
            try
            {
                using (var db = new VillacortaDataContext())
                {
                    var q = txtSearch.Text.Trim();
                    var rows = db.Products
                        .Where(p => p.IsActive &&
                                    (q == "" || p.Sku.Contains(q) || p.Name.Contains(q) ||
                                     (p.Barcode != null && p.Barcode.Contains(q))))
                        .OrderBy(p => p.Name)
                        .Select(p => new
                        {
                            p.ProductId,
                            p.Sku,
                            p.Barcode,
                            p.Name,
                            Category = p.Category.Name,
                            p.Price,
                            p.Cost,
                            p.StockQty,
                            p.ReorderLevel
                        })
                        .ToList();

                    grid.DataSource = rows;
                    int low = rows.Count(r => r.StockQty <= r.ReorderLevel);
                    lblCount.Text = rows.Count + " products   |   " + low + " low on stock (highlighted in red)";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Friendly column titles and number formats
        private void Col(string name, string header, float weight, bool number, bool money)
        {
            var c = grid.Columns[name];
            if (c == null) return;
            c.HeaderText = header;
            c.FillWeight = weight;
            if (money) c.DefaultCellStyle.Format = "N2";
            if (number)
            {
                c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }

        private void grid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (grid.Columns["ProductId"] != null) grid.Columns["ProductId"].Visible = false;

            Col("Sku", "SKU", 70, false, false);
            Col("Barcode", "Barcode", 100, false, false);
            Col("Name", "Product", 170, false, false);
            Col("Category", "Category", 90, false, false);
            Col("Price", "Price", 60, true, true);
            Col("Cost", "Cost", 60, true, true);
            Col("StockQty", "Stock", 55, true, false);
            Col("ReorderLevel", "Reorder at", 65, true, false);

            foreach (DataGridViewRow r in grid.Rows)
            {
                int stock = Convert.ToInt32(r.Cells["StockQty"].Value);
                int reorder = Convert.ToInt32(r.Cells["ReorderLevel"].Value);
                if (stock <= reorder)
                {
                    r.DefaultCellStyle.BackColor = Theme.LowRowBack;
                    r.DefaultCellStyle.ForeColor = Theme.LowRowText;
                }
            }
        }

        private int SelectedId()
        {
            if (grid.CurrentRow == null) return 0;
            return Convert.ToInt32(grid.CurrentRow.Cells["ProductId"].Value);
        }

        private void OpenEditor(int productId)
        {
            using (var editor = new ProductEditorForm(productId))
                if (editor.ShowDialog(this) == DialogResult.OK) LoadRows();
        }

        private void EditSelected()
        {
            int id = SelectedId();
            if (id == 0) { MessageBox.Show("Please select a product first.", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            OpenEditor(id);
        }

        // Soft delete: keeps the sales history intact
        private void DeleteSelected()
        {
            int id = SelectedId();
            if (id == 0) { MessageBox.Show("Please select a product first.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

            string name = Convert.ToString(grid.CurrentRow.Cells["Name"].Value);
            if (MessageBox.Show("Delete \"" + name + "\"?\nIt will be hidden from the list.", "Confirm delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            try
            {
                using (var db = new VillacortaDataContext())
                {
                    var p = db.Products.Single(x => x.ProductId == id);
                    p.IsActive = false;
                    p.UpdatedAt = DateTime.Now;
                    db.SubmitChanges();
                }
                LoadRows();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}