using CityInfoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfoAPI
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();

        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            //init dummy data
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id=1,
                    Name="Imotski",
                    Description="Grad na gori, sa sedam bisera, sedam jezera.",
                    PointsOfInterest= new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Crveno jezero, Modro jezero, Galipovac, Mamića jezero, Knezovića jezero, Prološko blato i Zeleno jezero",
                            Description= "Morate posjetiti te prirodne ljepote."},
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Restorani, kula Topana, biciklističke staze, off road Quads",
                            Description= "Morate probati."},
                    }
                },

                new CityDto()
                {
                    Id=2,
                    Name="Zagreb",
                    Description="Jarun, Bundek, Sljeme, Festivali i mnogo drugih sadržaja.",
                    PointsOfInterest= new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 3,
                            Name = "Sljeme, Bundek, Jarun",
                            Description= "Mjesta za rekreaciju i opuštanje sa obitelji."},
                        new PointOfInterestDto()
                        {
                            Id = 4,
                            Name = "HNK, Zagrebačka katedrala, koncerti, kino Tuškanac, festivali",
                            Description= "Spoj arhitekture za posjetiti i mjesta za zabavu i  kina na otvorenom."},
                    }
                },

                new CityDto()
                {
                    Id=3,
                    Name="Split",
                    Description="Šetnje Marjanom, kupanje na Baćama.",
                    PointsOfInterest= new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 5,
                            Name = "Marjan, Bačvice",
                            Description= "Šetnje i kupanje."},
                        new PointOfInterestDto()
                        {
                            Id = 6,
                            Name = "Dioklecianova palača, riva",
                            Description= "Mjesta koja se moraju vidjeti i sjesti."},
                    }
                }
            };
        }

    }
}
