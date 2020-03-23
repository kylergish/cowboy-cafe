/* Author: Kyler Gish
 * Class name: Drink.cs
 * Purpose: A base class representing a drink
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing a drink
    /// </summary>
    public abstract class Drink : IOrderItem
    {
        /// <summary>
        /// Gets the Size of the drink
        /// </summary>
        public virtual Size Size { get; set; } = Size.Small;

        /// <summary>
        /// Gets the price of the drink
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the drink
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// If the drink has ice
        /// </summary>
        public virtual bool Ice { get; set; } = true;

        /// <summary>
        /// Gets the special instructions of the entree
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
