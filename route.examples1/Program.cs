using System.IO.Enumeration;
namespace route.examples1
{
    class Program
    {
     
        class Book
        {
            public string title;
            public int pages;
        }

        static void Main(string[] args)
        {    Book book = new Book();
            book.title = "OLIVERTWIST"; 
            book.pages = 1200;
            object obj = book;
            Console.WriteLine(obj);
            Console.WriteLine(book.ToString());
            Console.WriteLine(book.Equals(book) );
            Console.WriteLine(book.GetHashCode() );
            Console.WriteLine(book.GetType());

            try
            {
                int num1 = 10;
                int num2 = 0;
                int result = num1 / num2;

            }
            catch (DivideByZeroException ex)

            {
                Console.WriteLine($" cannot divide by zero  ");

            }
            finally {
                Console.WriteLine($" done ");
            }
            int pages = 300;
            double dpages = pages;
            Console.WriteLine (dpages);
            double price = 49.99;
            int iprice= (int)price;
            Console.WriteLine(iprice);
            string pagesText = "464";
           int ipages= Convert.ToInt32(pagesText);
            Console.WriteLine(ipages);
            string YearText = "2023";
            int iyearText = int.Parse(YearText);
            Console.WriteLine(iyearText);
            string BadText = "abc";
            bool BT = int .TryParse(BadText,out int res);

            if (BT == true) {
                Console.WriteLine(res);
            }else Console.WriteLine("invalid number");

            int pages2 = 464;
            pages2.ToString();
            Console.WriteLine(pages2.GetType() );
            int copies = 100;
            object obj2=copies;
            int newCopies = (int)obj2;
            Console.WriteLine(obj2);
            Console.WriteLine(newCopies);
            int? year = null;
            Console.WriteLine( year ?? 0);
            year = 2023;
            Console.WriteLine(year);
            string ? reviewer = null;
            Console.WriteLine(reviewer ?? "NULL");
            Book book2= new Book();
            Console.WriteLine(book.title);
            Console.WriteLine(book2.title ?? "untitled") ;

}
    }
}