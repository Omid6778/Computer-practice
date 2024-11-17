using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace امید_مریخی_پروژه_سوم
{
            using System;

class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine(" عدد اول را وارد کنید:");
                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine(" عدد دوم را وارد کنید:");
                int num2 = int.Parse(Console.ReadLine());

                Console.WriteLine(" عدد سوم را وارد کنید:");
                int num3 = int.Parse(Console.ReadLine());

               
                int[] numbers = { num1, num2, num3 };

              
                Array.Sort(numbers);
                Array.Reverse(numbers);

            
                Console.WriteLine("اعداد مرتب شده از بزرگ به کوچک:");
                foreach (int number in numbers)
                {
                    Console.WriteLine(number);
                }
            Console.ReadKey();
            }
        }

    }

