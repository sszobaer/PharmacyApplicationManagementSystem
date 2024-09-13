using System.Windows.Forms;

namespace PMS
{
    partial class Cart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cart));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.contactsBtn = new System.Windows.Forms.Label();
            this.aboutBtn = new System.Windows.Forms.Label();
            this.locationBtn = new System.Windows.Forms.Label();
            this.offersBtn = new System.Windows.Forms.Label();
            this.requestOrderBtn = new System.Windows.Forms.Label();
            this.homeBtn = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.cartList = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.orderBtn = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.contactsBtn);
            this.panel3.Controls.Add(this.aboutBtn);
            this.panel3.Controls.Add(this.locationBtn);
            this.panel3.Controls.Add(this.offersBtn);
            this.panel3.Controls.Add(this.requestOrderBtn);
            this.panel3.Controls.Add(this.homeBtn);
            this.panel3.Controls.Add(this.pictureBox5);
            this.panel3.Location = new System.Drawing.Point(-14, -2);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1986, 78);
            this.panel3.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Montserrat ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(382, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 50);
            this.label1.TabIndex = 7;
            this.label1.Text = "CATEGORIES    ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            // 
            // requestOrderBtn
            // 
            this.requestOrderBtn.AutoSize = true;
            this.requestOrderBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.requestOrderBtn.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestOrderBtn.Location = new System.Drawing.Point(999, 22);
            this.requestOrderBtn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.requestOrderBtn.Name = "requestOrderBtn";
            this.requestOrderBtn.Size = new System.Drawing.Size(238, 40);
            this.requestOrderBtn.TabIndex = 2;
            this.requestOrderBtn.Text = "Request Order";
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
            // cartList
            // 
            this.cartList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.cartList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.cartList.Location = new System.Drawing.Point(21, 185);
            this.cartList.Name = "cartList";
            this.cartList.RowHeadersWidth = 62;
            this.cartList.RowTemplate.Height = 28;
            this.cartList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cartList.Size = new System.Drawing.Size(1880, 735);
            this.cartList.TabIndex = 40;
            this.cartList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cartList_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Montserrat Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(867, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 55);
            this.label2.TabIndex = 1;
            this.label2.Text = "CART LIST";
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Transparent;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(978, 942);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(921, 68);
            this.deleteBtn.TabIndex = 41;
            this.deleteBtn.Text = "DELETE";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // orderBtn
            // 
            this.orderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.orderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderBtn.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderBtn.Location = new System.Drawing.Point(21, 942);
            this.orderBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(928, 68);
            this.orderBtn.TabIndex = 41;
            this.orderBtn.Text = "PLACE ORDER";
            this.orderBtn.UseVisualStyleBackColor = false;
            this.orderBtn.Click += new System.EventHandler(this.orderBtn_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(15, 83);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(92, 64);
            this.label26.TabIndex = 42;
            this.label26.Text = "🔙";
            this.label26.Click += new System.EventHandler(this.label26_Click);
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1917, 1049);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.orderBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.cartList);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Name = "Cart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cart";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label contactsBtn;
        private System.Windows.Forms.Label aboutBtn;
        private System.Windows.Forms.Label locationBtn;
        private System.Windows.Forms.Label offersBtn;
        private System.Windows.Forms.Label requestOrderBtn;
        private System.Windows.Forms.Label homeBtn;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.DataGridView cartList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button orderBtn;
        private System.Windows.Forms.Label label26;
    }
}