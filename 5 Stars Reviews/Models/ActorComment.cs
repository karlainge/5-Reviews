using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace _5_Stars_Reviews.Models
{
    public class ActorComment
    {
        [Key]
        public virtual int ACommentId { get; set; }

        public virtual string AComment { get; set; }

        public virtual int ActorId { get; set; }

        public virtual Actor Actor { get; set; }

    }
}