/* Author: Kyler Gish
 * Class name: CowboyCoffee.cs
 * Purpose: A class representing the Cowboy Coffe drink
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Cowboy Coffee drink
    /// </summary>
    public class CowboyCoffee : Drink
    {
        private bool decaf = false;
        /// <summary>
        /// If the drink is decaf
        /// </summary>
        public bool Decaf
        {
            get { return decaf; }
            set { decaf = value; }
        }

        private bool roomForCream = false;
        /// <summary>
        /// If the drink has room for cream
        /// </summary>
        public bool RoomForCream
        {
            get { return roomForCream; }
            set { roomForCream = value; }
        }

        private bool ice = false;
        /// <summary>
        /// If the drink has ice
        /// </summary>
        public override bool Ice
        {
            get { return ice; }
            set { ice = value; }
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

                if (Ice) instructions.Add("Add Ice");
                if (RoomForCream) instructions.Add("Room for Cream");

                return instructions;
            }
        }
    }
}
