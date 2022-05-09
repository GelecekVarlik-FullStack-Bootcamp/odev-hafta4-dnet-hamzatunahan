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
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(DbContext context) : base(context)
        {

        }
        public IQueryable<User> GetTotalReport()
        {
            return dbset.AsQueryable<User>();
        }

        public User Login(User login)
        {
            var user = dbset.Where(x => x.UserMail == login.UserMail && x.Password == login.Password).SingleOrDefault();
            //var user = dbset.FirstOrDefault(x => x.UserCode == login.UserCode && x.Password == login.Password);
            //var user = dbset.SingleOrDefault(x => x.UserCode == login.UserCode && x.Password == login.Password);

            return user;
        }
    }
}
