using System;
using System.Collections.Generic;
public class Program
{
    public static void Main()
    {
        Menu menu = new Menu(); 

        MenuItem item1 = new MenuItem
        {
            Name = "Parisien Cheese",
            Price = 13.00,
            Description = "Warm ricotta cheese, Nicoise olives, tomato confit, olive oil and fresh herbs. Served with toasted crostini",
            Category = "Appetizer",
            IsNew = false
        };

        menu.AddItem(item1);

        MenuItem item2 = new MenuItem
        {
            Name = "Salmon",
            Price = 28.00,
            Description = "Potato encrusted salmon topped with lenon beurre blanc. Served with haricot verts and garnish with arugula salad",
            Category = "Entrees",
            IsNew = true
        };

        menu.AddItem(item2);

         MenuItem item3 = new MenuItem
        {
            Name = "Chocolate Mousse Cake",
            Price = 10.00,
            Description = "It's just cake man",
            Category = "Dessert",
            IsNew = false
        };

        menu.AddItem(item3);

        //Display the menu
        Console.WriteLine("Menu (last updated {0}):)", menu.lastUPdated);
        foreach (MenuItem item in menu.Items)
        {
            Console.WriteLine("{0} ({1}): {2}", item.Name, item.Price.ToString("C"), item.Description);
            Console.WriteLine("Category: {0}", item.Category);
            if(item.IsNew)
            {
                Console.WriteLine("This is a new item!");

            }
            Console.WriteLine();
        }

        
    }
}