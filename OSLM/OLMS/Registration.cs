using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Data_Access;
using Data_Access.Entities;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OLMS
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login_Page().Show();
        }
        
        private void Proceed_Button_Click(object sender, EventArgs e)
        {

            int user_id = int.Parse(userid.Text);
            var username = ruser.Text;
            var email = remail.Text;
            var password = rpassword.Text;
            var user_type = rusertype.Text;
            var name = rname.Text;
            var status = rstatus.Text;

            User_Info usa = new User_Info();
            usa.User_Id = user_id;
            usa.User_Name = username;
            usa.Email = email;
            usa.Password = password;
            usa.User_Type = user_type;
            usa.Name = name;
            usa.Status = status;
            

            Database db = new Database();
            bool r = db.User_Info.Insert(usa);
            if (r == true)
            {
                MessageBox.Show("Regestration Complete.");
                userid.Text = "";
                ruser.Text = "";
                remail.Text = "";
                rpassword.Text = "";
                rusertype.Text = "";
                rname.Text = "";
                rstatus.Text = "";
            }
            else
            {
                MessageBox.Show("Regestration Error.");
                userid.Text = "";
                ruser.Text = "";
                remail.Text = "";
                rpassword.Text = "";
                rusertype.Text = "";
                rname.Text = "";
                rstatus.Text = "";
            }
        }
    }
}
