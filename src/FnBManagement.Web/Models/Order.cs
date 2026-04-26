namespace FnBManagement.Web.Models;

public class Order
{
    public int Id { get; init; }
    public DateTime OrderedAtUtc { get; init; }
    public List<OrderLine> Lines { get; init; } = [];

    public decimal Total => Lines.Sum(x => x.Quantity * x.UnitPrice);
}

public class OrderLine
{
    public int MenuItemId { get; init; }
    public string MenuItemName { get; init; } = string.Empty;
    public int Quantity { get; init; }
    public decimal UnitPrice { get; init; }
}
