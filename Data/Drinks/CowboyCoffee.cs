/* Author: Kyler Gish
 * Class name: CowboyCoffee.cs
 * Purpose: A class representing the Cowboy Coffe drink
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Cowboy Coffee drink
    /// </summary>
    public class CowboyCoffee : Drink, INotifyPropertyChanged
    {
        /// <summary>
        /// The property changed event
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        private Size size;
        /// <summary>
        /// Gets the size of the drink
        /// </summary>
        public override Size Size 
        { 
            get { return size; } 
            set 
            {
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
            }
        }

        private bool decaf = false;
        /// <summary>
        /// If the drink is decaf
        /// </summary>
        public bool Decaf
        {
            get { return decaf; }
            set 
            { 
                decaf = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Decaf"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool roomForCream = false;
        /// <summary>
        /// If the drink has room for cream
        /// </summary>
        public bool RoomForCream
        {
            get { return roomForCream; }
            set 
            { 
                roomForCream = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RoomForCream"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool ice = false;
        /// <summary>
        /// If the drink has ice
        /// </summary>
        public override bool Ice
        {
            get { return ice; }
            set 
            { 
                ice = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// The calories of the drink
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 7;
                    case Size.Medium:
                        return 5;
                    case Size.Small:
                        return 3;
                    default:
                        throw new NotImplementedException("Unknown size");
                }
            }
        }

        /// <summary>
        /// The price of the drink
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 1.60;
                    case Size.Medium:
                        return 1.10;
                    case Size.Small:
                        return 0.60;
                    default:
                        throw new NotImplementedException("Unknown size");
                }
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the drink
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (Decaf) instructions.Add("Decaf");
                if (Ice) instructions.Add("Add Ice");
                if (RoomForCream) instructions.Add("Room for Cream");

                return instructions;
            }
        }

        /// <summary>
        /// Returns the string representation of the drink
        /// </summary>
        /// <returns>The string representation of the drink</returns>
        public override string ToString()
        {
            if (Decaf)
            {
                switch (Size)
                {
                    case Size.Large:
                        return "Large Decaf Cowboy Coffee";
                    case Size.Medium:
                        return "Medium Decaf Cowboy Coffee";
                    case Size.Small:
                        return "Small Decaf Cowboy Coffee";
                    default:
                        throw new NotImplementedException("Unknown size");
                }
            }
            else
            {
                switch (Size)
                {
                    case Size.Large:
                        return "Large Cowboy Coffee";
                    case Size.Medium:
                        return "Medium Cowboy Coffee";
                    case Size.Small:
                        return "Small Cowboy Coffee";
                    default:
                        throw new NotImplementedException("Unknown size");
                }
            }
        }
    }
}
