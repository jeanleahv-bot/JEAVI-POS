namespace JeaViPOS
{
    partial class ProductEditorForm
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
            this.lblSku = new System.Windows.Forms.Label();
            this.txtSku = new System.Windows.Forms.TextBox();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lblReorder = new System.Windows.Forms.Label();
            this.txtReorder = new System.Windows.Forms.TextBox();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            //
            // Row 1: SKU | Barcode
            //
            this.lblSku.AutoSize = true;
            this.lblSku.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblSku.Location = new System.Drawing.Point(24, 20);
            this.lblSku.Name = "lblSku";
            this.lblSku.Text = "SKU *";
            this.txtSku.Location = new System.Drawing.Point(24, 44);
            this.txtSku.Name = "txtSku";
            this.txtSku.Size = new System.Drawing.Size(204, 30);
            this.txtSku.TabIndex = 0;
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblBarcode.Location = new System.Drawing.Point(252, 20);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Text = "Barcode";
            this.txtBarcode.Location = new System.Drawing.Point(252, 44);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(204, 30);
            this.txtBarcode.TabIndex = 1;
            //
            // Row 2: Product name
            //
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblName.Location = new System.Drawing.Point(24, 88);
            this.lblName.Name = "lblName";
            this.lblName.Text = "Product name *";
            this.txtName.Location = new System.Drawing.Point(24, 112);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(432, 30);
            this.txtName.TabIndex = 2;
            //
            // Row 3: Category
            //
            this.lblCategory.AutoSize = true;
            this.lblCategory.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblCategory.Location = new System.Drawing.Point(24, 156);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Text = "Category *";
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(24, 180);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(432, 31);
            this.cboCategory.TabIndex = 3;
            //
            // Row 4: Price | Cost
            //
            this.lblPrice.AutoSize = true;
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblPrice.Location = new System.Drawing.Point(24, 224);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Text = "Selling price *";
            this.txtPrice.Location = new System.Drawing.Point(24, 248);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(204, 30);
            this.txtPrice.TabIndex = 4;
            this.lblCost.AutoSize = true;
            this.lblCost.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblCost.Location = new System.Drawing.Point(252, 224);
            this.lblCost.Name = "lblCost";
            this.lblCost.Text = "Cost price *";
            this.txtCost.Location = new System.Drawing.Point(252, 248);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(204, 30);
            this.txtCost.TabIndex = 5;
            //
            // Row 5: Stock | Reorder level
            //
            this.lblStock.AutoSize = true;
            this.lblStock.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblStock.Location = new System.Drawing.Point(24, 292);
            this.lblStock.Name = "lblStock";
            this.lblStock.Text = "Stock *";
            this.txtStock.Location = new System.Drawing.Point(24, 316);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(204, 30);
            this.txtStock.TabIndex = 6;
            this.txtStock.Text = "0";
            this.lblReorder.AutoSize = true;
            this.lblReorder.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblReorder.Location = new System.Drawing.Point(252, 292);
            this.lblReorder.Name = "lblReorder";
            this.lblReorder.Text = "Reorder level *";
            this.txtReorder.Location = new System.Drawing.Point(252, 316);
            this.txtReorder.Name = "txtReorder";
            this.txtReorder.Size = new System.Drawing.Size(204, 30);
            this.txtReorder.TabIndex = 7;
            this.txtReorder.Text = "5";
            //
            // chkActive
            //
            this.chkActive.AutoSize = true;
            this.chkActive.Checked = true;
            this.chkActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActive.Location = new System.Drawing.Point(24, 368);
            this.chkActive.Name = "chkActive";
            this.chkActive.TabIndex = 8;
            this.chkActive.Text = "Product is active";
            this.chkActive.UseVisualStyleBackColor = true;
            //
            // pnlFooter
            //
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(249, 250, 251);
            this.pnlFooter.Controls.Add(this.btnCancel);
            this.pnlFooter.Controls.Add(this.btnSave);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(480, 64);
            this.pnlFooter.TabIndex = 9;
            //
            // btnCancel
            //
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(244, 14);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 36);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            //
            // btnSave
            //
            this.btnSave.Location = new System.Drawing.Point(356, 14);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 36);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            //
            // ProductEditorForm
            //
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(480, 470);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.chkActive);
            this.Controls.Add(this.txtReorder);
            this.Controls.Add(this.lblReorder);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.lblBarcode);
            this.Controls.Add(this.txtSku);
            this.Controls.Add(this.lblSku);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Product";
            this.Load += new System.EventHandler(this.ProductEditorForm_Load);
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Label lblSku;
        private System.Windows.Forms.TextBox txtSku;
        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label lblReorder;
        private System.Windows.Forms.TextBox txtReorder;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}