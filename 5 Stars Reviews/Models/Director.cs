using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _5_Stars_Reviews.Models
{
    public class Director
    {
        public virtual int DirectorId;

        public virtual string DirectorName;

        ICollection<Film> Film;

    }
}