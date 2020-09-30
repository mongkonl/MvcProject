using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace MvcProject.Models
{
    public class tblcustomerModel
    {

        private DateTime _dt = DateTime.Now;

        #region code

        [Key]

        [Display(Name = "Code :")]
        public string CODE { get; set; }


        #endregion

        #region Name

        [Required(ErrorMessage = "Please enter name")]

        [Display(Name = "Name :")]
        public string NAME { get; set; }

        #endregion


        #region Lastname

        [Required(ErrorMessage = "Please enter lastname")]

        [Display(Name = "LastName :")]
        public string LASTNAME { get; set; }

        #endregion


        #region mobile

        [Required(ErrorMessage = "Please enter mobile")]

        [Display(Name = "Mobile :")]
        public string MOBILE { get; set; }

        #endregion


        #region job

        [Required(ErrorMessage = "Please select job")]

        [Display(Name = "Job :")]
        public string JOB { get; set; }

        #endregion


        #region sex

        [Required(ErrorMessage = "Please select sex")]

        [Display(Name = "Sex :")]
        public string SEX { get; set; }

        #endregion

        public DateTime CREATE_DATE
        {
            get { return _dt; }
            set { _dt = value; }

        }


        public static string GenerateCode()
        {
            string strDT = DateTime.Now.Ticks.ToString();


            // "1518416541848541848" //19
            return "CD" + strDT.Substring(strDT.Length - 5, 5); //CD41848
        }

    }
}
