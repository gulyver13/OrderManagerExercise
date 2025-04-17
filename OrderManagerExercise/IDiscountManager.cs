namespace OrderManagerExercise;

public interface IDiscountManager
{
    double ApplyDiscount(string promotionCode, double total);
}