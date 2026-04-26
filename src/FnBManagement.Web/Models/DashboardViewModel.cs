namespace FnBManagement.Web.Models;

public class DashboardViewModel
{
    public int MenuItemsCount { get; init; }
    public int AvailableMenuItemsCount { get; init; }
    public int InventoryItemsCount { get; init; }
    public int LowStockItemsCount { get; init; }
    public int OrdersTodayCount { get; init; }
    public decimal RevenueToday { get; init; }
    public IReadOnlyList<InventoryItem> LowStockItems { get; init; } = [];
    public IReadOnlyList<Order> RecentOrders { get; init; } = [];
}
