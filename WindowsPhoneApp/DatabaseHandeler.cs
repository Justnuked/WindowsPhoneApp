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

        public string InsertCustomer(string company, string title, string firstName, string lastName, string phone, string email)
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
            return "Customer has been added succesfully.";
        }

        public string EditCustomer(int id, string company, string title, string firstName, string lastName, string phone, string email)
        {

            return "Customer edited succesfully.";
        }

        public Customers SelectCustomer(int id)
        {
            try
            {
               Customers cust;
               cust = new Customers();
                
               var query = db.Table<Customers>().Where(v => v.Id == id);

               foreach (var c in query)
               {
                   cust.Company = c.Company;
                   cust.First_Name = c.First_Name;
                   cust.Last_Name = c.Last_Name;
                   cust.Title = c.Title;
                   cust.Phone = c.Phone;
                   cust.Email = c.Email;
               }

               return cust;
            }
            catch (Exception e)
            {
                Customers cust;
                cust = new Customers();
                cust.First_Name = e.ToString();
                return cust;
            }
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
