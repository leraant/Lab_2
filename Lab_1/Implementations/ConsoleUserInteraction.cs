using Lab_1.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1.Implementations
{
	// Клас для взаємодії з користувачем через консоль
	public class ConsoleUserInteraction : IUserInteraction
	{
		// Метод для отримання числового вводу від користувача
		public double GetInput(string prompt)
		{
			Console.Write(prompt);
			while (true)
			{
				if (double.TryParse(Console.ReadLine(), out double result))
				{
					return result;
				}
				Console.WriteLine("Неправильний ввід. Будь ласка, введіть число.");
				Console.Write(prompt);  // повторний запит на введення
			}
		}

		// Метод для виведення результату або повідомлення
		public void ShowResult(string message)
		{
			Console.WriteLine(message);
		}

		// Метод для вибору арифметичної операції
		public string SelectOperation()
		{
			Console.WriteLine("Оберіть операцію:");
			Console.WriteLine("1. Додавання (+)");
			Console.WriteLine("2. Віднімання (-)");
			Console.WriteLine("3. Множення (*)");
			Console.WriteLine("4. Ділення (/)");
			Console.Write("Ваш вибір: ");

			string choice = Console.ReadLine();
			switch (choice)
			{
				case "1":
				case "+":
					return "Add";
				case "2":
				case "-":
					return "Subtract";
				case "3":
				case "*":
					return "Multiply";
				case "4":
				case "/":
					return "Divide";
				default:
					Console.WriteLine("Невірний вибір. Спробуйте ще раз.");
					return SelectOperation();  // повторити вибір
			}
		}
	}
}
