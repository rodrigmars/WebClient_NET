using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace minutoseguros.Util
{
    public class Utilidades
    {

        public static string FormataTexto(string textoHTML)
        {
            var texto = RemoveTags(textoHTML);

            return RemoveCaracteres(texto);
        }

        public static string RemoveTags(string texto)
        {
            return Regex.Replace(texto, @"<[^>]*>", String.Empty);
        }

        public static string RemoveCaracteres(string texto)
        {
            string pattern = @"(?i)[^a-záéíóúàèìòùâêîôûãõç\s]";
            return Regex.Replace(texto, pattern, string.Empty).Replace("\n", " ");
        }

        public static string[] SplitTexto(string texto)
        {
            return texto.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }

    }
}
