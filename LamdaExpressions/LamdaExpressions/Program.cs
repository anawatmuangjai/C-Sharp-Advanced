using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{

    class Program
    {
        static void Main(string[] args)
        {
            // args => expression
            //number => number * number;

            // () => ...
            // x => ...
            // (x, y, z) => ...

            // Example 1
            //Func<int, int> square = number => number * number;
            //Console.WriteLine(square(5));

            // Example 2
            //const int factor = 5;
            //Func<int, int> multiplar = n => n * factor;
            //var result = multiplar(10);
            //Console.WriteLine(result);

            // Example 3
            var books = new BookRepository().GetBooks();

            // Use predicate
            //var cheaperBooks1 = books.FindAll(IsCheaperThan10Dollars);

            // Use lambda 
            var cheaperBooks2 = books.FindAll(book => book.Price < 10);

            foreach (var book in cheaperBooks2)
            {
                Console.WriteLine(book.Title);
            }
        }

        // Predicate method
        static bool IsCheaperThan10Dollars(Book book)
        {
            return book.Price < 10;
        }
    }
}
