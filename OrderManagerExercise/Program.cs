using OrderManagerExercise;

var total = new OrderManager(new MenuItemsPriceCalculator(), new DiscountManager())
    .CalculateTotalPrice(["pizza", "Pasta"], "Discount10");

Console.WriteLine($"Total price: {total}");