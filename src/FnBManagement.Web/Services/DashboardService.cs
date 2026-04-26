using FnBManagement.Web.Data;
using FnBManagement.Web.Models;

namespace FnBManagement.Web.Services;

public class DashboardService : IDashboardService
{
    private readonly InMemoryStore _store;

    public DashboardService(InMemoryStore store)
    {
        _store = store;
    }

    public DashboardViewModel BuildDashboard()
    {
        var utcToday = DateTime.UtcNow.Date;
        var ordersToday = _store.Orders.Where(x => x.OrderedAtUtc.Date == utcToday).ToList();
        var lowStockItems = _store.InventoryItems.Where(x => x.IsLowStock).ToList();

        return new DashboardViewModel
        {
            MenuItemsCount = _store.MenuItems.Count,
            AvailableMenuItemsCount = _store.MenuItems.Count(x => x.IsAvailable),
            InventoryItemsCount = _store.InventoryItems.Count,
            LowStockItemsCount = lowStockItems.Count,
            OrdersTodayCount = ordersToday.Count,
            RevenueToday = ordersToday.Sum(x => x.Total),
            LowStockItems = lowStockItems,
            RecentOrders = _store.Orders.OrderByDescending(x => x.OrderedAtUtc).Take(5).ToList()
        };
    }
}
