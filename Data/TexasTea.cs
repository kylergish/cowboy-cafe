/* Author: Kyler Gish
 * Class name: TexasTea.cs
 * Purpose: A class representing the Texas Tea drink
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Texas Tea drink
    /// </summary>
    public class TexasTea : Drink
    {
        private bool sweet = true;
        /// <summary>
        /// If the drink has ice
        /// </summary>
        public bool Sweet
        {
            get { return sweet; }
            set { sweet = value; }
        }

        private bool lemon = false;
        /// <summary>
        /// If the drink has ice
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
                if(Sweet)
                {
                    switch (Size)
                    {
                        case Size.Large:
                            return 36;
                        case Size.Medium:
                            return 22;
                        case Size.Small:
                            return 10;
                        default:
                            throw new NotImplementedException("Unknown size");
                    }
                }
                else
                {
                    switch (Size)
                    {
                        case Size.Large:
                            return 18;
                        case Size.Medium:
                            return 11;
                        case Size.Small:
                            return 5;
                        default:
                            throw new NotImplementedException("Unknown size");
                    }
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
                        return 2.00;
                    case Size.Medium:
                        return 1.50;
                    case Size.Small:
                        return 1.00;
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
                    return "Large Texas Tea";
                case Size.Medium:
                    return "Medium Texas Tea";
                case Size.Small:
                    return "Small Texas Tea";
                default:
                    throw new NotImplementedException("Unknown size");
            }
        }
    }
}
