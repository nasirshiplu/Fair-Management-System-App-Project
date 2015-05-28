namespace ZoneInfoApp.UI
{
    partial class VisitorNumberUI
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
            this.zoneWithVisitorListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.grandTotalTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // zoneWithVisitorListView
            // 
            this.zoneWithVisitorListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.zoneWithVisitorListView.GridLines = true;
            this.zoneWithVisitorListView.Location = new System.Drawing.Point(48, 40);
            this.zoneWithVisitorListView.Name = "zoneWithVisitorListView";
            this.zoneWithVisitorListView.Size = new System.Drawing.Size(374, 136);
            this.zoneWithVisitorListView.TabIndex = 0;
            this.zoneWithVisitorListView.UseCompatibleStateImageBehavior = false;
            this.zoneWithVisitorListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Zone";
            this.columnHeader2.Width = 226;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "No. of Visitors";
            this.columnHeader3.Width = 83;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total";
            // 
            // grandTotalTextBox
            // 
            this.grandTotalTextBox.Location = new System.Drawing.Point(322, 190);
            this.grandTotalTextBox.Name = "grandTotalTextBox";
            this.grandTotalTextBox.ReadOnly = true;
            this.grandTotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.grandTotalTextBox.TabIndex = 2;
            // 
            // VisitorNumberUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 237);
            this.Controls.Add(this.grandTotalTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zoneWithVisitorListView);
            this.Name = "VisitorNumberUI";
            this.Text = "Visitor Number";
            this.Load += new System.EventHandler(this.VisitorNumberUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView zoneWithVisitorListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox grandTotalTextBox;
    }
}