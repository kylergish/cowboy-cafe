/* Author: Kyler Gish
 * Class name: Water.cs
 * Purpose: A class representing the Water drink
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class referencing the Water drink
    /// </summary>
    public class Water : Drink
    {
        private bool lemon = false;
        /// <summary>
        /// If the drink has lemon
        /// </summary>
        public bool Lemon
        {
            get { return lemon; }
            set { lemon = value; }
        }

        private bool ice = true;
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

                if (Lemon) instructions.Add("add lemon");
                if (!Ice) instructions.Add("hold ice");

                return instructions;
            }
        }
    }
}
