using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            // these two books have a different base price
            BasePhotoBook book = new PrestigePhotoBook();
            //BasePhotoBook book = new ModernPhotoBook();

            // comment an option or change the option price 
            // and the total amount will change
            book = new GlossPaperOption(book, 3.95);
            book = new GlossCoverOption(book, 2.95);
            book = new RibbonOption(book, 1.95);
            
            Console.WriteLine(book.Description);
            
            Console.Read();
        }
    }
}