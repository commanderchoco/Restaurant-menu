// See https://aka.ms/new-console-template for more information

using Restaurant_menu;

ShopMenu menu = new ShopMenu();

MenuItems item1 = new MenuItems
{
    Name = "Caesar Salad",
    Description = "Fresh romaine lettuce with Caesar dressing",
    Price = 7.99m,
    ItemCategory = MenuItems.Category.Appetizer
};

MenuItems item2 = new MenuItems
{
    Name = "Grilled Salmon",
    Description = "Salmon fillet grilled to perfection",
    Price = 15.99m,
    ItemCategory = MenuItems.Category.MainCourse
};
MenuItems item3 = new MenuItems
{
    Name = "Chocolate Cake",
    Description = "Rich chocolate cake with a creamy frosting",
    Price = 5.99m,
    ItemCategory = MenuItems.Category.Dessert
};
menu.AddItem(item1);
menu.AddItem(item2);
menu.AddItem(item3);
menu.PrintMenu();
Console.WriteLine("SHOP TIME!");

