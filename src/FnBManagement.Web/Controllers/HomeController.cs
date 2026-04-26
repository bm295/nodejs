using FnBManagement.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace FnBManagement.Web.Controllers;

public class HomeController : Controller
{
    private readonly IDashboardService _dashboardService;

    public HomeController(IDashboardService dashboardService)
    {
        _dashboardService = dashboardService;
    }

    public IActionResult Index()
    {
        var viewModel = _dashboardService.BuildDashboard();
        return View(viewModel);
    }
}
