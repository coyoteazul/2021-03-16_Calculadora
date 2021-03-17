using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validadores
{
    public class Val
    {
        static bool isnum(string str)
        {
            double cuack;
            return double.TryParse(str, out cuack);
        }
        static string getInput()
        {
            string input = Console.ReadLine();
            if (input == "x")
            {
                Environment.Exit(0);
                return "";
            }
            else
                return input;
        }
        public static double getDouble(string var_num)
        {
            string input;
            while (true)
            {
                Console.WriteLine("Ingrese la " + var_num + "° variable ");
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
        public static string getOperator()
        {
            string input;
            while (true)
            {
                Console.WriteLine("Ingrese un operador (+ - * /)");
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
    }
}
