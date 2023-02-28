using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW05_03_23_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 1
            /*Console.Write("Введите число (1 - 100): ");
            int number = int.Parse(Console.ReadLine());

            if (number < 1 || number > 100)
            {
                Console.WriteLine($"!Введённое число не входит в диапазон ({number})");
            }
            else
            {
                if (number % 3 == 0 && number % 5 == 0)
                    Console.WriteLine("Fizz Buzz");
                else if (number % 3 == 0)
                    Console.WriteLine("Fizz");
                else if (number % 5 == 0)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(number);
            }*/
            #endregion

            #region 2
            /*Console.Write("Введите число: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Введите процент от числа: ");
            double discount = double.Parse(Console.ReadLine());

            double result = (discount / 100) * (double)num;
            Console.WriteLine($"{discount}% от {num} состовляет {result}");*/
            #endregion

            #region 3
            /*string tempStr = "";

            for (int i = 1; i <= 4; ++i)
            {
                Console.Write($"Введите {i}ю цифру: ");
                tempStr += Console.ReadLine();
            }

            int resultNumber = int.Parse(tempStr);
            Console.WriteLine($"Получившееся число: {resultNumber}");*/
            #endregion

            #region 4
            /*Console.Write("Введите шестизначное число: ");
            int number = int.Parse(Console.ReadLine());

            if (number < 100000 || number > 999999)
            {
                Console.WriteLine("Введено не шестизначное число.");
                return;
            }

            Console.Write("Введите первый разряд: ");
            int index1 = int.Parse(Console.ReadLine());
            Console.Write("Введите второй разряд: ");
            int index2 = int.Parse(Console.ReadLine());

            int digit1 = (number / (int)Math.Pow(10, index1 - 1)) % 10;
            int digit2 = (number / (int)Math.Pow(10, index2 - 1)) % 10;

            number -= digit1 * (int)Math.Pow(10, index1 - 1);
            number -= digit2 * (int)Math.Pow(10, index2 - 1);

            number += digit1 * (int)Math.Pow(10, index2 - 1);
            number += digit2 * (int)Math.Pow(10, index1 - 1);

            Console.WriteLine($"Результат: {number}");*/
            #endregion

            #region 5
            /*Console.WriteLine("Введите дату в формате: --.--.----");
            DateTime date = DateTime.Parse(Console.ReadLine());
            int month = date.Month;
            string season;
            string dayOfWeek = Convert.ToString(date.DayOfWeek);
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    season = "Winter";
                    break;
                case 3:
                case 4:
                case 5:
                    season = "Spring";
                    break;
                case 6:
                case 7:
                case 8:
                    season = "Summer";
                    break;
                case 9:
                case 10:
                case 11:
                    season = "Autumn";
                    break;
                default:
                    season = "Fall";
                    break;
            }
            Console.WriteLine($"{season} {dayOfWeek}");*/
            #endregion

            #region 6            
            /*Console.WriteLine("Выберите способ перевода температуры.\nИз Фаренгейта в цельсии - 1\nИз цельсий в Фаренгейты - 2");
            int userAnswer = int.Parse(Console.ReadLine());            
            if (userAnswer < 1 || userAnswer > 2) Console.WriteLine("Неккоректное число\n");
            else if(userAnswer == 1)
            {
                Console.WriteLine("Введите температуру в Фаренгейтах");
                double F = double.Parse(Console.ReadLine());
                Console.WriteLine($"{F}F = {Math.Round(((F - 32) / 1.8), 2)}C");
            }
            else if(userAnswer == 2)
            {
                Console.WriteLine("Введите температуру в цельсиях");
                double C = double.Parse(Console.ReadLine());
                Console.WriteLine($"{C}C = {Math.Round(((C * 1.8) + 32), 2)}F");
            }*/
            #endregion

            #region 7
            /*Console.Write("Введите начало диапазона: ");
            int rangeStart = int.Parse(Console.ReadLine());
            Console.Write("Введите конец диапазона: ");
            int rangeEnd = int.Parse(Console.ReadLine());

            if (rangeEnd < rangeStart)
            {
                int temp = rangeStart;
                rangeStart = rangeEnd;
                rangeEnd = temp;
            }

            Console.Write($"Все чётные числа в диапазоне от {rangeStart} до {rangeEnd}: ");
            for (int diget = rangeStart; diget <= rangeEnd; ++diget)
                if (diget % 2 == 0) Console.Write($"{diget} ");
            Console.WriteLine();*/
            #endregion

        }
    }    
}
