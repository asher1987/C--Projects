using System;
using System.Collections.Generic;
// first class that lays out all of the properties of the MenuItem class

public class MenuItem
{
public string Name { get; set;}
public Double Price { get; set;}
public string Description { get; set;}
public string Category { get; set;}
public bool IsNew { get; set;}
}

// this is the second required class. 
// it contains the ability to show when the menu was last updated and the ability to 
// add items 
public class Menu
{
    public DateTime lastUPdated { get; set;}
    public List<MenuItem> Items { get; set;}

    public Menu() // this is a constructor
    {
        // these two lines of code ensure that every new instance of the 'Menu' class is created with an empty list of menu items
        // and the current date and time as the initial value of the 'LastUpdated' property 

        Items = new List<MenuItem>(); 
        // we are initializing 'Items' properties of the 'Menu' object that is being constructed
        lastUPdated = DateTime.Now; 
        // sets the 'LastUpdated' property to the current date and time using the 'DateTime.Now' property.
        // this initializes the "LastUpdated property to the current date and time.  

    } 

  // AddItem(MenuItem item) is a public method of the 'Menu' class that takes a 'MenuItem' object
        // as a paramter and adds it to the 'Items' list of the 'Menu' object. This method also updates the 
        // 'LastUpdated' property of the 'Menu' object to the current date and time, indicating that the menu was 
        // recently updated
    public void AddItem(MenuItem item){
        Items.Add(item); // this line adds the MenuItem object passed as the 'item' parameter to the list
        lastUPdated = DateTime.Now; // this line is used to update the 'LastUpdated' property every time a new item is added
     

    }

    public void RemoveItem(MenuItem item)
    {
        Items.Remove(item); // this line removes MenuItem object 
        lastUPdated = DateTime.Now; // this line is used to update the 'LastUpdated' property every time something is removed
    }
}
