using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using minutoseguros.BLL;
using System.Linq;
using System.Collections.Generic;

namespace analiseminseguros
{
    [TestClass]
    public class UnitTestArtigoBlogMinuto : UtilTest
    {
        [TestInitialize]
        public void Setup()
        {

        }

        [TestMethod]
        //[Ignore]
        public void Testeobtempalavras()
        {
            var sut = new ArtigoBlogMinuto();

            var artigos = sut.GetArtigos();

            Assert.IsTrue(artigos.Count >= 10);
        }

        [TestMethod]
        //[Ignore]
        public void Verificapalavrastop10()
        {
            var sutGramatical = new Gramatical();

            var sut = new ArtigoBlogMinuto();

            foreach (var content in ListContent)
            {
                var palavras = sutGramatical.GetPalavras(content);

                Assert.IsTrue(palavras.Count() >= 10);

                var top10 = sut.GetTop10(palavras);

                Assert.IsTrue(top10.Count() >= 10);

                Assert.IsFalse(top10.Where(e => sutGramatical.ListArtPrepo.Contains(e.Palavra.ToLower())).Count() > 0);

                Assert.IsFalse(top10.Where(e => sutGramatical.Conjuncoes.Contains(e.Palavra.ToLower())).Count() > 0);
            }
        }
    }
}
