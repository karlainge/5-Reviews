using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _5_Stars_Reviews.Models
{
    public class Review
    {
        public virtual int FilmId { get; set; }

        public virtual string ReviewName { get; set; }

        public virtual string Genre { get; set; }
    }
}