namespace OrderManagerExercise;

public class DiscountManager : IDiscountManager
{
    private readonly Dictionary<string, double> _promoCodes = new (StringComparer.OrdinalIgnoreCase)
    {
        ["DISCOUNT10"] = 0.9,
        ["DISCOUNT20"] = 0.8
    };
    
    public double ApplyDiscount(string promotionCode, double total) =>
        _promoCodes.TryGetValue(promotionCode, out var discount) 
            ? discount * total 
            : total;
}