﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Acceleration.cs" company="QuantityTypes">
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
//   Provides operators related to acceleration.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace QuantityTypes
{
    /// <summary>
    ///     Provides operators related to acceleration.
    /// </summary>
    public partial struct Acceleration
    {
        /// <summary>
        ///     Implements the operator *.
        /// </summary>
        /// <param name="x"> The x. </param>
        /// <param name="y"> The y. </param>
        /// <returns> The result of the operator. </returns>
        public static Velocity operator *(Acceleration x, Time y)
        {
            return new Velocity(x.Value * y.Value);
        }

        /// <summary>
        /// Implements the * operator for the product of <see cref="Acceleration" /> and <see cref="Length" />.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <returns>The result of the operator.</returns>
        public static VelocitySquared operator *(Acceleration x, Length y)
        {
            return new VelocitySquared(x.Value * y.Value);
        }

        /// <summary>
        /// Implements the * operator for the product of <see cref="Acceleration" /> and <see cref="TimeSquared" />.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <returns>The result of the operator.</returns>
        public static Length operator *(Acceleration x, TimeSquared y)
        {
            return new Length(x.Value * y.Value);
        }
    }
}