using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsPhoneApp.Models;
using System.Security;

namespace WindowsPhoneApp.Controllers
{
    public class Login
    {

        DatabaseHandeler dbh = new DatabaseHandeler();

        public Login()
        {
 
        }

        //Creates the test accounts
        public void CreateAccounts()
        {
            dbh.db.Insert(new Users(){
            UserName = "admin",
            PassWord = "Test"
        });
        }


    }
}
