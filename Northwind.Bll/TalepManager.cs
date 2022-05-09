using Northwind.Dal.Abstract;
using Northwind.Entity.Dto;
using Northwind.Entity.IBase;
using Northwind.Entity.Models;
using Northwind.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Northwind.Entity.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace Northwind.Bll
{
    public class TalepManager : GenericManager<Talep, DtoTalep>, ITalepService
    {
        //ItalepRepository
        public readonly ITalepRepository talepRepository;
        private IConfiguration configuration;

        public TalepManager(IServiceProvider service,IConfiguration configuration) : base(service)
        {
            talepRepository = service.GetService<ITalepRepository>();
            this.configuration = configuration;
        }

    }
}
