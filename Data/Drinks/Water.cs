/* Author: Kyler Gish
 * Class name: Water.cs
 * Purpose: A class representing the Water drink
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class referencing the Water drink
    /// </summary>
    public class Water : Drink, INotifyPropertyChanged
    {
        /// <summary>
        /// The property changed event
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The original name
        /// </summary>
        public override string Name => "Water";

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

        private bool lemon = false;
        /// <summary>
        /// If the drink has lemon
        /// </summary>
        public bool Lemon
        {
            get { return lemon; }
            set 
            { 
                lemon = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lemon"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool ice = true;
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
                        return 0;
                    case Size.Medium:
                        return 0;
                    case Size.Small:
                        return 0;
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
                        return 0.12;
                    case Size.Medium:
                        return 0.12;
                    case Size.Small:
                        return 0.12;
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

                if (Lemon) instructions.Add("Add Lemon");
                if (!Ice) instructions.Add("Hold Ice");

                return instructions;
            }
        }

        /// <summary>
        /// Returns the string representation of the drink
        /// </summary>
        /// <returns>The string representation of the drink</returns>
        public override string ToString()
        {
            switch (Size)
            {
                case Size.Large:
                    return "Large Water";
                case Size.Medium:
                    return "Medium Water";
                case Size.Small:
                    return "Small Water";
                default:
                    throw new NotImplementedException("Unknown size");
            }
        }
    }
}
