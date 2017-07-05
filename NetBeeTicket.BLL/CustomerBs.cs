using NetBeeTicket.BOL;
using NetBeeTicket.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBeeTicket.BLL
{
    public class CustomerBs
    {
        private CustomerDb ObjDb;

        public List<string> Errors = new List<string>();

        public CustomerBs()
        {
            ObjDb = new CustomerDb();
        }
        public IEnumerable<Customer> GetALL()
        {
            return ObjDb.GetALL();
        }
        public Customer GetByID(string Id)
        {
            return ObjDb.GetByID(Id);
        }

        public bool Insert(Customer emp)
        {
            if (IsValidOnInsert(emp))
            {
                ObjDb.Insert(emp);
                
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Delete(string Id)
        {
            ObjDb.Delete(Id);
        }
        public bool Update(Customer emp)
        {
            if (IsValidOnUpdate(emp))
            {
                ObjDb.Update(emp);
                return true;
            }
            else
            {
                return false;
            }
        }
        public Customer GetByEmail(string email)
        {
            return ObjDb.GetByEmail(email);
        }
        public Customer RecoverPasswordByEmail(string email)
        {
            var emp = ObjDb.GetByEmail(email);
           
            return emp;
        }

        public bool IsValidOnInsert(Customer emp)
        {
            
                return true;
        
        }

        public bool IsValidOnUpdate(Customer emp)
        {

            
                return true;
           
        }
    }
}
