using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Technology_Review_Site.Models
{
    public class Category
    {
        public int Id { get; set; }
        public virtual ICollection<Reviews> Reviews { get; set; }
        public string Name { get; set; }
    }
}