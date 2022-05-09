using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Dal.Abstract
{
    public interface ITalepRepository
    {
        Talep FindId(Talep findid);
    }
}
