using System;
using System.Collections.Generic;
using System.Text;

namespace nb.VehicleLibrary1
{
    public class Vehicle
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

        public string GetFullName()
        {
            return $"{Year} {Make} {Model}";

        }
    }
}
