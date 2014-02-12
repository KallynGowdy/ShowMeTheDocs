using System;
using System.Collections.Generic;
using System.IO;
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

        /// <summary>
        /// Gets a repository that represents the given documentation.
        /// </summary>
        /// <param name="documentationStream">A stream object that is readable and contains the documentation to use.</param>
        /// <exception cref="System.ArgumentNullException">Thrown if the given stream is null.</exception>
        /// <exception cref="Syste.ArgumentException">Throw if the given stream is closed or not readable.</exception>
        /// <returns>Returns a new ShowMeTheDocs.IDocumentationRepository object.</returns>
        IDocumentationRepository GetDocumentation(Stream documentationStream);
    }
}
