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
    public partial class Teacher_Info_for_Students : Form
    {
        public Teacher_Info_for_Students()
        {
            InitializeComponent();
            Database db = new Database();
            List<Teacher> data = db.Teacher.Get_All_Teachers();
            dgv2.DataSource = data;
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Student_Panel().Show();
        }

        private void Logoutbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login_Page().Show();
        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            int Teacher_Id = int.Parse(tb_uname.Text);
            Database db = new Database();

            Teacher tea = db.Teacher.Search(Teacher_Id);
            if (tea == null)
            {
                MessageBox.Show("Teacher not found.");
                D_textbox.Text = "";
                Contact_textbox.Text = "";
            }
            else
            {
                D_textbox.Text = tea.Department;
                Contact_textbox.Text = tea.Contact_Number;

            }
        }
    }
}
