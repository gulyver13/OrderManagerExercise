using Xunit;

namespace OrderManagerExercise.Tests;

public class DiscountManagerTest
{
    [Theory]
    [InlineData("Discount10", 90.0)]
    [InlineData("DiScOUNt10", 90.0)]
    [InlineData("DISCOUNT20", 80.0)]
    [InlineData("FakeDiscountCode", 100.0)]
    public void ApplyDiscount(string promotionCode, double expectedPrice)
    {
        var sut = new DiscountManager();
        
        var actualPrice = sut.ApplyDiscount(promotionCode, 100);

        Assert.Equal(expectedPrice, actualPrice);
    }
}