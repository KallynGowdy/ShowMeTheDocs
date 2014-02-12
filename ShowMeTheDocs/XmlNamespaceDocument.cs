using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShowMeTheDocs
{
    class XmlNamespaceDocument : INamespaceDocument
    {

        public XmlNamespaceDocument(string name, string summary)
        {
            this.Name = name;
            this.Summary = summary;
        }

        public IEnumerable<ITypeDocument> GetTypes()
        {
            throw new NotImplementedException();
        }

        public ITypeDocument GetType(string name)
        {
            throw new NotImplementedException();
        }

        public string Summary
        {
            get;
            private set;
        }

        public string Remarks
        {
            get;
            private set;
        }

        public string Name
        {
            get;
            private set;
        }
    }
}
