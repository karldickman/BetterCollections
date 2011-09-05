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
    public interface IReadableDictionary<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>>
    {
        /// <summary>
        /// Get the value with the specified key.
        /// </summary>
        /// <param name="key">
        /// The key of the value to get.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// The <paramref name="key"/> is <see langword="null" />.
        /// </exception>
        /// <exception cref="KeyNotFoundException">
        /// The property is retrieved and <paramref name="key"/> is not found.
        /// </exception>
        TValue this[TKey key]
        {
            get;
        }

        /// <summary>
        /// Gets a collection containing the keys of the dictionary.
        /// </summary>
        IIterable<TKey> Keys
        {
            get;
        }

        /// <summary>
        /// Gets a collection containing the values of the dictionary.
        /// </summary>
        IIterable<TValue> Values
        {
            get;
        }

        /// <summary>
        /// Determines whether the dictionary contains an element with the specified key.
        /// </summary>
        /// <param name="key">
        /// The key to locate in the dictionary.
        /// </param>
        /// <returns>
        /// <see langword="true"/> if the dictionary contains an value with the specified key; otherwise, <see langword="false" />.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// The <paramref name="key"/> is <see langword="null" />.
        /// </exception>
        bool ContainsKey(TKey key);

        /// <summary>
        /// Get the value associated with the specified key.
        /// </summary>
        /// <param name="key">
        /// The key whose value to get.
        /// </param>
        /// <param name="value">
        /// When this method returns, the value associated with the specified key, if the key is found.
        /// Otherwise, the default value for the type of the paramter.  This parameter is passed uninitialized.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the dictionary contains an value with the specified key; otherwise, <see langword="false" />.
        /// </returns>
        bool TryGetValue(TKey key, out TValue value);
    }
}

