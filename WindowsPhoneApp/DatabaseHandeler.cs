using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using WindowsPhoneApp.Models;

namespace WindowsPhoneApp
{
    public class DatabaseHandeler
    {
        public SQLiteConnection db;
        public DatabaseHandeler()
        {
            db = new SQLiteConnection("Foo");
            db.CreateTable<Users>();
        }

        public string Test()
        {
            var temp = db.Insert(new Users()
            {
                UserName = "Temp",
                PassWord = "wriuwiuhfwuiefh"
            });

            return "Temp";
        }

        public List<Users> QueryVals()
        {
            return db.Query<Users>("select * from Users");
        }   
    }
}
