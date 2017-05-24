using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _5_Stars_Reviews.Models
{
    public class CommentActor
    {
        
        public virtual int CommentAId { get; set; }

        public virtual string CommentsA { get; set; }

        public virtual int ActorId { get; set; }

        public virtual Actor Actor { get; set; }


    }
}