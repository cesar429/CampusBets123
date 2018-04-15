using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CampusBets.Helpers
{
    public class ProductContext : DbContext
    {
        public DbSet<Models.Events> Events { get; set; }
    
    }

}