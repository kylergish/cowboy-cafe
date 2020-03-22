using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests
{
    public class AngryChickenPropertyChangedTests
    {
        // Test 1: Angry Chicken should implement the INotifyPropertyChanged Interface
        [Fact]
        public void AngryChickenShouldImplementINotifyPropertyChanged()
        {
            var chicken = new AngryChicken();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(chicken);
        }

        // Test 2: Changing the "Bread" property should invoke PropertyChanged for "Bread"
        [Fact]
        public void ChangingBreadShouldInvokePropertyChangedForBread()
        {
            var chicken = new AngryChicken();
            Assert.PropertyChanged(chicken, "Bread", () =>
            {
                chicken.Bread = false;
            });
        }

        // Test 3: Changing the "Bread" property should invoke PropertyChanged for "SpecialInstructions"

        // Test 4: Changing the "Pickle" property should invoke PropertyChanged for "Pickle"

        // Test 5: Changing the "Pickle" property should invoke PropertyChanged for "SpecialInstructions"
    }
}
