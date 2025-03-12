using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access.Entities
{
    public class Teacher
    {
        public int Teacher_Id { get; set; }
        public int User_Id { get; set; }
        public string Department {  get; set; }
        public string Contact_Number { get; set; }

    }
}
