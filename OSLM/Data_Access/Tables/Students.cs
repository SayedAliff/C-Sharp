using System;
using Data_Access;
using Data_Access.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Data_Access.Tables
{
    public class Students
    {
        SqlConnection conn;
        public Students()
        {
            string connStr = @"Server= Alif\SQLEXPRESS; Database= OLMS; Integrated Security= true ";
            conn = new SqlConnection(connStr);
        }

        public List<Student> Get_All_Students()
        {
            string query = "select * from Student";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<Student> data = new List<Student>();

            while (reader.Read())
            {
                Student stu = new Student();
                stu.Student_Id = reader.GetInt32(reader.GetOrdinal("Student_Id"));
                stu.User_Id = reader.GetInt32(reader.GetOrdinal("User_Id"));
                stu.Department  = reader.GetString(reader.GetOrdinal("Department"));
                stu.Contact_Number = reader.GetString(reader.GetOrdinal("Contact_Number"));
                stu.Course = reader.GetString(reader.GetOrdinal("Course"));

                data.Add(stu);
            }
            conn.Close();
            return data;
        }


        public Student Search(int Student_Id)
        {
            string query = string.Format("select * from Student where Student_Id= '{0}'", Student_Id);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Student stu = null;

            while (reader.Read())
            {
                stu = new Student();

                stu.User_Id = reader.GetInt32(reader.GetOrdinal("User_Id"));
                stu.Department = reader.GetString(reader.GetOrdinal("Department"));
                stu.Contact_Number = reader.GetString(reader.GetOrdinal("Contact_Number"));
                stu.Course = reader.GetString(reader.GetOrdinal("Course"));
                //tea.Password = reader.GetString(reader.GetOrdinal("Password"));
            }
            conn.Close();
            return stu;
        }

        public bool Insert(Student stu)
        {
            string query = string.Format("insert into Student ('{2}','{3}','{4}')",
                                            stu.Department, stu.Contact_Number, stu.Course);

            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            int rs = cmd.ExecuteNonQuery();
            conn.Close();
            if (rs > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool Update(Student stu)
        {
            string query = string.Format("update Student set Department='{0}', Contact_Number='{1}', Course='{2}' where Student_Id ='{3}'", stu.Department, stu.Contact_Number, stu.Course, stu.Student_Id);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;
        }

        public bool Delete(string Student_Id)
        {
            string query = string.Format("delete from Student where Student_Id='{0}'", Student_Id );
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0)
            {
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
