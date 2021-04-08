using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VajaCodeFirst1.Models
{
    public class Račun
    {
        public int Id { get; set; }
        
        public decimal Vrednost { get; set; }
        public DateTime DatumIzdaje { get; set; }
        
        public Kupec Kupec { get; set; }
    }
}