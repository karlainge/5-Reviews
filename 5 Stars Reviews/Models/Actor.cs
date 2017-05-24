using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _5_Stars_Reviews.Models
{
    public class Actor
    {
        public virtual int ActorId { get; set; }

        public virtual string ActorName { get; set; }

        ICollection<Film> Films;

    }
}