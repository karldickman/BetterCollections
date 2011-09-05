using System;

namespace Ngol.Collections
{
    /// <summary>
    /// Defines methods to manipulate nongeneric collections.
    /// </summary>
    public interface ICollection : IIterable
    {
        /// <summary>
        /// Adds an item to the collection.
        /// </summary>
        /// <param name="value">
        /// The item to add to the collection.
        /// </param>
        void Add(object value);

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
        bool Remove(object value);
    }
}

