using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sumador;
using Product;
using Validadores;

namespace _2021_03_16_Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double var1, var2;
                string operador;

                var1 = Val.getDouble("1");
                var2 = Val.getDouble("2");
                operador = Val.getOperator();
                
                switch (operador)
                {
                    case "+": 
                        Console.WriteLine("Resultado: " + Sum.sum_(var1, var2) + "\n");
                        break;
                    case "-": 
                        Console.WriteLine("Resultado: " + Sum.sum_(var1, -var2) + "\n");
                        break;
                    case "*": 
                        Console.WriteLine("Resultado: " + Prod.product(var1, var2) + "\n");
                        break;
                    case "/": 
                        Console.WriteLine("Resultado: " + Prod.product(var1, 1/var2) + "\n");
                        break;
                }
            };
        }

        
    }
}
