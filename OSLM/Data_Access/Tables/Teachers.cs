using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Data_Access.Entities;

namespace Data_Access.Tables
{
    public class Teachers
    {
        SqlConnection conn;

        public Teachers()
        {

            string connStr = @"Server= Alif\SQLEXPRESS; Database= OLMS; Integrated Security= true ";
            conn = new SqlConnection(connStr);
        }

        public List<Teacher> Get_All_Teachers()
        {
            string query = "select * from Teacher";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<Teacher> data = new List<Teacher>();

            while (reader.Read())
            {
                Teacher tea = new Teacher();
                tea.Teacher_Id = reader.GetInt32(reader.GetOrdinal("Teacher_Id"));
                tea.User_Id = reader.GetInt32(reader.GetOrdinal("User_Id"));
                tea.Department = reader.GetString(reader.GetOrdinal("Department"));
                tea.Contact_Number = reader.GetString(reader.GetOrdinal("Contact_Number"));

                data.Add(tea);
            }
            conn.Close();
            return data;
        }
        public bool Insert(Teacher tea)
        {
            string query = string.Format("insert into Teacher ('{0}','{1}')", tea.Department, tea.Contact_Number );

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

        public Teacher Search(int Teacher_Id)
        {
            string query = string.Format("select * from Teacher where Teacher_Id= '{0}'",Teacher_Id);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Teacher tea = null;

            while (reader.Read())
            {
                tea = new Teacher();
                tea.Teacher_Id = reader.GetInt32(reader.GetOrdinal("Teacher_Id"));
                tea.User_Id = reader.GetInt32(reader.GetOrdinal("User_Id"));
                tea.Department = reader.GetString(reader.GetOrdinal("Department"));
                tea.Contact_Number = reader.GetString(reader.GetOrdinal("Contact_Number"));
                //tea.Password = reader.GetString(reader.GetOrdinal("Password"));
            }
            conn.Close();
            return tea;
        }

        public bool Update(Teacher tea)
        {
            string query = string.Format("update Teacher set Department= '{0}', Contact_Number='{1}' where Teacher_Id= '{2}'", tea.Department, tea.Contact_Number, tea.Teacher_Id);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;
        }

        public bool Delete(string Teacher_Id)
        {
            string query = string.Format("delete from Teacher where Teacher_Id='{0}'", Teacher_Id);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            int rs = cmd.ExecuteNonQuery();
            conn.Close();
            if (rs > 0)
            {
                return true;
            }
            return false;
        }

        
    }
}