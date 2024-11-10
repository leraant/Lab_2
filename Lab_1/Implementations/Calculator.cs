using Lab_1.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1.Implementations
{
	// Клас, що реалізує інтерфейс ICalculator і виконує арифметичні операції.
	public class Calculator : ICalculator
	{
		// Метод для додавання двох чисел 1
		public double Add(double a, double b)
		{
			return a + b;
		}

		// Метод для віднімання одного числа від іншого
		public double Subtract(double a, double b)
		{
			return a - b;
		}

		// Метод для множення двох чисел
		public double Multiply(double a, double b)
		{
			return a * b;
		}

		// Метод для ділення одного числа на інше з перевіркою ділення на нуль
		public double Divide(double a, double b)
		{
			if (b == 0)
			{
				throw new DivideByZeroException("Дiлення на нуль неможливе.");
			}
			return a / b;
		}
	}
}
