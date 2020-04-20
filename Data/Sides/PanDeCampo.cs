/* Author: Kyler Gish
 * Class name: PanDeCampo.cs
 * Purpose: A class representing the Pan De Campo side
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Pan De Campo side
    /// </summary>
    public class PanDeCampo : Side
    {
        /// <summary>
        /// The original name
        /// </summary>
        public override string Name => "Pan De Campo";

        /// <summary>
        /// The calories of the side
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 367;
                    case Size.Medium:
                        return 269;
                    case Size.Small:
                        return 227;
                    default:
                        throw new NotImplementedException("Unknown size");
                }
            }
        }

        /// <summary>
        /// The price of the side
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 1.99;
                    case Size.Medium:
                        return 1.79;
                    case Size.Small:
                        return 1.59;
                    default:
                        throw new NotImplementedException("Unknown size");
                }
            }
        }

        /// <summary>
        /// Returns the string representation of the side
        /// </summary>
        /// <returns>The string representation of the side</returns>
        public override string ToString()
        {
            switch (Size)
            {
                case Size.Large:
                    return "Large Pan de Campo";
                case Size.Medium:
                    return "Medium Pan de Campo";
                case Size.Small:
                    return "Small Pan de Campo";
                default:
                    throw new NotImplementedException("Unknown size");
            }
        }
    }
}
