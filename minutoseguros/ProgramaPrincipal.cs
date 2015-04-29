using minutoseguros.BLL;
using minutoseguros.DTO;
using minutoseguros.Util;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace minutoseguros
{
    public class ProgramaPrincipal
    {
        public ProgramaPrincipal() { }

        /// <summary>
        /// Cria contexto de TopicoDTO contendo o resultato final para as dez principais palavras abordadas
        /// </summary>
        /// <returns>IList<TopicoDTO></returns>
        public IList<TopicoDTO> AvaliaTop10Palavras()
        {
            var gramatical = new Gramatical();

            var obj = new ArtigoBlogMinuto();

            var artigos = obj.GetArtigos();

            var topicos = new List<TopicoDTO>();

            foreach (var item in artigos)
            {
                var palavras = gramatical.GetPalavras(item.Content);

                var top10 = obj.GetTop10(palavras);

                topicos.Add(new TopicoDTO
                {
                    Topico = item.Title,
                    Palavras = palavras,
                    Top10 = top10.ToList(),
                    TotalPalavras = palavras.Count()
                });
            }

            return topicos;
        }
    }
}
