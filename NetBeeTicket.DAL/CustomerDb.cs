using NetBeeTicket.BOL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBeeTicket.DAL
{
    public class EmployeeDb
    {
        private NetBeeTicketDBContext db;

        public EmployeeDb()
        {
            db = new NetBeeTicketDBContext();
        }
        public IEnumerable<Customer> GetALL()
        {
            return db.Customers.ToList();
        }
        public Customer GetByID(string Id)
        {
            return db.Customers.Find(Id);
        }
        public void Insert(Customer emp)
        {
            db.Customers.Add(emp);
            Save();
        }
        public void Delete(string Id)
        {
            Customer emp = db.Customers.Find(Id);
            db.Customers.Remove(emp);
            Save();
        }
        public void Update(Customer emp)
        {
            db.Entry(emp).State = EntityState.Modified;
            db.Configuration.ValidateOnSaveEnabled = false;
            Save();
            db.Configuration.ValidateOnSaveEnabled = true;
        }

        public Customer GetByEmail(string email)
        {
            return db.Customers.Where(x => x.Email == email).FirstOrDefault();
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
