using minutoseguros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleMinutoSeguros
{
    public class Exercicio
    {

        /// <summary>
        /// Executa exercício e disponibiliza resultado final via console
        /// </summary>
        public static void ExercicioMinutoSeguros()
        {
            var programa = new ProgramaPrincipal();

            var topicos = programa.AvaliaTop10Palavras();

            var count_topics = 1;
            
            var count_words = 1;

            foreach (var item in topicos)
            {

                Console.WriteLine("Tópico - {0}: {1}", (count_topics++), item.Topico + Environment.NewLine);

                Console.WriteLine(string.Format("{0, 11}{1, 27}", "Palavras", "Ocorrências"));

                item.Top10.ToList().ForEach(t =>
                {
                    Console.WriteLine(string.Format("{0, -25} {1}", (count_words++).ToString().PadLeft(2, '0') + "-" + t.Palavra, " - " + t.TotalOcorrencias + "x"));
                });

                count_words = 1;

                Console.WriteLine(Environment.NewLine + "Total " + item.TotalPalavras + " palavras" + Environment.NewLine);

                Console.WriteLine(" ======================================================= " + Environment.NewLine);
            }
        }

        /// <summary>
        /// Informa cabeçalho contendo as informações necessárias sobre o escopo do exercício
        /// </summary>
        public static void Header()
        {
            Write(15, ConsoleColor.White, "= EXERCÍCIO DE PROGRAMAÇÃO: AS PRINCIPAIS PALAVRAS =" + Environment.NewLine);
            Write(15, ConsoleColor.White, "=====================================================");
            Write(15, ConsoleColor.Yellow, string.Format("{0, -53}", "Candidato: Rodrigo Martins Silva"));
            Write(15, ConsoleColor.Yellow, string.Format("{0, -53}", "Desenvolvedor C#"));
            Write(15, ConsoleColor.White, string.Format("{0, -53}", " "));
            Write(15, ConsoleColor.White, string.Format("{0, -53}", " "));
            Write(15, ConsoleColor.Yellow, string.Format("{0, -53}", "Exercícios proposto."));
            Write(15, ConsoleColor.White, string.Format("{0, -53}", " "));
            Write(15, ConsoleColor.White, string.Format("{0, -53}", ">> Informar as dez principais palavras abordadas."));
            Write(15, ConsoleColor.White, string.Format("{0, -53}", ">> Informar o número de vezes que elas aparecem."));
            Write(15, ConsoleColor.White, string.Format("{0, -53}", ">> Informar a quantidade de palavras por tópico."));
            Write(15, ConsoleColor.White, string.Format("{0, -53}", ">> Remover os artigos e preposições nessa análise."));
            Write(15, ConsoleColor.White, "=====================================================");
        }

        /// <summary>
        /// Posiciona e altera cor de texto no console.
        /// </summary>
        /// <param name="left"></param>
        /// <param name="color"></param>
        /// <param name="texto"></param>
        public static void Write(int left, ConsoleColor color, string texto)
        {
            Console.CursorLeft = left;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = color;
            Console.WriteLine(texto);
        }
    }
}
