using OrderManagerExercise;

List<string> items = ["pizza", "Pasta"];
var total = new OrderManager(new MenuItemsPriceCalculator(), new DiscountManager()).CalculateTotalPrice(items, "Discount10");
Console.WriteLine($"Total price: {total}");