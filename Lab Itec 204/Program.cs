using System;

namespace Lab_Itec_204
{
    class Program //Boragay, John Mark
    {
        static int bookMaxNum = 1000;
        static Book[] books = new Book[bookMaxNum]; 
        static int bookCount = 0; 

        // Struct to hold book information
        struct Book
        {
            public string Title;
            public string Author;
        }

        public static void Main(string[] args)
        {
            while (true) 
            {
                menu();
            }
        }
		
        
        // Main Mewnu
        static void menu()
        {
            Console.WriteLine("Menu \n1. Add a new Book \n2. Display all Books \n3. Exit");
            Console.Write("Enter an option: ");
            char choice = Convert.ToChar(Console.ReadLine());

            switch (choice)
            {
                case '1':
                    addBook();
                    break;

                case '2':
                    displayBook();
                    break;

                case '3':
                    exit();
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }

        static void addBook()
        {
            if (bookCount < bookMaxNum)
            {
                // Adding a new book
                Console.WriteLine();
                Console.WriteLine("Enter Data for Book " + (bookCount + 1));
                Console.Write("Enter Book Title: ");
                string title = Console.ReadLine();
                Console.Write("Enter Book Author: ");
                string author = Console.ReadLine();

                // Storing the book
                books[bookCount].Title = title;
                books[bookCount].Author = author;
                bookCount++;

                Console.WriteLine("Book added successfully!\n");
            }
            else
            {
                Console.WriteLine("Book storage is full.\n");
            }
        }

        
        //Displaying Book
        static void displayBook()
        {
            if (bookCount == 0)
            {
                Console.WriteLine("No books to display.\n");
            }
            else
            {
                for (int i = 0; i < bookCount; i++)
                {
                    Console.WriteLine((i + 1) + ". Title: " + books[i].Title + ", Author: " + books[i].Author);
                }
                Console.WriteLine(); 
            }
        }
        
        
		// Exiting Program
        static void exit()
        {
            Console.WriteLine("Thank you for using the program!");
            Console.ReadKey();
            Environment.Exit(0);
        }
 
    }
}
