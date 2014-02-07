using System;
namespace ShowMeTheDocs
{
    /// <summary>
    /// Defines an interface for an object that summarizes content.
    /// </summary>
    public interface ISummary
    {
        /// <summary>
        /// Gets the summary of this object.
        /// </summary>
        string Summary { get; }
    }
}
