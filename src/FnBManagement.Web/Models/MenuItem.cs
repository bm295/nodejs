namespace FnBManagement.Web.Models;

public class MenuItem
{
    public int Id { get; init; }
    public string Name { get; init; } = string.Empty;
    public decimal Price { get; init; }
    public string Category { get; init; } = string.Empty;
    public bool IsAvailable { get; set; } = true;
}
