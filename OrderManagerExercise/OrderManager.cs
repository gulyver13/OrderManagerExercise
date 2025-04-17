namespace OrderManagerExercise;

public class OrderManager(IMenuItemsPriceCalculator menuItemsPriceCalculator, IDiscountManager discountManager)
{
    public double CalculateTotalPrice(List<string> items, string promotionCode) => 
        discountManager.ApplyDiscount(promotionCode, menuItemsPriceCalculator.Calculate(items));
}