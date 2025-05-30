 public class Program
    {
        public static void Main()
        {
            Console.WriteLine("=== LINQ Query Syntax ===");
            QuerySyntaxExample();

            Console.WriteLine("\n\n=== LINQ Method Syntax ===");
            MethodSyntaxExample();

            Console.WriteLine("\n\n=== LINQ Mixed Syntax (Query + Method) ===");
            MixedSyntaxExample();

            Console.ReadKey();
        }

        // Example using LINQ Query Syntax
        private static void QuerySyntaxExample()
        {
            List<int> numbers = new List<int> { 1, 43, 56, 7, 3, 2, 90 };

            // LINQ Query Syntax
            var result = from number in numbers
                         where number > 5
                         select number;

            Console.Write("Numbers greater than 5: ");
            foreach (var item in result)
            {
                Console.Write($"{item} ");
            }
        }

        // Example using LINQ Method Syntax
        private static void MethodSyntaxExample()
        {
            List<int> numbers = new List<int> { 1, 43, 56, 7, 3, 2, 90 };

            // LINQ Method Syntax
            var result = numbers.Where(x => x > 5).ToList();

            Console.Write("Numbers greater than 5: ");
            foreach (var item in result)
            {
                Console.Write($"{item} ");
            }
        }

        // Example using Mixed LINQ Syntax (Query + Method)
        private static void MixedSyntaxExample()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // LINQ Mixed Syntax: query to filter, method to aggregate
            var sum = (from number in numbers
                       where number > 5
                       select number).Sum();

            Console.WriteLine($"Sum of numbers greater than 5: {sum}");
        }
    }
