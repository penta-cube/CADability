#region netDxf library licensed under the MIT License
// 
//                       netDxf library
// Copyright (c) Daniel Carvajal (haplokuon@gmail.com)
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
// 
#endregion

using System;

namespace netDxf.Blocks
{
    /// <summary>
    /// Block-type flags (bit-coded values, may be combined).
    /// </summary>
    [Flags]
    public enum BlockTypeFlags
    {
        /// <summary>
        /// Indicates none of the following flags apply.
        /// </summary>
        None = 0,

        /// <summary>
        /// This is an anonymous block generated by hatching, associative dimensioning, other internal operations, or an application.
        /// </summary>
        AnonymousBlock = 1,

        /// <summary>
        /// This block has non-constant attribute definitions
        /// (this bit is not set if the block has any attribute definitions that are constant, or has no attribute definitions at all).
        /// </summary>
        NonConstantAttributeDefinitions = 2,

        /// <summary>
        /// This block is an external reference.
        /// </summary>
        XRef = 4,

        /// <summary>
        /// This block is an external reference overlay.
        /// </summary>
        XRefOverlay = 8,

        /// <summary>
        /// This block is externally dependent.
        /// </summary>
        ExternallyDependent = 16,

        /// <summary>
        /// This is a resolved external reference, or dependent of an external reference (ignored on input).
        /// </summary>
        ResolvedExternalReference = 32,

        /// <summary>
        /// This definition is a referenced external reference (ignored on input).
        /// </summary>
        DefinitionExternalReference = 64
    }
}