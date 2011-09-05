using System;

namespace Ngol.Collections.Generic
{
    /// <summary>
    /// Provides the base interface for reading sets.
    /// </summary>
    public interface IReadableSet<T> : IIterable<T>
    {
        /// <summary>
        /// Determines whether the current set is a proper subset of
        /// the specified collection.
        /// </summary>
        /// <param name="other">
        /// The collection to compare with the current set.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the current set is a proper subset of <paramref name="other"/>;
        /// otherwise <see langword="false" />.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown if <paramref name="other"/> is <see langword="null" />.
        /// </exception>
        bool IsProperSubsetOf(IIterable<T> other);

        /// <summary>
        /// Determines whether the current set is a proper superset of
        /// the specified collection.
        /// </summary>
        /// <param name="other">
        /// The collection to compare with the current set.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the current set is a proper superset of <paramref name="other"/>;
        /// otherwise <see langword="false" />.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown if <paramref name="other"/> is <see langword="null" />.
        /// </exception>
        bool IsProperSupersetOf(IIterable<T> other);

        /// <summary>
        /// Determines whether the current set is a subset of
        /// the specified collection.
        /// </summary>
        /// <param name="other">
        /// The collection to compare with the current set.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the current set is a subset of <paramref name="other"/>;
        /// otherwise <see langword="false" />.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown if <paramref name="other"/> is <see langword="null" />.
        /// </exception>
        bool IsSubsetOf(IIterable<T> other);

        /// <summary>
        /// Determines whether the current set is a superset of
        /// the specified collection.
        /// </summary>
        /// <param name="other">
        /// The collection to compare with the current set.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the current set is a superset of <paramref name="other"/>;
        /// otherwise <see langword="false" />.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown if <paramref name="other"/> is <see langword="null" />.
        /// </exception>
        bool IsSupersetOf(IIterable<T> other);

        /// <summary>
        /// Determines wheter the current set overlaps with the specified collection.
        /// </summary>
        /// <param name="other">
        /// The collection to compare with the current set.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the current set and <paramref name="other"/>
        /// share at least one commone value; otherwise <see langword="false" />.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown if <paramref name="other"/> is <see langword="null" />.
        /// </exception>
        bool Overlaps(IIterable<T> other);

        /// <summary>
        /// Determines whether the current set and the specified collection contain
        /// the same values.
        /// </summary>
        /// <param name="other">
        /// The collection to compare with the current set.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the current set is equal to <paramref name="other"/>; otherwise
        /// <see langword="false" />.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown if <paramref name="other"/> is <see langword="null" />.
        /// </exception>
        bool SetEquals(IIterable<T> other);
    }
}

