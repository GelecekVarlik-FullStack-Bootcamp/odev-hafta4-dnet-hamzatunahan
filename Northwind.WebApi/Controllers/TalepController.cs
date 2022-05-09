using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Northwind.Entity.Base;
using Northwind.Entity.Dto;
using Northwind.Entity.IBase;
using Northwind.Entity.Models;
using Northwind.Interface;
using Northwind.WebApi.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Northwind.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TalepController : ApiBaseController<ITalepService, Talep, DtoTalep>
    {
        private readonly ITalepService talepService;

        public TalepController(ITalepService talepService) : base(talepService)
        {
            this.talepService = talepService;
        }
    }
}
