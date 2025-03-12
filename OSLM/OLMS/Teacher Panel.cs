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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OLMS
{
    public partial class Teacher_Portal : Form
    {
        public Teacher_Portal()
        {
            InitializeComponent();
            Database db = new Database();
            List<Student> data = db.Student.Get_All_Students();
            dgv2.DataSource = data;
        }

        private void Teacher_info_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Teacher_Info().Show();
        }

        private void Admin_info_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Admin_Info().Show();
        }

        private void Logout_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login_Page().Show();
        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            int Student_Id = int.Parse(tb_uname.Text);
            Database db = new Database();

            Student stu = db.Student.Search(Student_Id);
            if (stu == null)
            {
                MessageBox.Show("Teacher not found.");
                C_textbox.Text = "";
                D_textbox.Text = "";
                Contact_textbox.Text = "";
            }
            else
            {
                C_textbox.Text = stu.Course;
                D_textbox.Text = stu.Department;
                Contact_textbox.Text = stu.Contact_Number;

            }
        }

        private void U_botton1_Click(object sender, EventArgs e)
        {
            string updated_course = C_textbox.Text;
            string updated_deoartment = D_textbox.Text;
            string updated_contactnumber = Contact_textbox.Text;
            

            Student stu = new Student();
            stu.Course = C_textbox.Text;
            stu.Department = D_textbox.Text;
            stu.Contact_Number = Contact_textbox.Text;

            Database db = new Database();
            bool rs = db.Student.Update(stu);
            if (rs)
            {
                MessageBox.Show("Updated.");
                C_textbox.Text = "";
                D_textbox.Text = "";
                Contact_textbox.Text = "";
            }
            else
            {
                MessageBox.Show("Update Error.");
                C_textbox.Text = "";
                D_textbox.Text = "";
                Contact_textbox.Text = "";
            }
        }
    }
}
