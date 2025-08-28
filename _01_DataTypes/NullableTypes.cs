using System;

namespace JuniorInterviewPractice._01_DataTypes
{
    /// <summary>Nullable value types and null operators (??, ?., ??=).</summary>
    public static class NullableTypes
    {
        public static void Run()
        {
            int? loyaltyPoints = null;
            int effective = loyaltyPoints ?? 0;
            Console.WriteLine($"Effective points: {effective}");

            var c = new Customer { Name = "Flav" };
            int nameLen = c?.Name?.Length ?? 0;
            Console.WriteLine($"Customer name length: {nameLen}");

            c.Nickname ??= "Guest";
            Console.WriteLine($"Nickname: {c.Nickname}");
        }

        private class Customer
        {
            public string Name { get; set; } = "";
            public string? Nickname { get; set; }
        }
    }
}
