using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab8
{
    class Program
    {
        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        static void Main()
        {
            Console.WriteLine("=== Lab 8 ===");

            List<int> nums = new List<int> { 1, 2, 3, 4, 11 };
            List<string> strs = new List<string> { "hi", "hello", "abc" };
            List<Person> people = new List<Person>
            {
                new Person { Name = "Alice", Age = 20 },
                new Person { Name = "Bob", Age = 25 },
                new Person { Name = "Alice", Age = 30 }
            };

            // Task 1
            Console.WriteLine("Even Numbers: " + string.Join(", ", GetEvenNumbers(nums)));

            // Task 2
            Console.WriteLine("Sum: " + GetSum(nums));

            // Task 3
            Console.WriteLine("Long Strings: " + string.Join(", ", GetLongStrings(strs)));

            // Task 4
            var p = FindPersonByName(people, "Alice");
            Console.WriteLine($"Found Person: {p?.Name}, Age {p?.Age}");

            // Task 5
            Console.WriteLine("Descending: " + string.Join(", ", SortDescending(nums)));

            // Task 6
            var grouped = GroupByAge(people);
            foreach (var g in grouped)
                Console.WriteLine($"Age: {g.Key}, Count: {g.Count()}");

            // Task 7
            Console.WriteLine("Any > 10: " + AnyNumberGreaterThanTen(nums));

            // Task 8
            Console.WriteLine("Names: " + string.Join(", ", SelectNames(people)));

            // Task 9
            Console.WriteLine("All Positive: " + AllPositive(nums));

            // Task 10
            Console.WriteLine("Concatenated: " + string.Join(", ", ConcatenateLists(nums, new List<int> { 5, 6 })));
        }

        static IEnumerable<int> GetEvenNumbers(List<int> numbers) => numbers.Where(n => n % 2 == 0);
        static int GetSum(List<int> numbers) => numbers.Sum();
        static IEnumerable<string> GetLongStrings(List<string> strings) => strings.Where(s => s.Length > 3);
        static Person FindPersonByName(List<Person> list, string name) => list.FirstOrDefault(p => p.Name == name);
        static IEnumerable<int> SortDescending(List<int> numbers) => numbers.OrderByDescending(n => n);
        static IEnumerable<IGrouping<int, Person>> GroupByAge(List<Person> people) => people.GroupBy(p => p.Age);
        static bool AnyNumberGreaterThanTen(List<int> numbers) => numbers.Any(n => n > 10);
        static IEnumerable<string> SelectNames(List<Person> people) => people.Select(p => p.Name);
        static bool AllPositive(List<int> numbers) => numbers.All(n => n > 0);
        static IEnumerable<int> ConcatenateLists(List<int> a, List<int> b) => a.Concat(b);
    }
}
