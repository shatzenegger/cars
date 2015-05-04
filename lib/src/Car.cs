using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.shatzenegger.cars.lib
{
    class Vehicle
    {
        /*
         * Model - object
         * Year - int
         * Color - enum
         * Engine - object
         * Number of Doors - int
         * Number of Tires - int
         * Convertible
         * Height - double
         * Width- double
         * Depth - double
         * Weight - double
         * Seats - array
         */

        public int Id { get; set; }
        public enum Model { Focus, Fiesta, Fusion, Mustang, Cmax, Taurus, Explorer, F150 }
        public int Year { get; set; }
        public enum Color { Black, Red, Blue, Silver, Yellow, Orange, White  }
        public void Engine { get; set; }
        public int Number_of_Doors { get; set; }
        public int Number_of_Tires { get; set; }
        public bool Convertible { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Weight { get; set; } 
        public void Seats { get; set; } 
        public enum Transmission { Automatic, Manual }

    }

    

    class Engine
    {
        public int Cylinders { get; set; }
        public int Horse_Power { get; set; }
    }

    class Seats
    {
        public int number_of_seats { get; set; }
        public enum seat_style { Captain, Bucket, Bench, Saddle }
    }
}
