using System;
using System.Collections.Generic;
using System.Text;

namespace Cs_con_booklibrary
{
    class Borrower
    {
        public int userId;
        public string userName;
        public string userAddress;
        public int borrowBookId;
        public int borrowNewspaperId;
        public DateTime borrowDate;
        public int borrowCount;

        static List<Borrower> borrowList = new List<Borrower>();
        static Borrower borrow = new Borrower();
        static List<Books> bookList = new List<Books>();
        static List<Newspaper> newspaperList = new List<Newspaper>();
        public static void BorrowBook()
        {
            Books book = new Books();
            Borrower borrow = new Borrower();
            Console.WriteLine("User id : {0}", (borrow.userId = borrowList.Count + 1));
            Console.Write("Name :");

            borrow.userName = Console.ReadLine();

            Console.Write("Book id :");
            borrow.borrowBookId = int.Parse(Console.ReadLine());
            Console.Write("Number of Books : ");
            borrow.borrowCount = int.Parse(Console.ReadLine());
            Console.Write("Address :");
            borrow.userAddress = Console.ReadLine();
            borrow.borrowDate = DateTime.Now;
            Console.WriteLine("Date - {0} and Time - {1}", borrow.borrowDate.ToShortDateString(), borrow.borrowDate.ToShortTimeString());

            if (bookList.Exists(x => x.bookId == borrow.borrowBookId))
            {
                foreach (Books searchId in bookList)
                {
                    if (searchId.bookCount >= searchId.bookCount - borrow.borrowCount && searchId.bookCount - borrow.borrowCount >= 0)
                    {
                        if (searchId.bookId == borrow.borrowBookId)
                        {
                            searchId.bookCount = searchId.bookCount - borrow.borrowCount;
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Only {0} books are found", searchId.bookCount);
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Book id {0} not found", borrow.borrowBookId);
            }
            borrowList.Add(borrow);
        }

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

        public static void BorrowNewspaper()
        {
            Newspaper newspaper = new Newspaper();
            Borrower borrow = new Borrower();
            Console.WriteLine("User id : {0}", (borrow.userId = borrowList.Count + 1));
            Console.Write("Name :");

            borrow.userName = Console.ReadLine();

            Console.Write("Newspaper id :");
            borrow.borrowNewspaperId = int.Parse(Console.ReadLine());
            Console.Write("Number of Newspaper : ");
            borrow.borrowCount = int.Parse(Console.ReadLine());
            Console.Write("Address :");
            borrow.userAddress = Console.ReadLine();
            borrow.borrowDate = DateTime.Now;
            Console.WriteLine("Date - {0} and Time - {1}", borrow.borrowDate.ToShortDateString(), borrow.borrowDate.ToShortTimeString());

            if (newspaperList.Exists(x => x.newspaperId == borrow.borrowNewspaperId))
            {
                foreach (Newspaper searchId in newspaperList)
                {
                    if (searchId.newspaperCount >= searchId.newspaperCount - borrow.borrowCount && searchId.newspaperCount - borrow.borrowCount >= 0)
                    {
                        if (searchId.newspaperId == borrow.borrowNewspaperId)
                        {
                            searchId.newspaperCount = searchId.newspaperCount - borrow.borrowCount;
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Only {0} newspaper are found", searchId.newspaperCount);
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Newspaper id {0} not found", borrow.borrowNewspaperId);
            }
            borrowList.Add(borrow);
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
