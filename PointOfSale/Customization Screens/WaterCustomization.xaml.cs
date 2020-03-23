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
    /// Interaction logic for WaterCustomization.xaml
    /// </summary>
    public partial class WaterCustomization : UserControl
    {
        public WaterCustomization()
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
            if (DataContext is Water water)
            {
                water.Size = Size.Small;
            }
        }

        /// <summary>
        /// Event for medium
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="arg">argument</param>
        private void SizeMedium_Checked(object sender, RoutedEventArgs arg)
        {
            if (DataContext is Water water)
            {
                water.Size = Size.Medium;
            }
        }

        /// <summary>
        /// Event for large
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="arg">argument</param>
        private void SizeLarge_Checked(object sender, RoutedEventArgs arg)
        {
            if (DataContext is Water water)
            {
                water.Size = Size.Large;
            }
        }
    }
}
