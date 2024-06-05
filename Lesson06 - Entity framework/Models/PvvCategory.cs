using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lesson06___Entity_framework.Models
{
    public class PvvCategory
    {
        [Key]
        public int PvvId { get; set; }
        public string PvvCategoryName { get; set;}
        public virtual ICollection<PvvBook> PvvBooks { get; set; }
    }
}