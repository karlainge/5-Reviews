﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _5_Stars_Reviews.Models
{
    public class CommentContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public CommentContext() : base("name=CommentContext")
        {
        }

        public System.Data.Entity.DbSet<_5_Stars_Reviews.Models.Comment> Comments { get; set; }

        public System.Data.Entity.DbSet<_5_Stars_Reviews.Models.Film> Films { get; set; }
    }
}
