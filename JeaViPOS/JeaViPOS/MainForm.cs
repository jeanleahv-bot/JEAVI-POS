using System;
using System.Linq;
using System.Windows.Forms;

namespace JeaViPOS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Text = "JeaViPOS";
            lblWelcome.Text = "Welcome, " + Session.FullName;
            lblRole.Text = Session.RoleName + "   |   " + DateTime.Today.ToString("dddd, MMMM d, yyyy");
            btnProducts.Visible = Session.RoleName != "Cashier"; // role-based menu
        }

        private void MainForm_Load(object sender, EventArgs e) { LoadMetrics(); }

        private void btnDashboard_Click(object sender, EventArgs e) { LoadMetrics(); }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            using (var f = new ProductForm()) f.ShowDialog(this);
            LoadMetrics(); // refresh numbers after inventory changes
        }

        private void btnLogout_Click(object sender, EventArgs e) { Close(); }

        private void LoadMetrics()
        {
            try
            {
                using (var db = new VillacortaDataContext())
                {
                    var today = DateTime.Today;
                    var sales = db.Orders
                        .Where(o => o.Status == "Completed" && o.OrderDate >= today)
                        .Select(o => (decimal?)o.Total).Sum() ?? 0m;

                    lblSales.Text = sales.ToString("N2");
                    lblOrders.Text = db.Orders.Count(o => o.Status == "Completed" && o.OrderDate >= today).ToString();
                    lblLow.Text = db.Products.Count(p => p.IsActive && p.StockQty <= p.ReorderLevel).ToString();
                    lblActive.Text = db.Products.Count(p => p.IsActive).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Dashboard", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}