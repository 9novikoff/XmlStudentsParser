
namespace XmlStudentCirclesParser
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.DOMButton = new System.Windows.Forms.RadioButton();
            this.SAXButton = new System.Windows.Forms.RadioButton();
            this.LINQToXMLButton = new System.Windows.Forms.RadioButton();
            this.FacultyCheckBox = new System.Windows.Forms.CheckBox();
            this.ScheduleCheckBox = new System.Windows.Forms.CheckBox();
            this.MonitorCheckBox = new System.Windows.Forms.CheckBox();
            this.SubjectCheckBox = new System.Windows.Forms.CheckBox();
            this.NameCheckBox = new System.Windows.Forms.CheckBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.TransformButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.NameComboBox = new System.Windows.Forms.ComboBox();
            this.FacultyComboBox = new System.Windows.Forms.ComboBox();
            this.MonitorComboBox = new System.Windows.Forms.ComboBox();
            this.ScheduleComboBox = new System.Windows.Forms.ComboBox();
            this.SubjectComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Location = new System.Drawing.Point(410, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(490, 505);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // DOMButton
            // 
            this.DOMButton.AutoSize = true;
            this.DOMButton.Location = new System.Drawing.Point(12, 351);
            this.DOMButton.Name = "DOMButton";
            this.DOMButton.Size = new System.Drawing.Size(65, 24);
            this.DOMButton.TabIndex = 1;
            this.DOMButton.TabStop = true;
            this.DOMButton.Text = "DOM";
            this.DOMButton.UseVisualStyleBackColor = true;
            this.DOMButton.CheckedChanged += new System.EventHandler(this.DOMButton_CheckedChanged);
            // 
            // SAXButton
            // 
            this.SAXButton.AutoSize = true;
            this.SAXButton.Location = new System.Drawing.Point(149, 351);
            this.SAXButton.Name = "SAXButton";
            this.SAXButton.Size = new System.Drawing.Size(57, 24);
            this.SAXButton.TabIndex = 2;
            this.SAXButton.TabStop = true;
            this.SAXButton.Text = "SAX";
            this.SAXButton.UseVisualStyleBackColor = true;
            this.SAXButton.CheckedChanged += new System.EventHandler(this.SAXButton_CheckedChanged);
            // 
            // LINQToXMLButton
            // 
            this.LINQToXMLButton.AutoSize = true;
            this.LINQToXMLButton.Location = new System.Drawing.Point(269, 351);
            this.LINQToXMLButton.Name = "LINQToXMLButton";
            this.LINQToXMLButton.Size = new System.Drawing.Size(118, 24);
            this.LINQToXMLButton.TabIndex = 3;
            this.LINQToXMLButton.TabStop = true;
            this.LINQToXMLButton.Text = "LINQ TO XML";
            this.LINQToXMLButton.UseVisualStyleBackColor = true;
            this.LINQToXMLButton.CheckedChanged += new System.EventHandler(this.LINQToXMLButton_CheckedChanged);
            // 
            // FacultyCheckBox
            // 
            this.FacultyCheckBox.AutoSize = true;
            this.FacultyCheckBox.Location = new System.Drawing.Point(17, 88);
            this.FacultyCheckBox.Name = "FacultyCheckBox";
            this.FacultyCheckBox.Size = new System.Drawing.Size(76, 24);
            this.FacultyCheckBox.TabIndex = 4;
            this.FacultyCheckBox.Text = "Faculty";
            this.FacultyCheckBox.UseVisualStyleBackColor = true;
            this.FacultyCheckBox.CheckedChanged += new System.EventHandler(this.FacultyCheckBox_CheckedChanged);
            // 
            // ScheduleCheckBox
            // 
            this.ScheduleCheckBox.AutoSize = true;
            this.ScheduleCheckBox.Location = new System.Drawing.Point(17, 145);
            this.ScheduleCheckBox.Name = "ScheduleCheckBox";
            this.ScheduleCheckBox.Size = new System.Drawing.Size(91, 24);
            this.ScheduleCheckBox.TabIndex = 5;
            this.ScheduleCheckBox.Text = "Schedule";
            this.ScheduleCheckBox.UseVisualStyleBackColor = true;
            this.ScheduleCheckBox.CheckedChanged += new System.EventHandler(this.ScheduleCheckBox_CheckedChanged);
            // 
            // MonitorCheckBox
            // 
            this.MonitorCheckBox.AutoSize = true;
            this.MonitorCheckBox.Location = new System.Drawing.Point(17, 204);
            this.MonitorCheckBox.Name = "MonitorCheckBox";
            this.MonitorCheckBox.Size = new System.Drawing.Size(84, 24);
            this.MonitorCheckBox.TabIndex = 6;
            this.MonitorCheckBox.Text = "Monitor";
            this.MonitorCheckBox.UseVisualStyleBackColor = true;
            this.MonitorCheckBox.CheckedChanged += new System.EventHandler(this.MonitorCheckBox_CheckedChanged);
            // 
            // SubjectCheckBox
            // 
            this.SubjectCheckBox.AutoSize = true;
            this.SubjectCheckBox.Location = new System.Drawing.Point(17, 264);
            this.SubjectCheckBox.Name = "SubjectCheckBox";
            this.SubjectCheckBox.Size = new System.Drawing.Size(80, 24);
            this.SubjectCheckBox.TabIndex = 7;
            this.SubjectCheckBox.Text = "Subject";
            this.SubjectCheckBox.UseVisualStyleBackColor = true;
            this.SubjectCheckBox.CheckedChanged += new System.EventHandler(this.SubjectCheckBox_CheckedChanged);
            // 
            // NameCheckBox
            // 
            this.NameCheckBox.AutoSize = true;
            this.NameCheckBox.Location = new System.Drawing.Point(17, 29);
            this.NameCheckBox.Name = "NameCheckBox";
            this.NameCheckBox.Size = new System.Drawing.Size(71, 24);
            this.NameCheckBox.TabIndex = 8;
            this.NameCheckBox.Text = "Name";
            this.NameCheckBox.UseVisualStyleBackColor = true;
            this.NameCheckBox.CheckedChanged += new System.EventHandler(this.NameCheckBox_CheckedChanged);
            // 
            // SearchButton
            // 
            this.SearchButton.Enabled = false;
            this.SearchButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SearchButton.Location = new System.Drawing.Point(12, 381);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(126, 112);
            this.SearchButton.TabIndex = 9;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // TransformButton
            // 
            this.TransformButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TransformButton.Location = new System.Drawing.Point(224, 445);
            this.TransformButton.Name = "TransformButton";
            this.TransformButton.Size = new System.Drawing.Size(163, 48);
            this.TransformButton.TabIndex = 10;
            this.TransformButton.Text = "Transform to HTML";
            this.TransformButton.UseVisualStyleBackColor = true;
            this.TransformButton.Click += new System.EventHandler(this.TransformButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClearButton.Location = new System.Drawing.Point(224, 381);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(163, 46);
            this.ClearButton.TabIndex = 11;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // NameComboBox
            // 
            this.NameComboBox.BackColor = System.Drawing.Color.White;
            this.NameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NameComboBox.Enabled = false;
            this.NameComboBox.FormattingEnabled = true;
            this.NameComboBox.Location = new System.Drawing.Point(168, 25);
            this.NameComboBox.Name = "NameComboBox";
            this.NameComboBox.Size = new System.Drawing.Size(207, 28);
            this.NameComboBox.TabIndex = 12;
            // 
            // FacultyComboBox
            // 
            this.FacultyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FacultyComboBox.Enabled = false;
            this.FacultyComboBox.FormattingEnabled = true;
            this.FacultyComboBox.Location = new System.Drawing.Point(168, 84);
            this.FacultyComboBox.Name = "FacultyComboBox";
            this.FacultyComboBox.Size = new System.Drawing.Size(207, 28);
            this.FacultyComboBox.TabIndex = 13;
            // 
            // MonitorComboBox
            // 
            this.MonitorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MonitorComboBox.Enabled = false;
            this.MonitorComboBox.FormattingEnabled = true;
            this.MonitorComboBox.Location = new System.Drawing.Point(168, 200);
            this.MonitorComboBox.Name = "MonitorComboBox";
            this.MonitorComboBox.Size = new System.Drawing.Size(207, 28);
            this.MonitorComboBox.TabIndex = 15;
            // 
            // ScheduleComboBox
            // 
            this.ScheduleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ScheduleComboBox.Enabled = false;
            this.ScheduleComboBox.FormattingEnabled = true;
            this.ScheduleComboBox.Location = new System.Drawing.Point(168, 141);
            this.ScheduleComboBox.Name = "ScheduleComboBox";
            this.ScheduleComboBox.Size = new System.Drawing.Size(207, 28);
            this.ScheduleComboBox.TabIndex = 14;
            // 
            // SubjectComboBox
            // 
            this.SubjectComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SubjectComboBox.Enabled = false;
            this.SubjectComboBox.FormattingEnabled = true;
            this.SubjectComboBox.Location = new System.Drawing.Point(168, 260);
            this.SubjectComboBox.Name = "SubjectComboBox";
            this.SubjectComboBox.Size = new System.Drawing.Size(207, 28);
            this.SubjectComboBox.TabIndex = 16;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(902, 505);
            this.Controls.Add(this.SubjectComboBox);
            this.Controls.Add(this.MonitorComboBox);
            this.Controls.Add(this.ScheduleComboBox);
            this.Controls.Add(this.FacultyComboBox);
            this.Controls.Add(this.NameComboBox);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.TransformButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.NameCheckBox);
            this.Controls.Add(this.SubjectCheckBox);
            this.Controls.Add(this.MonitorCheckBox);
            this.Controls.Add(this.ScheduleCheckBox);
            this.Controls.Add(this.FacultyCheckBox);
            this.Controls.Add(this.LINQToXMLButton);
            this.Controls.Add(this.SAXButton);
            this.Controls.Add(this.DOMButton);
            this.Controls.Add(this.richTextBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "XMLParser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RadioButton DOMButton;
        private System.Windows.Forms.RadioButton SAXButton;
        private System.Windows.Forms.RadioButton LINQToXMLButton;
        private System.Windows.Forms.CheckBox FacultyCheckBox;
        private System.Windows.Forms.CheckBox ScheduleCheckBox;
        private System.Windows.Forms.CheckBox MonitorCheckBox;
        private System.Windows.Forms.CheckBox SubjectCheckBox;
        private System.Windows.Forms.CheckBox NameCheckBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button TransformButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.ComboBox NameComboBox;
        private System.Windows.Forms.ComboBox FacultyComboBox;
        private System.Windows.Forms.ComboBox MonitorComboBox;
        private System.Windows.Forms.ComboBox ScheduleComboBox;
        private System.Windows.Forms.ComboBox SubjectComboBox;
    }
}

