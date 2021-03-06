// Copyright (c) 2010-2013 SharpDX - Alexandre Mutel
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
#if !WIN8METRO
using System;

namespace SharpDX.Direct3D10
{
    public partial class MeshBuffer
    {
        /// <summary>	
        /// Get a reference to the mesh buffer memory to modify its contents.	
        /// </summary>	
        /// <remarks>	
        /// Differences between Direct3D 9 and Direct3D 10: Map() in Direct3D 10 is analogous to resource Map() in Direct3D 9.   ? 	
        /// </remarks>	
        /// <returns>Returns a reference to the mesh buffer memory to modify its contents</returns>
        /// <unmanaged>HRESULT ID3DX10MeshBuffer::Map([Out] void** ppData,[Out] SIZE_T* pSize)</unmanaged>
        public DataStream Map()
        {
            IntPtr dataPointer;
            PointerSize dataSize;
            Map(out dataPointer, out dataSize);
            return new DataStream(dataPointer, dataSize, true, true);
        }
    }
}
#endif