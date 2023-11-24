namespace RestaurantManager.GUI.UserControls
{
    partial class UC_ProductItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NameOfProductLbl = new System.Windows.Forms.Label();
            this.DetailsBtn = new Guna.UI2.WinForms.Guna2Button();
            this.PriceLbl = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NameOfProductLbl
            // 
            this.NameOfProductLbl.AutoSize = true;
            this.NameOfProductLbl.Font = new System.Drawing.Font("Segoe UI Symbol", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameOfProductLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.NameOfProductLbl.Location = new System.Drawing.Point(212, 18);
            this.NameOfProductLbl.Name = "NameOfProductLbl";
            this.NameOfProductLbl.Size = new System.Drawing.Size(134, 38);
            this.NameOfProductLbl.TabIndex = 1;
            this.NameOfProductLbl.Text = "Tên món";
            // 
            // DetailsBtn
            // 
            this.DetailsBtn.AutoRoundedCorners = true;
            this.DetailsBtn.BorderRadius = 20;
            this.DetailsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DetailsBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DetailsBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DetailsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DetailsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DetailsBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.DetailsBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailsBtn.ForeColor = System.Drawing.Color.White;
            this.DetailsBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(70)))), ((int)(((byte)(97)))));
            this.DetailsBtn.Location = new System.Drawing.Point(826, 91);
            this.DetailsBtn.Name = "DetailsBtn";
            this.DetailsBtn.Size = new System.Drawing.Size(176, 43);
            this.DetailsBtn.TabIndex = 16;
            this.DetailsBtn.Text = "Xem chi tiết";
            this.DetailsBtn.Click += new System.EventHandler(this.DetailsBtn_Click);
            // 
            // PriceLbl
            // 
            this.PriceLbl.AutoSize = true;
            this.PriceLbl.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PriceLbl.Location = new System.Drawing.Point(214, 70);
            this.PriceLbl.Name = "PriceLbl";
            this.PriceLbl.Size = new System.Drawing.Size(182, 29);
            this.PriceLbl.TabIndex = 1;
            this.PriceLbl.Text = "Giá: 20000 VNĐ";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.guna2PictureBox1.ErrorImage = null;
            this.guna2PictureBox1.Image = global::RestaurantManager.Properties.Resources.food_serving;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(19, 18);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(148, 116);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // UC_ProductItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.DetailsBtn);
            this.Controls.Add(this.PriceLbl);
            this.Controls.Add(this.NameOfProductLbl);
            this.Controls.Add(this.guna2PictureBox1);
            this.Name = "UC_ProductItem";
            this.Size = new System.Drawing.Size(1028, 146);
            this.Load += new System.EventHandler(this.UC_ProductItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label NameOfProductLbl;
        private Guna.UI2.WinForms.Guna2Button DetailsBtn;
        private System.Windows.Forms.Label PriceLbl;
    }
}
