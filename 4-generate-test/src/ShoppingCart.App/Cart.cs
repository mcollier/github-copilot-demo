using System.Collections.Generic;

public class Cart
{
    public List<CartItem> Items { get; set; } = new List<CartItem>();

    public int CalculateTotalItems()
    {
        int totalItems = 0;
        foreach (var item in Items)
        {
            totalItems += item.Quantity;
        }
        return totalItems;
    }

    public decimal CalculateTotalPrice()
    {
        decimal totalPrice = 0;
        foreach (var item in Items)
        {
            totalPrice += item.Price * item.Quantity;
        }
        return totalPrice;
    }
}
