﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class CarLot // class
    {
        public static int numberOfCars { get; set; }

        public CarLot() // constructor
        {
            
        }

        public List<Car> listOfCars = new List<Car>();

    }
}
