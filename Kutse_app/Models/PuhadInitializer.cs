using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Kutse_app.Models
{
    public class PuhadInitializer : CreateDatabaseIfNotExists<PuhadContext>
    {
        protected override void Seed(PuhadContext dbfordays)
        {
            base.Seed(dbfordays);

        }
    }
}