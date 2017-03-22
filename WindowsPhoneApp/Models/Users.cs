using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace WindowsPhoneApp.Models
{
   public class Users
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set;}
        public string UserName { get; set; }
        public string PassWord { get; set; }

        public Users()
        { 
        }


    }
}
