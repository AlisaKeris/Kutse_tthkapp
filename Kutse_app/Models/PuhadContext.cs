using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Kutse_app.Models
{
    public class PuhadContext : DbContext
    {
        public DbSet<Puhad> Puhad { get; set; }
    }
}