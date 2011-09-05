using System;

namespace Ngol.Collections.Generic
{
    /// <summary>
    /// Represents a collection of objects that can be individually accessed by index.
    /// </summary>
    /// <typeparam name="T">
    /// The type of values in the collection.
    /// </typeparam>
    public interface IIndexable<T> : IIndexable
    {
        /// <summary>
        /// Gets the element at the specified index.
        /// </summary>
        /// <param name="index">
        /// Zero-based index of the element to get.
        /// </param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="index"/> is not a valid index on the collection.
        /// </exception>
        new T this[int index]
        {
            get;
        }

        /// <summary>
        /// Get the index of the specified element in the collection.
        /// </summary>
        /// <param name="value">
        /// The value for which to search.
        /// </param>
        /// <returns>
        /// The index of the first occurrence of <paramref name="value"/>.
        /// </returns>
        int IndexOf(T value);
    }
}

