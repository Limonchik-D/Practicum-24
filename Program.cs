using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Avto avto = new Avto();
            avto.Brand = "BMW";
            avto.Color = "Red";
            avto.Skor = 90;
            Console.WriteLine(avto.ToString());
            Console.WriteLine();

            Avto avto1 = new Avto("Bmw", "Red", 80);
            Console.WriteLine(avto1);
            Console.WriteLine();

            Console.WriteLine("Введите марку машины: ");
            string brend = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите цвет: ");
            string color = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Введите скорость: ");
            double skor = Convert.ToDouble(Console.ReadLine());

            Avto avto2 = new Avto(brend, color, skor);
            Console.WriteLine(avto2);

            Console.ReadLine();

        }
    }
}
