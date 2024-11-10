using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_1.Implementations;
using Lab_1.interfaces;
using Lab_1;

namespace Lab_1
{
	// Клас, що керує основною логікою програми, взаємодіє з калькулятором, користувачем і вибором операцій.
	public class CalculatorApp
	{
		private ICalculator _calculator;
		private IUserInteraction _userInteraction;
		public CalculatorApp(ICalculator calculator, IUserInteraction userInteraction)
		{
			_calculator = calculator;
			_userInteraction = userInteraction;
		}
		// Основний метод для запуску програми
		public void Run()
		{
			while (true)
			{
				// Отримуємо числа від користувача
				double a = _userInteraction.GetInput("Введiть перше число: ");
				double b = _userInteraction.GetInput("Введiть друге число: ");

				// Обираємо операцію
				string operation = _userInteraction.SelectOperation();

				try
				{
					// Виконуємо обрану операцію та виводимо результат
					double result = operation switch
					{
						"Add" => _calculator.Add(a, b),
						"Subtract" => _calculator.Subtract(a, b),
						"Multiply" => _calculator.Multiply(a, b),
						"Divide" => _calculator.Divide(a, b),
						_ => throw new InvalidOperationException("Невiдома операцiя")
					};
					_userInteraction.ShowResult($"Результат: {result}");
				}
				catch (DivideByZeroException ex)
				{
					_userInteraction.ShowResult($"Помилка: {ex.Message}");
				}
				catch (InvalidOperationException ex)
				{
					_userInteraction.ShowResult($"Помилка: {ex.Message}");
				}


				// Запитати у користувача, чи хоче він продовжити
				Console.Write("Бажаєте продовжити? (y/n): ");
				string continueChoice = Console.ReadLine().ToLower();
				if (continueChoice != "y")
				{
					break;
				}
			}
		}
	}
}
