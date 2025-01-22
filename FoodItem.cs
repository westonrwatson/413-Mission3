// Weston Watson, Section 3, Team 3

namespace Mission3;

// Food Item Class
public class FoodItem
{
    // Private lists to store food details
    private List<string> _names = new List<string>();
    private List<string> _categories = new List<string>();
    private List<int> _quantities = new List<int>();
    private List<string> _expiration = new List<string>();

    // Method to add a food name
    public void AddFoodName(string name)
    {
        _names.Add(name);
        //Console.WriteLine("Food item " + name + " added successfully!");
    }

    // Method to add a category
    public void AddCategory(string category)
    {
        _categories.Add(category);
        //Console.WriteLine("Category " + category + " added successfully!");
    }

    // Method to add quantity
    public void AddQuantity(int quantity)
    {
        _quantities.Add(quantity);
        //Console.WriteLine("Quantity " + quantity + " added successfully!");
    }

    // Method to add expiration date
    public void AddExpirationDate(string date)
    {
        _expiration.Add(date);
        //Console.WriteLine("Expiration date " + date + " added successfully!");
    }
    
    // Method to remove all info about a food item by name
    public void RemoveFoodItem(string name)
    {
        int index = _names.IndexOf(name);
        if (index != -1)
        {
            _names.RemoveAt(index);
            _categories.RemoveAt(index);
            _quantities.RemoveAt(index);
            _expiration.RemoveAt(index);

            //Console.WriteLine($"Food item '{name}' removed successfully!");
        }
        else
        {
            Console.WriteLine($"Food item '{name}' not found.");
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