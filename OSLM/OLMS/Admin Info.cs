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
    public partial class Admin_Info : Form
    {
        public Admin_Info()
        {
            InitializeComponent();
            Database db = new Database();
            List<Admin> data = db.Admin.Get_All_Admins();
            dgv2.DataSource = data;
        }

        private void logoutbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login_Page().Show();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Teacher_Portal().Show();
        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            int Admin_Id = int.Parse(tb_adminid.Text);
            Database db = new Database();
            Admin adm = db.Admin.FindById(Admin_Id);
            if (adm == null)
            {
                MessageBox.Show("Admin not found.");
                D_textbox.Text = "";
                Contact_textbox.Text = "";
            }
            else
            {
                D_textbox.Text = adm.Position;
                Contact_textbox.Text = adm.Contact_Number;

            }
        }
    }
}
