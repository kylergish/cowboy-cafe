/* Author: Nathaniel Bean
 * Edited by: Kyler Gish
 * Class name: Side.cs
 * Purpose: A base class representing a side
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing a side
    /// </summary>
    public abstract class Side : IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// The property changed event
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The original name
        /// </summary>
        public abstract string Name { get; }

        private Size size;
        /// <summary>
        /// Gets the size of the side
        /// </summary>
        public virtual Size Size 
        {
            get { return size; } 
            set 
            { 
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
            }
        }

        /// <summary>
        /// Gets the price of the side
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the side
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Gets the Special Instructions of the side
        /// </summary>
        public virtual List<string> SpecialInstructions { get; }
    }
}
