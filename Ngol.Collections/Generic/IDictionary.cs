using System;
using System.Collections.Generic;

namespace Ngol.Collections.Generic
{
    /// <summary>
    /// A generic collection of key/value pairs.
    /// </summary>
    /// <typeparam name="TKey">
    /// The type of keys in the dictionary.
    /// </typeparam>
    /// <typeparam name="TValue">
    /// The type of values in the dictionary.
    /// </typeparam>
    public interface IDictionary<TKey, TValue> : IReadableDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>
    {
        /// <summary>
        /// Set the value with the specified key.
        /// </summary>
        /// <param name="key">
        /// The key of the value to set.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// The <paramref name="key"/> is <see langword="null" />.
        /// </exception>
        new TValue this[TKey key]
        {
            set;
        }

        /// <summary>
        /// Add an element with the specified key and value to the dictionary.
        /// </summary>
        /// <param name="key">
        /// The key of the value to add.
        /// </param>
        /// <param name="value">
        /// The value to add.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// Thrown if <paramref name="key"/> is <see langword="null" />.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// Thrown if a value with the same key already exists in the dictionary.
        /// </exception>
        void Add(TKey key, TValue value);

        /// <summary>
        /// Remove the value with the specified key from the dictionary.
        /// </summary>
        /// <param name="key">
        /// The key fo the value to remove.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the value is successfully removed;
        /// otherwise, <see langword="false" />.  This method also returns <see langword="false" /> if
        /// <paramref name="key"/> was not found in the original dictionary.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown if <paramref name="key"/> is <see langword="null" />.
        /// </exception>
        bool Remove(TKey key);
    }
}

