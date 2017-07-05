using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBeeTicket.DAL
{
    public class DALBase
    {
        protected NetBeeTicketDBContext db;

        public  DALBase()
        {
            db = new NetBeeTicketDBContext();
        }
    }
}
