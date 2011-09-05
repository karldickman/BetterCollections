using System;

namespace Ngol.Collections
{
    /// <summary>
    /// Represents a collection of objects that can be accessed by index.
    /// </summary>
    public interface IList : IIndexable, ICollection
    {
        /// <summary>
        /// Insert a value to the list at the specified index.
        /// </summary>
        /// <param name="index">
        /// The index at which to insert the value.
        /// </param>
        /// <param name="value">
        /// The value to insert into the list.
        /// </param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="index"/> is not a valid index of the list.
        /// </exception>
        void Insert(int index, object value);

        /// <summary>
        /// Removes the value from the list at the specified index.
        /// </summary>
        /// <param name="index">
        /// The zero-based index of the value to remove.
        /// </param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="index"/> is not a valid index of the list.
        /// </exception>
        void RemoveAt(int index);
    }
}

