using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShowMeTheDocs
{
    /// <summary>
    /// Defines an interface for an object that contains documentation about a property contained in a type.
    /// </summary>
    public interface IPropertyDocument : INamed, ISummary, IRemarks
    {
        /// <summary>
        /// Gets the documentation for the type of objects that this property contains.
        /// </summary>
        ITypeDocument PropertyType
        {
            get;
        }

    }
}
