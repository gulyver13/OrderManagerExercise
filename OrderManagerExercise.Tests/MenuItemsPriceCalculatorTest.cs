using System;
using System.Linq;
using Xunit;

namespace OrderManagerExercise.Tests;

public class MenuItemsPriceCalculatorTest
{
    [Theory]
    [InlineData(new [] {"Pizza", "pasta"}, 14.5)]
    [InlineData(new [] {"PIZZA", "pasta", "SaLAd"}, 18.5)]
    [InlineData(new [] {"Pizza"}, 8.0)]
    public void CalculateTotal(string[] menuItems, double expectedTotal)
    {
        var sut = new MenuItemsPriceCalculator();
        
        var actualTotal = sut.Calculate(menuItems.ToList());

        Assert.Equal(expectedTotal, actualTotal);
    }
    
    [Fact]
    public void MissingItem()
    {
        var sut = new MenuItemsPriceCalculator();
        const string missingMenuItem = "Cheese";
        
        var ex = Assert.Throws<ArgumentException>(() => sut.Calculate(["Pizza", missingMenuItem]));

        Assert.Contains(missingMenuItem, ex.Message);
    }
}