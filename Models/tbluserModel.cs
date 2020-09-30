using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace MvcProject.Models
{
    public class tbluserModel
    {

        [Key]

        [Required]

        [Display(Name = "UserName :")]
        public string USERNAME { get; set; }

        [Required]

        [Display(Name = "Password :")]
        public string PASSWORD { get; set; }

        [Required]

        [Display(Name = "Role :")]
        public string ROLE { get; set; }

    }
}
