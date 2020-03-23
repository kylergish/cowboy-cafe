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
using PointOfSale.Customization_Screens;
using PointOfSale.ExtensionMethods;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {
        public MenuItemSelectionControl()
        {
            InitializeComponent();
            AddCowpokeChiliButton.Click += AddCowpokeChiliButton_Click;
            AddRustlersRibsButton.Click += AddRustlersRibsButton_Click;
            AddPecosPulledPorkButton.Click += AddPecosPulledPorkButton_Click;
            AddTrailBurgerButton.Click += AddTrailBurgerButton_Click;
            AddDakotaDoubleBurgerButton.Click += AddDakotaDoubleBurgerButton_Click;
            AddTexasTripleBurgerButton.Click += AddTexasTripleBurgerButton_Click;
            AddAngryChickenButton.Click += AddAngryChickenButton_Click;
            
            AddChiliCheeseButton.Click += AddChiliCheeseButton_Click;
            AddCornDodgersButton.Click += AddCornDodgersButton_Click;
            AddPanDeCampoButton.Click += AddPanDeCampoButton_Click;
            AddBakedBeansButton.Click += AddBakedBeansButton_Click;
            
            AddJerkedSodaButton.Click += AddJerkedSodaButton_Click;
            AddTexasTeaButton.Click += AddTexasTeaButton_Click;
            AddCowboyCoffeeButton.Click += AddCowboyCoffeeButton_Click;
            AddWater.Click += AddWaterButton_Click;
        }

        public Order order = new Order();

        private void AddCowpokeChiliButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                var item = new CowpokeChili();
                var screen = new CowpokeChiliCustomization();
                screen.DataContext = item;
                order.Add(item);
                orderControl?.SwapScreen(screen);
            }
        }

        private void AddRustlersRibsButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                var item = new RustlersRibs();
                var screen = new RustlersRibsCustomization();
                screen.DataContext = item;
                order.Add(item);
                orderControl?.SwapScreen(screen);
            }
        }

        private void AddPecosPulledPorkButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                var item = new PecosPulledPork();
                var screen = new PecosPulledPorkCustomization();
                screen.DataContext = item;
                order.Add(item);
                orderControl?.SwapScreen(screen);
            }
        }
        
        private void AddTrailBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                var item = new TrailBurger();
                var screen = new TrailBurgerCustomization();
                screen.DataContext = item;
                order.Add(item);
                orderControl?.SwapScreen(screen);
            }
        }
        
        private void AddDakotaDoubleBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                var item = new DakotaDoubleBurger();
                var screen = new DakotaDoubleBurgerCustomization();
                screen.DataContext = item;
                order.Add(item);
                orderControl?.SwapScreen(screen);
            }
        }
        
        private void AddTexasTripleBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                var item = new TexasTripleBurger();
                var screen = new TexasTripleBurgerCustomization();
                screen.DataContext = item;
                order.Add(item);
                orderControl?.SwapScreen(screen);
            }
        }
        
        private void AddAngryChickenButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                var item = new AngryChicken();
                var screen = new AngryChickenCustomization();
                screen.DataContext = item;
                order.Add(item);
                orderControl?.SwapScreen(screen);
            }
        }

        private void AddChiliCheeseButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                var item = new ChiliCheeseFries();
                var screen = new ChiliCheeseFriesCustomization();
                screen.DataContext = item;
                order.Add(item);
                orderControl?.SwapScreen(screen);
            }
        }
        
        private void AddCornDodgersButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                var item = new CornDodgers();
                var screen = new CornDodgersCustomization();
                screen.DataContext = item;
                order.Add(item);
                orderControl?.SwapScreen(screen);
            }
        }

        private void AddPanDeCampoButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                var item = new PanDeCampo();
                var screen = new PanDeCampoCustomization();
                screen.DataContext = item;
                order.Add(item);
                orderControl?.SwapScreen(screen);
            }
        }

        private void AddBakedBeansButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                var item = new BakedBeans();
                var screen = new BakedBeansCustomization();
                screen.DataContext = item;
                order.Add(item);
                orderControl?.SwapScreen(screen);
            }
        }
        
        private void AddJerkedSodaButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                var item = new JerkedSoda();
                var screen = new JerkedSodaCustomization();
                screen.DataContext = item;
                order.Add(item);
                orderControl?.SwapScreen(screen);
            }
        }

        private void AddTexasTeaButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                var item = new TexasTea();
                var screen = new TexasTeaCustomization();
                screen.DataContext = item;
                order.Add(item);
                orderControl?.SwapScreen(screen);
            }
        }

        private void AddCowboyCoffeeButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                var item = new CowboyCoffee();
                var screen = new CowboyCoffeeCustomization();
                screen.DataContext = item;
                order.Add(item);
                orderControl?.SwapScreen(screen);
            }
        }

        private void AddWaterButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                var item = new Water();
                var screen = new WaterCustomization();
                screen.DataContext = item;
                order.Add(item);
                orderControl?.SwapScreen(screen);
            }
        }
    }
}
