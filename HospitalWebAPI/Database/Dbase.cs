using HospitalWebAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalWebAPI.Database
{
    public class Dbase : DbContext
    {
        public Dbase(DbContextOptions<Dbase> options) : base(options)
        {

        }

        public DbSet<Doctor> Doctor_Set { get; set; }
    }
}
