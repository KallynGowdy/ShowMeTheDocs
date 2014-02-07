using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShowMeTheDocs
{
    /// <summary>
    /// Defines a repository of documentation for a group of namespaces, classes, methods, properties and fields.
    /// </summary>
    public interface IDocumentationRepository
    {
        /// <summary>
        /// Gets the name of the assembly.
        /// </summary>
        string AssemblyName
        {
            get;
        }

        /// <summary>
        /// Gets a list of documents that contain documentation for all of the namespaces contained in this repository.
        /// </summary>
        /// <returns></returns>
        IEnumerable<INamespaceDocument> GetNamespaces();

        /// <summary>
        /// Gets a document that contains documentation for the given namespace.
        /// </summary>
        /// <param name="namespace">The name of the namespace to get the documenation for.</param>
        /// <returns></returns>
        INamespaceDocument GetNamespace(string @namespace);
    }
}
