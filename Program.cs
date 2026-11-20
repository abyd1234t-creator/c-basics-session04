namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region point 1,2
            double[] prices = [25.5, 40.0, 33.75];
            Console.WriteLine(prices[1]);
            int[,] shelfCopies =
            {
                {3,5 },
                {1,4 }
            };
            Console.WriteLine(shelfCopies[1, 0]);
            #endregion
            #region point 3
            PrintWelcomeMessage();
            #endregion
            #region 6
            double[] Dprice = { 25.5, 40.0 };
            ApplyDiscount(Dprice);
            Console.WriteLine(Dprice[0]);
            #endregion
            #region point 4,5,7
            PrintBookTitle("Clean code");
            int pages = 400;
            AddBonusPages(pages);
            Console.WriteLine( pages);// 400 لان دا value type
            int refpages = 400;
            AddBonusPagesByRef( ref pages);
            Console.WriteLine(pages);//450 عشان دا ref
            #endregion
            #region point 8
            double[] price = { 10.5, 11.5 };
            ReplaceArray(ref price);
            Console.WriteLine(price.Length);
            #endregion
            #region point 9
            double Bprice;
            bool result = TryGetPrice("Clean Code", out Bprice);
            Console.WriteLine(result);
            Console.WriteLine(Bprice);
            #endregion
            #region 10
            PrintBookInfo("Clean Code");
            PrintBookInfo("C#", 200);
            PrintBookInfo(pages: 350, title: "session4");
            
            #endregion
            #region 11
            string[] titles = { "route", "nasr city", "new cairo" };
            PrintAllTitles( titles);
            PrintAllTitles("route", "nasr city", "new cairo");
            #endregion
        }
        static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Library!");
        }
        static void PrintBookTitle(string title)
        {
            Console.WriteLine("Book title:" + title);
        }
        static void AddBonusPages(int pages)
        {
          pages+=50;
        }
        static void AddBonusPagesByRef(ref int pages)
        {
            pages += 50;
        }
        static void ReplaceArray(ref double[] prices)
        {
            prices = [15.0, 12.5, 10.0 ];
        }
        static bool TryGetPrice(string title, out double price)
        {
            if (title== "Clean Code")
            {
                price = 25.5;
                return true;
            }
            else
            {
                price = 0;
                return false;
            }
            Console.WriteLine(price);
        }
        static void PrintBookInfo(string title, int pages = 300)
        {
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Pages: " + pages);
        }
        static void PrintAllTitles(params string[] titles)
        {
            for(int i = 0; i < titles.Length; i++)
            {
                Console.WriteLine(titles[i]);
            }
        }
        static void ApplyDiscount(double[] prices)
        {
            prices[0] -= 5;
        }
    }
}
