
using System;
using static com.sun.tools.javac.tree.JCTree;
using static com.sun.xml.@internal.bind.v2.runtime.reflect.Lister;
using static javax.jws.soap.SOAPBinding;

namespace route.examples1
{
    class Program
    {

        #region QUESTION1
       // Create a Book class with a Title(string) and Pages(int). Create a Book object and store it 
      //in a variable of type object.Print it.
        class Book
        {
            public string title;
            public int pages;
        }

        static void Main(string[] args)
        {
            Book book = new Book();
            book.title = "OLIVERTWIST";
            book.pages = 1200;

            object obj = book;
            Console.WriteLine(obj);
        #endregion
            #region QUESTION2
           // Using the Book class above, print the result of calling ToString(), Equals() (compare book
           //with itself), GetHashCode(), and GetType() on book.

            Console.WriteLine(book.ToString());
            Console.WriteLine(book.Equals(book));
            Console.WriteLine(book.GetHashCode());
            Console.WriteLine(book.GetType());
#endregion
            #region QUESTION3
            //Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot 
             //divide by zero", and then prints "Done" in a finally block.
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
            finally
            {
                Console.WriteLine($" done ");
            }
            #endregion
            #region QUESTION4
            // Declare an int pages = 300; then store it in a double variable without using a cast.
            int pages = 300;
            double dpages = pages;
            Console.WriteLine(dpages);
            #endregion
            #region QUESTION5
            // Declare a double price = 49.99; then convert it into an int using a cast.
            double price = 49.99;
            int iprice = (int)price;
            Console.WriteLine(iprice);
            #endregion
            #region QUESTION6
            // conveting it intoan int using Convert class.
            string pagesText = "464";
            int ipages = Convert.ToInt32(pagesText);
            Console.WriteLine(ipages);
            #endregion
            #region QUESTION7
            // Given string yearText = "2023";, convert it using int.Parse().Then given string badText =
            // "abc";, use int.TryParse() to safely try converting it, and print "Invalid number" if it fails.
            string YearText = "2023";
            int iyearText = int.Parse(YearText);
            Console.WriteLine(iyearText);
            string BadText = "abc";
            bool BT = int.TryParse(BadText, out int res);

            if (BT == true)
            {
                Console.WriteLine(res);
            }
            else Console.WriteLine("invalid number");
            #endregion

            #region QUESTION8
            //Given int pages = 464;, convert it into a string using ToString() and print its type using
           //GetType() to prove it's now a string.
            int pages2 = 464;
            string ptext = pages2.ToString();
            Console.WriteLine(ptext);
            Console.WriteLine(ptext.GetType());
            #endregion
            #region QUESTION9
           // Declare int copies = 100;. Box it into an object variable, then unbox it back into a new int
            // variable, and print both.
            int copies = 100;
            object obj2 = copies;
            int newCopies = (int)obj2;
            Console.WriteLine(obj2);
            Console.WriteLine(newCopies);
            #endregion
            #region QUESTION10
            //Declare an int? year = null;. Print whether it has a value, then assign it 2023 and print its
             //value.
            int? year = null;
            Console.WriteLine(year ?? 0);
            year = 2023;
            Console.WriteLine(year);
            #endregion
            #region QUESTION11
            // Declare a string? reviewer = null;. Print whether it is null.
            string? reviewer = null;
            Console.WriteLine(reviewer ?? "NULL");
            #endregion
            #region QUESTION12
            //Declare a Book? book = null;. Use?.to safely read book.Title without crashing the
//program, and print the result.
            Book book2 = new Book();
            Console.WriteLine(book.title);
            #endregion

            #region QUESTION13
          //  Using title from the previous question, use ?? to print "Untitled" if title is null.Then use ??=
//to assign title the value "Untitled" only if it's still null.
            Console.WriteLine(book2.title ?? "untitled");
            #endregion

            #region QUESTION14
           // Given string? name = "Ahmed"; (you are sure it's not null here), assign it to a non-nullable
            //string confirmedName using the ! operator.
            // didnt know the answer for this question so i searched .
            string? name = "Ahmed";

            string confirmedName = name!;

            Console.WriteLine(confirmedName);

            #endregion
        }
    }
}