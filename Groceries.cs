using System.Collections.Generic;

namespace Carlton.Dashboard.Models
{
    public record Groceries(IEnumerable<GroceryItem> Items);
    public record GroceryItem(int Id, string Name, double PercentRemaining);
}
