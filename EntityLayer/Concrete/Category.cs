using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer.Concrete
{
   public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        [StringLength(50)]
        public string CaregoryName { get; set; }
        [StringLength(200)]
        public string CaregoryDescription { get; set; }
        public bool CaregoryStatus { get; set; }

        public ICollection<Heading> headings { get; set; }
    }
}
