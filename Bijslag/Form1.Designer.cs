namespace Bijslag
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
            this.AddStudentLabel = new System.Windows.Forms.Label();
            this.StudentNameLabel = new System.Windows.Forms.Label();
            this.StudentNameBox = new System.Windows.Forms.TextBox();
            this.StudentBirthdayLabel = new System.Windows.Forms.Label();
            this.StudentBirthdayPicker = new System.Windows.Forms.DateTimePicker();
            this.AddStudentButton = new System.Windows.Forms.Button();
            this.OtherConfigLabel = new System.Windows.Forms.Label();
            this.RefDateLabel = new System.Windows.Forms.Label();
            this.RefDatePicker = new System.Windows.Forms.DateTimePicker();
            this.StudentListLabel = new System.Windows.Forms.Label();
            this.StudentList = new System.Windows.Forms.DataGridView();
            this.Student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemoveStudentButton = new System.Windows.Forms.Button();
            this.InfoGridView = new System.Windows.Forms.DataGridView();
            this.Info = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartCalcButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StudentList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AddStudentLabel
            // 
            this.AddStudentLabel.AutoSize = true;
            this.AddStudentLabel.Location = new System.Drawing.Point(12, 9);
            this.AddStudentLabel.Name = "AddStudentLabel";
            this.AddStudentLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AddStudentLabel.Size = new System.Drawing.Size(67, 13);
            this.AddStudentLabel.TabIndex = 0;
            this.AddStudentLabel.Text = "Add student:";
            // 
            // StudentNameLabel
            // 
            this.StudentNameLabel.AutoSize = true;
            this.StudentNameLabel.Location = new System.Drawing.Point(12, 44);
            this.StudentNameLabel.Name = "StudentNameLabel";
            this.StudentNameLabel.Size = new System.Drawing.Size(38, 13);
            this.StudentNameLabel.TabIndex = 1;
            this.StudentNameLabel.Text = "Name:";
            // 
            // StudentNameBox
            // 
            this.StudentNameBox.Location = new System.Drawing.Point(82, 44);
            this.StudentNameBox.Name = "StudentNameBox";
            this.StudentNameBox.Size = new System.Drawing.Size(200, 20);
            this.StudentNameBox.TabIndex = 2;
            // 
            // StudentBirthdayLabel
            // 
            this.StudentBirthdayLabel.AutoSize = true;
            this.StudentBirthdayLabel.Location = new System.Drawing.Point(12, 82);
            this.StudentBirthdayLabel.Name = "StudentBirthdayLabel";
            this.StudentBirthdayLabel.Size = new System.Drawing.Size(48, 13);
            this.StudentBirthdayLabel.TabIndex = 3;
            this.StudentBirthdayLabel.Text = "Birthday:";
            // 
            // StudentBirthdayPicker
            // 
            this.StudentBirthdayPicker.Location = new System.Drawing.Point(82, 82);
            this.StudentBirthdayPicker.Name = "StudentBirthdayPicker";
            this.StudentBirthdayPicker.Size = new System.Drawing.Size(200, 20);
            this.StudentBirthdayPicker.TabIndex = 4;
            // 
            // AddStudentButton
            // 
            this.AddStudentButton.Location = new System.Drawing.Point(82, 120);
            this.AddStudentButton.Name = "AddStudentButton";
            this.AddStudentButton.Size = new System.Drawing.Size(77, 23);
            this.AddStudentButton.TabIndex = 5;
            this.AddStudentButton.Text = "Add";
            this.AddStudentButton.UseVisualStyleBackColor = true;
            this.AddStudentButton.Click += new System.EventHandler(this.AddStudentButton_Click);
            // 
            // OtherConfigLabel
            // 
            this.OtherConfigLabel.AutoSize = true;
            this.OtherConfigLabel.Location = new System.Drawing.Point(325, 9);
            this.OtherConfigLabel.Name = "OtherConfigLabel";
            this.OtherConfigLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.OtherConfigLabel.Size = new System.Drawing.Size(75, 13);
            this.OtherConfigLabel.TabIndex = 6;
            this.OtherConfigLabel.Text = "Other settings:";
            // 
            // RefDateLabel
            // 
            this.RefDateLabel.AutoSize = true;
            this.RefDateLabel.Location = new System.Drawing.Point(325, 82);
            this.RefDateLabel.Name = "RefDateLabel";
            this.RefDateLabel.Size = new System.Drawing.Size(84, 13);
            this.RefDateLabel.TabIndex = 8;
            this.RefDateLabel.Text = "Reference date:";
            // 
            // RefDatePicker
            // 
            this.RefDatePicker.Location = new System.Drawing.Point(415, 82);
            this.RefDatePicker.Name = "RefDatePicker";
            this.RefDatePicker.Size = new System.Drawing.Size(200, 20);
            this.RefDatePicker.TabIndex = 9;
            // 
            // StudentListLabel
            // 
            this.StudentListLabel.AutoSize = true;
            this.StudentListLabel.Location = new System.Drawing.Point(12, 177);
            this.StudentListLabel.Name = "StudentListLabel";
            this.StudentListLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StudentListLabel.Size = new System.Drawing.Size(62, 13);
            this.StudentListLabel.TabIndex = 10;
            this.StudentListLabel.Text = "Student list:";
            // 
            // StudentList
            // 
            this.StudentList.AllowUserToAddRows = false;
            this.StudentList.AllowUserToDeleteRows = false;
            this.StudentList.AllowUserToResizeColumns = false;
            this.StudentList.AllowUserToResizeRows = false;
            this.StudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Student,
            this.Birthday});
            this.StudentList.Location = new System.Drawing.Point(15, 203);
            this.StudentList.Name = "StudentList";
            this.StudentList.ReadOnly = true;
            this.StudentList.Size = new System.Drawing.Size(243, 150);
            this.StudentList.TabIndex = 11;
            // 
            // Student
            // 
            this.Student.HeaderText = "Student";
            this.Student.Name = "Student";
            this.Student.ReadOnly = true;
            // 
            // Birthday
            // 
            this.Birthday.HeaderText = "Birthday";
            this.Birthday.Name = "Birthday";
            this.Birthday.ReadOnly = true;
            // 
            // RemoveStudentButton
            // 
            this.RemoveStudentButton.Location = new System.Drawing.Point(15, 359);
            this.RemoveStudentButton.Name = "RemoveStudentButton";
            this.RemoveStudentButton.Size = new System.Drawing.Size(77, 23);
            this.RemoveStudentButton.TabIndex = 12;
            this.RemoveStudentButton.Text = "Remove";
            this.RemoveStudentButton.UseVisualStyleBackColor = true;
            this.RemoveStudentButton.Click += new System.EventHandler(this.RemoveStudentButton_Click);
            // 
            // InfoGridView
            // 
            this.InfoGridView.AllowUserToAddRows = false;
            this.InfoGridView.AllowUserToDeleteRows = false;
            this.InfoGridView.AllowUserToResizeColumns = false;
            this.InfoGridView.AllowUserToResizeRows = false;
            this.InfoGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InfoGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Info,
            this.Quantity});
            this.InfoGridView.Location = new System.Drawing.Point(328, 203);
            this.InfoGridView.Name = "InfoGridView";
            this.InfoGridView.ReadOnly = true;
            this.InfoGridView.Size = new System.Drawing.Size(243, 150);
            this.InfoGridView.TabIndex = 13;
            // 
            // Info
            // 
            this.Info.HeaderText = "Info";
            this.Info.Name = "Info";
            this.Info.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // StartCalcButton
            // 
            this.StartCalcButton.Location = new System.Drawing.Point(328, 359);
            this.StartCalcButton.Name = "StartCalcButton";
            this.StartCalcButton.Size = new System.Drawing.Size(118, 23);
            this.StartCalcButton.TabIndex = 14;
            this.StartCalcButton.Text = "Calculate benefits";
            this.StartCalcButton.UseVisualStyleBackColor = true;
            this.StartCalcButton.Click += new System.EventHandler(this.StartCalcButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 397);
            this.Controls.Add(this.StartCalcButton);
            this.Controls.Add(this.InfoGridView);
            this.Controls.Add(this.RemoveStudentButton);
            this.Controls.Add(this.StudentList);
            this.Controls.Add(this.StudentListLabel);
            this.Controls.Add(this.RefDatePicker);
            this.Controls.Add(this.RefDateLabel);
            this.Controls.Add(this.OtherConfigLabel);
            this.Controls.Add(this.AddStudentButton);
            this.Controls.Add(this.StudentBirthdayPicker);
            this.Controls.Add(this.StudentBirthdayLabel);
            this.Controls.Add(this.StudentNameBox);
            this.Controls.Add(this.StudentNameLabel);
            this.Controls.Add(this.AddStudentLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.StudentList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddStudentLabel;
        private System.Windows.Forms.Label StudentNameLabel;
        private System.Windows.Forms.TextBox StudentNameBox;
        private System.Windows.Forms.Label StudentBirthdayLabel;
        private System.Windows.Forms.DateTimePicker StudentBirthdayPicker;
        private System.Windows.Forms.Button AddStudentButton;
        private System.Windows.Forms.Label OtherConfigLabel;
        private System.Windows.Forms.Label RefDateLabel;
        private System.Windows.Forms.DateTimePicker RefDatePicker;
        private System.Windows.Forms.Label StudentListLabel;
        private System.Windows.Forms.DataGridView StudentList;
        private System.Windows.Forms.Button RemoveStudentButton;
        private System.Windows.Forms.DataGridView InfoGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Info;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.Button StartCalcButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthday;
    }
}

