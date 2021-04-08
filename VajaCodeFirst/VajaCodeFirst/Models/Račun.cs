using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VajaCodeFirst.Models
{
    public class Račun
    {
        public int Id { get; set; }
        public int IdKupca { get; set; }
        public decimal Vrednost { get; set; }
        public DateTime DatumIzdaje { get; set; }
        
        public Kupec Stranka { get; set; }
    }
}