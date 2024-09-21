namespace PMS
{
    partial class manageProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(manageProduct));
            this.label26 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cartBtn = new System.Windows.Forms.Button();
            this.contactsBtn = new System.Windows.Forms.Label();
            this.aboutBtn = new System.Windows.Forms.Label();
            this.locationBtn = new System.Windows.Forms.Label();
            this.offersBtn = new System.Windows.Forms.Label();
            this.rewuestOrderBtn = new System.Windows.Forms.Label();
            this.homeBtn = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button11 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.productList = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.updateBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtproductId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productList)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(3, 80);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(92, 64);
            this.label26.TabIndex = 34;
            this.label26.Text = "🔙";
            this.label26.Click += new System.EventHandler(this.label26_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.cartBtn);
            this.panel3.Controls.Add(this.contactsBtn);
            this.panel3.Controls.Add(this.aboutBtn);
            this.panel3.Controls.Add(this.locationBtn);
            this.panel3.Controls.Add(this.offersBtn);
            this.panel3.Controls.Add(this.rewuestOrderBtn);
            this.panel3.Controls.Add(this.homeBtn);
            this.panel3.Controls.Add(this.pictureBox5);
            this.panel3.Location = new System.Drawing.Point(-8, -2);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1986, 78);
            this.panel3.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Montserrat ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(384, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 50);
            this.label1.TabIndex = 7;
            this.label1.Text = "CATEGORIES    ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cartBtn
            // 
            this.cartBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cartBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cartBtn.Font = new System.Drawing.Font("Montserrat ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartBtn.ForeColor = System.Drawing.Color.Black;
            this.cartBtn.Location = new System.Drawing.Point(1791, 15);
            this.cartBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cartBtn.Name = "cartBtn";
            this.cartBtn.Size = new System.Drawing.Size(128, 55);
            this.cartBtn.TabIndex = 1;
            this.cartBtn.Text = "Cart";
            this.cartBtn.UseVisualStyleBackColor = false;
            this.cartBtn.Click += new System.EventHandler(this.cartBtn_Click);
            // 
            // contactsBtn
            // 
            this.contactsBtn.AutoSize = true;
            this.contactsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.contactsBtn.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactsBtn.Location = new System.Drawing.Point(1630, 22);
            this.contactsBtn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.contactsBtn.Name = "contactsBtn";
            this.contactsBtn.Size = new System.Drawing.Size(152, 40);
            this.contactsBtn.TabIndex = 6;
            this.contactsBtn.Text = "Contacts";
            this.contactsBtn.Click += new System.EventHandler(this.contactsBtn_Click);
            // 
            // aboutBtn
            // 
            this.aboutBtn.AutoSize = true;
            this.aboutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aboutBtn.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutBtn.Location = new System.Drawing.Point(1514, 22);
            this.aboutBtn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(111, 40);
            this.aboutBtn.TabIndex = 5;
            this.aboutBtn.Text = "About";
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
            // 
            // locationBtn
            // 
            this.locationBtn.AutoSize = true;
            this.locationBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.locationBtn.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationBtn.Location = new System.Drawing.Point(1359, 22);
            this.locationBtn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.locationBtn.Name = "locationBtn";
            this.locationBtn.Size = new System.Drawing.Size(150, 40);
            this.locationBtn.TabIndex = 4;
            this.locationBtn.Text = "Location";
            this.locationBtn.Click += new System.EventHandler(this.locationBtn_Click);
            // 
            // offersBtn
            // 
            this.offersBtn.AutoSize = true;
            this.offersBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.offersBtn.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offersBtn.Location = new System.Drawing.Point(1240, 22);
            this.offersBtn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.offersBtn.Name = "offersBtn";
            this.offersBtn.Size = new System.Drawing.Size(109, 40);
            this.offersBtn.TabIndex = 3;
            this.offersBtn.Text = "Offers";
            this.offersBtn.Click += new System.EventHandler(this.offersBtn_Click);
            // 
            // rewuestOrderBtn
            // 
            this.rewuestOrderBtn.AutoSize = true;
            this.rewuestOrderBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rewuestOrderBtn.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rewuestOrderBtn.Location = new System.Drawing.Point(999, 22);
            this.rewuestOrderBtn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rewuestOrderBtn.Name = "rewuestOrderBtn";
            this.rewuestOrderBtn.Size = new System.Drawing.Size(238, 40);
            this.rewuestOrderBtn.TabIndex = 2;
            this.rewuestOrderBtn.Text = "Request Order";
            this.rewuestOrderBtn.Click += new System.EventHandler(this.rewuestOrderBtn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.AutoSize = true;
            this.homeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeBtn.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBtn.Location = new System.Drawing.Point(884, 22);
            this.homeBtn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(107, 40);
            this.homeBtn.TabIndex = 1;
            this.homeBtn.Text = "Home";
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(22, 2);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(208, 78);
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.button11);
            this.panel6.Controls.Add(this.button14);
            this.panel6.Controls.Add(this.button15);
            this.panel6.Controls.Add(this.button16);
            this.panel6.Location = new System.Drawing.Point(12, 640);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(406, 260);
            this.panel6.TabIndex = 40;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Montserrat ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.Black;
            this.button11.Location = new System.Drawing.Point(3, 5);
            this.button11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(394, 55);
            this.button11.TabIndex = 16;
            this.button11.Text = "PROFILE";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Montserrat ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.Color.Black;
            this.button14.Location = new System.Drawing.Point(4, 134);
            this.button14.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(394, 55);
            this.button14.TabIndex = 16;
            this.button14.Text = "MANAGE DEPARTMENT";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Font = new System.Drawing.Font("Montserrat ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.ForeColor = System.Drawing.Color.Black;
            this.button15.Location = new System.Drawing.Point(4, 198);
            this.button15.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(394, 55);
            this.button15.TabIndex = 16;
            this.button15.Text = "MANAGE SALARY";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Font = new System.Drawing.Font("Montserrat ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.ForeColor = System.Drawing.Color.Black;
            this.button16.Location = new System.Drawing.Point(4, 71);
            this.button16.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(394, 55);
            this.button16.TabIndex = 16;
            this.button16.Text = "MANAGE EMPLOYEE";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // productList
            // 
            this.productList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.productList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.productList.Location = new System.Drawing.Point(459, 254);
            this.productList.Name = "productList";
            this.productList.RowHeadersWidth = 62;
            this.productList.RowTemplate.Height = 28;
            this.productList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productList.Size = new System.Drawing.Size(1437, 698);
            this.productList.TabIndex = 38;
            this.productList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productList_CellContentClick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.updateBtn);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.addBtn);
            this.panel4.Controls.Add(this.txtProductPrice);
            this.panel4.Controls.Add(this.txtProductName);
            this.panel4.Controls.Add(this.txtproductId);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(12, 228);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(406, 396);
            this.panel4.TabIndex = 37;
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("Montserrat ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.ForeColor = System.Drawing.Color.Black;
            this.updateBtn.Location = new System.Drawing.Point(201, 300);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(162, 55);
            this.updateBtn.TabIndex = 16;
            this.updateBtn.Text = "UPDATE";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 33);
            this.label3.TabIndex = 1;
            this.label3.Text = "Product ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 33);
            this.label4.TabIndex = 1;
            this.label4.Text = "Product Name";
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Montserrat ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.Black;
            this.addBtn.Location = new System.Drawing.Point(32, 300);
            this.addBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(156, 55);
            this.addBtn.TabIndex = 16;
            this.addBtn.Text = "ADD";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductPrice.Location = new System.Drawing.Point(28, 228);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(330, 35);
            this.txtProductPrice.TabIndex = 0;
            // 
            // txtProductName
            // 
            this.txtProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(28, 138);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(330, 35);
            this.txtProductName.TabIndex = 0;
            // 
            // txtproductId
            // 
            this.txtproductId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtproductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproductId.Location = new System.Drawing.Point(28, 35);
            this.txtproductId.Name = "txtproductId";
            this.txtproductId.Size = new System.Drawing.Size(330, 35);
            this.txtproductId.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 66);
            this.label6.TabIndex = 1;
            this.label6.Text = "Product Price\r\n\r\n";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-6, 162);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1928, 47);
            this.panel1.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Manage Product ➡️";
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Montserrat ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.Black;
            this.deleteBtn.Location = new System.Drawing.Point(459, 978);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(1437, 55);
            this.deleteBtn.TabIndex = 35;
            this.deleteBtn.Text = "DELETE PRODUCT";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(1034, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(298, 55);
            this.label9.TabIndex = 39;
            this.label9.Text = "Products List";
            // 
            // manageProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1917, 1049);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.productList);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "manageProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "manageProduct";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productList)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cartBtn;
        private System.Windows.Forms.Label contactsBtn;
        private System.Windows.Forms.Label aboutBtn;
        private System.Windows.Forms.Label locationBtn;
        private System.Windows.Forms.Label offersBtn;
        private System.Windows.Forms.Label rewuestOrderBtn;
        private System.Windows.Forms.Label homeBtn;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.DataGridView productList;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox txtproductId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.TextBox txtProductName;
    }
}