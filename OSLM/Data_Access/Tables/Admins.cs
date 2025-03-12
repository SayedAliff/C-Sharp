using Data_Access.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access.Tables
{
    public class Admins
    {
        SqlConnection conn;

        public Admins()
        {

            string connStr = @"Server= Alif\SQLEXPRESS; Database= OLMS; Integrated Security= true ";
            conn = new SqlConnection(connStr);
        }

        public List<Admin> Get_All_Admins()
        {
            string query = "select * from Admin";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<Admin> data = new List<Admin>();

            while (reader.Read())
            {
                Admin adm = new Admin();
                adm.Admin_Id = reader.GetInt32(reader.GetOrdinal("Admin_Id"));
                adm.User_Id = reader.GetInt32(reader.GetOrdinal("User_Id"));
                adm.Position = reader.GetString(reader.GetOrdinal("Position"));
                adm.Contact_Number = reader.GetString(reader.GetOrdinal("Contact_Number"));

                data.Add(adm);
            }
            conn.Close();
            return data;
        }

        public Admin FindById(int Admin_Id) {
            string query = "select * from Admin where Admin_Id = "+Admin_Id;
            conn.Open();
            SqlCommand cmd = new SqlCommand(@query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            Admin adm = new Admin();
            while (reader.Read())
            {
                adm.Admin_Id = reader.GetInt32(reader.GetOrdinal("Admin_Id"));
                adm.User_Id = reader.GetInt32(reader.GetOrdinal("User_Id"));
                adm.Position = reader.GetString(reader.GetOrdinal("Position"));
                adm.Contact_Number = reader.GetString(reader.GetOrdinal("Contact_Number"));
            }
            conn.Close();
            return adm;
        }

        public bool Insert(Admin adm)
        {
            string query = string.Format("insert into Admin ('{0}','{1}')",
                                            adm.Position, adm.Contact_Number);

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

        public bool Update(Admin adm)
        {
            string query = string.Format("Update Admin set Position='{0}', Contact_Number='{1}'", adm.Position, adm.Contact_Number);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;
        }

        public bool Delete(int Admin_Id)
        {
            string query = string.Format("Delete from Admin where Admin_Id='{0}'", Admin_Id);
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
