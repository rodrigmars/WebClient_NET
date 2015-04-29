using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace minutoseguros.BLL
{
    public class WebClientMinutoSeguro
    {

        private static Uri uri;
        public static Uri URI
        {
            get
            {
                if (uri == null)
                {
                    uri = new Uri(@"http://www.minutoseguros.com.br/blog/feed/");
                }

                return uri;
            }
        }

        /// <summary>
        /// Obtém os atigos de blog via HttpWebResponse
        /// </summary>
        /// <returns>string</returns>
        public static string HttpGetBlog()
        {
            var request = HttpWebRequest.Create(URI);

            using (var response = (HttpWebResponse)request.GetResponse())
            {
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    using (var sr = new StreamReader(response.GetResponseStream()))
                    {
                        return sr.ReadToEnd().Trim();
                    }
                }
                else
                {
                    throw new Exception(response.StatusCode + " - " + response.StatusDescription);
                }
            }


        }
    }
}
