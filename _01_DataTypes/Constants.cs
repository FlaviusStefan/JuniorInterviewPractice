using System;

namespace JuniorInterviewPractice._01_DataTypes
{
    /// <summary>const vs readonly vs static readonly.</summary>
    public static class Constants
    {
        public static void Run()
        {
            Console.WriteLine($"Pi (const): {MathConstants.Pi}");
            var o1 = new Order(); var o2 = new Order();
            Console.WriteLine($"Order1 Id: {o1.Id}");
            Console.WriteLine($"Order2 Id: {o2.Id}");
            Console.WriteLine($"Build Timestamp: {BuildInfo.BuildTimestamp:O}");
        }

        private static class MathConstants
        {
            public const double Pi = 3.141592653589793;
        }

        private class Order
        {
            public readonly Guid Id;
            public Order() => Id = Guid.NewGuid();
        }

        private static class BuildInfo
        {
            public static readonly DateTime BuildTimestamp = DateTime.UtcNow;
        }
    }
}
