using Data_Access;
using Data_Access.Entities;
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
    public partial class Student_Panel : Form
    {
        public Student_Panel()
        {
            InitializeComponent();
            Database db = new Database();
            List<Student> data = db.Student.Get_All_Students();
            dgv2.DataSource = data;
        }

        private void Logout_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login_Page().Show();
        }

        private void Teacher_info_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Teacher_Info_for_Students().Show();
        }

        private void Admin_info_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Admin_Info_for_Students().Show();
        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            int Student_Id = int.Parse(tb_uname.Text);
            Database db = new Database();

            Student stu = db.Student.Search(Student_Id);
            if (stu == null)
            {
                MessageBox.Show("Student not found.");
                D_textbox.Text = "";
                Contact_textbox.Text = "";
            }
            else
            {
                D_textbox.Text = stu.Department;
                Contact_textbox.Text = stu.Contact_Number;

            }
        }

        private void S_Student_Id_Click(object sender, EventArgs e)
        {

        }
    }
}
