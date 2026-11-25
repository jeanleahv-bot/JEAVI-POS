using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace JeaViPOS
{
    public partial class ProductEditorForm : Form
    {
        private readonly int productId; // 0 = new product

        // Needed so the Visual Studio designer can open this form
        public ProductEditorForm() : this(0) { }

        public ProductEditorForm(int id)
        {
            InitializeComponent();
            productId = id;
            Text = id == 0 ? "Add Product" : "Edit Product";
            Theme.StyleInputs(this);
            Theme.StylePrimary(btnSave);
            Theme.StyleSecondary(btnCancel);
        }

        private void ProductEditorForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveProduct();
        }

        private void LoadData()
        {
            try
            {
                using (var db = new VillacortaDataContext())
                {
                    cboCategory.DataSource = db.Categories.OrderBy(c => c.Name)
                        .Select(c => new { c.CategoryId, c.Name }).ToList();
                    cboCategory.DisplayMember = "Name";
                    cboCategory.ValueMember = "CategoryId";

                    if (productId != 0)
                    {
                        var p = db.Products.Single(x => x.ProductId == productId);
                        txtSku.Text = p.Sku;
                        txtBarcode.Text = p.Barcode;
                        txtName.Text = p.Name;
                        cboCategory.SelectedValue = p.CategoryId;
                        txtPrice.Text = p.Price.ToString(CultureInfo.CurrentCulture);
                        txtCost.Text = p.Cost.ToString(CultureInfo.CurrentCulture);
                        txtStock.Text = p.StockQty.ToString();
                        txtReorder.Text = p.ReorderLevel.ToString();
                        chkActive.Checked = p.IsActive;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveProduct()
        {
            string sku = txtSku.Text.Trim();
            string barcode = txtBarcode.Text.Trim();
            string name = txtName.Text.Trim();
            decimal price, cost;
            int stock, reorder;

            if (sku.Length == 0 || name.Length == 0) { Warn("SKU and product name are required."); return; }
            if (cboCategory.SelectedValue == null) { Warn("Select a category."); return; }
            if (!decimal.TryParse(txtPrice.Text, out price) || price < 0) { Warn("Enter a valid selling price (0 or more)."); return; }
            if (!decimal.TryParse(txtCost.Text, out cost) || cost < 0) { Warn("Enter a valid cost price (0 or more)."); return; }
            if (!int.TryParse(txtStock.Text, out stock) || stock < 0) { Warn("Stock must be a whole number (0 or more)."); return; }
            if (!int.TryParse(txtReorder.Text, out reorder) || reorder < 0) { Warn("Reorder level must be a whole number (0 or more)."); return; }

            try
            {
                using (var db = new VillacortaDataContext())
                {
                    if (db.Products.Any(x => x.Sku == sku && x.ProductId != productId))
                    { Warn("That SKU already exists."); return; }
                    if (barcode.Length > 0 && db.Products.Any(x => x.Barcode == barcode && x.ProductId != productId))
                    { Warn("That barcode already exists."); return; }

                    Product p;
                    int oldStock = 0;

                    if (productId == 0)
                    {
                        p = new Product { CreatedAt = DateTime.Now };
                        db.Products.InsertOnSubmit(p);
                    }
                    else
                    {
                        p = db.Products.Single(x => x.ProductId == productId);
                        oldStock = p.StockQty;
                    }

                    p.Sku = sku;
                    p.Barcode = barcode.Length == 0 ? null : barcode;
                    p.Name = name;
                    p.CategoryId = (int)cboCategory.SelectedValue;
                    p.Price = price;
                    p.Cost = cost;
                    p.StockQty = stock;
                    p.ReorderLevel = reorder;
                    p.IsActive = chkActive.Checked;
                    p.UpdatedAt = DateTime.Now;
                    db.SubmitChanges(); // new products get their ProductId here

                    if (stock != oldStock)
                    {
                        db.InventoryLogs.InsertOnSubmit(new InventoryLog
                        {
                            ProductId = p.ProductId,
                            ChangeQty = stock - oldStock,
                            Reason = productId == 0 ? "Initial stock" : "Manual adjustment",
                            UserId = Session.UserId,
                            CreatedAt = DateTime.Now
                        });
                        db.SubmitChanges();
                    }
                }
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Save failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void Warn(string msg)
        {
            MessageBox.Show(msg, "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}