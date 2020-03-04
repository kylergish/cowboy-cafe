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
        public OrderControl()
        {
            var order = new Order();
            InitializeComponent();
            this.DataContext = order;

            AddItemSelectionButton.Click += AddItemSelectionButton_Click;
            AddCancelItemButton.Click += AddCancelItemButton_Click;
            AddCompleteOrderButton.Click += AddCompleteOrderButton_Click;
        }

        private void AddItemSelectionButton_Click(object sender, RoutedEventArgs e)
        {
            Container.Child = new MenuItemSelectionControl();
        }

        private void AddCancelItemButton_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
        }

        private void AddCompleteOrderButton_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
        }

        public void SwapScreen(FrameworkElement element)
        {
            Container.Child = element;
        }
    }
}
