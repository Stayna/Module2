using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            double c;
            string oper;
            Program calculation = new Program();
            Console.WriteLine("Введите первое значение");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите опертатор");
            oper = Console.ReadLine(); ;
            Console.WriteLine("Введите второе значение");
            b = Convert.ToDouble(Console.ReadLine());
            
            switch (oper)
            {
                case "+": c = a + b;
                    Console.WriteLine(c);
                    break;
                case "-": c = (a - b);
                    Console.WriteLine(c);
                    break;
                case "*": c = (a * b); 
                    Console.WriteLine(c);
                    break;
                case "/": c = (a / b); 
                    Console.WriteLine(c);
                    break;
            }
            Console.ReadLine();          
        }
    }
}
