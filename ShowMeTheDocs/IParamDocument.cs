using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShowMeTheDocs
{
    /// <summary>
    /// Defines an interface for an object that contains information about a method parameter.
    /// </summary>
    public interface IParamDocument : INamed, ISummary
    {
        /// <summary>
        /// Gets the type of this parameter.
        /// </summary>
        string Type
        {
            get;
        }
    }
}
