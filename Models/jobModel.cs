using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace MvcProject.Models
{
    public class jobModel
    {
        [Key]
        public string ID { get; set; }
        public string NAME { get; set; }
    }
}
