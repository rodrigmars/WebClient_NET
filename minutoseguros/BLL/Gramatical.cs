using minutoseguros.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace minutoseguros.BLL
{
    public class Gramatical
    {
        private List<string> listArtPrepo;

        public List<string> ListArtPrepo
        {
            get
            {
                if (listArtPrepo == null)
                {
                    listArtPrepo = new List<string>{                            
        
                        "o", "a", "ao", "à", "às", "as", "os", "aos", 
                        "um", "uma", "uns", "umas", "num", "numa", "nuns", "numas", "dum", "duma", "duns", "dumas", 
                        "da", "de", "do", "dos", "das", "desde", "durante", "depois", 
                        "em", "no", "na", "nos", "nas", 
                        "per", "por", "para", "pelo", "pela", "pelos", "pelas", "perante", 
                        "até", "após", "ante", "com", "contra", 
                        "em", "entre", "sob", "sobre", "sem", "sob", "sobre", "tráz" };
                }

                return listArtPrepo;
            }
        }

        private List<string> conjuncoes;

        public List<string> Conjuncoes
        {
            get
            {
                if (conjuncoes == null)
                {
                    conjuncoes = new List<string> { 
                        "é", "e", "que",
                        "ou", "ora", "quer", "já", 
                        "mas", "porém", "todavia",
                        "que", "porque", "porquanto", "pois"
                    };
                }

                return conjuncoes;
            }
        }

        /// <summary>
        /// Formata texto retirando elementos(artigos, preposições e conjunções)  
        /// </summary>
        /// <param name="splitTexto">string array texto</param>
        /// <returns>IList<string></returns>
        public IList<string> GetPalavras(string texto)
        {
            return RemoveElementosGramatica(Utilidades.SplitTexto(texto));
        }

        /// <summary>
        /// Remove os artigos, preposições e conjunções
        /// </summary>
        /// <param name="splitTexto">string[] splitTexto</param>
        /// <returns>IList<string></returns>
        public IList<string> RemoveElementosGramatica(string[] splitTexto)
        {

            var palavras = new List<string>();

            foreach (var item in splitTexto)
            {
                if (!ListArtPrepo.Contains(item.ToLower()) && !Conjuncoes.Contains(item.ToLower()))
                {
                    palavras.Add(item);
                }
            }

            return palavras;
        }
    }
}
