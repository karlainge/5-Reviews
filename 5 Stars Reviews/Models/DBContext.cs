using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _5_Stars_Reviews.Models
{
    public class DBContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public DBContext() : base("name=DBContext")
        {
        }

        public System.Data.Entity.DbSet<_5_Stars_Reviews.Models.Film> Films { get; set; }

        public System.Data.Entity.DbSet<_5_Stars_Reviews.Models.Director> Directors { get; set; }
        [AllowHtml]
        public System.Data.Entity.DbSet<_5_Stars_Reviews.Models.Actor> Actors { get; set; }

        public System.Data.Entity.DbSet<_5_Stars_Reviews.Models.ActorComment> ActorComments { get; set; }

        public System.Data.Entity.DbSet<_5_Stars_Reviews.Models.DirectorComment> DirectorComments { get; set; }

        public System.Data.Entity.DbSet<_5_Stars_Reviews.Models.Review> Reviews { get; set; }
    }
}
