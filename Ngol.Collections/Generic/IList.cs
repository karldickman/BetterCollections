using System;

namespace Ngol.Collections.Generic
{
    /// <summary>
    /// Represents a collection of objects that can be accessed by index.
    /// </summary>
    /// <typeparam name="T">
    /// The type of values in the collection.
    /// </typeparam>
    public interface IList<T> : IList, IIndexable<T>, ICollection<T>
    {
        /// <summary>
        /// Set the value at the specified index.
        /// </summary>
        /// <param name="index">
        /// The index at which to set the value.
        /// </param>
        new T this[int index]
        {
            set;
        }

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
        void Insert(int index, T value);
    }
}

