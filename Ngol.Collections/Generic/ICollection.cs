using System;
using Ngol.Collections;

namespace Ngol.Collections.Generic
{
    /// <summary>
    /// Defines methods to manipulate generic collections.
    /// </summary>
    /// <typeparam name="T">
    /// The type of values in the collection.
    /// </typeparam>
    public interface ICollection<T> : ICollection, IIterable<T>
    {
        /// <summary>
        /// Adds an item to the collection.
        /// </summary>
        /// <param name="value">
        /// The item to add to the collection.
        /// </param>
        void Add(T value);

        /// <summary>
        /// Removes the first occurrence of a specified object from the collection.
        /// </summary>
        /// <param name="value">
        /// The item to remove.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if <paramref name="value" /> was successfully removed from the collection;
        /// otherwise, <see langword="false" />. This method also returns <see langword="false" />
        /// if <paramref name="value"/> is not found in the original collection.
        /// </returns>
        bool Remove(T value);
    }
}

