using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShowMeTheDocs
{
    /// <summary>
    /// Defines an interface for an object that contains documentation for a method.
    /// </summary>
    public interface IMethodDocument : ISummary, IRemarks, INamed
    {
        /// <summary>
        /// Gets a list of objects that contain documentation about the parameters of this method.
        /// </summary>
        /// <returns></returns>
        IEnumerable<IParamDocument> GetParameters();

        /// <summary>
        /// Gets an object that contains documentation for the parameter with the given name. Returns null if the 
        /// parameter does not exist in the method.
        /// </summary>
        /// <param name="name">The name of the parameter to get documentation for.</param>
        /// <returns></returns>
        IParamDocument GetParameter(string name);
    }
}
