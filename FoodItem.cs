// Weston Watson, Section 3, Team 3
namespace Mission3;

// Food Item Class
public class FoodItem
{
    // Private lists to store food details
    private List<string> _names;
    private List<string> _categories;
    private List<int> _quantities;
    private List<string> _expiration;

    // Constructor to initialize the lists
    public FoodItem()
    {
        _names = new List<string>();
        _categories = new List<string>();
        _quantities = new List<int>();
        _expiration = new List<string>();
    }

    // Method to add a food name
    public void AddFoodName(string name)
    {
        _names.Add(name);
    }

    // Method to add a category
    public void AddCategory(string category)
    {
        _categories.Add(category);
    }

    // Method to add quantity
    public void AddQuantity(int quantity)
    {
        _quantities.Add(quantity);
    }

    // Method to add expiration date
    public void AddExpirationDate(string date)
    {
        _expiration.Add(date);
    }
    
    // Method to remove all info about a food item by name
    public void RemoveFoodItem()
    {
        if (_names.Count == 0)
        {
            Console.WriteLine("No food items entered. Please add food items first.");
        }
        else
        {
            // Display Possible Food Names to Remove
            Console.WriteLine("--- Food Names ---");
            for (int i = 0; i < _names.Count; i++)
            {
                Console.WriteLine(_names[i]);
            }
            
            // Prompt to Remove
            Console.WriteLine("What Food Item would you like to remove??");
            string name = Console.ReadLine()?.Trim().ToLower();
            
            // Remove Food Item
            int index = _names.IndexOf(name);
            if (index != -1)
            {
                _names.RemoveAt(index);
                _categories.RemoveAt(index);
                _quantities.RemoveAt(index);
                _expiration.RemoveAt(index);
            }
            else
            {
                Console.WriteLine("Food item '" + name + "' not found.");
                RemoveFoodItem();
            }
        }
    }

    // Method to display all food items
    public void DisplayAllFoodDetails()
    {
        if (_names.Count == 0)
        {
            Console.WriteLine("No food items entered. Please add food items first.");
        }
        else
        {
            Console.WriteLine("\n--- Food Item Details ---");

            for (int i = 0; i < _names.Count; i++)
            {
                Console.WriteLine("Item " + (i + 1));
                Console.WriteLine("  Name: " + _names[i]);
                Console.WriteLine("  Category: " + _categories[i]);
                Console.WriteLine("  Quantity: " + _quantities[i] + " Units");
                Console.WriteLine("  Expiration: " + _expiration[i] + "\n");
            }
        }
    }
}