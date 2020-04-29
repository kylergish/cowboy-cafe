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
            OrderItems = Menu.Search(SearchTerms);
            OrderItems = Menu.FilterByOrderItemType(OrderItems, OrderItemType);
            OrderItems = Menu.FilterByCalories(OrderItems, CalorieMin, CalorieMax);
            OrderItems = Menu.FilterByPrice(OrderItems, PriceMin, PriceMax);
        }
    }
}
