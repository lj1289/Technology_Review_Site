using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Technology_Review_Site.Models
{
    public class Technology_Review_SiteContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Technology_Review_SiteContext() : base("name=Technology_Review_SiteContext")
        {
        }

        public System.Data.Entity.DbSet<Technology_Review_Site.Models.Category> Categories { get; set; }

        public System.Data.Entity.DbSet<Technology_Review_Site.Models.Reviews> Reviews { get; set; }
    }
}
