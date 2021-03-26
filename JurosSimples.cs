using System;

namespace Juros
{

    public class Program 
    {
        public static void Main(string [] args)
        {
			double Capital;
			double Taxa;
			double Tempo;
			double Juros;
			double Montante;
			
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("Cálculo de Juros");
			Console.WriteLine();
			Console.ResetColor();
			
			Console.Write("Insira o valor (R$): ");
			Capital = Convert.ToDouble(Console.ReadLine());
			
			Console.Write("Insira a taxa de juros (%): ");
			Taxa = Convert.ToDouble(Console.ReadLine());
			
			Console.Write("Insira o tempo (meses): ");
			Tempo = Convert.ToDouble(Console.ReadLine());
			
			Console.WriteLine();
			Juros = Capital * Taxa / 100 * Tempo;
			Console.WriteLine($"Juros R${Juros:N2}");
			
			Montante = Capital + Juros;
			Console.WriteLine($"Montante R${Montante:N2}");
        }
    }
}