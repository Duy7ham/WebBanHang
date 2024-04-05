public class ShoppingCart
{
    public List<CartItem> Items { get; set; } = new List<CartItem>();

    public void AddItem(CartItem item)
    {
        var existingItem = Items.FirstOrDefault(i => i.ProductId ==
item.ProductId); if (existingItem != null)
        {
            existingItem.Quantity += item.Quantity;
        }
        else
        {
            Items.Add(item);
        }
    }
    public void RemoveItem(int productId, int quantityToRemove)
    {
        var itemToRemove = Items.FirstOrDefault(i => i.ProductId == productId);
        if (itemToRemove != null)
        {
            if (itemToRemove.Quantity <= quantityToRemove)
            {
                Items.Remove(itemToRemove);
            }
            else
            {
                itemToRemove.Quantity -= quantityToRemove;
            }
        }
    }
}
