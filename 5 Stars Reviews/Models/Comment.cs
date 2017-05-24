using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _5_Stars_Reviews.Models
{
    public class Comment
    {
        public virtual int CommentId { get; set; }

        public virtual string Comments { get; set; }

        public virtual int FilmId { get; set; }

        public virtual Film Film { get; set; }

    }
}