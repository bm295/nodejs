using FnBManagement.Web.Models;

namespace FnBManagement.Web.Data;

public class InMemoryStore
{
    public List<MenuItem> MenuItems { get; } =
    [
        new() { Id = 1, Name = "Classic Burger", Price = 8.50m, Category = "Main Course", IsAvailable = true },
        new() { Id = 2, Name = "Caesar Salad", Price = 6.00m, Category = "Appetizer", IsAvailable = true },
        new() { Id = 3, Name = "Orange Juice", Price = 3.25m, Category = "Beverage", IsAvailable = false }
    ];

    public List<InventoryItem> InventoryItems { get; } =
    [
        new() { Id = 1, Name = "Burger Bun", Unit = "pcs", QuantityInStock = 32, ReorderLevel = 20 },
        new() { Id = 2, Name = "Romaine Lettuce", Unit = "kg", QuantityInStock = 4, ReorderLevel = 5 },
        new() { Id = 3, Name = "Orange Syrup", Unit = "liters", QuantityInStock = 1.5m, ReorderLevel = 2 }
    ];

    public List<Order> Orders { get; } =
    [
        new()
        {
            Id = 1001,
            OrderedAtUtc = DateTime.UtcNow.AddHours(-2),
            Lines =
            [
                new() { MenuItemId = 1, MenuItemName = "Classic Burger", Quantity = 2, UnitPrice = 8.50m },
                new() { MenuItemId = 2, MenuItemName = "Caesar Salad", Quantity = 1, UnitPrice = 6.00m }
            ]
        },
        new()
        {
            Id = 1002,
            OrderedAtUtc = DateTime.UtcNow.AddHours(-1),
            Lines =
            [
                new() { MenuItemId = 1, MenuItemName = "Classic Burger", Quantity = 1, UnitPrice = 8.50m }
            ]
        }
    ];
}
