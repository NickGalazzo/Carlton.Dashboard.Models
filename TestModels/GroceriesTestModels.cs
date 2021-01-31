using System.Collections.Generic;
using System.Linq;

namespace Carlton.Dashboard.Models.TestModels
{
    public static class GroceriesTestModels
    {
        public static Groceries DefaultGroceriesListModel()
        {
            return new Groceries
                (
                    new List<GroceryItem>
                    {
                        new GroceryItem(1, "Toilet Paper", 25),
                        new GroceryItem(2, "Paper Towels", 57),
                        new GroceryItem(3, "Dish Soap", 92),
                        new GroceryItem(4, "Swiffers", 36)
                    }.OrderBy(o => o.PercentRemaining)
                );
        }

        public static GroceryItem GroceriesLowListItemModel()
        {
            return DefaultGroceriesListModel().Items.ElementAt(0);
        }

        public static GroceryItem GroceriesMediumListItemModel()
        {
            return DefaultGroceriesListModel().Items.ElementAt(2);
        }

        public static GroceryItem GroceriesHighListItemModel()
        {
            return DefaultGroceriesListModel().Items.ElementAt(3);
        }
    }
}

