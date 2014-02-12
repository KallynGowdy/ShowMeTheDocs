using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowMeTheDocs
{
    /// <summary>
    /// Defines an IDocumentationProvider that retrieves documentation from an xml file.
    /// </summary>
    public class XmlDocumentationProvider : IDocumentationProvider
    {
        public IDocumentationRepository GetDocumentation(params string[] documentation)
        {
            
        }

        public IDocumentationRepository GetDocumentation(System.IO.Stream documentationStream)
        {
            StreamReader reader = new StreamReader(documentationStream);
            
        }
    }
}
