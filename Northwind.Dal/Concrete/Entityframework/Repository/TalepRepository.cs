using Microsoft.EntityFrameworkCore;
using Northwind.Dal.Abstract;
using Northwind.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Dal.Concrete.Entityframework.Repository
{
    public class TalepRepository : GenericRepository<Talep>, ITalepRepository
    {
        public TalepRepository(DbContext context) : base(context)
        {
        }
        public Talep FindId(Talep findid)
        {
            var user = dbset.Where(x => x.DepartmanId == findid.DepartmanId);
            //var user = dbset.FirstOrDefault(x => x.UserCode == login.UserCode && x.Password == login.Password);
            //var user = dbset.SingleOrDefault(x => x.UserCode == login.UserCode && x.Password == login.Password);
            return (Talep)user;
        }
    }
}
