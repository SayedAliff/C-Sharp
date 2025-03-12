namespace OLMS
{
    partial class Teacher_Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teacher_Info));
            this.backbutton = new System.Windows.Forms.Button();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.Contact_textbox = new System.Windows.Forms.TextBox();
            this.D_textbox = new System.Windows.Forms.TextBox();
            this.Contact_Number = new System.Windows.Forms.Label();
            this.Department = new System.Windows.Forms.Label();
            this.S_Student_Id = new System.Windows.Forms.Label();
            this.bt_search = new System.Windows.Forms.Button();
            this.tb_uname = new System.Windows.Forms.TextBox();
            this.Logoutbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.SuspendLayout();
            // 
            // backbutton
            // 
            this.backbutton.BackColor = System.Drawing.Color.Crimson;
            this.backbutton.Font = new System.Drawing.Font("Goudy Stout", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbutton.ForeColor = System.Drawing.SystemColors.Window;
            this.backbutton.Location = new System.Drawing.Point(13, 569);
            this.backbutton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(189, 52);
            this.backbutton.TabIndex = 49;
            this.backbutton.Text = "Back";
            this.backbutton.UseVisualStyleBackColor = false;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // dgv2
            // 
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Location = new System.Drawing.Point(168, 51);
            this.dgv2.Name = "dgv2";
            this.dgv2.Size = new System.Drawing.Size(597, 290);
            this.dgv2.TabIndex = 50;
            // 
            // Contact_textbox
            // 
            this.Contact_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contact_textbox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Contact_textbox.Location = new System.Drawing.Point(302, 549);
            this.Contact_textbox.Name = "Contact_textbox";
            this.Contact_textbox.Size = new System.Drawing.Size(310, 26);
            this.Contact_textbox.TabIndex = 59;
            this.Contact_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // D_textbox
            // 
            this.D_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D_textbox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.D_textbox.Location = new System.Drawing.Point(384, 486);
            this.D_textbox.Name = "D_textbox";
            this.D_textbox.Size = new System.Drawing.Size(144, 26);
            this.D_textbox.TabIndex = 57;
            this.D_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Contact_Number
            // 
            this.Contact_Number.AutoSize = true;
            this.Contact_Number.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Contact_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contact_Number.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Contact_Number.Location = new System.Drawing.Point(392, 526);
            this.Contact_Number.Name = "Contact_Number";
            this.Contact_Number.Size = new System.Drawing.Size(125, 20);
            this.Contact_Number.TabIndex = 56;
            this.Contact_Number.Text = "Contact Number";
            // 
            // Department
            // 
            this.Department.AutoSize = true;
            this.Department.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Department.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Department.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Department.Location = new System.Drawing.Point(413, 463);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(94, 20);
            this.Department.TabIndex = 54;
            this.Department.Text = "Department";
            // 
            // S_Student_Id
            // 
            this.S_Student_Id.AutoSize = true;
            this.S_Student_Id.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.S_Student_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S_Student_Id.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.S_Student_Id.Location = new System.Drawing.Point(411, 360);
            this.S_Student_Id.Name = "S_Student_Id";
            this.S_Student_Id.Size = new System.Drawing.Size(93, 20);
            this.S_Student_Id.TabIndex = 53;
            this.S_Student_Id.Text = "Teacher_ID";
            // 
            // bt_search
            // 
            this.bt_search.BackColor = System.Drawing.Color.Cyan;
            this.bt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_search.Location = new System.Drawing.Point(405, 415);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(102, 23);
            this.bt_search.TabIndex = 52;
            this.bt_search.Text = "Search";
            this.bt_search.UseVisualStyleBackColor = false;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // tb_uname
            // 
            this.tb_uname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_uname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tb_uname.Location = new System.Drawing.Point(302, 383);
            this.tb_uname.Name = "tb_uname";
            this.tb_uname.Size = new System.Drawing.Size(310, 26);
            this.tb_uname.TabIndex = 51;
            this.tb_uname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Logoutbutton
            // 
            this.Logoutbutton.BackColor = System.Drawing.Color.Crimson;
            this.Logoutbutton.Font = new System.Drawing.Font("Goudy Stout", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logoutbutton.ForeColor = System.Drawing.SystemColors.Window;
            this.Logoutbutton.Location = new System.Drawing.Point(638, 569);
            this.Logoutbutton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Logoutbutton.Name = "Logoutbutton";
            this.Logoutbutton.Size = new System.Drawing.Size(232, 52);
            this.Logoutbutton.TabIndex = 60;
            this.Logoutbutton.Text = "Log Out";
            this.Logoutbutton.UseVisualStyleBackColor = false;
            this.Logoutbutton.Click += new System.EventHandler(this.Logoutbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(334, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 37);
            this.label1.TabIndex = 61;
            this.label1.Text = "Teacher\'s Table";
            // 
            // Teacher_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(902, 633);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Logoutbutton);
            this.Controls.Add(this.Contact_textbox);
            this.Controls.Add(this.D_textbox);
            this.Controls.Add(this.Contact_Number);
            this.Controls.Add(this.Department);
            this.Controls.Add(this.S_Student_Id);
            this.Controls.Add(this.bt_search);
            this.Controls.Add(this.tb_uname);
            this.Controls.Add(this.dgv2);
            this.Controls.Add(this.backbutton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Teacher_Info";
            this.Text = "Online Learning Management System";
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.TextBox Contact_textbox;
        private System.Windows.Forms.TextBox D_textbox;
        private System.Windows.Forms.Label Contact_Number;
        private System.Windows.Forms.Label Department;
        private System.Windows.Forms.Label S_Student_Id;
        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.TextBox tb_uname;
        private System.Windows.Forms.Button Logoutbutton;
        private System.Windows.Forms.Label label1;
    }
}