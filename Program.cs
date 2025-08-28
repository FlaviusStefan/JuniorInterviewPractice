using System;
using System.Collections.Generic;
using JuniorInterviewPractice._01_DataTypes;

namespace JuniorInterviewPractice
{
    internal static class Program
    {
        private static readonly Dictionary<string, (string Title, Action Run)> Menu =
            new()
            {
                ["1"] = ("01 - Data Types", DataTypesExamples.RunAllExamples),
                ["2"] = ("02 - OOP", ComingSoon("OOP")),
                ["3"] = ("03 - Collections", ComingSoon("Collections")),
                ["4"] = ("04 - Exception Handling", ComingSoon("Exception Handling")),
                ["5"] = ("05 - LINQ", ComingSoon("LINQ")),
                ["6"] = ("06 - String Manipulation", ComingSoon("String Manipulation")),
                ["7"] = ("07 - File I/O", ComingSoon("File I/O")),
                ["8"] = ("08 - Delegates & Events", ComingSoon("Delegates & Events")),
                ["9"] = ("09 - Generics", ComingSoon("Generics")),
                ["10"] = ("10 - Async Programming", ComingSoon("Async Programming")),
                ["11"] = ("11 - Memory Management", ComingSoon("Memory Management")),
                ["12"] = ("12 - Debugging", ComingSoon("Debugging")),
                ["13"] = ("13 - Unit Testing", ComingSoon("Unit Testing")),
                ["14"] = ("14 - Design Patterns", ComingSoon("Design Patterns")),
                ["15"] = ("15 - Advanced", ComingSoon("Advanced Topics")),
                ["0"] = ("Exit", () => { }
                )
            };

        private static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== .NET 8 Junior Interview Practice ===");
                foreach (var kvp in Menu)
                    Console.WriteLine($"{kvp.Key}. {kvp.Value.Title}");
                Console.Write("\nChoose an option: ");

                var choice = Console.ReadLine()?.Trim() ?? string.Empty;
                if (!Menu.TryGetValue(choice, out var entry))
                {
                    Console.WriteLine("Invalid choice. Press any key...");
                    Console.ReadKey();
                    continue;
                }

                if (choice == "0") return;

                Console.Clear();
                Console.WriteLine($"--- {entry.Title} ---\n");
                try { entry.Run(); }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("An error occurred while running the example.");
                    Console.ResetColor();
                    Console.WriteLine(ex);
                }

                Console.WriteLine("\n\nPress any key to return to menu...");
                Console.ReadKey();
            }
        }

        private static Action ComingSoon(string sectionName) => () =>
        {
            Console.WriteLine($"{sectionName} examples will appear here as we build them.");
            Console.WriteLine("We’ll cover concepts, code, pitfalls, performance, and interview tips.");
        };
    }
}
