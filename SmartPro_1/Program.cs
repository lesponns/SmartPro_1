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
            //Değişken kayıt
            double Weight, Height, bmi;

            //Kullanıcıdan Kilo değeri alma
            Console.WriteLine("What is your weight?");
            Console.Write("Weight: ");
            Weight= double.Parse(Console.ReadLine());
            Console.Clear();

            //Kullanıcıdan boy değeri alma
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
