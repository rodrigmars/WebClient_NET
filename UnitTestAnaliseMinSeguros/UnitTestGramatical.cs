using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using minutoseguros.BLL;
using System.Collections.Generic;
using System.Linq;

namespace analiseminseguros
{
    [TestClass]
    public class UnitTestGramatical : UtilTest
    {

        public string[] ListPalavras { get; set; }

        [TestInitialize]
        public void Setup()
        {
            ListPalavras = new string[] { "A", "Minuto", "Seguros", "recebeu", "no", "último", "dia", "a", "visita", "do", "renomado", "empresário", "José", "Roberto", "Macéa", "presidente", "da", "Jopema", "empresa", "integrante", "da", "multinacional", "alemã" };
        }

        [TestMethod]
        //[Ignore]
        public void Testeparaserializartexto()
        {
            var sut = new Gramatical();

            foreach (var content in ListContent)
            {
                var listPalavras = sut.GetPalavras(content);

                Assert.IsTrue(listPalavras.Count > 0);

                Assert.IsFalse(listPalavras.Contains("a", StringComparer.OrdinalIgnoreCase));
            }
        }

        [TestMethod]
        //[Ignore]
        public void Testepararemoverartigosepreposições()
        {
            var sut = new Gramatical();

            var listaPalavras = sut.RemoveElementosGramatica(ListPalavras);

            Assert.IsTrue(listaPalavras.Count > 5);

            Assert.IsFalse(listaPalavras.Contains("a", StringComparer.OrdinalIgnoreCase));
        }

    }
}
