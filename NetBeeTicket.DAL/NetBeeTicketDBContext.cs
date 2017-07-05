using NetBeeTicket.BOL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBeeTicket.DAL
{
    public class NetBeeTicketDBContext : DbContext
    {
        public NetBeeTicketDBContext():base("NetBeeTicketDB")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<NetBeeTicketDBContext, NetBeeTicket.DAL.Migrations.Configuration>());
            Configuration.ProxyCreationEnabled = false;
        }
        public  DbSet<Role> Roles { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
