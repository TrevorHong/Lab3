using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommunityApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CommunityApp.Data
{
    public static class SeedData
    {
        public static void Seed(this ModelBuilder modelBuilder) {
            modelBuilder.Entity<City>().HasData(
                GetCities()
            );
            modelBuilder.Entity<Province>().HasData(
                GetProvince()
            );
        }

        public static List<Province> GetProvince() {
            List<Province> provinces = new List<Province>() {
                new Province() {
                    ProvinceCode = "BC",
                    ProvinceName = "British Columbia",
                    Population = 4648055
                },
                new Province() {
                    ProvinceCode = "AB",
                    ProvinceName = "Alberta",
                    Population = 4067175
                },
                new Province() {
                    ProvinceCode = "SK",
                    ProvinceName = "Saskatchewan",
                    Population = 1098352
                }
            };
            return provinces;
        }

        public static List<City> GetCities() {
            List<City> cities = new List<City>() {
                new City() {
                    CityId = 1,
                    CityName = "Vancouver",
                    Population = 675218,
                    ProvinceCode = "BC"
                },
                new City() {
                    CityId = 2,
                    CityName = "Victoria",
                    Population = 344615,
                    ProvinceCode = "BC"
                },
                new City() {
                    CityId = 3,
                    CityName = "Kelowna",
                    Population = 142146,
                    ProvinceCode = "BC"
                },
                new City() {
                    CityId = 4,
                    CityName = "Calgary",
                    Population = 1237656,
                    ProvinceCode = "AB"
                },
                new City() {
                    CityId = 5,
                    CityName = "Edmonton",
                    Population = 981280,
                    ProvinceCode = "AB"
                },
                new City() {
                    CityId = 6,
                    CityName = "Red Deer",
                    Population = 103588,
                    ProvinceCode = "AB"
                },
                new City() {
                    CityId = 7,
                    CityName = "Saskatoon",
                    Population = 246376,
                    ProvinceCode = "SK"
                },
                new City() {
                    CityId = 8,
                    CityName = "Regina",
                    Population = 215106,
                    ProvinceCode = "SK"
                },
                new City() {
                    CityId = 9,
                    CityName = "Prince Albert",
                    Population = 35802,
                    ProvinceCode = "SK"
                }
            };
            return cities;
        }
    }
}