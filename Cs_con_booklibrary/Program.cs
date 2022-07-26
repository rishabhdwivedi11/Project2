using System;
using System.Collections.Generic;
using System.Threading;

namespace Cs_con_booklibrary
{

    
    class Program
    {
        static List<Books> bookList = new List<Books>();
        static List<Newspaper> newspaperList = new List<Newspaper>();
        static List<Borrower> borrowList = new List<Borrower>();
        static Books book = new Books();
        static Newspaper newspaper = new Newspaper();
        static Borrower borrow = new Borrower();
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("   Welcome To My Library    ");
           
            Console.WriteLine("Choose who you are : ");
            Console.WriteLine("\nMenu\n"
                + "1) Librarian\n"
                + "2) Borrower");
            Console.WriteLine();
            Console.WriteLine("Choose option from menu");
            int opt1 = int.Parse(Console.ReadLine());
            if (opt1 == 1)
            {
                Console.WriteLine("May I know your choice?");
                Console.WriteLine("\nMenu\n" +
                                    "1) Book \n" +
                                    "2) Newspaper");
                Console.WriteLine();
                Console.WriteLine("Choose option from menu");
                int opt2 = int.Parse(Console.ReadLine());
                if (opt2 == 1)
                {
                    Console.WriteLine("\nMenu\n" +
                                    "1) Add Book \n" +
                                    "2) Remove Book\n" +
                                    "3) Search Book\n" +
                                    "4) Retun Book\n");
                                    
                    Console.WriteLine();
                    Console.WriteLine("Choose option from menu");
                    int opt3 = int.Parse(Console.ReadLine());
                    if (opt3 == 1)
                    {
                        Books.AddBook();

                    }

                    else if (opt3 == 2)
                    {
                        Books.DelBook();
                    }
                    else if (opt3 == 3)
                    {
                        Books.SearchBook();
                    }
                    else if (opt3 == 4)
                    {
                        Books.ReturnBook();
                    }
                    
                    else
                    {
                        Console.WriteLine("You entered wrong choice.");
                    }

                }
                if (opt2 == 2)
                {
                    Console.WriteLine("\nMenu\n" +
                                    "1) Add Newspaper \n" +
                                    "2) Remove Newspaper\n" +
                                    "3) Search Newspaper\n" +
                                    "4) Retun Newspaper");
                                   
                    Console.WriteLine();
                    Console.WriteLine("Choose option from menu");
                    int opt3 = int.Parse(Console.ReadLine());
                    if (opt3 == 1)
                    {
                        Newspaper.AddNewspaper();
                    }
                    else if (opt3 == 2)
                    {
                        Newspaper.DelNewspaper();
                    }
                    else if (opt3 == 3)
                    {
                        Newspaper.SearchNewspaper();
                    }
                    else if (opt3 == 4)
                    {
                        Newspaper.ReturnNewspaper();
                    }
                    else
                    {
                        Console.WriteLine("You entered wrong choice.");
                    }

                }

            }
            if (opt1 == 2)
            {
                Console.WriteLine("May i know your choice?");
                Console.WriteLine("\nMenu\n" +
                                    "1) Book \n" +
                                    "2) Newspaper");
                Console.WriteLine();
                Console.WriteLine("Choose option from menu");
                int opt2 = int.Parse(Console.ReadLine());
                if (opt2 == 1)
                {
                    Console.WriteLine("\nMenu\n" +
                                    "1)Borrow book\n" +
                    "2)Search book\n" +
                    "3)Return book");
                    
                    Console.WriteLine();
                    Console.WriteLine("Choose option from menu");
                    int opt3 = int.Parse(Console.ReadLine());
                    if (opt3 == 1)
                    {
                        Borrower.BorrowBook();
                    }
                    else if (opt3 == 2)
                    {
                        Borrower.SearchBook();
                    }

                    else if (opt3 == 3)
                    {
                        Books.ReturnBook();
                    }
                    else
                    {
                        Console.WriteLine("You entered wrong choice.");
                    }

                }
                if (opt2 == 2)
                {
                    Console.WriteLine("\nMenu\n" +
                                    "1) Borrow Newspaper \n" +
                                    "2) Return Newspaper\n" +
                                    "3) Search Newspaper");
                    Console.WriteLine();
                    Console.WriteLine("Choose option from menu");
                    int opt3 = int.Parse(Console.ReadLine());
                    if (opt3 == 1)
                    {
                        Borrower.BorrowNewspaper();
                    }
                    else if (opt3 == 2)
                    {
                        Borrower.ReturnNewspaper();
                    }
                    else if (opt3 == 3)
                    {
                        Newspaper.SearchNewspaper();
                    }
                    else
                    {
                        Console.WriteLine("You entered wrong choice.");
                    }

                }

            }
            Thread.Sleep(2000);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Could you come again!!!");
            Console.WriteLine();
            Console.WriteLine();
            function();                            //For Continuously Running the Application 
        }
        public static void function()
        {
            Main(null);
        }
    }
}
    



