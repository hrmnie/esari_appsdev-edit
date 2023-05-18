namespace esari_app
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.signInBackground = new System.Windows.Forms.PictureBox();
            this.homepageBackground = new System.Windows.Forms.PictureBox();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabOrderForm = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.newOrderBtn = new System.Windows.Forms.Button();
            this.lblItemsOrdered = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.dudProducts = new System.Windows.Forms.DomainUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOrder = new System.Windows.Forms.TextBox();
            this.tabCart = new System.Windows.Forms.TabPage();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lstProducts = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.signInBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homepageBackground)).BeginInit();
            this.headerPanel.SuspendLayout();
            this.tabOrderForm.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabCart.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // signInBackground
            // 
            this.signInBackground.Image = ((System.Drawing.Image)(resources.GetObject("signInBackground.Image")));
            this.signInBackground.Location = new System.Drawing.Point(-2, -1);
            this.signInBackground.Name = "signInBackground";
            this.signInBackground.Size = new System.Drawing.Size(879, 470);
            this.signInBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.signInBackground.TabIndex = 1;
            this.signInBackground.TabStop = false;
            // 
            // homepageBackground
            // 
            this.homepageBackground.Image = ((System.Drawing.Image)(resources.GetObject("homepageBackground.Image")));
            this.homepageBackground.Location = new System.Drawing.Point(-2, -1);
            this.homepageBackground.Name = "homepageBackground";
            this.homepageBackground.Size = new System.Drawing.Size(879, 470);
            this.homepageBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.homepageBackground.TabIndex = 2;
            this.homepageBackground.TabStop = false;
            this.homepageBackground.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.button3);
            this.headerPanel.Controls.Add(this.button2);
            this.headerPanel.Controls.Add(this.button1);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(877, 39);
            this.headerPanel.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(793, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Login";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(712, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "To Pay";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(635, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tabOrderForm
            // 
            this.tabOrderForm.Controls.Add(this.tabPage1);
            this.tabOrderForm.Controls.Add(this.tabCart);
            this.tabOrderForm.Controls.Add(this.tabPage3);
            this.tabOrderForm.Location = new System.Drawing.Point(66, 30);
            this.tabOrderForm.Name = "tabOrderForm";
            this.tabOrderForm.SelectedIndex = 0;
            this.tabOrderForm.Size = new System.Drawing.Size(692, 391);
            this.tabOrderForm.TabIndex = 0;
            this.tabOrderForm.SelectedIndexChanged += new System.EventHandler(this.tabShoppingCart);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.newOrderBtn);
            this.tabPage1.Controls.Add(this.lblItemsOrdered);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.dudProducts);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtOrder);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(684, 365);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Order Form";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(407, 276);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "Exit";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // newOrderBtn
            // 
            this.newOrderBtn.Location = new System.Drawing.Point(287, 277);
            this.newOrderBtn.Name = "newOrderBtn";
            this.newOrderBtn.Size = new System.Drawing.Size(75, 23);
            this.newOrderBtn.TabIndex = 5;
            this.newOrderBtn.Text = "New Order";
            this.newOrderBtn.UseVisualStyleBackColor = true;
            this.newOrderBtn.Click += new System.EventHandler(this.button5_Click);
            // 
            // lblItemsOrdered
            // 
            this.lblItemsOrdered.AutoSize = true;
            this.lblItemsOrdered.Location = new System.Drawing.Point(292, 257);
            this.lblItemsOrdered.Name = "lblItemsOrdered";
            this.lblItemsOrdered.Size = new System.Drawing.Size(68, 13);
            this.lblItemsOrdered.TabIndex = 4;
            this.lblItemsOrdered.Text = "Item Order: 0";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(289, 223);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Add to Order";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dudProducts
            // 
            this.dudProducts.Location = new System.Drawing.Point(273, 193);
            this.dudProducts.Name = "dudProducts";
            this.dudProducts.Size = new System.Drawing.Size(120, 20);
            this.dudProducts.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Checkout Order";
            // 
            // txtOrder
            // 
            this.txtOrder.Location = new System.Drawing.Point(29, 37);
            this.txtOrder.Multiline = true;
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.Size = new System.Drawing.Size(602, 305);
            this.txtOrder.TabIndex = 0;
            // 
            // tabCart
            // 
            this.tabCart.Controls.Add(this.lblTotalCost);
            this.tabCart.Controls.Add(this.lstProducts);
            this.tabCart.Location = new System.Drawing.Point(4, 22);
            this.tabCart.Name = "tabCart";
            this.tabCart.Padding = new System.Windows.Forms.Padding(3);
            this.tabCart.Size = new System.Drawing.Size(684, 365);
            this.tabCart.TabIndex = 1;
            this.tabCart.Text = "Shopping Cart";
            this.tabCart.UseVisualStyleBackColor = true;
            this.tabCart.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Location = new System.Drawing.Point(74, 257);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(58, 13);
            this.lblTotalCost.TabIndex = 1;
            this.lblTotalCost.Text = "Total Cost:";
            // 
            // lstProducts
            // 
            this.lstProducts.FormattingEnabled = true;
            this.lstProducts.Location = new System.Drawing.Point(66, 46);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(541, 199);
            this.lstProducts.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(684, 365);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Qr Code";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(66, 34);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(537, 210);
            this.textBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(877, 468);
            this.Controls.Add(this.tabOrderForm);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Esari";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.signInBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homepageBackground)).EndInit();
            this.headerPanel.ResumeLayout(false);
            this.tabOrderForm.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabCart.ResumeLayout(false);
            this.tabCart.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private signInForm signInForm1;
        private System.Windows.Forms.PictureBox signInBackground;
        private System.Windows.Forms.PictureBox homepageBackground;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabOrderForm;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabCart;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button newOrderBtn;
        private System.Windows.Forms.Label lblItemsOrdered;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DomainUpDown dudProducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOrder;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.ListBox lstProducts;
        private System.Windows.Forms.TextBox textBox1;
    }
}

