﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Volume.cs" company="QuantityTypes">
//   The MIT License (MIT)
//   
//   Copyright (c) 2012 Oystein Bjorke
//   
//   Permission is hereby granted, free of charge, to any person obtaining a
//   copy of this software and associated documentation files (the
//   "Software"), to deal in the Software without restriction, including
//   without limitation the rights to use, copy, modify, merge, publish,
//   distribute, sublicense, and/or sell copies of the Software, and to
//   permit persons to whom the Software is furnished to do so, subject to
//   the following conditions:
//   
//   The above copyright notice and this permission notice shall be included
//   in all copies or substantial portions of the Software.
//   
//   THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS
//   OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
//   MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
//   IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY
//   CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
//   TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE
//   SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
// </copyright>
// <summary>
//   Provides operators related to volume.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace QuantityTypes
{
    /// <summary>
    ///     Provides operators related to volume.
    /// </summary>
    public partial struct Volume
    {
        /// <summary>
        ///     Implements the operator /.
        /// </summary>
        /// <param name="l1"> The l1. </param>
        /// <param name="l2"> The l2. </param>
        /// <returns> The result of the operator. </returns>
        public static Length operator /(Volume l1, Area l2)
        {
            return new Length(l1.Value / l2.Value);
        }

        /// <summary>
        ///     Implements the operator *.
        /// </summary>
        /// <param name="x"> The volume. </param>
        /// <param name="y"> The density. </param>
        /// <returns> The result of the operator. </returns>
        public static Mass operator *(Volume x, Density y)
        {
            return new Mass(x.Value * y.Value);
        }
    
        /// <summary>
        /// Implements the operator *.
        /// </summary>
        /// <param name="x">The volume.</param>
        /// <param name="y">The length.</param>
        /// <returns>
        /// The result of the operator.
        /// </returns>
        public static SecondMomentOfArea operator *(Volume x, Length y)
        {
            return new SecondMomentOfArea(x.value * y.Value);
        }
    }
}