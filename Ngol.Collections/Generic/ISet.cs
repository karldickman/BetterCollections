using System;

namespace Ngol.Collections.Generic
{
    /// <summary>
    /// Provides the base interface for manipulating sets.
    /// </summary>
    public interface ISet<T> : ICollection<T>, IReadableSet<T>
    {
        /// <summary>
        /// Add a value to the current set and return a <see cref="bool" /> to indicate if
        /// the element was successfully added.
        /// </summary>
        /// <param name="value">
        /// The value to add to the set.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the value had not been previously added to the set;
        /// <see langword="false" /> if the element was already in the set.
        /// </returns>
        new bool Add(T value);

        /// <summary>
        /// Removes all value of the specified collection from the current set.
        /// </summary>
        /// <param name="other">
        /// The collection of values to remove from the set.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// Thrown if <paramref name="other"/> is <see langword="null" />.
        /// </exception>
        void ExceptWith(IIterable<T> other);

        /// <summary>
        /// Modifies the current set so that it contains only elements that are also in the specified
        /// collection.
        /// </summary>
        /// <param name="other">
        /// The collection to compare with the current set.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// Thrown if <paramref name="other"/> is <see langword="null" />.
        /// </exception>
        void IntersectWith(IIterable<T> other);

        /// <summary>
        /// Modifies the current set so that it contains only elements that are present
        /// either in the current set or in the specified collection, but not both.
        /// </summary>
        /// <param name="other">
        /// The collection of values to compare with the current set.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// Thrown if <paramref name="other"/> is <see langword="null" />.
        /// </exception>
        void SymmetricExceptWith(IIterable<T> other);

        /// <summary>
        /// Modifies the current set so that it contains all elements that are present in both the current set and
        /// in the specified collection.
        /// </summary>
        /// <param name="other">
        /// The collection to compare to the current set.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// Thrown if <paramref name="other"/> is <see langword="null" />.
        /// </exception>
        void UnionWith(IIterable<T> other);
    }
}

