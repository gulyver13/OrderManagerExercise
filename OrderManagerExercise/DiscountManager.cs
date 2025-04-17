namespace OrderManagerExercise;

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