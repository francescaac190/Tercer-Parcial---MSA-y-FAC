using CovidInfectadosOficial.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidInfectadosOficial.Data
{
    public class CovidDbContext : DbContext
    {
        public CovidDbContext(DbContextOptions<CovidDbContext>options) :base(options)
        {

        }

        public DbSet<Person> People { get; set; }
    }
}
