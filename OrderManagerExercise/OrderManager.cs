namespace OrderManagerExercise;

public interface IMenuItemsPriceCalculator
{
    double Calculate(List<string> items);
}

public class MenuItemsPriceCalculator : IMenuItemsPriceCalculator
{
    private readonly IDictionary<string, double> _menu =
        new Dictionary<string, double>(StringComparer.OrdinalIgnoreCase)
        {
            ["Pizza"] = 8.0,
            ["Pasta"] = 6.5,
            ["Salad"] = 4.0,
        };
    
    public double Calculate(List<string> items) =>
        items.Sum(item=> _menu.TryGetValue(item, out var price) 
            ? price 
            : throw new ArgumentException($"Unknown item: {item}"));
}

public interface IDiscountManager
{
    double ApplyDiscount(string promotionCode, double total);
}

public class DiscountManager : IDiscountManager
{
    private readonly IDictionary<string, double> _promoCodes = new Dictionary<string, double>(StringComparer.OrdinalIgnoreCase)
    {
        ["DISCOUNT10"] = 0.9,
        ["DISCOUNT20"] = 0.8
    };
    
    public double ApplyDiscount(string promotionCode, double total) =>
        _promoCodes.TryGetValue(promotionCode, out var discount) 
            ? discount * total 
            : total;
}

public class OrderManager(IMenuItemsPriceCalculator menuItemsPriceCalculator, IDiscountManager discountManager)
{
    public double CalculateTotalPrice(List<string> items, string promotionCode) => 
        discountManager.ApplyDiscount(promotionCode, menuItemsPriceCalculator.Calculate(items));
}