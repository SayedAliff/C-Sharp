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
    public partial class Login_Page : Form
    {
        public Login_Page()
        {
            InitializeComponent();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit();
        }

        private void Reg_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Registration().Show();
        }

        private void Proceed_Button_Click(object sender, EventArgs e)
        {
            if (rb_Admin.Checked)
            {
                string username = Username1.Text;
                string password = Password1.Text;

                Database db = new Database();
                bool rs = db.User_Info.Check_login(username, password);
                if (rs == true)
                {
                    this.Hide();
                    new Admin_Panel().Show();
                }

                else
                {
                    _ = MessageBox.Show("Invalid Username or Password");
                    Username1.Text = "";
                    Password1.Text = "";
                }
            }

            if (rb_Teacher.Checked)
            {
                string username = Username1.Text;
                string password = Password1.Text;

                Database db = new Database();
                bool rs = db.User_Info.Check_login(username, password);
                if (rs == true)
                {
                    this.Hide();
                    new Teacher_Portal().Show();
                }

                else
                {
                    _ = MessageBox.Show("Invalid Username or Password");
                    Username1.Text = "";
                    Password1.Text = "";
                }
            }

            if (rb_Student.Checked)
            {
                string username = Username1.Text;
                string password = Password1.Text;

                Database db = new Database();
                bool rs = db.User_Info.Check_login(username, password);
                if (rs == true)
                {
                    this.Hide();
                    new Student_Panel().Show();
                }

                else
                {
                    _ = MessageBox.Show("Invalid Username or Password");
                    Username1.Text = "";
                    Password1.Text = "";
                }
            }
        }
    }
}
