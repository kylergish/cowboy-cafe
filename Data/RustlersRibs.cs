/* Author: Kyler Gish
 * Class name: RustlersRibs.cs
 * Purpose: A class representing the Rustler's Rib entree
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Rustler's Rib entree
    /// </summary>
    public class RustlersRibs : Entree
    {
        /// <summary>
        /// The price of the ribs
        /// </summary>
        public override double Price
        {
            get
            {
                return 7.50;
            }
        }

        /// <summary>
        /// The calories of the ribs
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 894;
            }
        }

        /// <summary>
        /// The Special Instructions of the ribs
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                return instructions;
            }
        }

        /// <summary>
        /// Returns the string representation of the entree
        /// </summary>
        /// <returns>The string representation of the entree</returns>
        public override string ToString()
        {
            return "Rustler's Ribs";
        }
    }
}
