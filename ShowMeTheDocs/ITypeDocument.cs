using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShowMeTheDocs
{
    /// <summary>
    /// Defines an interface for an object that contains documentation about a type(class, interface, structure, enum or delegate).
    /// </summary>
    public interface ITypeDocument : ISummary, IRemarks
    {
        /// <summary>
        /// Gets a list of documentation for the methods that are contained by this type.
        /// </summary>
        /// <returns></returns>
        IEnumerable<IMethodDocument> GetMethods();

        /// <summary>
        /// Gets a list of documentation for the fields that are contained by this type.
        /// </summary>
        /// <returns></returns>
        IEnumerable<IFieldDocument> GetFields();

        /// <summary>
        /// Gets a list of documentation for the properties that are contained by this type.
        /// </summary>
        /// <returns></returns>
        IEnumerable<IPropertyDocument> GetProperties();
    }
}
