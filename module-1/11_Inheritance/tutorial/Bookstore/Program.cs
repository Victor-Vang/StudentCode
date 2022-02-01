using System;

namespace TechElevator.Bookstore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Tech Elevator Bookstore");
            Console.WriteLine();

            // Step Three: Test the getters and setters
            MediaItem twoCities = new MediaItem();
            twoCities.Title = "A Tale of Two Cities";
            twoCities.Author = "Charles Dickens";
            twoCities.Price = 14.99M;

            // Step Five: Test the Book constructor
            MediaItem threeMusketeers = new MediaItem("The Three Musketeers", "Alexandre Dumas", 12.95M);
            MediaItem childhoodEnd = new MediaItem("Childhood's End", "Arthur C. Clark", 5.99M);

            // Step Nine: Test the ShoppingCart class
            ShoppingCart shoppingCart = new ShoppingCart();
            shoppingCart.Add(twoCities);
            shoppingCart.Add(threeMusketeers);
            shoppingCart.Add(childhoodEnd);
            Console.WriteLine(shoppingCart.GetReceipt());
        }
    }
}
