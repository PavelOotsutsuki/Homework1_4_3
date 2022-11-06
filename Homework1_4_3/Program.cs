using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = ReadInt();
            Console.WriteLine("number: " + number);
            Console.Write("Для продолжения нажмите любую кнопку...");
            Console.ReadKey();
        }

        static int ReadInt()
        {
            bool isConvert = false;
            int number=0;
            Console.Write("Введите число: ");

            while (isConvert == false)
            {
                string numberString = Console.ReadLine();
                Console.WriteLine();
                isConvert = int.TryParse(numberString, out number);

                if (isConvert==false)
                {
                    Console.Write("Это не число. Попробуйте заного: ");
                }
            }

            return number;
        }
    }
}