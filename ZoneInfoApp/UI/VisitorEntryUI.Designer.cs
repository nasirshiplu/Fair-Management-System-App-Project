namespace ZoneInfoApp.UI
{
    partial class VisitorEntryUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contactNumberTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.visitorNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ZoneTypeVisitorWantToVisitGroupBox = new System.Windows.Forms.GroupBox();
            this.zoneNameCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.ZoneTypeVisitorWantToVisitGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.contactNumberTextBox);
            this.groupBox1.Controls.Add(this.emailTextBox);
            this.groupBox1.Controls.Add(this.visitorNameTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 124);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vistor\'s information";
            // 
            // contactNumberTextBox
            // 
            this.contactNumberTextBox.Location = new System.Drawing.Point(156, 75);
            this.contactNumberTextBox.Name = "contactNumberTextBox";
            this.contactNumberTextBox.Size = new System.Drawing.Size(343, 20);
            this.contactNumberTextBox.TabIndex = 2;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(156, 46);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(343, 20);
            this.emailTextBox.TabIndex = 1;
            // 
            // visitorNameTextBox
            // 
            this.visitorNameTextBox.Location = new System.Drawing.Point(156, 20);
            this.visitorNameTextBox.Name = "visitorNameTextBox";
            this.visitorNameTextBox.Size = new System.Drawing.Size(343, 20);
            this.visitorNameTextBox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Contact Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // ZoneTypeVisitorWantToVisitGroupBox
            // 
            this.ZoneTypeVisitorWantToVisitGroupBox.Controls.Add(this.zoneNameCheckedListBox);
            this.ZoneTypeVisitorWantToVisitGroupBox.Location = new System.Drawing.Point(13, 157);
            this.ZoneTypeVisitorWantToVisitGroupBox.Name = "ZoneTypeVisitorWantToVisitGroupBox";
            this.ZoneTypeVisitorWantToVisitGroupBox.Size = new System.Drawing.Size(516, 273);
            this.ZoneTypeVisitorWantToVisitGroupBox.TabIndex = 1;
            this.ZoneTypeVisitorWantToVisitGroupBox.TabStop = false;
            this.ZoneTypeVisitorWantToVisitGroupBox.Text = "Zone type visitor wants to visit";
            // 
            // zoneNameCheckedListBox
            // 
            this.zoneNameCheckedListBox.FormattingEnabled = true;
            this.zoneNameCheckedListBox.Location = new System.Drawing.Point(16, 24);
            this.zoneNameCheckedListBox.Name = "zoneNameCheckedListBox";
            this.zoneNameCheckedListBox.Size = new System.Drawing.Size(483, 229);
            this.zoneNameCheckedListBox.TabIndex = 0;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(437, 436);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // VisitorEntryUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 483);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.ZoneTypeVisitorWantToVisitGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "VisitorEntryUI";
            this.Text = "Visitor Entry";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ZoneTypeVisitorWantToVisitGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox contactNumberTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox visitorNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox ZoneTypeVisitorWantToVisitGroupBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.CheckedListBox zoneNameCheckedListBox;
    }
}