using Northwind.Entity.Base;
using System;
using System.Collections.Generic;
using System.Text;

#nullable disable

namespace Northwind.Entity.Dto
{
    public partial class DtoTalep : DtoBase
    {
        public int TalepId { get; set; }
        public string TalepBasligi { get; set; }
        public int DepartmanId { get; set; }
        public string OncelikDurumu { get; set; }
        public string DepartmanKonusu { get; set; }
        public string BaslamaTarihi { get; set; }
        public string Icerik { get; set; }
    }
}
