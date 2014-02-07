using System;
namespace ShowMeTheDocs
{
    /// <summary>
    /// Defines an interface for objects that contain remarks describing something.
    /// </summary>
    public interface IRemarks
    {
        /// <summary>
        /// Gets the remarks that describe a feature or property of an object.
        /// </summary>
        string Remarks { get; }
    }
}
