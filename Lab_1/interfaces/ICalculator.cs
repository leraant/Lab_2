using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1.interfaces
{
	// Інтерфейс, що описує основні арифметичні операції калькулятора.
	public interface ICalculator
	{
		double Add(double a, double b);
		double Subtract(double a, double b);
		double Multiply(double a, double b);
		double Divide(double a, double b);
	}
}
