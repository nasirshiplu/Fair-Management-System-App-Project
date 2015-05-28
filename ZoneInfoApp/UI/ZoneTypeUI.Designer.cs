namespace ZoneInfoApp.UI
{
    partial class ZoneTypeUI
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
            this.zoneTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.zoneNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.zoneListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.zoneTypeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // zoneTypeGroupBox
            // 
            this.zoneTypeGroupBox.Controls.Add(this.saveButton);
            this.zoneTypeGroupBox.Controls.Add(this.zoneNameTextBox);
            this.zoneTypeGroupBox.Controls.Add(this.label1);
            this.zoneTypeGroupBox.Location = new System.Drawing.Point(12, 13);
            this.zoneTypeGroupBox.Name = "zoneTypeGroupBox";
            this.zoneTypeGroupBox.Size = new System.Drawing.Size(413, 83);
            this.zoneTypeGroupBox.TabIndex = 0;
            this.zoneTypeGroupBox.TabStop = false;
            this.zoneTypeGroupBox.Text = "Zone Type";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(332, 37);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // zoneNameTextBox
            // 
            this.zoneNameTextBox.Location = new System.Drawing.Point(74, 37);
            this.zoneNameTextBox.Name = "zoneNameTextBox";
            this.zoneNameTextBox.Size = new System.Drawing.Size(242, 20);
            this.zoneNameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type Name";
            // 
            // zoneListView
            // 
            this.zoneListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.zoneListView.FullRowSelect = true;
            this.zoneListView.GridLines = true;
            this.zoneListView.Location = new System.Drawing.Point(12, 102);
            this.zoneListView.Name = "zoneListView";
            this.zoneListView.Size = new System.Drawing.Size(413, 230);
            this.zoneListView.TabIndex = 1;
            this.zoneListView.UseCompatibleStateImageBehavior = false;
            this.zoneListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Zone Type";
            this.columnHeader2.Width = 222;
            // 
            // ZoneTypeUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 344);
            this.Controls.Add(this.zoneListView);
            this.Controls.Add(this.zoneTypeGroupBox);
            this.Name = "ZoneTypeUI";
            this.Text = "Zone Type Entry";
            this.zoneTypeGroupBox.ResumeLayout(false);
            this.zoneTypeGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox zoneTypeGroupBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox zoneNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView zoneListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}