/* Author: Kyler Gish
 * Class name: Order.cs
 * Purpose: A class representing an order
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing an order
    /// </summary>
    public class Order : INotifyPropertyChanged
    {
        private uint lastOrderNumber;

        private List<IOrderItem> items = new List<IOrderItem>();
        /// <summary>
        /// Gets the items in the list
        /// </summary>
        public IEnumerable<IOrderItem> Items => items.ToArray();

        private double subtotal = 0;
        /// <summary>
        /// Returns the subtotal of the items in the list
        /// </summary>
        public double Subtotal => subtotal;

        /// <summary>
        /// Gets the current order number
        /// </summary>
        public uint OrderNumber { get; }

        /// <summary>
        /// Checks if the property has been changed using the INotifyPropertyChanged interface
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Adds the item to the list and updates the changed property
        /// </summary>
        /// <param name="item">Item to add to the list</param>
        public void Add(IOrderItem item)
        {
            items.Add(item);
            subtotal += item.Price;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));

        }

        /// <summary>
        /// Removes the item from the list and updates the changed property
        /// </summary>
        /// <param name="item">Item to remove from the list</param>
        public void Remove(IOrderItem item)
        {
            items.Remove(item);
            subtotal -= item.Price;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }
    }
}
