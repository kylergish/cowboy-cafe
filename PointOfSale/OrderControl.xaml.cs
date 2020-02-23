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
        }

        private void AddCowpokeChiliButton_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new CowpokeChili());
        }

        private void AddRustlersRibsButton_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new RustlersRibs());
        }

        private void AddPecosPulledPorkButton_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new PecosPulledPork());
        }

        private void AddTrailBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new TrailBurger());
        }

        private void AddDakotaDoubleBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new DakotaDoubleBurger());
        }

        private void AddTexasTripleBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new TexasTripleBurger());
        }

        private void AddAngryChickenButton_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new AngryChicken());
        }


        private void AddChiliCheeseButton_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new ChiliCheeseFries());
        }

        private void AddCornDodgersButton_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new CornDodgers());
        }

        private void AddPanDeCampoButton_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new PanDeCampo());
        }

        private void AddBakedBeansButton_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new BakedBeans());
        }
    }
}
