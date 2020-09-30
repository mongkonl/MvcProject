using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcProject.DataAccess;
using MvcProject.Models;
//using MvcProject.DataAccess;

namespace MvcProject.Controllers
{
    public class LoginController : Controller
    {

        private readonly tbluserconnect _dbContext;

        public LoginController(tbluserconnect dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(tbluserModel data)
        {
            if (data.USERNAME != null && data.PASSWORD != null)
            {

                string username = data.USERNAME.ToString();
                string password = data.PASSWORD.ToString();


                tbluserModel result = _dbContext.Tbluser.ToList().Where(x => x.USERNAME == username && x.PASSWORD == password).FirstOrDefault();

                if (result != null)
                {

                    return RedirectToAction("Index", "Main");

                }
            }
            return View();
        }
    }
}
