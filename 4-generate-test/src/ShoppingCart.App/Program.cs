
var cart = new Cart();
cart.Items.Add(new CartItem { Name = "Apple", Price = 0.5m, Quantity = 3 });
cart.Items.Add(new CartItem { Name = "Banana", Price = 0.2m, Quantity = 5 });

Console.WriteLine($"Total items in cart: {cart.CalculateTotalItems()}, Total price: {cart.CalculateTotalPrice():C}");
