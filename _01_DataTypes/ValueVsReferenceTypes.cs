using System;

namespace JuniorInterviewPractice._01_DataTypes
{
	/// <summary>Demonstrates value vs reference semantics and ref parameters.</summary>
	public static class ValueVsReferenceTypes
	{
		public static void Run()
		{
			// Value type copy
			Score a = new Score(10);
			Score b = a;              // copy
			b = b.Increment();        // mutate the copy
			Console.WriteLine($"Value type: a={a.Value}, b={b.Value} (a unaffected)");

			// Reference type reference
			Player p1 = new Player(1);
			Player p2 = p1;           // same object
			p2.Level = 5;
			Console.WriteLine($"Reference type: p1.Level={p1.Level}, p2.Level={p2.Level} (both changed)");

			IncreaseByOne(a);         // no effect
			Console.WriteLine($"After IncreaseByOne(a): a={a.Value}");

			IncreaseByOneRef(ref a);  // modifies caller
			Console.WriteLine($"After IncreaseByOneRef(ref a): a={a.Value}");

			// Strings: reference + immutable
			var s1 = "Hello";
			var s2 = s1;
			s2 += " World";           // new string instance
			Console.WriteLine($"String immutability: s1='{s1}', s2='{s2}'");
		}

		public readonly struct Score
		{
			public int Value { get; }
			public Score(int value) => Value = value;
			public Score Increment() => new Score(Value + 1);
		}

		public class Player
		{
			public int Level { get; set; }
			public Player(int level) => Level = level;
		}

		private static void IncreaseByOne(Score s) => s = s.Increment();
		private static void IncreaseByOneRef(ref Score s) => s = s.Increment();
	}
}
