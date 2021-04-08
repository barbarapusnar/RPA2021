using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace VajaCodeFirst1.Models
{
    public class VajaCodeFirst1Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public VajaCodeFirst1Context() : base("name=VajaCodeFirst1Context")
        {
        }

        public System.Data.Entity.DbSet<VajaCodeFirst1.Models.Kupec> Kupecs { get; set; }

        public System.Data.Entity.DbSet<VajaCodeFirst1.Models.Račun> Račun { get; set; }
    }
}
