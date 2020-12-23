using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            int c = 0;
            String oper;
            Console.Write("Введите первое число: ");
            String str = Console.ReadLine();
            a = Convert.ToInt32(str);
            Console.Write("Введите второе число: ");
            str = Console.ReadLine();
            b = Convert.ToInt32(str);
            Console.Write("Выберите операцию(+,-,*,/,%,&,|,^,<<,>>,~) - ");
            str = Console.ReadLine();
            oper = str;
            switch (oper)
            {
                case "+":
                    c = a + b;
                    break;
                case "-":
                    c = a - b;
                    break;
                case "*":
                    c = a * b;
                    break;
                case "/":
                    c = a / b;
                    break;
                case "%":
                    c = a % b;
                    break;
                case "&":
                    c = a & b;
                    break;
                case "|":
                    c = a | b;
                    break;
                case "^":
                    c = a ^ b;
                    break;
                case "<<":
                    c = a << b;
                    break;
                case ">>":
                    c = a >> b;
                    break;
                case "~":
                    c = ~b;
                    break;
                default:
                    Console.Write("Ошибка");
                    break;
            }
            if (oper == "~")
            {
                a = ~a;
                b = ~b;
                Console.WriteLine("~a = " + a + " ~b = " + b);
            }
            else
            {
                Console.WriteLine("a " + oper + " b = " + c);
            }
            Console.ReadKey();
        }    
    }
}
