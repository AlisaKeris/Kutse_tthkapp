using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Kutse_app.Models
{
    public class GuestDBInitializer : CreateDatabaseIfNotExists<GuestContext>
    {
        protected override void Seed(GuestContext db)
        {
            base.Seed(db);
            
        }
        
    }
}