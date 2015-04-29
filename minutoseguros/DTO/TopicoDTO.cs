using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace minutoseguros.DTO
{
    public class TopicoDTO
    {

        public string Topico { get; set; }

        public IList<string> Palavras { get; set; }

        public IList<TinyTop10Palavras> Top10 { get; set; }

        public int TotalPalavras { get; set; }

    }
}
