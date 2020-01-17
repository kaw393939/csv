using System;
using Models;
using Cities;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class CityEntity : CityModel
    {
        [Key]
        public int CityID { get; set; }

        public virtual CountryEntity Country { get; set; }
    }
}
