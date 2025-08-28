using System;
using System.Globalization;

namespace JuniorInterviewPractice._01_DataTypes
{
    /// <summary>Implicit/explicit conversions, Parse vs TryParse, Convert.*.</summary>
    public static class TypeConversions
    {
        public static void Run()
        {
            int i = 100; long l = i;                // implicit (widening)
            Console.WriteLine($"Implicit int->long: {l}");

            double d = 3.99; int t = (int)d;        // explicit (truncates)
            Console.WriteLine($"Explicit double->int: {t}");

            if (int.TryParse("12x", out var val))
                Console.WriteLine($"TryParse value: {val}");
            else
                Console.WriteLine("TryParse failed for '12x'.");

            int r1 = Convert.ToInt32(3.5); // 4
            int r2 = Convert.ToInt32(2.5); // 2 (banker's rounding)
            Console.WriteLine($"Convert: 3.5->{r1}, 2.5->{r2}");

            var num = double.Parse("3.14", CultureInfo.InvariantCulture);
            Console.WriteLine($"InvariantCulture parse: {num}");
        }
    }
}
