namespace WinModernFlatUi
{
    partial class FormMainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlMenu = new Panel();
            btnSetting = new FontAwesome.Sharp.IconButton();
            btnMarketing = new FontAwesome.Sharp.IconButton();
            btnCustomer = new FontAwesome.Sharp.IconButton();
            btnProduct = new FontAwesome.Sharp.IconButton();
            btnOrder = new FontAwesome.Sharp.IconButton();
            btnDashboard = new FontAwesome.Sharp.IconButton();
            pnlLogo = new Panel();
            pnlMenu.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(31, 30, 68);
            pnlMenu.Controls.Add(btnSetting);
            pnlMenu.Controls.Add(btnMarketing);
            pnlMenu.Controls.Add(btnCustomer);
            pnlMenu.Controls.Add(btnProduct);
            pnlMenu.Controls.Add(btnOrder);
            pnlMenu.Controls.Add(btnDashboard);
            pnlMenu.Controls.Add(pnlLogo);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(220, 592);
            pnlMenu.TabIndex = 0;
            // 
            // btnSetting
            // 
            btnSetting.Dock = DockStyle.Top;
            btnSetting.FlatAppearance.BorderSize = 0;
            btnSetting.FlatStyle = FlatStyle.Flat;
            btnSetting.ForeColor = Color.Gainsboro;
            btnSetting.IconChar = FontAwesome.Sharp.IconChar.Tools;
            btnSetting.IconColor = Color.Gainsboro;
            btnSetting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSetting.IconSize = 32;
            btnSetting.ImageAlign = ContentAlignment.MiddleLeft;
            btnSetting.Location = new Point(0, 440);
            btnSetting.Name = "btnSetting";
            btnSetting.Size = new Size(220, 60);
            btnSetting.TabIndex = 6;
            btnSetting.Text = "Setting";
            btnSetting.TextAlign = ContentAlignment.MiddleLeft;
            btnSetting.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSetting.UseVisualStyleBackColor = true;
            // 
            // btnMarketing
            // 
            btnMarketing.Dock = DockStyle.Top;
            btnMarketing.FlatAppearance.BorderSize = 0;
            btnMarketing.FlatStyle = FlatStyle.Flat;
            btnMarketing.ForeColor = Color.Gainsboro;
            btnMarketing.IconChar = FontAwesome.Sharp.IconChar.MailBulk;
            btnMarketing.IconColor = Color.Gainsboro;
            btnMarketing.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMarketing.IconSize = 32;
            btnMarketing.ImageAlign = ContentAlignment.MiddleLeft;
            btnMarketing.Location = new Point(0, 380);
            btnMarketing.Name = "btnMarketing";
            btnMarketing.Size = new Size(220, 60);
            btnMarketing.TabIndex = 5;
            btnMarketing.Text = "Marketing";
            btnMarketing.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMarketing.UseVisualStyleBackColor = true;
            // 
            // btnCustomer
            // 
            btnCustomer.Dock = DockStyle.Top;
            btnCustomer.FlatAppearance.BorderSize = 0;
            btnCustomer.FlatStyle = FlatStyle.Flat;
            btnCustomer.ForeColor = Color.Gainsboro;
            btnCustomer.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            btnCustomer.IconColor = Color.Gainsboro;
            btnCustomer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCustomer.IconSize = 32;
            btnCustomer.ImageAlign = ContentAlignment.MiddleLeft;
            btnCustomer.Location = new Point(0, 320);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(220, 60);
            btnCustomer.TabIndex = 4;
            btnCustomer.Text = "Customers";
            btnCustomer.TextAlign = ContentAlignment.MiddleLeft;
            btnCustomer.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCustomer.UseVisualStyleBackColor = true;
            // 
            // btnProduct
            // 
            btnProduct.Dock = DockStyle.Top;
            btnProduct.FlatAppearance.BorderSize = 0;
            btnProduct.FlatStyle = FlatStyle.Flat;
            btnProduct.ForeColor = Color.Gainsboro;
            btnProduct.IconChar = FontAwesome.Sharp.IconChar.Tag;
            btnProduct.IconColor = Color.Gainsboro;
            btnProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnProduct.IconSize = 32;
            btnProduct.ImageAlign = ContentAlignment.MiddleLeft;
            btnProduct.Location = new Point(0, 260);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(220, 60);
            btnProduct.TabIndex = 3;
            btnProduct.Text = "Products";
            btnProduct.TextAlign = ContentAlignment.MiddleLeft;
            btnProduct.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProduct.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            btnOrder.Dock = DockStyle.Top;
            btnOrder.FlatAppearance.BorderSize = 0;
            btnOrder.FlatStyle = FlatStyle.Flat;
            btnOrder.ForeColor = Color.Gainsboro;
            btnOrder.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            btnOrder.IconColor = Color.Gainsboro;
            btnOrder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnOrder.IconSize = 32;
            btnOrder.ImageAlign = ContentAlignment.MiddleLeft;
            btnOrder.Location = new Point(0, 200);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(220, 60);
            btnOrder.TabIndex = 2;
            btnOrder.Text = "Orders";
            btnOrder.TextAlign = ContentAlignment.MiddleLeft;
            btnOrder.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOrder.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.ForeColor = Color.Gainsboro;
            btnDashboard.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            btnDashboard.IconColor = Color.Gainsboro;
            btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDashboard.IconSize = 32;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(0, 140);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(220, 60);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = true;
            // 
            // pnlLogo
            // 
            pnlLogo.Dock = DockStyle.Top;
            pnlLogo.Location = new Point(0, 0);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(220, 140);
            pnlLogo.TabIndex = 0;
            // 
            // FormMainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 592);
            Controls.Add(pnlMenu);
            Name = "FormMainMenu";
            Text = "Form1";
            pnlMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMenu;
        private Panel pnlLogo;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private FontAwesome.Sharp.IconButton btnSetting;
        private FontAwesome.Sharp.IconButton btnMarketing;
        private FontAwesome.Sharp.IconButton btnCustomer;
        private FontAwesome.Sharp.IconButton btnProduct;
        private FontAwesome.Sharp.IconButton btnOrder;
    }
}