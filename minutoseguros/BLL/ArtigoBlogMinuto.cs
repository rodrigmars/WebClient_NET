using minutoseguros.DTO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace minutoseguros.BLL
{
    public class ArtigoBlogMinuto
    {

        public ArtigoBlogMinuto() { }

        /// <summary>
        /// Serializa artigo xml para objeto ArtigoDTO
        /// </summary>
        /// <returns>list ArtigoDTO</returns>
        public IList<ArtigoDTO> GetArtigos()
        {
            var wc = WebClientMinutoSeguro.HttpGetBlog();

            var xdoc = XDocument.Parse(wc);

            var listArtigos = (from itens in xdoc.Descendants("item")
                               select new ArtigoDTO(itens)).ToList();

            return listArtigos;
        }

        /// <summary>
        /// Avalia as dez principais palavras por tópico
        /// </summary>
        /// <param name="listPalavras"></param>
        /// <returns></returns>
        public IEnumerable<TinyTop10Palavras> GetTop10(IList<string> listPalavras)
        {
            var duplicidade = listPalavras.GroupBy(i => i).
                    Where(g => g.Count() > 1).Select
                    (g => new TinyTop10Palavras
                    {
                        Palavra = g.Key,
                        TotalOcorrencias = g.Count()
                    }).OrderByDescending(o => o.TotalOcorrencias).ToList().Take(10);

            return duplicidade;
        }

    }
}
