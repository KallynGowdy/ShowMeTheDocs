using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShowMeTheDocs
{
    /// <summary>
    /// Defines an object that contains documentation for a field in a type.
    /// </summary>
    public interface IFieldDocument : INamed, ISummary, IRemarks
    {
        /// <summary>
        /// Gets the documentation for the type of objects that this field contains.
        /// </summary>
        ITypeDocument FieldType
        {
            get;
        }

    }
}
