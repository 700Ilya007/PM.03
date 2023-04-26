using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exam
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


        public void FillArray()
        {
            for (int i = 0; i < fishArray.Length; i++)
            {
                Console.WriteLine("Введите данные о рыбе #" + (i + 1));
                Console.Write("Вид рыбы: ");
                string fishType = Console.ReadLine();
                Console.Write("Производитель: ");
                string manufacturer = Console.ReadLine();
                Console.Write("Цена: ");
                string price = Console.ReadLine();

                fishArray[i] = new Fish(fishType, manufacturer, price);
            }
        }

    }
}