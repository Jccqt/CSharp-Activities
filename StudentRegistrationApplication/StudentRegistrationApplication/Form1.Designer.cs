﻿namespace StudentRegistrationApplication
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
            this.Title = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.Label();
            this.MiddleName = new System.Windows.Forms.Label();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.MiddleNameTextBox = new System.Windows.Forms.TextBox();
            this.Note = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.Label();
            this.Male = new System.Windows.Forms.RadioButton();
            this.Female = new System.Windows.Forms.RadioButton();
            this.BirthDay = new System.Windows.Forms.Label();
            this.Days = new System.Windows.Forms.ComboBox();
            this.Months = new System.Windows.Forms.ComboBox();
            this.Years = new System.Windows.Forms.ComboBox();
            this.Register = new System.Windows.Forms.Button();
            this.Programs = new System.Windows.Forms.Label();
            this.ProgramsBox = new System.Windows.Forms.ComboBox();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BrowseBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(50, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(222, 20);
            this.Title.TabIndex = 0;
            this.Title.Text = "Student Registration Form";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName.Location = new System.Drawing.Point(11, 85);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(107, 20);
            this.LastName.TabIndex = 1;
            this.LastName.Text = "Last Name *";
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName.Location = new System.Drawing.Point(12, 148);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(108, 20);
            this.FirstName.TabIndex = 2;
            this.FirstName.Text = "First Name *";
            // 
            // MiddleName
            // 
            this.MiddleName.AutoSize = true;
            this.MiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MiddleName.Location = new System.Drawing.Point(12, 219);
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.Size = new System.Drawing.Size(196, 20);
            this.MiddleName.TabIndex = 3;
            this.MiddleName.Text = "Middle Name (Optional)";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameTextBox.Location = new System.Drawing.Point(16, 108);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(256, 26);
            this.LastNameTextBox.TabIndex = 4;
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FirstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameTextBox.Location = new System.Drawing.Point(15, 171);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(256, 26);
            this.FirstNameTextBox.TabIndex = 5;
            // 
            // MiddleNameTextBox
            // 
            this.MiddleNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MiddleNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MiddleNameTextBox.Location = new System.Drawing.Point(15, 242);
            this.MiddleNameTextBox.Name = "MiddleNameTextBox";
            this.MiddleNameTextBox.Size = new System.Drawing.Size(256, 26);
            this.MiddleNameTextBox.TabIndex = 6;
            // 
            // Note
            // 
            this.Note.AutoSize = true;
            this.Note.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Note.Location = new System.Drawing.Point(12, 56);
            this.Note.Name = "Note";
            this.Note.Size = new System.Drawing.Size(278, 16);
            this.Note.TabIndex = 7;
            this.Note.Text = "Note: Forms with * are required to fill-in.";
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender.Location = new System.Drawing.Point(11, 285);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(81, 20);
            this.Gender.TabIndex = 8;
            this.Gender.Text = "Gender *";
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Male.Location = new System.Drawing.Point(98, 285);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(61, 24);
            this.Male.TabIndex = 9;
            this.Male.TabStop = true;
            this.Male.Text = "Male";
            this.Male.UseVisualStyleBackColor = true;
            // 
            // Female
            // 
            this.Female.AutoSize = true;
            this.Female.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Female.Location = new System.Drawing.Point(165, 285);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(80, 24);
            this.Female.TabIndex = 10;
            this.Female.TabStop = true;
            this.Female.Text = "Female";
            this.Female.UseVisualStyleBackColor = true;
            // 
            // BirthDay
            // 
            this.BirthDay.AutoSize = true;
            this.BirthDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BirthDay.Location = new System.Drawing.Point(11, 323);
            this.BirthDay.Name = "BirthDay";
            this.BirthDay.Size = new System.Drawing.Size(124, 20);
            this.BirthDay.TabIndex = 11;
            this.BirthDay.Text = "Date of Birth *";
            // 
            // Days
            // 
            this.Days.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Days.FormattingEnabled = true;
            this.Days.Location = new System.Drawing.Point(219, 344);
            this.Days.Name = "Days";
            this.Days.Size = new System.Drawing.Size(68, 28);
            this.Days.TabIndex = 12;
            this.Days.Text = "-Day";
            // 
            // Months
            // 
            this.Months.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Months.FormattingEnabled = true;
            this.Months.Location = new System.Drawing.Point(117, 344);
            this.Months.Name = "Months";
            this.Months.Size = new System.Drawing.Size(96, 28);
            this.Months.TabIndex = 13;
            this.Months.Text = "-Month";
            this.Months.SelectedIndexChanged += new System.EventHandler(this.Months_SelectedIndexChanged);
            // 
            // Years
            // 
            this.Years.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Years.FormattingEnabled = true;
            this.Years.Location = new System.Drawing.Point(15, 344);
            this.Years.Name = "Years";
            this.Years.Size = new System.Drawing.Size(96, 28);
            this.Years.TabIndex = 14;
            this.Years.Text = "-Year";
            this.Years.SelectedIndexChanged += new System.EventHandler(this.Years_SelectedIndexChanged);
            // 
            // Register
            // 
            this.Register.BackColor = System.Drawing.Color.Crimson;
            this.Register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Register.ForeColor = System.Drawing.Color.White;
            this.Register.Location = new System.Drawing.Point(15, 460);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(152, 40);
            this.Register.TabIndex = 15;
            this.Register.Text = "Register Student";
            this.Register.UseVisualStyleBackColor = false;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // Programs
            // 
            this.Programs.AutoSize = true;
            this.Programs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Programs.Location = new System.Drawing.Point(12, 388);
            this.Programs.Name = "Programs";
            this.Programs.Size = new System.Drawing.Size(165, 20);
            this.Programs.TabIndex = 20;
            this.Programs.Text = "Programs to apply *";
            // 
            // ProgramsBox
            // 
            this.ProgramsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ProgramsBox.FormattingEnabled = true;
            this.ProgramsBox.Location = new System.Drawing.Point(15, 411);
            this.ProgramsBox.Name = "ProgramsBox";
            this.ProgramsBox.Size = new System.Drawing.Size(272, 28);
            this.ProgramsBox.TabIndex = 21;
            // 
            // PictureBox
            // 
            this.PictureBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.PictureBox.Location = new System.Drawing.Point(309, 85);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(201, 172);
            this.PictureBox.TabIndex = 23;
            this.PictureBox.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "png";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "PNG files|*.png";
            // 
            // BrowseBtn
            // 
            this.BrowseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseBtn.Location = new System.Drawing.Point(366, 263);
            this.BrowseBtn.Name = "BrowseBtn";
            this.BrowseBtn.Size = new System.Drawing.Size(88, 31);
            this.BrowseBtn.TabIndex = 24;
            this.BrowseBtn.Text = "Browse";
            this.BrowseBtn.UseVisualStyleBackColor = true;
            this.BrowseBtn.Click += new System.EventHandler(this.BrowseBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 512);
            this.Controls.Add(this.BrowseBtn);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.ProgramsBox);
            this.Controls.Add(this.Programs);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.Years);
            this.Controls.Add(this.Months);
            this.Controls.Add(this.Days);
            this.Controls.Add(this.BirthDay);
            this.Controls.Add(this.Female);
            this.Controls.Add(this.Male);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.Note);
            this.Controls.Add(this.MiddleNameTextBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.MiddleName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.Title);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Registration Form";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Label MiddleName;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox MiddleNameTextBox;
        private System.Windows.Forms.Label Note;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.RadioButton Male;
        private System.Windows.Forms.RadioButton Female;
        private System.Windows.Forms.Label BirthDay;
        private System.Windows.Forms.ComboBox Days;
        private System.Windows.Forms.ComboBox Months;
        private System.Windows.Forms.ComboBox Years;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.Label Programs;
        private System.Windows.Forms.ComboBox ProgramsBox;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Button BrowseBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

