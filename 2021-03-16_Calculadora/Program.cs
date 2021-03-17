using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sumador;
using Product;

namespace _2021_03_16_Calculadora
{
    class Program
    {
        static bool isnum(string str)
        {
            double cuack;
            return double.TryParse(str, out cuack);
        }
        static string getInput()
        {
            string input = Console.ReadLine();
            if (input == "x") { 
                Environment.Exit(0);
                return "";
            }
            else
                return input;
        }
        static double getDouble(string var_num)
        {
            string input;
            while (true)
            {
                Console.WriteLine("Ingrese la "+ var_num+ "° variable ");
                input = getInput();
                if (isnum(input))
                {
                    return double.Parse(input);
                }
                else
                {
                    Console.WriteLine("Debes ingresar un numero");
                }
            }
        }
        static string getOperator()
        {
            string input;
            while (true)
            {
                Console.WriteLine("Ingrese un operador (+ - * %)");
                input = getInput();
                if (input == "+" ||
                    input == "-" ||
                    input == "*" ||
                    input == "/" )
                {
                    return input;
                }
                else
                {
                    Console.WriteLine("No es un operador valido");
                }
            }
        }
        static void Main(string[] args)
        {
            
            while (true)
            {
                double var1, var2;
                string operador;

                var1 = getDouble("1");
                var2 = getDouble("2");
                operador = getOperator();
                
                switch (operador)
                {
                    case "+": 
                        Console.WriteLine("Resultado: "+ Sumador.Sumador.sum_(var1, var2));
                        break;
                    case "-": 
                        Console.WriteLine("Resultado: " + Sumador.Sumador.sum_(var1, -var2));
                        break;
                    case "*": 
                        Console.WriteLine("Resultado: " + Product.Product.product(var1, var2));
                        break;
                    case "/": 
                        Console.WriteLine("Resultado: " + Product.Product.product(var1, 1/var2));
                        break;
                }
            };
        }

        
    }
}
