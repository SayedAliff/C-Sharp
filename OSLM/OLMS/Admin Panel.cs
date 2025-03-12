using Data_Access.Entities;
using Data_Access.Tables;
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
using System.Security.Cryptography.X509Certificates;

namespace OLMS
{
    public partial class Admin_Panel : Form
    {
        public Admin_Panel()
        {
            InitializeComponent();
            Database db = new Database();
            List<Student> data = db.Student.Get_All_Students();
            dgv_student.DataSource = data;

            Database db1 = new Database();
            List<Teacher> data1 = db1.Teacher.Get_All_Teachers();
            dgv_teacher.DataSource = data1;
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit();
        }

        private void bt_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login_Page().Show();
        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tb_uname.Text);


            if (rb_teacher.Checked)
            {
                Database db1 = new Database();
                Teacher tea = db1.Teacher.Search(id);
                if (tea == null)
                {
                    MessageBox.Show("Not found.");
                    
                    tb_Contact.Text = "";
                    tb_dept.Text = "";
                }
                else
                {
                    tb_dept.Text = tea.Department;
                    tb_Contact.Text = tea.Contact_Number;
                }
            }

            if (rb_student.Checked)
            {
                Database db = new Database();
                Student stu = db.Student.Search(id);
                if (stu == null)
                {
                    MessageBox.Show("Not found.");
                    tb_Contact.Text = "";
                    tb_dept.Text = "";
                    tb_course.Text = "";
                }
                else
                {
                    tb_dept.Text = stu.Department;
                    tb_Contact.Text = stu.Contact_Number;
                    tb_course.Text = stu.Course;
                }
            }
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
     
            if (rb_teacher.Checked)
            {
                string updated_ContactNumber = tb_Contact.Text;
                string updated_Department = tb_dept.Text;

                Teacher tea = new Teacher();
                tea.Contact_Number = tb_Contact.Text;
                tea.Department = tb_dept.Text;

                Database db = new Database();
                bool r = db.Teacher.Update(tea);
                if (r == true)
                {
                    dgv_teacher.DataSource = db.Teacher.Get_All_Teachers();
                    MessageBox.Show("Updated.");
                    tb_Contact.Text = "";
                    tb_dept.Text = "";
                }
                else
                {
                    MessageBox.Show("Update Error.");
                    tb_Contact.Text = "";
                    tb_dept.Text = "";
                }
            }

            if (rb_student.Checked)
            {
                string updated_ContactNumber = tb_Contact.Text;
                string updated_Course = tb_course.Text;
                string updated_Department = tb_dept.Text;

                Student stu = new Student();
                stu.Course = tb_course.Text;
                stu.Contact_Number = tb_Contact.Text;
                stu.Department = tb_dept.Text;
                

                Database db = new Database();
                bool rs = db.Student.Update(stu);
                if (rs == true)
                {
                    dgv_student.DataSource = db.Student.Get_All_Students();
                    MessageBox.Show("Updated.");
                    tb_Contact.Text = "";
                    tb_course.Text = "";
                    tb_dept.Text = "";
                }
                else
                {
                    MessageBox.Show("Update Error.");
                    tb_Contact.Text = "";
                    tb_course.Text = "";
                    tb_dept.Text = "";
                }
            }
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            string User_Id = tb_uname.Text;

            if (rb_teacher.Checked)
            {
                Database db = new Database();
                bool r = db.Teacher.Delete(User_Id);
                if (r)
                {
                    dgv_teacher.DataSource = db.Teacher.Get_All_Teachers();
                    MessageBox.Show("Row Deleted.");
                    tb_Contact.Text = "";
                    tb_dept.Text = "";
                }
                else
                {
                    MessageBox.Show("ERROR.");
                    tb_Contact.Text = "";
                    tb_dept.Text = "";
                }
            }

            if (rb_student.Checked)
            {
                Database db = new Database();
                bool rs = db.Student.Delete(User_Id) ;
                if (rs)
                {
                    dgv_student.DataSource = db.Student.Get_All_Students();
                    MessageBox.Show("Row Deleted.");
                    tb_Contact.Text = "";
                    tb_course.Text = "";
                    tb_dept.Text = "";
                }
                else
                {
                    MessageBox.Show("ERROR.");
                    tb_Contact.Text = "";
                    tb_course.Text = "";
                    tb_dept.Text = "";
                }
            }
        }

        private void User_Imfo_bt_Click(object sender, EventArgs e)
        {
            this.Hide();
            new User_info_Edit().Show();
        }


    }
}
