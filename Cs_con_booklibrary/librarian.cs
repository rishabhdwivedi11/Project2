using System;
using System.Collections.Generic;
using System.Text;

namespace Cs_con_booklibrary
{
    class librarian
    {

        static List<Books> bookList = new List<Books>();
        static List<Newspaper> newspaperList = new List<Newspaper>();
        
        static Books book = new Books();
        static Newspaper newspaper = new Newspaper();


        public static void AddBook()
        {
            Books book = new Books();
            Console.WriteLine("Book Id:{0}", book.bookId = bookList.Count + 1);
            Console.Write("Book Name:");
            book.bookName = Console.ReadLine();
            Console.Write("Book Price:");
            book.bookPrice = int.Parse(Console.ReadLine());
            Console.Write("Number of Books:");
            book.x = book.bookCount = int.Parse(Console.ReadLine());
            bookList.Add(book);
        }

        //To delete book details 
        public static void DelBook()
        {
            Books book = new Books();
            Console.Write("Enter Book id to be deleted : ");

            int Del = int.Parse(Console.ReadLine());

            if (bookList.Exists(x => x.bookId == Del))
            {
                bookList.RemoveAt(Del - 1);
                Console.WriteLine("Book id - {0} has been deleted", Del);
            }
            else
            {
                Console.WriteLine("Invalid Book id");
            }

            bookList.Add(book);
        }

        //To search book details from the Library database using Book id 
        public static void SearchBook()
        {
            Books book = new Books();
            Console.Write("Search by BOOK id :");
            int find = int.Parse(Console.ReadLine());

            if (bookList.Exists(x => x.bookId == find))
            {
                foreach (Books searchId in bookList)
                {
                    if (searchId.bookId == find)
                    {
                        Console.WriteLine("Book id :{0}\n" +
                        "Book name :{1}\n" +
                        "Book price :{2}\n" +
                        "Book Count :{3}", searchId.bookId, searchId.bookName, searchId.bookPrice, searchId.bookCount);
                    }
                }
            }
            else
            {
                Console.WriteLine("Book id {0} not found", find);
            }
        }



        //To return borrowed book to the library 
        public static void ReturnBook()
        {
            Books book = new Books();
            Console.WriteLine("Enter following details :");

            Console.Write("Book id : ");
            int returnId = int.Parse(Console.ReadLine());

            Console.Write("Number of Books:");
            int returnCount = int.Parse(Console.ReadLine());

            if (bookList.Exists(y => y.bookId == returnId))
            {
                foreach (Books addReturnBookCount in bookList)
                {
                    if (addReturnBookCount.x >= returnCount + addReturnBookCount.bookCount)
                    {
                        if (addReturnBookCount.bookId == returnId)
                        {
                            addReturnBookCount.bookCount = addReturnBookCount.bookCount + returnCount;
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Count exists the actual count");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Book id {0} not found", returnId);
            }
        }

        public static void AddNewspaper()
        {
            Newspaper newspaper = new Newspaper();
            Console.WriteLine("Newspaper Id:{0}", newspaper.newspaperId = newspaperList.Count + 1);
            Console.Write("Newspaper Name:");
            newspaper.newspaperName = Console.ReadLine();
            Console.Write("Newspaper Price:");
            newspaper.newspaperPrice = int.Parse(Console.ReadLine());
            Console.Write("Number of Newspaper:");
            newspaper.x = newspaper.newspaperCount = int.Parse(Console.ReadLine());
            newspaperList.Add(newspaper);
        }





        public static void DelNewspaper()
        {
            Newspaper newspaper = new Newspaper();
            Console.Write("Enter Newspaper id to be deleted : ");

            int Del = int.Parse(Console.ReadLine());

            if (newspaperList.Exists(x => x.newspaperId == Del))
            {
                newspaperList.RemoveAt(Del - 1);
                Console.WriteLine("Newspaper id - {0} has been deleted", Del);
            }
            else
            {
                Console.WriteLine("Invalid Newspaper id");
            }

            newspaperList.Add(newspaper);
        }




        public static void SearchNewspaper()
        {
            Newspaper newspaper = new Newspaper();
            Console.Write("Search by Newspaper id :");
            int find = int.Parse(Console.ReadLine());

            if (newspaperList.Exists(x => x.newspaperId == find))
            {
                foreach (Newspaper searchId in newspaperList)
                {
                    if (searchId.newspaperId == find)
                    {
                        Console.WriteLine("newspaper id :{0}\n" +
                        "Newspaper name :{1}\n" +
                        "Newspaper price :{2}\n" +
                        "Newspaper Count :{3}", searchId.newspaperId, searchId.newspaperName, searchId.newspaperPrice, searchId.newspaperCount);
                    }
                }
            }
            else
            {
                Console.WriteLine("Newspaper id {0} not found", find);
            }
        }



        public static void ReturnNewspaper()
        {
            Newspaper newspaper = new Newspaper();
            Console.WriteLine("Enter following details :");

            Console.Write("Newspaper id : ");
            int returnId = int.Parse(Console.ReadLine());

            Console.Write("Number of Newspaper:");
            int returnCount = int.Parse(Console.ReadLine());

            if (newspaperList.Exists(y => y.newspaperId == returnId))
            {
                foreach (Newspaper addReturnNewspaperCount in newspaperList)
                {
                    if (addReturnNewspaperCount.x >= returnCount + addReturnNewspaperCount.newspaperCount)
                    {
                        if (addReturnNewspaperCount.newspaperId == returnId)
                        {
                            addReturnNewspaperCount.newspaperCount = addReturnNewspaperCount.newspaperCount + returnCount;
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Count exists the actual count");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Newspaper id {0} not found", returnId);
            }
        }
    }

}

