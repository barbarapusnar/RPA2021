using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VajaCodeFirst.Models
{
    public class Kupec
    {
        public int Id { get; set; }
        public string ImePodjetja { get; set; }
        public string Kontakt { get; set; }
        public string Telefon { get; set; }
        public string Mail { get; set; }
    }
}