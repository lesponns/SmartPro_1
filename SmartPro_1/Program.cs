using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPro_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Değişkenler
            double Weight, Height, bmi;

            //Kullanıcının Ağırlık Bilgisi
            Console.WriteLine("What is your weight?");
            Console.Write("Weight: ");
            Weight= double.Parse(Console.ReadLine());
            Console.Clear();

            //Kullanıcının Uzunluk Bilgisi
            Console.WriteLine("What is your height?");
            Console.Write("Height: ");
            Height = double.Parse(Console.ReadLine());
            Console.Clear();

            //VKI hesaplama vki = kg / metre*metre
            bmi = Weight / (Height * Height);

            Console.WriteLine("Your body mass index: " + bmi);
            Console.ReadKey();
        }
    }
}
