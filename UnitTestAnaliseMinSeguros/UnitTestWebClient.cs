using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using minutoseguros.BLL;

namespace analiseminseguros
{
    [TestClass]
    public class UnitTestWebClient
    {
        [TestMethod]
        //[Ignore]
        public void Testeparaverificaroretornodoserviço()
        {
            var resultado = WebClientMinutoSeguro.HttpGetBlog();

            Assert.IsTrue(resultado != "", "Retorno inválido, verificar status de serviço.");

            Debug.WriteLine(resultado);
        }
    }
}
