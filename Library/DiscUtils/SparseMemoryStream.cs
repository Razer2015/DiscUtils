//
// Copyright (c) 2008-2011, Kenneth Bell
//
// Permission is hereby granted, free of charge, to any person obtaining a
// copy of this software and associated documentation files (the "Software"),
// to deal in the Software without restriction, including without limitation
// the rights to use, copy, modify, merge, publish, distribute, sublicense,
// and/or sell copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
// DEALINGS IN THE SOFTWARE.
//

namespace DiscUtils
{
    using System.IO;

    /// <summary>
    /// Provides a sparse equivalent to MemoryStream.
    /// </summary>
    public sealed class SparseMemoryStream : BufferStream
    {
        /// <summary>
        /// Initializes a new instance of the SparseMemoryStream class.
        /// </summary>
        /// <remarks>The created instance permits read and write access.</remarks>
        public SparseMemoryStream()
            : base(new SparseMemoryBuffer(16 * 1024), FileAccess.ReadWrite)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SparseMemoryStream class.
        /// </summary>
        /// <param name="buffer">The buffer to use.</param>
        /// <param name="access">The access permitted to clients.</param>
        public SparseMemoryStream(SparseMemoryBuffer buffer, FileAccess access)
            : base(buffer, access)
        {
        }
    }
}
