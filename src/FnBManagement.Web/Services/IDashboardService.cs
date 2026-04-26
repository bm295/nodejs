using FnBManagement.Web.Models;

namespace FnBManagement.Web.Services;

public interface IDashboardService
{
    DashboardViewModel BuildDashboard();
}
