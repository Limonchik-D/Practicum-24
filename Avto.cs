using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum_24
{
    internal class Avto
    {
        string brand;
        string color;
        double skor;

        public double Skor
        {
            get { return skor; }
            set
            {

                if (value < 20)
                {
                    skor = 20;
                }
                else if (value > 120)
                {
                    skor = 120;
                }
                else
                {
                    skor = value;
                }
            }
        }
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }


        public Avto() //Без параметров
        {
            brand = "BMW";
            color = "red";
            skor = 90;
        }
        public Avto(string brand, string color, double skor) // C параметрами
        {
            this.Brand = brand;
            this.Color = color;
            this.Skor = skor;
        }

        public string Color //Свойство для цвета автомобиля
        {
            get { return color; }
            set { color = value; }
        }
        public override string ToString()
        {
            return $"Марка: {brand}, Цвет: {color}, Скорость: {skor} км/ч";
        }
    }
}

