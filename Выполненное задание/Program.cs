using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            Mnogo();
            Console.ReadKey();
        }
        static void Mnogo()
        {
            Console.WriteLine("Введите количество сторон у многоугольника");
            double n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите чему равен радиус многоугольника");
            double r = Convert.ToDouble(Console.ReadLine());
        
            if (n>=3)
            {
                if (r > 0)
                {

                    double perimitr = 2 * n * r * Math.Tan(Math.PI / n);
                    double ploshad = n * r * r * Math.Tan(Math.PI / n);
                    Console.WriteLine("Периметр данного многоугольника равен"+" "+perimitr);
                    Console.WriteLine("Площадь данного многоугольника равна" + " " +ploshad);
                }
                else
                {
                    Console.WriteLine("Радиус должен быть больше 0");
                }

            }
            else
            {
                Console.WriteLine("Вы ввели неверное количество сторон");
            }
            
        }
    }
}
