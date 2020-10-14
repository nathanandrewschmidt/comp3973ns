using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AspDb.Models.NW
{
    public partial class Categories
    {
        public Categories()
        {
            Products = new HashSet<Products>();
        }

        public int CategoryId { get; set; }
        [Required (ErrorMessage = "dont do that")]
        [Display(Name = "Ayo")]
        public string CategoryName { get; set; }
        [Required]
        public string Description { get; set; }
        public byte[] Picture { get; set; }

        public virtual ICollection<Products> Products { get; set; }
    }
}
