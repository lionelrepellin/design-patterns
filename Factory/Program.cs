using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Where do you want to save the data ?");
            Console.WriteLine("1 : Database");
            Console.WriteLine("2 : Xml file");
            Console.WriteLine("3 : Json file");

            var number = Console.ReadLine();
            if (int.TryParse(number, out int id))
            {
                var factory = new OutputFactory();
                var output = factory.FindById(id);
                output.Save();
            }
            else
            {
                Console.WriteLine("Enter a number please !");
            }

            Console.Read();
        }
    }
}
