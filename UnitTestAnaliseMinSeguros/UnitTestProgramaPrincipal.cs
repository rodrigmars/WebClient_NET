using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using analiseminseguros;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Linq;
using minutoseguros;
using minutoseguros.BLL;



namespace analiseminseguros
{
    [TestClass]
    public class UnitTestProgramaPrincipal
    {

        [TestMethod]
        //[Ignore]
        public void TestGetTop10()
        {

            var programa = new ProgramaPrincipal();

            var topicos = programa.AvaliaTop10Palavras();

            Assert.IsTrue(topicos.Count() > 0);

            var count_topics = 1;

            var count_words = 1;

            foreach (var item in topicos)
            {

                Debug.WriteLine("Tópico - {0}: {1}", (count_topics++), item.Topico + Environment.NewLine);

                Debug.WriteLine(string.Format("{0, 11}{1, 27}", "Palavras", "Ocorrências"));

                item.Top10.ToList().ForEach(t =>
                {
                    Debug.WriteLine(string.Format("{0, -25} {1}", (count_words++).ToString().PadLeft(2, '0') + "-" + t.Palavra, " - " + t.TotalOcorrencias + "x"));
                });

                count_words = 1;

                Debug.WriteLine(Environment.NewLine + "Total " + item.TotalPalavras + " palavras" + Environment.NewLine);

                Debug.WriteLine(" ======================================================= " + Environment.NewLine);
            }
        }

        [TestMethod]
        //[Ignore]
        public void TestGetArtigos()
        {
            var obj = new ArtigoBlogMinuto();

            var artigos = obj.GetArtigos();

            Assert.IsNotNull(obj);
        }
    }
}
