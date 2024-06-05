using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lesson06___Entity_framework.Models
{
    public class PvvBook
    {
        [Key]
        public int PvvId { get; set; }
        public string PvvBookId { get; set; }
        public string PvvTitle { get; set;}
        public string PvvAuthor { get;set; }
        public int PvvYear { get;set; }
        public string PvvPulisher { get; set; }  
        public string PvvPicture { get; set; }
        public int PvvCategoryId { get; set; }
        public virtual PvvCategory PvvCategory { get; set; }



    }
}