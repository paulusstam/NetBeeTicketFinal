using NetBeeTicket.BLL;
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
            RoleBs R = new RoleBs();
            R.Insert(new Role() { RoleName = "User", RoleCode = "U" });
        }
    }
}
