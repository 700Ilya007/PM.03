﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{

    public class Fish
    {
        public string FishType { get; set; }
        public string Manufacturer { get; set; }
        public string Price { get; set; }

       
        public Fish(string fishType, string manufacturer, string price)
        {
            FishType = fishType;
            Manufacturer = manufacturer;
            Price = price;
        }
    }

    public class FishControl
    {
     
        private Fish[] fishArray;

        public FishControl(int size)
        {
            fishArray = new Fish[size];
        }

    }
}