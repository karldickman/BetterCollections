using System;
using Ngol.Collections;

namespace Ngol.Collections.Generic
{
    /// <summary>
    /// Exposes the iterator, which supports a simple iteration over a collection of a specified type.
    /// </summary>
    /// <typeparam name="T">
    /// The type of values over which to iterate.
    /// </typeparam>
    public interface IIterable<T> : IIterable
    {
        /// <summary>
        /// Returns an iterator that iterates through the collection.
        /// </summary>
        new IIterator<T> GetIterator();
    }
}

