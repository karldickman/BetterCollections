using System;
using System.Collections;

namespace Ngol.Collections
{
    /// <summary>
    /// Supports a simple iteration over a nongeneric collection.
    /// </summary>
    public interface IIterator : IDisposable, IEnumerator
    {
    }
}