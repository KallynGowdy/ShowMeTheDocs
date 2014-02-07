using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowMeTheDocs
{
    /// <summary>
    /// Defines an interface for a object that, given a list of strings representing the documentation, returns an object that represents the documentation.
    /// </summary>
    public interface IDocumentationProvider
    {
        /// <summary>
        /// Gets a repository that represents the given documentation.
        /// </summary>
        /// <param name="documentation">A list of string objects that represent the documentation to use.</param>
        /// <returns>Returns a new ShowMeTheDocs.IDocumentationRepository object.</returns>
        IDocumentationRepository GetDocumentation(params string[] documentation);
    }
}
