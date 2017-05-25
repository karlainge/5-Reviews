using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace _5_Stars_Reviews.Models
{
    public class DirectorComment
    {
        [Key]
        public virtual int DCommentId { get; set; }

        public virtual string DComment { get; set; }

        public virtual int DirectorId { get; set; }

        public virtual Director Director { get; set; }

    }
}