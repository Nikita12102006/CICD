using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CICD
{

    public class Class1
    {
        //Факториал числа
        public static double Factorial(double x)
        {
            try
            {
                if (x < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(x), "Значение должно быть неотрицательным.");
                }

                if (x == 0 || x == 1)
                {
                    return 1;
                }

                return x * Factorial(x - 1);
            }
            catch (StackOverflowException)
            {
                Console.WriteLine("Ошибка: Переполнение стека при вычислении факториала.");
                throw;
            }
        }
        //Проверка числа на простое и сложное
        public static bool IsProst(double x)
        {
            try
            {
                if (x <= 1)
                {
                    return false;
                }

                for (int i = 2; i <= Math.Sqrt(x); i++)
                {
                    if (x % i == 0)
                    {
                        return false;
                    }
                }

                return true;
            }
            catch (ArgumentOutOfRangeException) when (x < 0)
            {
                Console.WriteLine($"Ошибка: Нельзя проверять отрицательное число {x} на простоту.");
                throw;
            }
        }
        //Арифметическая прогрессия
        public static double ArithmeticProgressiv(int n, double a1, double d)
        {
            try
            {
                if (d == 0 && n != 1)
                {
                    throw new DivideByZeroException("Невозможно выполнить операцию, когда разность равна нулю.");
                }

                return a1 + d * (n - 1);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ошибка: Попытка деления на ноль в арифметической прогрессии.");
                throw;
            }
        }
    }
}

