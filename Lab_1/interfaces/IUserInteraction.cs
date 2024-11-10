using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1.interfaces
{
	// Інтерфейс для взаємодії з користувачем
	public interface IUserInteraction
	{
		double GetInput(string prompt);   // Метод для отримання числового вводу від користувача
		void ShowResult(string message);  // Метод для виведення результату або повідомлення
		string SelectOperation();         // Метод для вибору арифметичної операції
	}
}
