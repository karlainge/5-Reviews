using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _5_Stars_Reviews.Models
{
    public class Review
    {
        public virtual int ReviewId { get; set; }

        public virtual string ReviewName { get; set; }

        public virtual int Rating { get; set; }

        public virtual int FilmId { get; set; }

        public virtual Film Film { get; set; }


    }
}