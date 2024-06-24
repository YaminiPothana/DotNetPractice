using System;
using System.Collections.Generic;

public class ToDoList
{
    private List<ToDoItem> _items = new List<ToDoItem>();
    private int _nextId = 1;

    public void AddItem(string description)
    {
        var newItem = new ToDoItem(_nextId, description);
        _items.Add(newItem);
        _nextId++;
    }

    public void ViewItems()
    {
        if (_items.Count == 0)
        {
            Console.WriteLine("No to-do items.");
        }
        else
        {
            foreach (var item in _items)
            {
                Console.WriteLine(item);
            }
        }
    }

    public void RemoveItem(int id)
    {
        var item = _items.Find(i => i.Id == id);
        if (item != null)
        {
            _items.Remove(item);
        }
        else
        {
            Console.WriteLine($"Item with ID {id} not found.");
        }
    }

    public void MarkAsCompleted(int id)
    {
        var item = _items.Find(i => i.Id == id);
        if (item != null)
        {
            item.IsCompleted = true;
        }
        else
        {
            Console.WriteLine($"Item with ID {id} not found.");
        }
    }
}