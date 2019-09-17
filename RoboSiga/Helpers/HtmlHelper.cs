using HtmlAgilityPack;
using System;
using System.Collections.Generic;

namespace RoboSiga.Helpers
{
    public class HtmlHelper
    {
        public HtmlDocument document = new HtmlDocument();

        public HtmlHelper(string html)
        {
            document.LoadHtml(html);
        }

        public IEnumerable<HtmlNode> GetElementsByTagName(string tagName)
        {
            if (document == null) throw new Exception("Não é possível interagir com documento nulo");
            return document.DocumentNode.Descendants(tagName);
        }

        public IEnumerable<HtmlNode> GetElementsByTagName(HtmlNode parent, string tagName)
        {
            if (document == null) throw new Exception("Não é possível interagir com documento nulo");
            return parent.Descendants(tagName);
        }

        public HtmlNode GetElementByProperty(IEnumerable<HtmlNode> nodes, string propertyName, string propertyValue)
        {
            HtmlNode n = null;
            foreach (HtmlNode node in nodes)
            {
                HtmlAttributeCollection attributes = node.Attributes;
                if (attributes.Count > 0)
                {
                    foreach (HtmlAttribute att in attributes)
                    {
                        if (att.Name != null && att.Name.Equals(propertyName) && att.Value.Equals(propertyValue))
                        {
                            n = node;
                            break;
                        }
                    }
                    if (n != null)
                    {
                        break;
                    }
                }
            }
            return n;
        }

        public HtmlNode GetElementByInnerText(IEnumerable<HtmlNode> nodes, string innerText)
        {
            HtmlNode n = null;
            foreach (HtmlNode node in nodes)
            {
                if (node.InnerText.Equals(innerText))
                {
                    n = node;
                }
            }
            return n;
        }
    }
}
