using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using MvcProject.Models;

namespace MvcProject.DataAccess
{
    public class tblcustomerconnect : DbContext
    {

        public tblcustomerconnect(DbContextOptions<tblcustomerconnect> options) : base(options)
        {



        }

        public DbSet<tblcustomerModel> Tblcustomer { get; set; }

    }
}
