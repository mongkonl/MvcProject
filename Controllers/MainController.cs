using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcProject.DataAccess;
using MvcProject.Models;

namespace MvcProject.Controllers
{
    public class MainController : Controller
    {

        private readonly tblcustomerconnect _dbContext;

        public MainController(tblcustomerconnect dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            //get data to job


            List<jobModel> mmm = new List<jobModel>();

            jobModel _j = new jobModel();

            _j.ID = "111111";
            _j.NAME = "Teacher";

            mmm.Add(_j);

            jobModel _j2 = new jobModel();

            _j2.ID = "222222";
            _j2.NAME = "Docter";

            mmm.Add(_j2);



            List<jobModel> listJob = new List<jobModel>() { new jobModel { ID = "0001", NAME = "Engineer" }, new jobModel { ID = "0002", NAME = "Programmer" } };


            listJob.Insert(0, new jobModel { ID = null, NAME = "------Please Select Job------" });

            ViewBag.ListJob = listJob;

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Index(tblcustomerModel _customer)
        {


            //get data to job

            List<jobModel> listJob = new List<jobModel>()

            { new jobModel { ID = "0001", NAME = "Engineer" } , new jobModel { ID="0002" , NAME = "Programmer" } };


            listJob.Insert(0, new jobModel
            {
                ID = null
                ,
                NAME = "------Please Select Job------"
            });

            ViewBag.ListJob = listJob;



            if (ModelState.IsValid)
            {
                tblcustomerModel _result = new tblcustomerModel();

                _result = _customer;
                _result.CODE = tblcustomerModel.GenerateCode();

                _dbContext.Add(_result);

                await _dbContext.SaveChangesAsync();


            }

            return View();

        }
    }
}
