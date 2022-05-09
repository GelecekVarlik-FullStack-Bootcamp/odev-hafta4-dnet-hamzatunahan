using Northwind.Entity.Base;
using System;
using System.Collections.Generic;
using System.Text;

#nullable disable

namespace Northwind.Entity.Dto
{
    public partial class DtoUser : DtoBase
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserLastName { get; set; }
        public string UserMail { get; set; }
        public string UserCode { get; set; }
        public string TelNo { get; set; }
        public string Password = GetRandomPassword(6);
        public int DepartmanId { get; set; }
        public string UserYetki { get; set; }

        public static string GetRandomPassword(int length)
        {
            const string chars = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

            StringBuilder sb = new StringBuilder();
            Random rnd = new Random();

            for (int i = 0; i < length; i++)
            {
                int index = rnd.Next(chars.Length);
                sb.Append(chars[index]);
            }

            return sb.ToString();
        }
    }
}
