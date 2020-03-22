using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.ComponentModel;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class RustlersRibsPropertyChangedTests
    {
        // Test 1: Rustlers Ribs should implement the INotifyPropertyChanged Interface
        [Fact]
        public void RustlersRibsShouldImplementINotifyPropertyChanged()
        {
            var ribs = new RustlersRibs();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(ribs);
        }
    }
}
