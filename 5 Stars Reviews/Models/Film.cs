using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _5_Stars_Reviews.Models
{
    public class Film
    {
        public virtual int FilmId { get; set; }

        public virtual string FilmName { get; set; }

        public virtual string Description { get; set; }

        public virtual DateTime ReleaseDate { get; set; }

        public virtual string Genre { get; set; }

        public virtual int DirectorId { get; set; }

        public virtual Director Director { get; set; }

    }
}