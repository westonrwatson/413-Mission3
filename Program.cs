// Weston Watson, Section 3, Team 3
namespace Mission3;
class Program
{
    static FoodItem _fi = new FoodItem();
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Weston's Food Bank");
        while (true)
        {
            
            // Menu
            Console.WriteLine("Enter the number of what you would like to do:" +
                              "\n 1. Add an Item?" +
                              "\n 2. Remove an Item?" +
                              "\n 3. Display All Items?" +
                              "\n 4. Exit Food Bank");
            
            // Get menu selection once per loop iteration
            int selection = GetMenuSelection();
            
            // Add Item
            if (selection == 1)
            {
                addItem();
                continue;
            }

            // Remove Item
            if (selection == 2)
            {
                _fi.RemoveFoodItem();
                continue;
            }

            // Display Items
            if (selection == 3)
            {
                _fi.DisplayAllFoodDetails();
                continue;
            }
            
            // Exit
            if (selection == 4)
            {
                Console.WriteLine("Exiting the program. Thank you for using Weston's Food Bank!");
                break;
            }
        }
    }
    
    // Method to validate menu selection
    static int GetMenuSelection()
    {
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int response) && response >= 1 && response <= 4)
            {
                return response;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 4:");
            }
        }
    }
    
    static void addItem()
    {
        // User Input Food Name
        Console.Write("Enter Food Name: ");
        string foodName = Console.ReadLine()?.Trim().ToLower();
        _fi.AddFoodName(foodName);
        
        // User Input Food Category
        Console.Write("Enter Category: ");
        string foodCategory = Console.ReadLine();
        _fi.AddCategory(foodCategory);
        
        // User Input Food Quantity
        int foodQuantity = -1;
        while (foodQuantity <= 0)
        {
            Console.Write("Enter Quantity By Units (must be a positive number): ");

            // Validate input
            if (int.TryParse(Console.ReadLine(), out foodQuantity) && foodQuantity > 0)
            {
                _fi.AddQuantity(foodQuantity);
            }
            else
            {
                Console.WriteLine("Invalid input. Quantity must be a positive number!");
                foodQuantity = -1;
            }
        }
        
        // User Input Food Expiration Date
        Console.Write("Enter Food Expiration Date: ");
        string foodExpirationDate = Console.ReadLine();
        _fi.AddExpirationDate(foodExpirationDate);
    }
}