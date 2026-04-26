namespace FnBManagement.Web.Models;

public class InventoryItem
{
    public int Id { get; init; }
    public string Name { get; init; } = string.Empty;
    public string Unit { get; init; } = string.Empty;
    public decimal QuantityInStock { get; set; }
    public decimal ReorderLevel { get; init; }

    public bool IsLowStock => QuantityInStock <= ReorderLevel;
}
