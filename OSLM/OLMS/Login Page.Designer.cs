namespace OLMS
{
    partial class Login_Page
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Page));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Login = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_Student = new System.Windows.Forms.RadioButton();
            this.rb_Teacher = new System.Windows.Forms.RadioButton();
            this.rb_Admin = new System.Windows.Forms.RadioButton();
            this.Username1 = new System.Windows.Forms.TextBox();
            this.Password1 = new System.Windows.Forms.TextBox();
            this.Proceed_Button = new System.Windows.Forms.Button();
            this.Reg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Login
            // 
            this.Login.AccessibleName = "Login";
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Login.Location = new System.Drawing.Point(481, 429);
            this.Login.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(158, 72);
            this.Login.TabIndex = 3;
            this.Login.Text = "Log In";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(304, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(507, 412);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.groupBox1.Controls.Add(this.rb_Student);
            this.groupBox1.Controls.Add(this.rb_Teacher);
            this.groupBox1.Controls.Add(this.rb_Admin);
            this.groupBox1.Controls.Add(this.Username1);
            this.groupBox1.Controls.Add(this.Password1);
            this.groupBox1.Controls.Add(this.Proceed_Button);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(304, 493);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 215);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose User Type";
            // 
            // rb_Student
            // 
            this.rb_Student.AutoSize = true;
            this.rb_Student.Location = new System.Drawing.Point(149, 33);
            this.rb_Student.Name = "rb_Student";
            this.rb_Student.Size = new System.Drawing.Size(67, 19);
            this.rb_Student.TabIndex = 16;
            this.rb_Student.TabStop = true;
            this.rb_Student.Text = "Student";
            this.rb_Student.UseVisualStyleBackColor = true;
            // 
            // rb_Teacher
            // 
            this.rb_Teacher.AutoSize = true;
            this.rb_Teacher.Location = new System.Drawing.Point(73, 33);
            this.rb_Teacher.Name = "rb_Teacher";
            this.rb_Teacher.Size = new System.Drawing.Size(70, 19);
            this.rb_Teacher.TabIndex = 15;
            this.rb_Teacher.TabStop = true;
            this.rb_Teacher.Text = "Teacher";
            this.rb_Teacher.UseVisualStyleBackColor = true;
            // 
            // rb_Admin
            // 
            this.rb_Admin.AutoSize = true;
            this.rb_Admin.Location = new System.Drawing.Point(7, 33);
            this.rb_Admin.Name = "rb_Admin";
            this.rb_Admin.Size = new System.Drawing.Size(60, 19);
            this.rb_Admin.TabIndex = 14;
            this.rb_Admin.TabStop = true;
            this.rb_Admin.Text = "Admin";
            this.rb_Admin.UseVisualStyleBackColor = true;
            // 
            // Username1
            // 
            this.Username1.AccessibleName = "";
            this.Username1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Username1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Username1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Username1.Location = new System.Drawing.Point(2, 69);
            this.Username1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Username1.Multiline = true;
            this.Username1.Name = "Username1";
            this.Username1.Size = new System.Drawing.Size(507, 35);
            this.Username1.TabIndex = 11;
            this.Username1.Text = "User_Name";
            this.Username1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Password1
            // 
            this.Password1.AccessibleName = "";
            this.Password1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Password1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Password1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Password1.Location = new System.Drawing.Point(2, 110);
            this.Password1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Password1.Name = "Password1";
            this.Password1.Size = new System.Drawing.Size(507, 35);
            this.Password1.TabIndex = 12;
            this.Password1.Text = "password";
            this.Password1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Password1.UseSystemPasswordChar = true;
            // 
            // Proceed_Button
            // 
            this.Proceed_Button.BackColor = System.Drawing.Color.DodgerBlue;
            this.Proceed_Button.Font = new System.Drawing.Font("Goudy Stout", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Proceed_Button.ForeColor = System.Drawing.SystemColors.Window;
            this.Proceed_Button.Location = new System.Drawing.Point(122, 151);
            this.Proceed_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Proceed_Button.Name = "Proceed_Button";
            this.Proceed_Button.Size = new System.Drawing.Size(274, 52);
            this.Proceed_Button.TabIndex = 13;
            this.Proceed_Button.Text = "PROCEED";
            this.Proceed_Button.UseVisualStyleBackColor = false;
            this.Proceed_Button.Click += new System.EventHandler(this.Proceed_Button_Click);
            // 
            // Reg
            // 
            this.Reg.BackColor = System.Drawing.Color.Crimson;
            this.Reg.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reg.ForeColor = System.Drawing.SystemColors.Window;
            this.Reg.Location = new System.Drawing.Point(350, 714);
            this.Reg.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Reg.Name = "Reg";
            this.Reg.Size = new System.Drawing.Size(426, 52);
            this.Reg.TabIndex = 14;
            this.Reg.Text = "Click Here for Registration";
            this.Reg.UseVisualStyleBackColor = false;
            this.Reg.Click += new System.EventHandler(this.Reg_Click);
            // 
            // Login_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1083, 778);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Reg);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Login);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Login_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Online Learning Management System";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label Login;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Username1;
        private System.Windows.Forms.Button Reg;
        private System.Windows.Forms.TextBox Password1;
        private System.Windows.Forms.Button Proceed_Button;
        private System.Windows.Forms.RadioButton rb_Student;
        private System.Windows.Forms.RadioButton rb_Teacher;
        private System.Windows.Forms.RadioButton rb_Admin;
    }
}