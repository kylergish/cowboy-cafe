/* Author: Kyler Gish
 * Class name: ExtensionMethods.cs
 * Purpose: A class that finds the ancestor of the page
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace PointOfSale.ExtensionMethods
{
    public static class ExtensionMethods
    {
        /// <summary>
        /// Finds the ancestor
        /// </summary>
        /// <typeparam name="T">Dependency Object</typeparam>
        /// <param name="element">this Dependency Object</param>
        /// <returns>The Ancestor</returns>
        public static T FindAncestor<T>(this DependencyObject element) where T : DependencyObject
        {
            var parent = VisualTreeHelper.GetParent(element);

            if (parent == null) return null;

            if (parent is T) return parent as T;

            return parent.FindAncestor<T>();
        }
    }
}