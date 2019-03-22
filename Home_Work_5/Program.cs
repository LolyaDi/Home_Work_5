using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace Home_Work_5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                WriteLine("Введите первое число: ");
                double firstNumber = double.Parse(ReadLine());

                WriteLine("Введите второе число: ");
                double secondNumber = double.Parse(ReadLine());

                if (secondNumber == 0)
                {
                    throw new ArgumentException("Делитель равен нулю!");
                }

                double result = firstNumber / secondNumber;
                WriteLine($"Деление числа {firstNumber} на число {secondNumber} = {result}");
            }

            catch (ArgumentNullException exception)
            {
                WriteLine(exception.Message);
            }

            catch (ArgumentException exception)
            {
                WriteLine(exception.Message);
            }

            catch (FormatException exception)
            {
                WriteLine(exception.Message);
            }



            WriteLine("-------------------------------------------------------------");

            const int FIVE = 5;
            int[] array = new int[FIVE];
            Random random = new Random();

            try
            {
                for (int i = 0; i <= array.Length; i++)
                {
                    array[i] = random.Next(array.Length);
                }
            }

            catch (IndexOutOfRangeException exception)
            {
                WriteLine(exception.Message);
            }

            finally
            {
                WriteLine("Завершение обработки массива!");
            }
            ReadKey();
        }

    }
}
