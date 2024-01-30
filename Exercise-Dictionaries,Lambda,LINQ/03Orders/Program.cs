Dictionary<string, List<decimal>> orders = new();

string input = Console.ReadLine();

while (input != "buy")
{
    string[] inputArray = input.Split();
    string product = inputArray[0];
    decimal price = decimal.Parse(inputArray[1]);
    decimal quantity = decimal.Parse(inputArray[2]);

    if (!orders.ContainsKey(product))
    {
        orders.Add(product, new List<decimal>() { price, quantity });
       
    }
    else
    {
        orders[product][0] = price;
        orders[product][1] += quantity;
    }
    input = Console.ReadLine();
}

foreach (KeyValuePair<string, List<decimal>> order in orders)
{
    string currentOrderName = order.Key;
    decimal currentOrderPrice = order.Value[0];
    decimal currentOrderQuantity = order.Value[1];

    decimal currentOrderAmount = currentOrderPrice * currentOrderQuantity;

    Console.WriteLine($"{currentOrderName} -> {currentOrderAmount:F2}");
}
