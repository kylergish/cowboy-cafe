/* Author: Kyler Gish
 * Class name: OrderControl.xaml.cs
 * Purpose: A xaml class representing the order control
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CowboyCafe.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        /// <summary>
        /// Constructor for OrderControl
        /// </summary>
        public OrderControl()
        {
            var order = new Order();
            InitializeComponent();
            this.DataContext = order;

            AddItemSelectionButton.Click += AddItemSelectionButton_Click;
            AddCancelItemButton.Click += AddCancelItemButton_Click;
            AddCompleteOrderButton.Click += AddCompleteOrderButton_Click;
        }

        /// <summary>
        /// Event for clicking the item selection button
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void AddItemSelectionButton_Click(object sender, RoutedEventArgs e)
        {
            Container.Child = new MenuItemSelectionControl();
        }

        /// <summary>
        /// Event for clicking the cancel item button
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void AddCancelItemButton_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
        }

        /// <summary>
        /// Event for clicking the complete order button
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void AddCompleteOrderButton_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
        }

        /// <summary>
        /// Swap screen function
        /// </summary>
        /// <param name="element">Framework Element</param>
        public void SwapScreen(FrameworkElement element)
        {
            Container.Child = element;
        }
    }
}
