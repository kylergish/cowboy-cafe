using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;

namespace CowboyCafe.Data
{
    public static class Menu
    {
        public static string[] OrderItemTypes
        {
            get => new string[]
            {
                "Entrees",
                "Sides",
                "Drinks"
            };
        }

        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> items = new List<IOrderItem>();
            items.Add(new AngryChicken());
            items.Add(new CowpokeChili());
            items.Add(new DakotaDoubleBurger());
            items.Add(new PecosPulledPork());
            items.Add(new RustlersRibs());
            items.Add(new TexasTripleBurger());
            items.Add(new TrailBurger());
            return items;
        }

        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> items = new List<IOrderItem>();
            BakedBeans smallBeans = new BakedBeans();
            smallBeans.Size = Size.Small;
            items.Add(smallBeans);
            BakedBeans mediumBeans = new BakedBeans();
            mediumBeans.Size = Size.Medium;
            items.Add(mediumBeans);
            BakedBeans largeBeans = new BakedBeans();
            largeBeans.Size = Size.Large;
            items.Add(largeBeans);
            ChiliCheeseFries smallFries = new ChiliCheeseFries();
            smallFries.Size = Size.Small;
            items.Add(smallFries);
            ChiliCheeseFries mediumFries = new ChiliCheeseFries();
            mediumFries.Size = Size.Medium;
            items.Add(mediumFries);
            ChiliCheeseFries largeFries = new ChiliCheeseFries();
            largeFries.Size = Size.Large;
            items.Add(largeFries);
            CornDodgers smallDodger = new CornDodgers();
            smallDodger.Size = Size.Small;
            items.Add(smallDodger);
            CornDodgers mediumDodger = new CornDodgers();
            mediumDodger.Size = Size.Medium;
            items.Add(mediumDodger);
            CornDodgers largeDodger = new CornDodgers();
            largeBeans.Size = Size.Large;
            items.Add(largeDodger);
            PanDeCampo smallPan = new PanDeCampo();
            smallPan.Size = Size.Small;
            items.Add(smallPan);
            PanDeCampo mediumPan = new PanDeCampo();
            mediumPan.Size = Size.Medium;
            items.Add(mediumPan);
            PanDeCampo largePan = new PanDeCampo();
            largePan.Size = Size.Large;
            items.Add(largePan);
            return items;
        }

        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> items = new List<IOrderItem>();
            CowboyCoffee smallDrink1 = new CowboyCoffee();
            smallDrink1.Size = Size.Small;
            items.Add(smallDrink1);
            CowboyCoffee mediumDrink1 = new CowboyCoffee();
            mediumDrink1.Size = Size.Medium;
            items.Add(mediumDrink1);
            CowboyCoffee largeDrink1 = new CowboyCoffee();
            largeDrink1.Size = Size.Large;
            items.Add(largeDrink1);
            JerkedSoda smallDrink2 = new JerkedSoda();
            smallDrink2.Size = Size.Small;
            items.Add(smallDrink2);
            JerkedSoda mediumDrink2 = new JerkedSoda();
            mediumDrink2.Size = Size.Medium;
            items.Add(mediumDrink2);
            JerkedSoda largeDrink2 = new JerkedSoda();
            largeDrink2.Size = Size.Large;
            items.Add(largeDrink2);
            TexasTea smallDrink3 = new TexasTea();
            smallDrink3.Size = Size.Small;
            items.Add(smallDrink3);
            TexasTea mediumDrink3 = new TexasTea();
            mediumDrink3.Size = Size.Medium;
            items.Add(mediumDrink3);
            TexasTea largeDrink3 = new TexasTea();
            largeDrink3.Size = Size.Large;
            items.Add(largeDrink3);
            Water smallDrink4 = new Water();
            smallDrink4.Size = Size.Small;
            items.Add(smallDrink4);
            Water mediumDrink4 = new Water();
            mediumDrink4.Size = Size.Medium;
            items.Add(mediumDrink4);
            Water largeDrink4 = new Water();
            largeDrink4.Size = Size.Large;
            items.Add(largeDrink4);
            return items;
        }

        public static IEnumerable<IOrderItem> CompleteMenu()
        {
            List<IOrderItem> items = new List<IOrderItem>();
            items.Add(new AngryChicken());
            items.Add(new CowpokeChili());
            items.Add(new DakotaDoubleBurger());
            items.Add(new PecosPulledPork());
            items.Add(new RustlersRibs());
            items.Add(new TexasTripleBurger());
            items.Add(new TrailBurger());
            BakedBeans smallBeans = new BakedBeans();
            smallBeans.Size = Size.Small;
            items.Add(smallBeans);
            BakedBeans mediumBeans = new BakedBeans();
            mediumBeans.Size = Size.Medium;
            items.Add(mediumBeans);
            BakedBeans largeBeans = new BakedBeans();
            largeBeans.Size = Size.Large;
            items.Add(largeBeans);
            ChiliCheeseFries smallFries = new ChiliCheeseFries();
            smallFries.Size = Size.Small;
            items.Add(smallFries);
            ChiliCheeseFries mediumFries = new ChiliCheeseFries();
            mediumFries.Size = Size.Medium;
            items.Add(mediumFries);
            ChiliCheeseFries largeFries = new ChiliCheeseFries();
            largeFries.Size = Size.Large;
            items.Add(largeFries);
            CornDodgers smallDodger = new CornDodgers();
            smallDodger.Size = Size.Small;
            items.Add(smallDodger);
            CornDodgers mediumDodger = new CornDodgers();
            mediumDodger.Size = Size.Medium;
            items.Add(mediumDodger);
            CornDodgers largeDodger = new CornDodgers();
            largeBeans.Size = Size.Large;
            items.Add(largeDodger);
            PanDeCampo smallPan = new PanDeCampo();
            smallPan.Size = Size.Small;
            items.Add(smallPan);
            PanDeCampo mediumPan = new PanDeCampo();
            mediumPan.Size = Size.Medium;
            items.Add(mediumPan);
            PanDeCampo largePan = new PanDeCampo();
            largePan.Size = Size.Large;
            items.Add(largePan);
            CowboyCoffee smallDrink1 = new CowboyCoffee();
            smallDrink1.Size = Size.Small;
            items.Add(smallDrink1);
            CowboyCoffee mediumDrink1 = new CowboyCoffee();
            mediumDrink1.Size = Size.Medium;
            items.Add(mediumDrink1);
            CowboyCoffee largeDrink1 = new CowboyCoffee();
            largeDrink1.Size = Size.Large;
            items.Add(largeDrink1);
            JerkedSoda smallDrink2 = new JerkedSoda();
            smallDrink2.Size = Size.Small;
            items.Add(smallDrink2);
            JerkedSoda mediumDrink2 = new JerkedSoda();
            mediumDrink2.Size = Size.Medium;
            items.Add(mediumDrink2);
            JerkedSoda largeDrink2 = new JerkedSoda();
            largeDrink2.Size = Size.Large;
            items.Add(largeDrink2);
            TexasTea smallDrink3 = new TexasTea();
            smallDrink3.Size = Size.Small;
            items.Add(smallDrink3);
            TexasTea mediumDrink3 = new TexasTea();
            mediumDrink3.Size = Size.Medium;
            items.Add(mediumDrink3);
            TexasTea largeDrink3 = new TexasTea();
            largeDrink3.Size = Size.Large;
            items.Add(largeDrink3);
            Water smallDrink4 = new Water();
            smallDrink4.Size = Size.Small;
            items.Add(smallDrink4);
            Water mediumDrink4 = new Water();
            mediumDrink4.Size = Size.Medium;
            items.Add(mediumDrink4);
            Water largeDrink4 = new Water();
            largeDrink4.Size = Size.Large;
            items.Add(largeDrink4);
            return items;
        }

        public static IEnumerable<IOrderItem> All => CompleteMenu();

        /// <summary>
        /// Searches the database for matching terms
        /// </summary>
        /// <param name="terms">The terms to search for</param>
        /// <returns>A collection of terms</returns>
        public static IEnumerable<IOrderItem> Search(string terms)
        {
            List<IOrderItem> results = new List<IOrderItem>();
            // Return all terms if there are no search terms
            if (terms == null) return Menu.All;
            // Return each term in the database containing the terms substring
            foreach(IOrderItem order in Menu.All)
            {
                if(order.ToString() != null && order.ToString().Contains(terms, StringComparison.InvariantCultureIgnoreCase))
                {
                    results.Add(order);
                }
            }
            return results;
        }

        /// <summary>
        /// Filters the provided orders
        /// </summary>
        /// <param name="order">The orders</param>
        /// <param name="type">The types</param>
        /// <returns>A collection containing only movies that match the filter</returns>
        public static IEnumerable<IOrderItem> FilterByOrderItemType(IEnumerable<IOrderItem> order, IEnumerable<string> type)
        {
            // If no filter is specified, just return the provided collection
            if (type == null || type.Count() == 0) return order;
            // Filter the supplied collection of orders
            List<IOrderItem> results = new List<IOrderItem>();
            foreach(String orderItem in type)
            {
                if(orderItem == "Entrees")
                {
                    foreach(IOrderItem item in Menu.Entrees())
                    {
                        results.Add(item);
                    }
                }
                if (orderItem == "Sides")
                {
                    foreach (IOrderItem item in Menu.Sides())
                    {
                        results.Add(item);
                    }
                }
                if (orderItem == "Drinks")
                {
                    foreach (IOrderItem item in Menu.Drinks())
                    {
                        results.Add(item);
                    }
                }
            }
            return results;
        }

        /// <summary>
        /// Filters the provided collection of items to those with calories falling within the specified range
        /// </summary>
        /// <param name="orderItems">The collection of items to filter</param>
        /// <param name="min">The minimum range value</param>
        /// <param name="max">The maximum range value</param>
        /// <returns>The filtered item collection</returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> orderItems, int? min, int? max)
        {
            if (min == null && max == null) return orderItems;
            var results = new List<IOrderItem>();
            // only a maximum specified
            if(min == null)
            {
                foreach(IOrderItem order in orderItems)
                {
                    if (order.Calories <= max) results.Add(order);
                }
                return results;
            }
            // only a minimum specified
            if(max == null)
            {
                foreach(IOrderItem order in orderItems)
                {
                    if (order.Calories >= min) results.Add(order);
                }
                return results;
            }
            // Both minimum and maximum specified
            foreach(IOrderItem order in orderItems)
            {
                if(order.Calories >= min && order.Calories <= max)
                {
                    results.Add(order);
                }
            }
            return results;
        }

        /// <summary>
        /// Filters the provided collection of items to those with calories falling within the specified range
        /// </summary>
        /// <param name="orderItems">The collection of items to filter</param>
        /// <param name="min">The minimum range value</param>
        /// <param name="max">The maximum range value</param>
        /// <returns>The filtered item collection</returns>
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> orderItems, double? min, double? max)
        {
            if (min == null && max == null) return orderItems;
            var results = new List<IOrderItem>();
            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem order in orderItems)
                {
                    if (order.Price <= max) results.Add(order);
                }
                return results;
            }
            // only a minimum specified
            if (max == null)
            {
                foreach (IOrderItem order in orderItems)
                {
                    if (order.Price >= min) results.Add(order);
                }
                return results;
            }
            // Both minimum and maximum specified
            foreach (IOrderItem order in orderItems)
            {
                if (order.Price >= min && order.Price <= max)
                {
                    results.Add(order);
                }
            }
            return results;
        }
    }
}
