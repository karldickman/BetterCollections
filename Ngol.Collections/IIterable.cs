using System;

namespace Ngol.Collections
{
    /// <summary>
    /// Exposes the iterator, which supports a simple iteration over a non-generic collection.
    /// </summary>
    /// <remarks>
    /// For the generic version of this interface, see Ngol.Collections.Generic.IEnumerable&lt;T&gt;.
    /// </remarks>
    public interface IIterable
    {
        /// <summary>
        /// Returns an iterator that iterates through the collection.
        /// </summary>
        IIterator GetIterator();
    }
}

