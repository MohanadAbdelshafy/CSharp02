namespace C_Basics_02
{
    #region BookClass
    //public class Book
    //{
    //    public string Title;
    //    public int Pages;
    //}
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Createing and printing Book Object
            //Book b1 = new Book();
            //object obj= b1;
            //Console.WriteLine(obj);
            #endregion
            #region Object Functions
            //Console.WriteLine(book.ToString());
            //Console.WriteLine(book.Equals(book));
            //Console.WriteLine(book.GetHashCode());
            //Console.WriteLine(book.GetType());
            #endregion
            #region compile-time error, a runtime error, or a logical error?
            //Compile-time error
            //int pages = 464;
            #endregion
            #region code that divides 10 by 0 inside a try block
            //int a = 10;
            //int b = 0;
            //try
            //{
            //    Console.WriteLine(a/b);

            //}
            //catch (DivideByZeroException ex) {
            //    Console.WriteLine($"Error: Division by zero is not allowed.{ex.Message}");
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            //}
            //finally
            //{
            //    Console.WriteLine("Done.");
            //}
            #endregion
            #region Implicit Conversion
            //int pages = 300;
            //double doublePages = pages;
            //Console.WriteLine(doublePages);
            #endregion
            #region Explicit Conversion
            //double price = 49.99;
            //int intPrice = (int)price; 
            //Console.WriteLine(intPrice);
            #endregion
            #region Convert class.
            //string pagesText = "464";
            //int pages = Convert.ToInt32(pagesText);
            //Console.WriteLine(pages);
            #endregion
            #region Parse and TryParse
            //string yearText = "2023";
            //int year=int.Parse(yearText);
            //string badText = "abc";
            //if(int.TryParse(badText,out int num)) 
            //{
            //    Console.WriteLine(num);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid number");
            //}
            #endregion
            #region ToString Conversion
            //int pages = 464;
            //string pagesText = pages.ToString();
            //Console.WriteLine(pagesText.GetType());
            #endregion
            #region Boxing and Unboxing
            //int copies = 100;
            //object boxedCopies = copies;
            //int newCopies = (int)boxedCopies;

            //Console.WriteLine(boxedCopies);
            //Console.WriteLine(newCopies);
            #endregion
            #region null type
            //int? year = null;

            //Console.WriteLine(year != null);

            //year = 2023;

            //Console.WriteLine(year);
            #endregion
            #region Null string
            //string? reviewer = null;
            //Console.WriteLine(reviewer == null);
            #endregion
        }
    }
}
