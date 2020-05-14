using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks;

namespace Test11
{
    class Program
    {
        static double f(double X)
        {
            return 3 * Math.Pow(X, 3) - 2 * Math.Pow(X, 2);         
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding(866);             
            Console.InputEncoding = Encoding.GetEncoding(866);
            double A;             
            double B;             
            double U=0;             
            char H;
            Console.Write("Введите первое число:");             
            A = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nВведите оператор:");             
            H = Convert.ToChar(Console.ReadLine());
            Console.Write("\nВведите второе число:");             
            B = Convert.ToDouble(Console.ReadLine());
            if (H == '+')
            {
                U = A + B;             
            }
            else if (H == '-')
            {
                U = A - B;
            }
            else if (H == '*')
            {
                U = A * B;            
            }
            else if (H == '/')
            {
                if (B != 0)                     
                U = A / B;                 
                else Console.WriteLine("На 0 делить нельзя!");
            }             
            else
            {
                Console.WriteLine("Неизвестный оператор.");
            }
            Console.WriteLine("\nРезультат: {0}", U);
            Console.ReadLine();
        }
    }
}