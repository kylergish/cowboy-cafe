/* Author: Kyler Gish
 * Class name: IOrderItem.cs
 * Purpose: An interface representing an IOrderItem
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// An interface representing an IOrderItem
    /// </summary>
    public interface IOrderItem
    {
        /// <summary>
        /// Gets the price
        /// </summary>
        double Price { get; }

        /// <summary>
        /// Gets the special instructions
        /// </summary>
        List<string> SpecialInstructions { get; }
    }
}
