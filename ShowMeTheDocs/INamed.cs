using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShowMeTheDocs
{
    /// <summary>
    /// Defines an interface for an object that has a name.
    /// </summary>
    public interface INamed
    {
        /// <summary>
        /// Gets the basic name of this object.
        /// </summary>
        string Name
        {
            get;
        }
    }
}
