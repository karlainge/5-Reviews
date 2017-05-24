using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _5_Stars_Reviews.Models
{
    public class Director
    {
        public virtual int DirectorId { get; set; }

        public virtual string DirectorName { get; set; }

        ICollection<Film> Film;

    }
}