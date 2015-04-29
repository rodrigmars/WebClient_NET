using minutoseguros.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace minutoseguros.DTO
{
    public class ArtigoDTO
    {
   
        public string Title { get; set; }

        public string Link { get; set; }

        public string Comments { get; set; }

        public string PubDate { get; set; }

        public string Dc { get; set; }

        public string Category { get; set; }

        public string Guid { get; set; }

        public string Description { get; set; }

        public string Content { get; set; }

        public string Wfw { get; set; }

        public string Slash { get; set; }

        public ArtigoDTO(XElement xdco)
        {

            Title = xdco.Element("title").Value;

            Link = xdco.Element("link").Value;

            Comments = xdco.Element("comments").Value;

            PubDate = xdco.Element("pubDate").Value;

            Dc = xdco.Element(XName.Get("creator", "http://purl.org/dc/elements/1.1/")).Value;

            Category = xdco.Element("category").Value;

            Guid = xdco.Element("guid").Value;

            Description = xdco.Element("description").Value;

            Content = Utilidades.FormataTexto(xdco.Element(XName.Get("encoded", "http://purl.org/rss/1.0/modules/content/")).Value);

            Wfw = xdco.Element(XName.Get("commentRss", "http://wellformedweb.org/CommentAPI/")).Value;

            Slash = xdco.Element(XName.Get("comments", "http://purl.org/rss/1.0/modules/slash/")).Value;
        }

    }
}
