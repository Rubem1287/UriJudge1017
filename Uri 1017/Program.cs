using System;
using System.Globalization;

namespace Uri_1017
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b;
            double valor;

            

           

            Console.WriteLine();
            Console.Write("Digite o tempo gasto na viagem : ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Digite a velocidade média : ");
            b = int.Parse(Console.ReadLine());

             valor = (a * b) / 12.0;
            



            Console.WriteLine();
            Console.Write("Quantidade de litros necessário para realizar a viagem : "+valor.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
