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

        public virtual int ActorId { get; set; }

        public virtual Actor Actor { get; set; }

        public virtual int DirectorId { get; set; }

        public virtual Director Director { get; set; }
    }
}