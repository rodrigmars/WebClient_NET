using minutoseguros;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace ConsoleMinutoSeguros
{
    public class ConsoleUI : Exercicio
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.CursorTop = 5;

                Header();

                Console.SetCursorPosition(15, 20);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine("Iniciar ENTER ...");

                Console.ReadLine();

                Console.CursorTop = 25;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;

                ExercicioMinutoSeguros();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
