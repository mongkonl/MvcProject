using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using MvcProject.Models;

namespace MvcProject.DataAccess
{
    public class tbluserconnect : DbContext
    {
        public tbluserconnect(DbContextOptions<tbluserconnect> options) : base(options)
        {


        }

        public DbSet<tbluserModel> Tbluser { get; set; }
    }
}
