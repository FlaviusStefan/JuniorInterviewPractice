using System;
using System.Collections;
using System.Collections.Generic;

namespace JuniorInterviewPractice._01_DataTypes
{
    /// <summary>Shows where boxing/unboxing occurs and how generics avoid it.</summary>
    public static class BoxingUnboxing
    {
        public static void Run()
        {
            int x = 42;
            object boxed = x;       // boxing
            int y = (int)boxed;     // unboxing
            Console.WriteLine($"Boxed {x} -> object -> unboxed {y}");

            var arrayList = new ArrayList(); // non-generic => boxing for value types
            arrayList.Add(1);        // boxing
            arrayList.Add(2);        // boxing
            int first = (int)arrayList[0]; // unboxing
            Console.WriteLine($"ArrayList causes boxing; first={first}");

            var list = new List<int> { 1, 2, 3 }; // generic => no boxing
            Console.WriteLine($"Generic List<int> avoids boxing; count={list.Count}");
        }
    }
}
