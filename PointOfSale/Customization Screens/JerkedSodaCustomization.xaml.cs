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
using Size = CowboyCafe.Data.Size;

namespace PointOfSale.Customization_Screens
{
    /// <summary>
    /// Interaction logic for JerkedSodaCustomization.xaml
    /// </summary>
    public partial class JerkedSodaCustomization : UserControl
    {
        public JerkedSodaCustomization()
        {
            InitializeComponent();

            CreamSoda.Checked += CreamSoda_Checked;
            OrangeSoda.Checked += OrangeSoda_Checked;
            Sarsparilla.Checked += Sarsparilla_Checked;
            BirchBeer.Checked += BirchBeer_Checked;
            RootBeer.Checked += RootBeer_Checked;

            Small.Checked += SizeSmall_Checked;
            Medium.Checked += SizeMedium_Checked;
            Large.Checked += SizeLarge_Checked;
        }

        /// <summary>
        /// Event for cream soda
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="arg">argument</param>
        private void CreamSoda_Checked(object sender, RoutedEventArgs arg)
        {
            if (DataContext is JerkedSoda flavor)
            {
                flavor.Flavor = SodaFlavor.CreamSoda;
            }
        }

        /// <summary>
        /// Event for orange soda
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="arg">argument</param>
        private void OrangeSoda_Checked(object sender, RoutedEventArgs arg)
        {
            if (DataContext is JerkedSoda flavor)
            {
                flavor.Flavor = SodaFlavor.OrangeSoda;
            }
        }

        /// <summary>
        /// Event for sarsparilla
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="arg">argument</param>
        private void Sarsparilla_Checked(object sender, RoutedEventArgs arg)
        {
            if (DataContext is JerkedSoda flavor)
            {
                flavor.Flavor = SodaFlavor.Sarsparilla;
            }
        }

        /// <summary>
        /// Event for birch beer
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="arg">argument</param>
        private void BirchBeer_Checked(object sender, RoutedEventArgs arg)
        {
            if (DataContext is JerkedSoda flavor)
            {
                flavor.Flavor = SodaFlavor.BirchBeer;
            }
        }

        /// <summary>
        /// Event for root beer
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="arg">argument</param>
        private void RootBeer_Checked(object sender, RoutedEventArgs arg)
        {
            if (DataContext is JerkedSoda flavor)
            {
                flavor.Flavor = SodaFlavor.RootBeer;
            }
        }

        /// <summary>
        /// Event for small
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="arg">argument</param>
        private void SizeSmall_Checked(object sender, RoutedEventArgs arg)
        {
            if (DataContext is JerkedSoda soda)
            {
                soda.Size = Size.Small;
            }
        }

        /// <summary>
        /// Event for medium
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="arg">argument</param>
        private void SizeMedium_Checked(object sender, RoutedEventArgs arg)
        {
            if (DataContext is JerkedSoda soda)
            {
                soda.Size = Size.Medium;
            }
        }

        /// <summary>
        /// Event for large
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="arg">argument</param>
        private void SizeLarge_Checked(object sender, RoutedEventArgs arg)
        {
            if (DataContext is JerkedSoda soda)
            {
                soda.Size = Size.Large;
            }
        }
    }
}
