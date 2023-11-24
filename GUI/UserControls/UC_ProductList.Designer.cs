namespace RestaurantManager.GUI.UserControls
{
    partial class UC_ProductList
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
            this.ListProductflowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // ListProductflowLayoutPanel
            // 
            this.ListProductflowLayoutPanel.AutoScroll = true;
            this.ListProductflowLayoutPanel.Location = new System.Drawing.Point(27, 30);
            this.ListProductflowLayoutPanel.Name = "ListProductflowLayoutPanel";
            this.ListProductflowLayoutPanel.Size = new System.Drawing.Size(1093, 478);
            this.ListProductflowLayoutPanel.TabIndex = 27;
            // 
            // UC_ProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ListProductflowLayoutPanel);
            this.Name = "UC_ProductList";
            this.Size = new System.Drawing.Size(1147, 560);
            this.Load += new System.EventHandler(this.UC_ProductList_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel ListProductflowLayoutPanel;
    }
}
