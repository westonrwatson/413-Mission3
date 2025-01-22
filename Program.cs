namespace Mission3;

class Program
{
    static FoodItem _fi = new FoodItem();
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Weston's Food Bank");
        while (true)
        {
            // Add Item
            Console.WriteLine("Would you like to add an item? (y/n):");
            if (GetYesOrNo())
            {
                addItem();
                continue;
            }

            // Remove Item
            Console.WriteLine("Would you like to remove an item? (y/n):");
            if (GetYesOrNo())
            {
                Console.WriteLine("What Food Item would you like to remove??");
                string name = Console.ReadLine()?.Trim().ToLower();
                _fi.RemoveFoodItem(name);
                continue;
            }

            // Display Items
            Console.WriteLine("Would you like to display all items? (y/n):");
            if (GetYesOrNo())
            {
                _fi.DisplayAllFoodDetails();
                continue;
            }
            
            // Exit
            Console.WriteLine("Would you like to exit? (y/n):");
            if (GetYesOrNo())
            {
                // Exit
                Console.WriteLine("Exiting the program. Thank you for using Weston's Food Bank!");
                break;
            }
        }
    }
    
    // Method to validate "y" or "n" input
    static bool GetYesOrNo()
    {
        while (true)
        {
            string response = Console.ReadLine()?.Trim().ToLower();
            if (response == "y")
            {
                return true;
            }
            else if (response == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter 'y' for yes or 'n' for no:");
            }
        }
    }

    
    static void addItem()
    {
        // User Input Food Name
        Console.WriteLine("Enter Food Name:");
        string foodName = Console.ReadLine()?.Trim().ToLower();
        _fi.AddFoodName(foodName);
        
        // User Input Food Category
        Console.WriteLine("Enter Category:");
        string foodCategory = Console.ReadLine();
        _fi.AddCategory(foodCategory);
        
        // User Input Food Quantity
        int foodQuantity = -1;

        while (foodQuantity <= 0)
        {
            Console.WriteLine("Enter Quantity By Units (must be a positive number):");

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
        Console.WriteLine("Enter Food Expiration Date");
        string foodExpirationDate = Console.ReadLine();
        _fi.AddExpirationDate(foodExpirationDate);
        
    }
}