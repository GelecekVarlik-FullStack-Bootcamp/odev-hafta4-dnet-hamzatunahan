using Northwind.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace Northwind.Entity.Models
{
    public partial class User : EntityBase
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserLastName { get; set; }
        public string UserMail { get; set; }
        public string UserCode { get; set; }
        public string TelNo { get; set; }
        public string Password { get; set; }
        public int DepartmanId { get; set; }
        public string UserYetki { get; set; }
    }
}
