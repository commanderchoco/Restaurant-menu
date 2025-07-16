using System;
using System.Dynamic;
using System.Collections.Generic;
using System.Linq;

namespace Restaurant_menu;

public class ShopMenu
{
    public List<MenuItems> Items { get; set; } = new List<MenuItems>();

    public void AddItem(MenuItems item)
    {
        if (item != null)
        {
            item.Id = Items.Count > 0 ? Items.Max(i => i.Id) + 1 : 1; // Auto-increment ID
            Items.Add(item);
        }
    }
    public void RemoveItem(int id)
    {
        var itemToRemove = Items.FirstOrDefault(i => i.Id == id);
        if (itemToRemove != null)
        {
            int tempId = itemToRemove.Id;
            // Remove the item from the list
            Items.Remove(itemToRemove);
            // Update IDs of items after the removed item  
            foreach (var item in Items.Where(i => i.Id > tempId))
            {
                item.Id--;
            }
        }
    }
    public void PrintMenu()
    {
        foreach (var item in Items)
        {
            Console.WriteLine($"ID: {item.Id}, Name: {item.Name}, Description: {item.Description}, Price: {item.Price:C}, Category: {item.ItemCategory}");
        }
    }
    public void UpdateItem(int id, MenuItems updatedItem)
    {
        var itemToUpdate = Items.FirstOrDefault(i => i.Id == id);
        if (itemToUpdate != null && updatedItem != null)
        {
            itemToUpdate.Name = updatedItem.Name;
            itemToUpdate.Description = updatedItem.Description;
            itemToUpdate.Price = updatedItem.Price;
            itemToUpdate.ItemCategory = updatedItem.ItemCategory;
        }
    }
    // Overloaded method to update only the name
    public void UpdateItem(int id, string newName, string newDescription = null)
    {
        var itemToUpdate = Items.FirstOrDefault(i => i.Id == id);
        if (itemToUpdate != null)
        {
            itemToUpdate.Name = newName;
            if (newDescription != null)
            {
                itemToUpdate.Description = newDescription;
            }
        }
        else
        {
            throw new Exception("Item not found");
        }
    }
    // Overloaded method to update only the price
    public void UpdateItem(int id, decimal newPrice)
    {
        var itemToUpdate = Items.FirstOrDefault(i => i.Id == id);
        if (itemToUpdate != null)
        {
            itemToUpdate.Price = newPrice;
        }
        else
        {
            throw new Exception("Item not found");
        }
    }
    // Overloaded method to update only the category
    public void UpdateItem(int id, MenuItems.Category newCategory)
    {
        var itemToUpdate = Items.FirstOrDefault(i => i.Id == id);
        if (itemToUpdate != null)
        {
            itemToUpdate.ItemCategory = newCategory;
        }
        else
        {
            throw new Exception("Item not found");
        }
    }

    //finding items by ID or category
    public MenuItems GetItemById(int id)
    {
        return Items.FirstOrDefault(i => i.Id == id) ?? throw new Exception("Item not found");
    }
    public List<MenuItems> GetItemsByCategory(MenuItems.Category category)
    {
        return Items.Where(i => i.ItemCategory == category).ToList();
    }
    // Finding items by name
    public List<MenuItems> GetItemsByName(string name)
    {
        return Items.Where(i => i.Name.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();
    }
    // Finding items by price range
    public List<MenuItems> GetItemsByPriceRange(decimal minPrice, decimal maxPrice)
    {
        return Items.Where(i => i.Price >= minPrice && i.Price <= maxPrice).ToList();
    }

    // Clear the menu
    public void ClearMenu()
    {
        Items.Clear();
    }
}
