namespace JeaViPOS
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.lblBrand = new System.Windows.Forms.Label();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.flowCards = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlSales = new System.Windows.Forms.Panel();
            this.lblSalesCaption = new System.Windows.Forms.Label();
            this.lblSales = new System.Windows.Forms.Label();
            this.pnlOrders = new System.Windows.Forms.Panel();
            this.lblOrdersCaption = new System.Windows.Forms.Label();
            this.lblOrders = new System.Windows.Forms.Label();
            this.pnlLow = new System.Windows.Forms.Panel();
            this.lblLowCaption = new System.Windows.Forms.Label();
            this.lblLow = new System.Windows.Forms.Label();
            this.pnlActive = new System.Windows.Forms.Panel();
            this.lblActiveCaption = new System.Windows.Forms.Label();
            this.lblActive = new System.Windows.Forms.Label();
            this.pnlSidebar.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.flowCards.SuspendLayout();
            this.pnlSales.SuspendLayout();
            this.pnlOrders.SuspendLayout();
            this.pnlLow.SuspendLayout();
            this.pnlActive.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlSidebar
            //
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.pnlSidebar.Controls.Add(this.btnLogout);
            this.pnlSidebar.Controls.Add(this.btnProducts);
            this.pnlSidebar.Controls.Add(this.btnDashboard);
            this.pnlSidebar.Controls.Add(this.lblBrand);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(220, 650);
            this.pnlSidebar.TabIndex = 2;
            //
            // lblBrand
            //
            this.lblBrand.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblBrand.ForeColor = System.Drawing.Color.White;
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.lblBrand.Size = new System.Drawing.Size(220, 80);
            this.lblBrand.Text = "JeaViPOS";
            this.lblBrand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // btnDashboard
            //
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(55, 65, 81);
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(220, 50);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            //
            // btnProducts
            //
            this.btnProducts.BackColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.btnProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(55, 65, 81);
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.ForeColor = System.Drawing.Color.FromArgb(209, 213, 219);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.btnProducts.Size = new System.Drawing.Size(220, 50);
            this.btnProducts.TabIndex = 1;
            this.btnProducts.Text = "Inventory / Products";
            this.btnProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.UseVisualStyleBackColor = false;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            //
            // btnLogout
            //
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(55, 65, 81);
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(252, 165, 165);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(220, 54);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Log out";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            //
            // pnlHeader
            //
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblRole);
            this.pnlHeader.Controls.Add(this.lblWelcome);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(880, 76);
            this.pnlHeader.TabIndex = 1;
            //
            // lblWelcome
            //
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.lblWelcome.Location = new System.Drawing.Point(30, 12);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Text = "Welcome";
            //
            // lblRole
            //
            this.lblRole.AutoSize = true;
            this.lblRole.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblRole.Location = new System.Drawing.Point(32, 44);
            this.lblRole.Name = "lblRole";
            this.lblRole.Text = "Role";
            //
            // pnlContent
            //
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(243, 244, 246);
            this.pnlContent.Controls.Add(this.flowCards);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(30);
            this.pnlContent.TabIndex = 0;
            //
            // flowCards
            //
            this.flowCards.Controls.Add(this.pnlSales);
            this.flowCards.Controls.Add(this.pnlOrders);
            this.flowCards.Controls.Add(this.pnlLow);
            this.flowCards.Controls.Add(this.pnlActive);
            this.flowCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowCards.Name = "flowCards";
            this.flowCards.Size = new System.Drawing.Size(820, 150);
            this.flowCards.TabIndex = 0;
            //
            // Card 1: Today's Sales
            //
            this.pnlSales.BackColor = System.Drawing.Color.White;
            this.pnlSales.Controls.Add(this.lblSales);
            this.pnlSales.Controls.Add(this.lblSalesCaption);
            this.pnlSales.Margin = new System.Windows.Forms.Padding(0, 0, 24, 24);
            this.pnlSales.Name = "pnlSales";
            this.pnlSales.Size = new System.Drawing.Size(240, 120);
            this.lblSalesCaption.AutoSize = true;
            this.lblSalesCaption.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblSalesCaption.Location = new System.Drawing.Point(20, 18);
            this.lblSalesCaption.Name = "lblSalesCaption";
            this.lblSalesCaption.Text = "Today's Sales";
            this.lblSales.AutoSize = true;
            this.lblSales.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblSales.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.lblSales.Location = new System.Drawing.Point(16, 48);
            this.lblSales.Name = "lblSales";
            this.lblSales.Text = "0";
            //
            // Card 2: Today's Orders
            //
            this.pnlOrders.BackColor = System.Drawing.Color.White;
            this.pnlOrders.Controls.Add(this.lblOrders);
            this.pnlOrders.Controls.Add(this.lblOrdersCaption);
            this.pnlOrders.Margin = new System.Windows.Forms.Padding(0, 0, 24, 24);
            this.pnlOrders.Name = "pnlOrders";
            this.pnlOrders.Size = new System.Drawing.Size(240, 120);
            this.lblOrdersCaption.AutoSize = true;
            this.lblOrdersCaption.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblOrdersCaption.Location = new System.Drawing.Point(20, 18);
            this.lblOrdersCaption.Name = "lblOrdersCaption";
            this.lblOrdersCaption.Text = "Today's Orders";
            this.lblOrders.AutoSize = true;
            this.lblOrders.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblOrders.ForeColor = System.Drawing.Color.FromArgb(22, 163, 74);
            this.lblOrders.Location = new System.Drawing.Point(16, 48);
            this.lblOrders.Name = "lblOrders";
            this.lblOrders.Text = "0";
            //
            // Card 3: Low Stock
            //
            this.pnlLow.BackColor = System.Drawing.Color.White;
            this.pnlLow.Controls.Add(this.lblLow);
            this.pnlLow.Controls.Add(this.lblLowCaption);
            this.pnlLow.Margin = new System.Windows.Forms.Padding(0, 0, 24, 24);
            this.pnlLow.Name = "pnlLow";
            this.pnlLow.Size = new System.Drawing.Size(240, 120);
            this.lblLowCaption.AutoSize = true;
            this.lblLowCaption.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblLowCaption.Location = new System.Drawing.Point(20, 18);
            this.lblLowCaption.Name = "lblLowCaption";
            this.lblLowCaption.Text = "Low Stock Items";
            this.lblLow.AutoSize = true;
            this.lblLow.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblLow.ForeColor = System.Drawing.Color.FromArgb(234, 88, 12);
            this.lblLow.Location = new System.Drawing.Point(16, 48);
            this.lblLow.Name = "lblLow";
            this.lblLow.Text = "0";
            //
            // Card 4: Active Products
            //
            this.pnlActive.BackColor = System.Drawing.Color.White;
            this.pnlActive.Controls.Add(this.lblActive);
            this.pnlActive.Controls.Add(this.lblActiveCaption);
            this.pnlActive.Margin = new System.Windows.Forms.Padding(0, 0, 24, 24);
            this.pnlActive.Name = "pnlActive";
            this.pnlActive.Size = new System.Drawing.Size(240, 120);
            this.lblActiveCaption.AutoSize = true;
            this.lblActiveCaption.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblActiveCaption.Location = new System.Drawing.Point(20, 18);
            this.lblActiveCaption.Name = "lblActiveCaption";
            this.lblActiveCaption.Text = "Active Products";
            this.lblActive.AutoSize = true;
            this.lblActive.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblActive.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.lblActive.Location = new System.Drawing.Point(16, 48);
            this.lblActive.Name = "lblActive";
            this.lblActive.Text = "0";
            //
            // MainForm  (add order: Fill first, then Top, then Left)
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSidebar);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JeaViPOS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.flowCards.ResumeLayout(false);
            this.pnlSales.ResumeLayout(false);
            this.pnlSales.PerformLayout();
            this.pnlOrders.ResumeLayout(false);
            this.pnlOrders.PerformLayout();
            this.pnlLow.ResumeLayout(false);
            this.pnlLow.PerformLayout();
            this.pnlActive.ResumeLayout(false);
            this.pnlActive.PerformLayout();
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.FlowLayoutPanel flowCards;
        private System.Windows.Forms.Panel pnlSales;
        private System.Windows.Forms.Label lblSalesCaption;
        private System.Windows.Forms.Label lblSales;
        private System.Windows.Forms.Panel pnlOrders;
        private System.Windows.Forms.Label lblOrdersCaption;
        private System.Windows.Forms.Label lblOrders;
        private System.Windows.Forms.Panel pnlLow;
        private System.Windows.Forms.Label lblLowCaption;
        private System.Windows.Forms.Label lblLow;
        private System.Windows.Forms.Panel pnlActive;
        private System.Windows.Forms.Label lblActiveCaption;
        private System.Windows.Forms.Label lblActive;
    }
}