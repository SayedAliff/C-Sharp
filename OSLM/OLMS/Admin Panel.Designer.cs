namespace OLMS
{
    partial class Admin_Panel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Panel));
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.rb_teacher = new System.Windows.Forms.RadioButton();
            this.rb_student = new System.Windows.Forms.RadioButton();
            this.bt_search = new System.Windows.Forms.Button();
            this.bt_update = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_logout = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_dept = new System.Windows.Forms.TextBox();
            this.tb_uname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_course = new System.Windows.Forms.TextBox();
            this.tb_Contact = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_student = new System.Windows.Forms.DataGridView();
            this.dgv_teacher = new System.Windows.Forms.DataGridView();
            this.User_Imfo_bt = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_student)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_teacher)).BeginInit();
            this.SuspendLayout();
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.rb_teacher);
            this.gb1.Controls.Add(this.rb_student);
            this.gb1.Controls.Add(this.bt_search);
            this.gb1.Controls.Add(this.bt_update);
            this.gb1.Controls.Add(this.bt_delete);
            this.gb1.Location = new System.Drawing.Point(270, 322);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(314, 74);
            this.gb1.TabIndex = 61;
            this.gb1.TabStop = false;
            this.gb1.Text = "Choose an Option to Proceed..";
            // 
            // rb_teacher
            // 
            this.rb_teacher.AutoSize = true;
            this.rb_teacher.Location = new System.Drawing.Point(0, 22);
            this.rb_teacher.Name = "rb_teacher";
            this.rb_teacher.Size = new System.Drawing.Size(65, 17);
            this.rb_teacher.TabIndex = 39;
            this.rb_teacher.TabStop = true;
            this.rb_teacher.Text = "Teacher";
            this.rb_teacher.UseVisualStyleBackColor = true;
            // 
            // rb_student
            // 
            this.rb_student.AutoSize = true;
            this.rb_student.Location = new System.Drawing.Point(246, 22);
            this.rb_student.Name = "rb_student";
            this.rb_student.Size = new System.Drawing.Size(62, 17);
            this.rb_student.TabIndex = 40;
            this.rb_student.TabStop = true;
            this.rb_student.Text = "Student";
            this.rb_student.UseVisualStyleBackColor = true;
            // 
            // bt_search
            // 
            this.bt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_search.Location = new System.Drawing.Point(109, 19);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(102, 23);
            this.bt_search.TabIndex = 18;
            this.bt_search.Text = "Search";
            this.bt_search.UseVisualStyleBackColor = true;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // bt_update
            // 
            this.bt_update.BackColor = System.Drawing.Color.Aqua;
            this.bt_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_update.Location = new System.Drawing.Point(0, 45);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(102, 23);
            this.bt_update.TabIndex = 22;
            this.bt_update.Text = "Update";
            this.bt_update.UseVisualStyleBackColor = false;
            this.bt_update.Click += new System.EventHandler(this.bt_update_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.BackColor = System.Drawing.Color.LightCoral;
            this.bt_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_delete.Location = new System.Drawing.Point(212, 45);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(102, 23);
            this.bt_delete.TabIndex = 26;
            this.bt_delete.Text = "DELETE";
            this.bt_delete.UseVisualStyleBackColor = false;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_logout
            // 
            this.bt_logout.BackColor = System.Drawing.Color.Salmon;
            this.bt_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_logout.Location = new System.Drawing.Point(379, 614);
            this.bt_logout.Name = "bt_logout";
            this.bt_logout.Size = new System.Drawing.Size(102, 23);
            this.bt_logout.TabIndex = 60;
            this.bt_logout.Text = "LogOut";
            this.bt_logout.UseVisualStyleBackColor = false;
            this.bt_logout.Click += new System.EventHandler(this.bt_logout_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label4.Location = new System.Drawing.Point(39, 547);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(763, 13);
            this.label4.TabIndex = 58;
            this.label4.Text = "=================================================================================" +
    "=============================================";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(39, 399);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(763, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "=================================================================================" +
    "=============================================";
            // 
            // tb_dept
            // 
            this.tb_dept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_dept.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tb_dept.Location = new System.Drawing.Point(270, 518);
            this.tb_dept.Name = "tb_dept";
            this.tb_dept.Size = new System.Drawing.Size(314, 26);
            this.tb_dept.TabIndex = 47;
            this.tb_dept.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_uname
            // 
            this.tb_uname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_uname.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.tb_uname.Location = new System.Drawing.Point(270, 290);
            this.tb_uname.Name = "tb_uname";
            this.tb_uname.Size = new System.Drawing.Size(314, 26);
            this.tb_uname.TabIndex = 44;
            this.tb_uname.Text = "Type Teacher/Student ID Here";
            this.tb_uname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(441, 429);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 55;
            this.label7.Text = "Course";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(73, 429);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 54;
            this.label8.Text = "Contact_Number";
            // 
            // tb_course
            // 
            this.tb_course.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_course.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tb_course.Location = new System.Drawing.Point(444, 445);
            this.tb_course.Name = "tb_course";
            this.tb_course.Size = new System.Drawing.Size(314, 26);
            this.tb_course.TabIndex = 52;
            this.tb_course.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_Contact
            // 
            this.tb_Contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Contact.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tb_Contact.Location = new System.Drawing.Point(76, 445);
            this.tb_Contact.Name = "tb_Contact";
            this.tb_Contact.Size = new System.Drawing.Size(314, 26);
            this.tb_Contact.TabIndex = 51;
            this.tb_Contact.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 502);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Department";
            // 
            // dgv_student
            // 
            this.dgv_student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_student.Location = new System.Drawing.Point(439, 31);
            this.dgv_student.Name = "dgv_student";
            this.dgv_student.Size = new System.Drawing.Size(388, 253);
            this.dgv_student.TabIndex = 43;
            // 
            // dgv_teacher
            // 
            this.dgv_teacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_teacher.Location = new System.Drawing.Point(30, 31);
            this.dgv_teacher.Name = "dgv_teacher";
            this.dgv_teacher.Size = new System.Drawing.Size(403, 253);
            this.dgv_teacher.TabIndex = 42;
            // 
            // User_Imfo_bt
            // 
            this.User_Imfo_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_Imfo_bt.Location = new System.Drawing.Point(379, 575);
            this.User_Imfo_bt.Name = "User_Imfo_bt";
            this.User_Imfo_bt.Size = new System.Drawing.Size(102, 23);
            this.User_Imfo_bt.TabIndex = 62;
            this.User_Imfo_bt.Text = "User_Info";
            this.User_Imfo_bt.UseVisualStyleBackColor = true;
            this.User_Imfo_bt.Click += new System.EventHandler(this.User_Imfo_bt_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(177, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 63;
            this.label5.Text = "Teacher\'s Table";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(574, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 20);
            this.label6.TabIndex = 64;
            this.label6.Text = "Student\'s Table";
            // 
            // Admin_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(859, 649);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.User_Imfo_bt);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.bt_logout);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_dept);
            this.Controls.Add(this.tb_uname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_course);
            this.Controls.Add(this.tb_Contact);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_student);
            this.Controls.Add(this.dgv_teacher);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin_Panel";
            this.Text = "Online Learning Management System";
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_student)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_teacher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.RadioButton rb_teacher;
        private System.Windows.Forms.RadioButton rb_student;
        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Button bt_logout;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_dept;
        private System.Windows.Forms.TextBox tb_uname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_course;
        private System.Windows.Forms.TextBox tb_Contact;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_student;
        private System.Windows.Forms.DataGridView dgv_teacher;
        private System.Windows.Forms.Button User_Imfo_bt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}