using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access.Entities
{
    public class Admin
    {
        public int Admin_Id {  get; set; }
        public int User_Id { get; set;}
        public string Position { get; set; }
        public string Contact_Number { get; set; }
    }
}
