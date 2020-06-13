using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfoAPI.Models
{
    public class PointOfInterestDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //public int NumberOfPointsOfInterest
        //{
        //    get
        //    {
        //        return PointOfInterest.Count;
        //    }        
        //}

        ////kreiranje kolekcije
        //public ICollection<PointOfInterestDto> PointOfInterest { get; set; }
        //    = new List<PointOfInterestDto>();
    }
}
