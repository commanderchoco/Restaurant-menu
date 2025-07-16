using System;
using System.Collections.Generic;
using System.Linq;

namespace Restaurant_menu;



public class MenuItems
{
    public enum Category
    {
        Appetizer,
        MainCourse,
        SideDish,
        Dessert,
        Beverage
    }
    public int Id { get; set; } = 0;
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; } = 0.0m;

    public Category ItemCategory { get; set; } = Category.MainCourse;

}
