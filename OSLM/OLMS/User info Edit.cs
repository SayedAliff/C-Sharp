using Data_Access.Entities;
using Data_Access;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OLMS
{
    public partial class User_info_Edit : Form
    {
        public User_info_Edit()
        {
            InitializeComponent();
            Database db = new Database();
            List<User_Info> data = db.User_Info.Get_All_Users();
            dgv2.DataSource = data;
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit();
        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            string User_Id = tb_uname.Text;
            Database db = new Database();
            User_Info usa = db.User_Info.Search(User_Id);
            if (usa == null)
            {
                MessageBox.Show("User not found.");
                C_textbox.Text = "";
                D_textbox.Text = "";
                F_textbox.Text = "";
                G_textbox.Text = "";
                H_textbox.Text = "";
            }
            else
            {
                C_textbox.Text = usa.User_Name;
                D_textbox.Text = usa.Email; 
                F_textbox.Text = usa.User_Type;
                G_textbox.Text = usa.Name;
                H_textbox.Text = usa.Status;
                upassword.Text = usa.Password;

            }
        }

        private void Update_botton1_Click(object sender, EventArgs e)
        {
            int updated_user_id = int.Parse(tb_uname.Text);
            string updated_username = C_textbox.Text;
            string updated_email = D_textbox.Text;
            string updated_usertype = F_textbox.Text;
            string updated_name = G_textbox.Text;
            string updated_status = H_textbox.Text;
            string updated_password = upassword.Text;

            User_Info usa = new User_Info();
            usa.User_Id = int.Parse(tb_uname.Text);
            usa.User_Name = C_textbox.Text;
            usa.Email = D_textbox.Text;
            usa.User_Type = F_textbox.Text;
            usa.Name = G_textbox.Text;
            usa.Status = H_textbox.Text;
            usa.Password = upassword.Text;

            Database db = new Database();
            bool rs = db.User_Info.Update(usa);
            if (rs == true)
            {
                dgv2.DataSource = db.User_Info.Get_All_Users();
                MessageBox.Show("Updated.");
                tb_uname.Text = "";
                C_textbox.Text = "";
                D_textbox.Text = "";
                F_textbox.Text = "";
                G_textbox.Text = "";
                H_textbox.Text = "";
                upassword.Text = "";
            }
            else
            {
                MessageBox.Show("Update Error.");
                tb_uname.Text = "";
                C_textbox.Text = "";
                D_textbox.Text = "";
                F_textbox.Text = "";
                G_textbox.Text = "";
                H_textbox.Text = "";
                upassword.Text = "";
            }

        }

        private void Del_button_Click(object sender, EventArgs e)
        {
            string User_Id = tb_uname.Text;
            Database db = new Database();
            bool rs = db.User_Info.Delete(User_Id);
            if (rs)
            {
                dgv2.DataSource = db.User_Info.Get_All_Users();
                MessageBox.Show("Row Deleted.");
                C_textbox.Text = "";
                D_textbox.Text = "";
                F_textbox.Text = "";
                G_textbox.Text = "";
                H_textbox.Text = "";
                upassword.Text = "";
            }
            else
            {
                MessageBox.Show("ERROR.");
                C_textbox.Text = "";
                D_textbox.Text = "";
                F_textbox.Text = "";
                G_textbox.Text = "";
                H_textbox.Text = "";
                upassword.Text = "";

            }
        }

        private void logoutbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login_Page().Show();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Admin_Panel().Show();
        }

        
    }
}
