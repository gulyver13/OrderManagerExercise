namespace OrderManagerExercise;

public class OrderManager
{
    public double CalculateTotalPrice(List<string> items, string promotionCode)
    {
        double total = 0;
        foreach (var item in items)
        {
            if (item == "Pizza")
            {
                total += 8.0;
            }
            else if (item == "Pasta")
            {
                total += 6.5;
            }
            else if (item == "Salad")
            {
                total += 4.0;
            }
            else
            {
                throw new ArgumentException("Unknown item: " + item);
            }
        }

        if (promotionCode == "DISCOUNT10")
        {
            total *= 0.9; // 10% discount
        }
        else if (promotionCode == "DISCOUNT20")
        {
            total *= 0.8; // 20% discount
        }

        return total;
    }
}