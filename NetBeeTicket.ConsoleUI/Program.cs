using NetBeeTicket.DAL;
using NetBeeTicket.BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBeeTicket.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            RoleDb R = new RoleDb();
            R.Insert(new Role() { RoleName = "Admin", RoleCode = "A" });
            R.Save();
        }
    }
}
