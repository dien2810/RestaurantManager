namespace RestaurantManager.GUI.UserControls
{
    partial class UC_MaterialPurchase
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AddMPBtn = new Guna.UI2.WinForms.Guna2Button();
            this.MaterialPurchasesDG = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.DeleteMPBtn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialPurchasesDG)).BeginInit();
            this.SuspendLayout();
            // 
            // AddMPBtn
            // 
            this.AddMPBtn.AutoRoundedCorners = true;
            this.AddMPBtn.BorderRadius = 21;
            this.AddMPBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddMPBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddMPBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddMPBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddMPBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.AddMPBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMPBtn.ForeColor = System.Drawing.Color.White;
            this.AddMPBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(70)))), ((int)(((byte)(97)))));
            this.AddMPBtn.Location = new System.Drawing.Point(916, 133);
            this.AddMPBtn.Name = "AddMPBtn";
            this.AddMPBtn.Size = new System.Drawing.Size(182, 45);
            this.AddMPBtn.TabIndex = 25;
            this.AddMPBtn.Text = "Thêm ĐN";
            this.AddMPBtn.Click += new System.EventHandler(this.AddMPBtn_Click);
            // 
            // MaterialPurchasesDG
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.MaterialPurchasesDG.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MaterialPurchasesDG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.MaterialPurchasesDG.ColumnHeadersHeight = 20;
            this.MaterialPurchasesDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MaterialPurchasesDG.DefaultCellStyle = dataGridViewCellStyle6;
            this.MaterialPurchasesDG.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.MaterialPurchasesDG.Location = new System.Drawing.Point(30, 116);
            this.MaterialPurchasesDG.Name = "MaterialPurchasesDG";
            this.MaterialPurchasesDG.RowHeadersVisible = false;
            this.MaterialPurchasesDG.RowHeadersWidth = 51;
            this.MaterialPurchasesDG.RowTemplate.Height = 24;
            this.MaterialPurchasesDG.Size = new System.Drawing.Size(818, 416);
            this.MaterialPurchasesDG.TabIndex = 22;
            this.MaterialPurchasesDG.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.MaterialPurchasesDG.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.MaterialPurchasesDG.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.MaterialPurchasesDG.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.MaterialPurchasesDG.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.MaterialPurchasesDG.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.MaterialPurchasesDG.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.MaterialPurchasesDG.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.MaterialPurchasesDG.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.MaterialPurchasesDG.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaterialPurchasesDG.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.MaterialPurchasesDG.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.MaterialPurchasesDG.ThemeStyle.HeaderStyle.Height = 20;
            this.MaterialPurchasesDG.ThemeStyle.ReadOnly = false;
            this.MaterialPurchasesDG.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.MaterialPurchasesDG.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.MaterialPurchasesDG.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaterialPurchasesDG.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.MaterialPurchasesDG.ThemeStyle.RowsStyle.Height = 24;
            this.MaterialPurchasesDG.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.MaterialPurchasesDG.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2Button1
            // 
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderRadius = 19;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2Button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(70)))), ((int)(((byte)(97)))));
            this.guna2Button1.Location = new System.Drawing.Point(714, 66);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(134, 40);
            this.guna2Button1.TabIndex = 26;
            this.guna2Button1.Text = "Lọc";
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.AutoRoundedCorners = true;
            this.guna2DateTimePicker1.BorderRadius = 17;
            this.guna2DateTimePicker1.Checked = true;
            this.guna2DateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(30, 70);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(678, 36);
            this.guna2DateTimePicker1.TabIndex = 27;
            this.guna2DateTimePicker1.Value = new System.DateTime(2023, 11, 16, 2, 44, 41, 244);
            // 
            // DeleteMPBtn
            // 
            this.DeleteMPBtn.AutoRoundedCorners = true;
            this.DeleteMPBtn.BorderRadius = 21;
            this.DeleteMPBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DeleteMPBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DeleteMPBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeleteMPBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DeleteMPBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.DeleteMPBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteMPBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteMPBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(70)))), ((int)(((byte)(97)))));
            this.DeleteMPBtn.Location = new System.Drawing.Point(916, 193);
            this.DeleteMPBtn.Name = "DeleteMPBtn";
            this.DeleteMPBtn.Size = new System.Drawing.Size(182, 45);
            this.DeleteMPBtn.TabIndex = 25;
            this.DeleteMPBtn.Text = "Xoá ĐN";
            this.DeleteMPBtn.Click += new System.EventHandler(this.DeletePurchaseBtn_Click);
            // 
            // UC_MaterialPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2DateTimePicker1);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.DeleteMPBtn);
            this.Controls.Add(this.AddMPBtn);
            this.Controls.Add(this.MaterialPurchasesDG);
            this.Name = "UC_MaterialPurchase";
            this.Size = new System.Drawing.Size(1147, 560);
            this.Load += new System.EventHandler(this.UC_MaterialPurchase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MaterialPurchasesDG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button AddMPBtn;
        private Guna.UI2.WinForms.Guna2DataGridView MaterialPurchasesDG;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private Guna.UI2.WinForms.Guna2Button DeleteMPBtn;
    }
}
