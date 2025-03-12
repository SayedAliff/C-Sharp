namespace OLMS
{
    partial class Student_Panel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_Panel));
            this.label1 = new System.Windows.Forms.Label();
            this.Admin_info_button = new System.Windows.Forms.Button();
            this.Teacher_info_button = new System.Windows.Forms.Button();
            this.Logout_button = new System.Windows.Forms.Button();
            this.Contact_textbox = new System.Windows.Forms.TextBox();
            this.D_textbox = new System.Windows.Forms.TextBox();
            this.Contact_Number = new System.Windows.Forms.Label();
            this.Department = new System.Windows.Forms.Label();
            this.S_Student_Id = new System.Windows.Forms.Label();
            this.bt_search = new System.Windows.Forms.Button();
            this.tb_uname = new System.Windows.Forms.TextBox();
            this.Teacher_Title = new System.Windows.Forms.Label();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(242, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 67;
            this.label1.Text = "Student\'s Table";
            // 
            // Admin_info_button
            // 
            this.Admin_info_button.BackColor = System.Drawing.Color.DodgerBlue;
            this.Admin_info_button.Font = new System.Drawing.Font("Goudy Stout", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_info_button.ForeColor = System.Drawing.SystemColors.Window;
            this.Admin_info_button.Location = new System.Drawing.Point(425, 579);
            this.Admin_info_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Admin_info_button.Name = "Admin_info_button";
            this.Admin_info_button.Size = new System.Drawing.Size(451, 32);
            this.Admin_info_button.TabIndex = 66;
            this.Admin_info_button.Text = "ADMIN INFORMATION";
            this.Admin_info_button.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Admin_info_button.UseVisualStyleBackColor = false;
            this.Admin_info_button.Click += new System.EventHandler(this.Admin_info_button_Click);
            // 
            // Teacher_info_button
            // 
            this.Teacher_info_button.BackColor = System.Drawing.Color.DodgerBlue;
            this.Teacher_info_button.Font = new System.Drawing.Font("Goudy Stout", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Teacher_info_button.ForeColor = System.Drawing.SystemColors.Window;
            this.Teacher_info_button.Location = new System.Drawing.Point(425, 529);
            this.Teacher_info_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Teacher_info_button.Name = "Teacher_info_button";
            this.Teacher_info_button.Size = new System.Drawing.Size(451, 32);
            this.Teacher_info_button.TabIndex = 65;
            this.Teacher_info_button.Text = "Teacher\'s Information";
            this.Teacher_info_button.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Teacher_info_button.UseVisualStyleBackColor = false;
            this.Teacher_info_button.Click += new System.EventHandler(this.Teacher_info_button_Click);
            // 
            // Logout_button
            // 
            this.Logout_button.BackColor = System.Drawing.Color.Crimson;
            this.Logout_button.Font = new System.Drawing.Font("Goudy Stout", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout_button.ForeColor = System.Drawing.SystemColors.Window;
            this.Logout_button.Location = new System.Drawing.Point(66, 559);
            this.Logout_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Logout_button.Name = "Logout_button";
            this.Logout_button.Size = new System.Drawing.Size(225, 52);
            this.Logout_button.TabIndex = 64;
            this.Logout_button.Text = "Log Out";
            this.Logout_button.UseVisualStyleBackColor = false;
            this.Logout_button.Click += new System.EventHandler(this.Logout_button_Click);
            // 
            // Contact_textbox
            // 
            this.Contact_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contact_textbox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Contact_textbox.Location = new System.Drawing.Point(566, 286);
            this.Contact_textbox.Name = "Contact_textbox";
            this.Contact_textbox.Size = new System.Drawing.Size(310, 26);
            this.Contact_textbox.TabIndex = 62;
            this.Contact_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // D_textbox
            // 
            this.D_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D_textbox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.D_textbox.Location = new System.Drawing.Point(651, 223);
            this.D_textbox.Name = "D_textbox";
            this.D_textbox.Size = new System.Drawing.Size(144, 26);
            this.D_textbox.TabIndex = 60;
            this.D_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Contact_Number
            // 
            this.Contact_Number.AutoSize = true;
            this.Contact_Number.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Contact_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contact_Number.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Contact_Number.Location = new System.Drawing.Point(656, 263);
            this.Contact_Number.Name = "Contact_Number";
            this.Contact_Number.Size = new System.Drawing.Size(125, 20);
            this.Contact_Number.TabIndex = 59;
            this.Contact_Number.Text = "Contact Number";
            // 
            // Department
            // 
            this.Department.AutoSize = true;
            this.Department.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Department.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Department.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Department.Location = new System.Drawing.Point(677, 200);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(94, 20);
            this.Department.TabIndex = 57;
            this.Department.Text = "Department";
            // 
            // S_Student_Id
            // 
            this.S_Student_Id.AutoSize = true;
            this.S_Student_Id.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.S_Student_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S_Student_Id.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.S_Student_Id.Location = new System.Drawing.Point(675, 97);
            this.S_Student_Id.Name = "S_Student_Id";
            this.S_Student_Id.Size = new System.Drawing.Size(87, 20);
            this.S_Student_Id.TabIndex = 56;
            this.S_Student_Id.Text = "Student ID";
            this.S_Student_Id.Click += new System.EventHandler(this.S_Student_Id_Click);
            // 
            // bt_search
            // 
            this.bt_search.BackColor = System.Drawing.Color.Cyan;
            this.bt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_search.Location = new System.Drawing.Point(669, 152);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(102, 23);
            this.bt_search.TabIndex = 55;
            this.bt_search.Text = "Search";
            this.bt_search.UseVisualStyleBackColor = false;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // tb_uname
            // 
            this.tb_uname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_uname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tb_uname.Location = new System.Drawing.Point(566, 120);
            this.tb_uname.Name = "tb_uname";
            this.tb_uname.Size = new System.Drawing.Size(310, 26);
            this.tb_uname.TabIndex = 54;
            this.tb_uname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Teacher_Title
            // 
            this.Teacher_Title.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.Teacher_Title.AutoSize = true;
            this.Teacher_Title.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Teacher_Title.Font = new System.Drawing.Font("Calibri", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Teacher_Title.ForeColor = System.Drawing.Color.White;
            this.Teacher_Title.Location = new System.Drawing.Point(314, 20);
            this.Teacher_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Teacher_Title.Name = "Teacher_Title";
            this.Teacher_Title.Size = new System.Drawing.Size(377, 59);
            this.Teacher_Title.TabIndex = 53;
            this.Teacher_Title.Text = "STUDENT PORTAL";
            // 
            // dgv2
            // 
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Location = new System.Drawing.Point(66, 120);
            this.dgv2.Name = "dgv2";
            this.dgv2.Size = new System.Drawing.Size(479, 371);
            this.dgv2.TabIndex = 52;
            // 
            // Student_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(943, 630);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Admin_info_button);
            this.Controls.Add(this.Teacher_info_button);
            this.Controls.Add(this.Logout_button);
            this.Controls.Add(this.Contact_textbox);
            this.Controls.Add(this.D_textbox);
            this.Controls.Add(this.Contact_Number);
            this.Controls.Add(this.Department);
            this.Controls.Add(this.S_Student_Id);
            this.Controls.Add(this.bt_search);
            this.Controls.Add(this.tb_uname);
            this.Controls.Add(this.Teacher_Title);
            this.Controls.Add(this.dgv2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Student_Panel";
            this.Text = "Online Learning Management System";
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Admin_info_button;
        private System.Windows.Forms.Button Teacher_info_button;
        private System.Windows.Forms.Button Logout_button;
        private System.Windows.Forms.TextBox Contact_textbox;
        private System.Windows.Forms.TextBox D_textbox;
        private System.Windows.Forms.Label Contact_Number;
        private System.Windows.Forms.Label Department;
        private System.Windows.Forms.Label S_Student_Id;
        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.TextBox tb_uname;
        private System.Windows.Forms.Label Teacher_Title;
        private System.Windows.Forms.DataGridView dgv2;
    }
}