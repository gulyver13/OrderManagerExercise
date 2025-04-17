// See https://aka.ms/new-console-template for more information

using OrderManagerExercise;

List<string> items = ["Pizza", "Pasta"];
var total = new OrderManager().CalculateTotalPrice(items, "DISCOUNT10");
Console.WriteLine($"Total price: {total}");