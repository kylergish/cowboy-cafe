using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CowboyCafe.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        /// <summary>
        /// The orders to display on the index page
        /// </summary>
        public IEnumerable<IOrderItem> OrderItems { get; protected set; }

        /// <summary>
        /// The filtered Order Item Type
        /// </summary>
        [BindProperty]
        public string[] OrderItemType { get; set; }

        /// <summary>
        /// The current search terms
        /// </summary>
        [BindProperty]
        public string SearchTerms { get; set; }

        /// <summary>
        /// The minimum calorie count
        /// </summary>
        [BindProperty]
        public int? CalorieMin { get; set; }

        /// <summary>
        /// The maximum calorie count
        /// </summary>
        [BindProperty]
        public int? CalorieMax { get; set; }

        /// <summary>
        /// The minimum price
        /// </summary>
        [BindProperty]
        public double? PriceMin { get; set; }

        /// <summary>
        /// the maximum price
        /// </summary>
        [BindProperty]
        public double? PriceMax { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Gets the search results for display on the page
        /// </summary>
        public void OnGet(int? CalorieMin, int? CalorieMax, double? PriceMin, double? PriceMax)
        {
            this.CalorieMin = CalorieMin;
            this.CalorieMax = CalorieMax;
            this.PriceMin = PriceMin;
            this.PriceMax = PriceMax;

            SearchTerms = Request.Query["SearchTerms"];
            OrderItemType = Request.Query["OrderItemType"];
            
            OrderItems = Menu.All;
            //OrderItems = Menu.Search(SearchTerms);
            OrderItems = Menu.FilterByOrderItemType(OrderItems, OrderItemType);
            //OrderItems = Menu.FilterByCalories(OrderItems, CalorieMin, CalorieMax);
            //OrderItems = Menu.FilterByPrice(OrderItems, PriceMin, PriceMax);

            // Search Orders for Search Terms
            if (SearchTerms != null)
            {
                OrderItems = OrderItems.Where(order => order.ToString() != null && order.ToString().Contains(SearchTerms, StringComparison.InvariantCultureIgnoreCase));
            }

            // FilterByOrderItemType
            if (OrderItemType != null && OrderItemType.Length != 0)
            {
                //OrderItems = OrderItems.Where(order => order. != null && OrderItem.Contains(OrderItemType));
            }

            // FilterByCalories
            if (CalorieMin != null && CalorieMax != null)
            {
                OrderItems = OrderItems.Where(order => order.Calories <= CalorieMax);
                OrderItems = OrderItems.Where(order => order.Calories >= CalorieMin);
                OrderItems = OrderItems.Where(order => order.Calories >= CalorieMin && order.Calories <= CalorieMax);
            }

            // FilterByPrice
            if (PriceMin != null && PriceMax != null)
            {
                OrderItems = OrderItems.Where(order => order.Price <= PriceMax);
                OrderItems = OrderItems.Where(order => order.Price >= PriceMin);
                OrderItems = OrderItems.Where(order => order.Price >= PriceMin && order.Price <= PriceMax);
            }
        }
    }
}
