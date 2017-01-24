using System.Collections.Generic;
using System.Collections.Specialized;

namespace Task01_CarLibrary.Data
{
    public static class CarsData
    {
        public static readonly List<Producer> Producers = new List<Producer>()
        {
            new Producer()
            {
                Name = "BMW",
                Models = new List<string>()
                {
                    "116", "118", "120", "318", "320", "518", "520", "750iLi", "X1", "X3", "X5", "X6"
                }
            },
            new Producer()
            {
                Name = "Audi",
                Models = new List<string>()
                {
                    "A1", "A2", "A3", "A4", "A5", "A8", "S1", "S5", "S8", "Q1", "Q3", "Q7"
                }
            }
        };

        public static readonly List<Extra> Extras = new List<Extra>()
        {
            new Extra() {Id = 1, Name = "Bluetooth"},
            new Extra() {Id = 2, Name = "Board computer"},
            new Extra() {Id = 3, Name = "CD player"},
            new Extra() {Id = 4, Name = "Electr. Seat adjustment"},
            new Extra() {Id = 5, Name = "Head-Up Display"},
            new Extra() {Id = 6, Name = "Navigation System"},
            new Extra() {Id = 7, Name = "Ski bag"},
            new Extra() {Id = 8, Name = "Heated seats"},
            new Extra() {Id = 9, Name = "Cruise control"},
            new Extra() {Id = 10, Name = "Start / stop system"}
        };

        public static readonly List<string> EngineType = new List<string>()
        {
            "Petrol",
            "Diesel",
            "Electric"
        };
    }
}