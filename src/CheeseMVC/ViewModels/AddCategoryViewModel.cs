using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CheeseMVC.ViewModels
{
    public class AddCategoryViewModel
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Cheese Category")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Must be bwteen 3 and 20 characters long")]
        public string Name { get; set; }

    }
}
