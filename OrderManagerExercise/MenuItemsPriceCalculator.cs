namespace OrderManagerExercise;

public class MenuItemsPriceCalculator : IMenuItemsPriceCalculator
{
    private readonly Dictionary<string, double> _menu =
        new (StringComparer.OrdinalIgnoreCase)
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