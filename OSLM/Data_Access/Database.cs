using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access.Tables;
using System.Data.SqlClient;

namespace Data_Access
{
    public class Database
    {
        public User_Infos User_Info {  get; set; }
        public Admins Admin { get; set; }
        public Teachers Teacher { get; set; }
        public Students Student { get; set; }
        public object Teachers { get; set; }
        public object User_Infos { get; set; }
        public object Admins { get; set; }
        public object Students { get; set; }
        public Database()
        {
            /*string connStr = @"Server=DESKTOP-0L2RAUQ\SQLEXPRESS; Database=VARSITY_DB; Integrated Security= true";
            SqlConnection conn = new SqlConnection(connStr);
            Teachers = new Teachers(conn);*/

            Teacher = new Teachers();
            Student = new Students();
            Admin = new Admins();
            User_Info = new User_Infos();

        }

    }
}
