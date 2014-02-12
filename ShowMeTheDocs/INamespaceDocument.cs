using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShowMeTheDocs
{
    /// <summary>
    /// Defines an interface for an object that contains documentation about a namespace.
    /// </summary>
    public interface INamespaceDocument : INamed, ISummary, IRemarks
    {
        /// <summary>
        /// Gets a list of documents that provide documentation about classes, interfaces, structures, enums and delegates.
        /// </summary>
        /// <returns></returns>
        IEnumerable<ITypeDocument> GetTypes();

        /// <summary>
        /// Gets documentation for a type with the given name.
        /// </summary>
        /// <param name="name">The name of the type to get from this namespace.</param>
        /// <returns></returns>
        ITypeDocument GetType(string name);
    }
}
