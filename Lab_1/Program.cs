using Lab_1.Implementations;
using Lab_1.interfaces;
using Lab_1;

internal class Program
{
	private static void Main(string[] args)
	{
		// Створюємо об'єкти калькулятора та взаємодії з користувачем
		ICalculator calculator = new Calculator();
		IUserInteraction userInteraction = new ConsoleUserInteraction();

		// Створюємо додаток і запускаємо його
		CalculatorApp app = new CalculatorApp(calculator, userInteraction);
		app.Run();
	}
}