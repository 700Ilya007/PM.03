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
   

        
        public void SaveArrayToFile(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (Fish fish in fishArray)
                {
                    writer.WriteLine(fish.FishType + "," + fish.Manufacturer + "," + fish.Price);
                }
            }
        }

        private class FishComparer : IComparer<Fish>
        {
            public int Compare(Fish x, Fish y)
            {
                int typeComparison = y.FishType.CompareTo(x.FishType);
                if (typeComparison != 0)
                {
                    return typeComparison;
                }
                else
                {
                    return y.Price.CompareTo(x.Price);
                }
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива рыб: ");
            int size = int.Parse(Console.ReadLine());

            FishControl fishControl = new FishControl(size);
            fishControl.FillArray();
          
            fishControl.SaveArrayToFile("fish_data.txt");

            Console.WriteLine("Данные о рыбе сохраняются в файл.");
            Console.ReadLine();
        }
    }
}

