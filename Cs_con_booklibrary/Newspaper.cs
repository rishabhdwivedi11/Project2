using System;
using System.Collections.Generic;
using System.Text;

namespace Cs_con_booklibrary
{
    class Newspaper
    {
        public string newspaperName;
        public int newspaperId;
        public int newspaperCount;
        public int newspaperPrice;
        public int x;
        static List<Newspaper> newspaperList = new List<Newspaper>();

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

            foreach (Newspaper N in newspaperList)
            {
                Console.WriteLine("ID- {0}   Name- {1, -25}   Price- {2}   Count = {3}", N.newspaperId, N.newspaperName, N.newspaperPrice, N.newspaperCount);
            }
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
