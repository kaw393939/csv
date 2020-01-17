using System;
using Entities;
using System.Collections.Generic;
using System.Text;

namespace Context
{
   
    public class CitiesContext : DbContext
    {
        public DbSet<CountryEntity> Countries { get; set; }
        public DbSet<CityEntity> Cities { get; set; }
    }
}
