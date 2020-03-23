/* Author: Kyler Gish
 * Class name: ChiliCheeseFriesCustomization.xaml.cs
 * Purpose: A xaml class representing the customization of chili cheese fries
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
using Size = CowboyCafe.Data.Size;

namespace PointOfSale.Customization_Screens
{
    /// <summary>
    /// Interaction logic for ChiliCheeseFriesCustomization.xaml
    /// </summary>
    public partial class ChiliCheeseFriesCustomization : UserControl
    {
        /// <summary>
        /// Constructor for ChiliCheeseFriesCustomization
        /// </summary>
        public ChiliCheeseFriesCustomization()
        {
            InitializeComponent();

            Small.Checked += SizeSmall_Checked;
            Medium.Checked += SizeMedium_Checked;
            Large.Checked += SizeLarge_Checked;
        }

        /// <summary>
        /// Event for small
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="arg">argument</param>
        private void SizeSmall_Checked(object sender, RoutedEventArgs arg)
        {
            if (DataContext is ChiliCheeseFries fry)
            {
                fry.Size = Size.Small;
            }
        }

        /// <summary>
        /// Event for medium
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="arg">argument</param>
        private void SizeMedium_Checked(object sender, RoutedEventArgs arg)
        {
            if (DataContext is ChiliCheeseFries fry)
            {
                fry.Size = Size.Medium;
            }
        }

        /// <summary>
        /// Event for large
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="arg">argument</param>
        private void SizeLarge_Checked(object sender, RoutedEventArgs arg)
        {
            if (DataContext is ChiliCheeseFries fry)
            {
                fry.Size = Size.Large;
            }
        }
    }
}
