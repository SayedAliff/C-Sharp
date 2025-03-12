using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Data_Access.Entities;

namespace Data_Access.Tables
{
    public class User_Infos
    {
        SqlConnection conn;
        

        public User_Infos()
        {

            string connStr = @"Server= Alif\SQLEXPRESS; Database= OLMS; Integrated Security= true ";
            conn = new SqlConnection(connStr);
        }

        public List<User_Info> Get_All_Users()
        {
            string query = "select * from User_Info";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<User_Info> data = new List<User_Info>();

            while (reader.Read())
            {
                User_Info usa = new User_Info();

                usa.User_Id = reader.GetInt32(reader.GetOrdinal("User_Id"));
                usa.User_Name = reader.GetString(reader.GetOrdinal("User_Name"));
                usa.Password = reader.GetString(reader.GetOrdinal("Password"));
                usa.User_Type = reader.GetString(reader.GetOrdinal("User_Type"));
                usa.Name = reader.GetString(reader.GetOrdinal("Name"));
                usa.Email = reader.GetString(reader.GetOrdinal("Email"));
                usa.Status = reader.GetString(reader.GetOrdinal("Status"));


                data.Add(usa);
            }
            conn.Close();
            return data;


        }

        public bool Insert(User_Info usa)
        {
            string query = string.Format("insert into User_Info values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", usa.User_Id, usa.User_Name, usa.Password, usa.User_Type, usa.Name, usa.Email, usa.Status);
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

        public User_Info Search(string User_Id)
        {
            string query = string.Format("select * from User_Info where User_Id= '{0}'", User_Id);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            User_Info usa = null;
            while (reader.Read())
            {
                usa = new User_Info();
                usa.User_Name = reader.GetString(reader.GetOrdinal("User_Name"));
                usa.Password = reader.GetString(reader.GetOrdinal("Password"));
                usa.User_Type = reader.GetString(reader.GetOrdinal("User_Type"));
                usa.Name = reader.GetString(reader.GetOrdinal("Name"));
                usa.Email = reader.GetString(reader.GetOrdinal("Email"));
                usa.Status = reader.GetString(reader.GetOrdinal("Status"));
                
                //tea.Password = reader.GetString(reader.GetOrdinal("Password"));
            }
            conn.Close();
            return usa;
        }

        public bool Update(User_Info usa)
        {
            string query = string.Format("update User_Info set User_Id='{0}', User_Name= '{1}', Password= '{2}', User_Type='{3}', Name= '{4}', Email= '{5}', Status= '{6}' where User_Id= '{0}'", usa.User_Id, usa.User_Name, usa.Password, usa.User_Type, usa.Name, usa.Email, usa.Status, usa.User_Id);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;
        }

        public bool Delete(string User_Id)
        {
            string query = string.Format("delete from User_Info where User_Id='{0}'", User_Id);
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

        public bool Check_login(string User_Name, string Password)
        {
            string query = string.Format("select * from User_Info where User_Name='{0}' and Password='{1}'", User_Name, Password);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                return true;
            }
            return false;
        }
    }       
}
