using System;
namespace Ngol.Collections.Generic
{
    /// <summary>
    /// Supports a simple itertion over a generic collection.
    /// </summary>
    /// <typeparam name="T">
    /// The type of values over which to iterate.
    /// </typeparam>
    public interface IIterator<T> : IIterator
    {
        /// <summary>
        /// Gets the element in the collection at the current position of the iteration.
        /// </summary>
        new T Current
        {
            get;
        }
    }
}

