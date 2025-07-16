// See https://aka.ms/new-console-template for more information

using Restaurant_menu;

Console.WriteLine("SHOP TIME!");
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
menu.UpdateItem(1, new MenuItems
{
    Name = "Updated Caesar Salad",
    Description = "Updated description for Caesar Salad",
    Price = 8.99m,
    ItemCategory = MenuItems.Category.Appetizer
});
menu.PrintMenu();
menu.RemoveItem(2); // Remove Grilled Salmon
menu.PrintMenu();
Console.WriteLine("Items in the Appetizer category:");
var appetizers = menu.GetItemsByCategory(MenuItems.Category.Appetizer);
foreach (var appetizer in appetizers)
{
    Console.WriteLine($"ID: {appetizer.Id}, Name: {appetizer.Name}, Price: {appetizer.Price:C}");
}
Console.WriteLine("Items containing 'Cake':");
var cakes = menu.GetItemsByName("Cake");
foreach (var cake in cakes)
{
    Console.WriteLine($"ID: {cake.Id}, Name: {cake.Name}, Price: {cake.Price:C}");
}


