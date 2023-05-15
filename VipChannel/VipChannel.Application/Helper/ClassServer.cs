using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace VipChannel.Application.Helper
{
    public class ClassServer<T> where T : DbContext, new()
    {
        public DateTime GetTimeServer()
        {
            DateTime query;
            using (T db = new T())
            {
                query = db.Database.SqlQuery<DateTime>("SELECT GETDATE()").SingleOrDefault();
            }
            return query;
        }
    }
}
