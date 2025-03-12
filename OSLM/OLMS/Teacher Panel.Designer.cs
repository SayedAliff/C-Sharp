namespace OLMS
{
    partial class Teacher_Portal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teacher_Portal));
            this.Teacher_Title = new System.Windows.Forms.Label();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.S_Student_Id = new System.Windows.Forms.Label();
            this.bt_search = new System.Windows.Forms.Button();
            this.tb_uname = new System.Windows.Forms.TextBox();
            this.Department = new System.Windows.Forms.Label();
            this.Course = new System.Windows.Forms.Label();
            this.Contact_Number = new System.Windows.Forms.Label();
            this.D_textbox = new System.Windows.Forms.TextBox();
            this.C_textbox = new System.Windows.Forms.TextBox();
            this.Contact_textbox = new System.Windows.Forms.TextBox();
            this.U_botton1 = new System.Windows.Forms.Button();
            this.Logout_button = new System.Windows.Forms.Button();
            this.Teacher_info_button = new System.Windows.Forms.Button();
            this.Admin_info_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.SuspendLayout();
            // 
            // Teacher_Title
            // 
            this.Teacher_Title.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.Teacher_Title.AutoSize = true;
            this.Teacher_Title.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Teacher_Title.Font = new System.Drawing.Font("Calibri", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Teacher_Title.ForeColor = System.Drawing.Color.White;
            this.Teacher_Title.Location = new System.Drawing.Point(261, 9);
            this.Teacher_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Teacher_Title.Name = "Teacher_Title";
            this.Teacher_Title.Size = new System.Drawing.Size(369, 59);
            this.Teacher_Title.TabIndex = 12;
            this.Teacher_Title.Text = "TEACHER PORTAL";
            // 
            // dgv2
            // 
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Location = new System.Drawing.Point(13, 109);
            this.dgv2.Name = "dgv2";
            this.dgv2.Size = new System.Drawing.Size(479, 371);
            this.dgv2.TabIndex = 11;
            // 
            // S_Student_Id
            // 
            this.S_Student_Id.AutoSize = true;
            this.S_Student_Id.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.S_Student_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S_Student_Id.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.S_Student_Id.Location = new System.Drawing.Point(622, 86);
            this.S_Student_Id.Name = "S_Student_Id";
            this.S_Student_Id.Size = new System.Drawing.Size(87, 20);
            this.S_Student_Id.TabIndex = 36;
            this.S_Student_Id.Text = "Student ID";
            // 
            // bt_search
            // 
            this.bt_search.BackColor = System.Drawing.Color.Cyan;
            this.bt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_search.Location = new System.Drawing.Point(616, 141);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(102, 23);
            this.bt_search.TabIndex = 35;
            this.bt_search.Text = "Search";
            this.bt_search.UseVisualStyleBackColor = false;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // tb_uname
            // 
            this.tb_uname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_uname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tb_uname.Location = new System.Drawing.Point(513, 109);
            this.tb_uname.Name = "tb_uname";
            this.tb_uname.Size = new System.Drawing.Size(310, 26);
            this.tb_uname.TabIndex = 34;
            this.tb_uname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Department
            // 
            this.Department.AutoSize = true;
            this.Department.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Department.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Department.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Department.Location = new System.Drawing.Point(706, 189);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(94, 20);
            this.Department.TabIndex = 38;
            this.Department.Text = "Department";
            // 
            // Course
            // 
            this.Course.AutoSize = true;
            this.Course.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Course.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Course.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Course.Location = new System.Drawing.Point(548, 189);
            this.Course.Name = "Course";
            this.Course.Size = new System.Drawing.Size(60, 20);
            this.Course.TabIndex = 39;
            this.Course.Text = "Course";
            // 
            // Contact_Number
            // 
            this.Contact_Number.AutoSize = true;
            this.Contact_Number.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Contact_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contact_Number.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Contact_Number.Location = new System.Drawing.Point(603, 252);
            this.Contact_Number.Name = "Contact_Number";
            this.Contact_Number.Size = new System.Drawing.Size(125, 20);
            this.Contact_Number.TabIndex = 40;
            this.Contact_Number.Text = "Contact Number";
            // 
            // D_textbox
            // 
            this.D_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D_textbox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.D_textbox.Location = new System.Drawing.Point(679, 212);
            this.D_textbox.Name = "D_textbox";
            this.D_textbox.Size = new System.Drawing.Size(144, 26);
            this.D_textbox.TabIndex = 42;
            this.D_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // C_textbox
            // 
            this.C_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_textbox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.C_textbox.Location = new System.Drawing.Point(513, 212);
            this.C_textbox.Name = "C_textbox";
            this.C_textbox.Size = new System.Drawing.Size(144, 26);
            this.C_textbox.TabIndex = 43;
            this.C_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Contact_textbox
            // 
            this.Contact_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contact_textbox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Contact_textbox.Location = new System.Drawing.Point(513, 275);
            this.Contact_textbox.Name = "Contact_textbox";
            this.Contact_textbox.Size = new System.Drawing.Size(310, 26);
            this.Contact_textbox.TabIndex = 44;
            this.Contact_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // U_botton1
            // 
            this.U_botton1.BackColor = System.Drawing.Color.Cyan;
            this.U_botton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.U_botton1.Location = new System.Drawing.Point(616, 307);
            this.U_botton1.Name = "U_botton1";
            this.U_botton1.Size = new System.Drawing.Size(102, 23);
            this.U_botton1.TabIndex = 47;
            this.U_botton1.Text = "Update";
            this.U_botton1.UseVisualStyleBackColor = false;
            this.U_botton1.Click += new System.EventHandler(this.U_botton1_Click);
            // 
            // Logout_button
            // 
            this.Logout_button.BackColor = System.Drawing.Color.Crimson;
            this.Logout_button.Font = new System.Drawing.Font("Goudy Stout", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout_button.ForeColor = System.Drawing.SystemColors.Window;
            this.Logout_button.Location = new System.Drawing.Point(13, 548);
            this.Logout_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Logout_button.Name = "Logout_button";
            this.Logout_button.Size = new System.Drawing.Size(225, 52);
            this.Logout_button.TabIndex = 48;
            this.Logout_button.Text = "Log Out";
            this.Logout_button.UseVisualStyleBackColor = false;
            this.Logout_button.Click += new System.EventHandler(this.Logout_button_Click);
            // 
            // Teacher_info_button
            // 
            this.Teacher_info_button.BackColor = System.Drawing.Color.DodgerBlue;
            this.Teacher_info_button.Font = new System.Drawing.Font("Goudy Stout", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Teacher_info_button.ForeColor = System.Drawing.SystemColors.Window;
            this.Teacher_info_button.Location = new System.Drawing.Point(372, 518);
            this.Teacher_info_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Teacher_info_button.Name = "Teacher_info_button";
            this.Teacher_info_button.Size = new System.Drawing.Size(451, 32);
            this.Teacher_info_button.TabIndex = 49;
            this.Teacher_info_button.Text = "Teacher\'s Information";
            this.Teacher_info_button.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Teacher_info_button.UseVisualStyleBackColor = false;
            this.Teacher_info_button.Click += new System.EventHandler(this.Teacher_info_button_Click);
            // 
            // Admin_info_button
            // 
            this.Admin_info_button.BackColor = System.Drawing.Color.DodgerBlue;
            this.Admin_info_button.Font = new System.Drawing.Font("Goudy Stout", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_info_button.ForeColor = System.Drawing.SystemColors.Window;
            this.Admin_info_button.Location = new System.Drawing.Point(372, 568);
            this.Admin_info_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Admin_info_button.Name = "Admin_info_button";
            this.Admin_info_button.Size = new System.Drawing.Size(451, 32);
            this.Admin_info_button.TabIndex = 50;
            this.Admin_info_button.Text = "ADMIN INFORMATION";
            this.Admin_info_button.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Admin_info_button.UseVisualStyleBackColor = false;
            this.Admin_info_button.Click += new System.EventHandler(this.Admin_info_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(189, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 51;
            this.label1.Text = "Student\'s Table";
            // 
            // Teacher_Portal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(835, 623);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Admin_info_button);
            this.Controls.Add(this.Teacher_info_button);
            this.Controls.Add(this.Logout_button);
            this.Controls.Add(this.U_botton1);
            this.Controls.Add(this.Contact_textbox);
            this.Controls.Add(this.C_textbox);
            this.Controls.Add(this.D_textbox);
            this.Controls.Add(this.Contact_Number);
            this.Controls.Add(this.Course);
            this.Controls.Add(this.Department);
            this.Controls.Add(this.S_Student_Id);
            this.Controls.Add(this.bt_search);
            this.Controls.Add(this.tb_uname);
            this.Controls.Add(this.Teacher_Title);
            this.Controls.Add(this.dgv2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Teacher_Portal";
            this.Text = "Online Learning Management System";
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Teacher_Title;
        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.Label S_Student_Id;
        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.TextBox tb_uname;
        private System.Windows.Forms.Label Department;
        private System.Windows.Forms.Label Course;
        private System.Windows.Forms.Label Contact_Number;
        private System.Windows.Forms.TextBox D_textbox;
        private System.Windows.Forms.TextBox C_textbox;
        private System.Windows.Forms.TextBox Contact_textbox;
        private System.Windows.Forms.Button U_botton1;
        private System.Windows.Forms.Button Logout_button;
        private System.Windows.Forms.Button Teacher_info_button;
        private System.Windows.Forms.Button Admin_info_button;
        private System.Windows.Forms.Label label1;
    }
}