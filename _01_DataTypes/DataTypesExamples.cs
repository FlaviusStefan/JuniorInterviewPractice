using System;

namespace JuniorInterviewPractice._01_DataTypes
{
    /// <summary>
    /// Runs all Data Types demos in a clear, interview-friendly order.
    /// </summary>
    public static class DataTypesExamples
    {
        /// <summary>
        /// Entry point invoked by Program.cs menu.
        /// </summary>
        public static void RunAllExamples()
        {
            WriteHeader("Value vs Reference Types");
            ValueVsReferenceTypes.Run();

            WriteHeader("Boxing & Unboxing");
            BoxingUnboxing.Run();

            WriteHeader("Nullable Types & Null Operators");
            NullableTypes.Run();

            WriteHeader("Type Conversions");
            TypeConversions.Run();

            WriteHeader("Constants vs readonly vs static readonly");
            Constants.Run();
        }

        private static void WriteHeader(string title)
        {
            Console.WriteLine($"\n=== {title} ===\n");
        }
    }
}
