namespace OLMS
{
    partial class Admin_Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Info));
            this.logoutbutton = new System.Windows.Forms.Button();
            this.Contact_textbox = new System.Windows.Forms.TextBox();
            this.D_textbox = new System.Windows.Forms.TextBox();
            this.Contact_Number = new System.Windows.Forms.Label();
            this.position = new System.Windows.Forms.Label();
            this.Admin_id = new System.Windows.Forms.Label();
            this.bt_search = new System.Windows.Forms.Button();
            this.tb_adminid = new System.Windows.Forms.TextBox();
            this.backbutton = new System.Windows.Forms.Button();
            this.admintext = new System.Windows.Forms.Label();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.SuspendLayout();
            // 
            // logoutbutton
            // 
            this.logoutbutton.BackColor = System.Drawing.Color.Crimson;
            this.logoutbutton.Font = new System.Drawing.Font("Goudy Stout", 18F, System.Drawing.FontStyle.Bold);
            this.logoutbutton.ForeColor = System.Drawing.SystemColors.Window;
            this.logoutbutton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.logoutbutton.Location = new System.Drawing.Point(585, 574);
            this.logoutbutton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.logoutbutton.Name = "logoutbutton";
            this.logoutbutton.Size = new System.Drawing.Size(269, 52);
            this.logoutbutton.TabIndex = 95;
            this.logoutbutton.Text = "Log Out";
            this.logoutbutton.UseVisualStyleBackColor = false;
            this.logoutbutton.Click += new System.EventHandler(this.logoutbutton_Click);
            // 
            // Contact_textbox
            // 
            this.Contact_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Contact_textbox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Contact_textbox.Location = new System.Drawing.Point(282, 494);
            this.Contact_textbox.Name = "Contact_textbox";
            this.Contact_textbox.Size = new System.Drawing.Size(310, 26);
            this.Contact_textbox.TabIndex = 94;
            this.Contact_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // D_textbox
            // 
            this.D_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.D_textbox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.D_textbox.Location = new System.Drawing.Point(362, 431);
            this.D_textbox.Name = "D_textbox";
            this.D_textbox.Size = new System.Drawing.Size(144, 26);
            this.D_textbox.TabIndex = 92;
            this.D_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Contact_Number
            // 
            this.Contact_Number.AutoSize = true;
            this.Contact_Number.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Contact_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Contact_Number.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Contact_Number.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Contact_Number.Location = new System.Drawing.Point(372, 471);
            this.Contact_Number.Name = "Contact_Number";
            this.Contact_Number.Size = new System.Drawing.Size(125, 20);
            this.Contact_Number.TabIndex = 91;
            this.Contact_Number.Text = "Contact Number";
            // 
            // position
            // 
            this.position.AutoSize = true;
            this.position.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.position.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.position.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.position.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.position.Location = new System.Drawing.Point(406, 408);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(65, 20);
            this.position.TabIndex = 89;
            this.position.Text = "Position";
            // 
            // Admin_id
            // 
            this.Admin_id.AutoSize = true;
            this.Admin_id.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Admin_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Admin_id.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Admin_id.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Admin_id.Location = new System.Drawing.Point(391, 305);
            this.Admin_id.Name = "Admin_id";
            this.Admin_id.Size = new System.Drawing.Size(80, 20);
            this.Admin_id.TabIndex = 88;
            this.Admin_id.Text = "Admin_ID";
            // 
            // bt_search
            // 
            this.bt_search.BackColor = System.Drawing.Color.Cyan;
            this.bt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bt_search.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bt_search.Location = new System.Drawing.Point(385, 360);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(102, 23);
            this.bt_search.TabIndex = 87;
            this.bt_search.Text = "Search";
            this.bt_search.UseVisualStyleBackColor = false;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // tb_adminid
            // 
            this.tb_adminid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_adminid.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tb_adminid.Location = new System.Drawing.Point(282, 328);
            this.tb_adminid.Name = "tb_adminid";
            this.tb_adminid.Size = new System.Drawing.Size(310, 26);
            this.tb_adminid.TabIndex = 86;
            this.tb_adminid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // backbutton
            // 
            this.backbutton.BackColor = System.Drawing.Color.Crimson;
            this.backbutton.Font = new System.Drawing.Font("Goudy Stout", 18F, System.Drawing.FontStyle.Bold);
            this.backbutton.ForeColor = System.Drawing.SystemColors.Window;
            this.backbutton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.backbutton.Location = new System.Drawing.Point(6, 574);
            this.backbutton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(189, 52);
            this.backbutton.TabIndex = 85;
            this.backbutton.Text = "Back";
            this.backbutton.UseVisualStyleBackColor = false;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // admintext
            // 
            this.admintext.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.admintext.AutoSize = true;
            this.admintext.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.admintext.Font = new System.Drawing.Font("Calibri", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.admintext.ForeColor = System.Drawing.Color.White;
            this.admintext.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.admintext.Location = new System.Drawing.Point(361, -3);
            this.admintext.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.admintext.Name = "admintext";
            this.admintext.Size = new System.Drawing.Size(157, 59);
            this.admintext.TabIndex = 84;
            this.admintext.Text = "Admin";
            // 
            // dgv2
            // 
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Location = new System.Drawing.Point(174, 59);
            this.dgv2.Name = "dgv2";
            this.dgv2.Size = new System.Drawing.Size(533, 223);
            this.dgv2.TabIndex = 83;
            // 
            // Admin_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(857, 633);
            this.Controls.Add(this.logoutbutton);
            this.Controls.Add(this.Contact_textbox);
            this.Controls.Add(this.D_textbox);
            this.Controls.Add(this.Contact_Number);
            this.Controls.Add(this.position);
            this.Controls.Add(this.Admin_id);
            this.Controls.Add(this.bt_search);
            this.Controls.Add(this.tb_adminid);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.admintext);
            this.Controls.Add(this.dgv2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin_Info";
            this.Text = "Online Learning Management System";
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logoutbutton;
        private System.Windows.Forms.TextBox Contact_textbox;
        private System.Windows.Forms.TextBox D_textbox;
        private System.Windows.Forms.Label Contact_Number;
        private System.Windows.Forms.Label position;
        private System.Windows.Forms.Label Admin_id;
        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.TextBox tb_adminid;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Label admintext;
        private System.Windows.Forms.DataGridView dgv2;
    }
}