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
            if (db == null)
            {
                db = new SQLiteConnection("WPA_Database"); 
            }
        }

        public void CreateDatabase()
        {
            db.CreateTable<Users>();
            db.CreateTable<Customers>();
        }

        public string InsertContact(string company, string title, string firstName, string lastName, string phone, string email)
        {   
            try
            {
                db.Insert(new Customers()
                {
                    Company = company,
                    Title = title,
                    First_Name = firstName,
                    Last_Name = lastName,
                    Phone = phone,
                    Email = email
                });
            }
            catch (Exception e)
            {
                return e.ToString();
            }
            return "Contact has been added succesfully.";
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
