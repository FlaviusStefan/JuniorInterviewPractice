# JuniorInterviewPractice

A .NET 8, C# 12 **menu-driven console application** for junior developers to practice interview-ready concepts with runnable examples, best practices, pitfalls, and talking points.

> ✅ **Built for interviews.** Each topic has a small orchestrator, 3–5 focused demos, realistic business scenarios, and guidance on what interviewers look for.

---

## Table of Contents
- [Why this exists](#why-this-exists)
- [Prerequisites](#prerequisites)
- [Quick Start](#quick-start)
- [Project Structure](#project-structure)
- [Design Rules](#design-rules)
- [Topics & Coverage](#topics--coverage)
- [How the menu is wired](#how-the-menu-is-wired)
- [Coding Standards](#coding-standards)
- [Troubleshooting](#troubleshooting)
- [Suggested Learning Path](#suggested-learning-path)
- [Interview Talking Points](#interview-talking-points)
- [Extending the Project](#extending-the-project)
- [License](#license)
- [Acknowledgements](#acknowledgements)

---

## Why this exists
- **Hands-on learning:** press a number, run a focused demo, read the output.
- **Interview prep:** learn not just *how* to code it, but *why* and *when* to use it.
- **Good code hygiene:** separation of concerns, error handling, XML docs, simple design.

---

## Prerequisites
- [.NET 8 SDK](https://dotnet.microsoft.com/download) installed (`dotnet --info` should work)
- Any IDE/editor (Visual Studio 2022, Rider, VS Code)

---

## Quick Start

```bash
# build the solution
dotnet build .\JuniorInterviewPractice.sln

# run the app
dotnet run --project .\JuniorInterviewPractice.csproj
```

You’ll see a menu like:

```
=== .NET 8 Junior Interview Practice ===
1. 01 - Data Types
2. 02 - OOP
3. 03 - Collections
...
15. 15 - Advanced
0. Exit

Choose an option:
```

---

## Project Structure

> This repo keeps the `.sln` and `.csproj` at the **root** for simplicity.

```
JuniorInterviewPractice/
├── 01_DataTypes/
│   ├── DataTypesExamples.cs         # orchestrator for this topic
│   ├── ValueVsReferenceTypes.cs
│   ├── BoxingUnboxing.cs
│   ├── NullableTypes.cs
│   ├── TypeConversions.cs
│   ├── Constants.cs
│   └── README.md                    # short notes (optional)
├── 02_OOP/
├── 03_Collections/
├── 04_ExceptionHandling/
├── 05_LINQ/
├── 06_StringManipulation/
├── 07_FileIO/
├── 08_DelegatesEvents/
├── 09_Generics/
├── 10_AsyncProgramming/
├── 11_MemoryManagement/
├── 12_Debugging/
├── 13_UnitTesting/
├── 14_DesignPatterns/
├── 15_Advanced/
├── Program.cs                       # menu only (no business logic here)
├── JuniorInterviewPractice.csproj
└── JuniorInterviewPractice.sln
```

### Design Rules

- **Program.cs = menu only.** It just routes to topic orchestrators (e.g., `DataTypesExamples.RunAllExamples()`).
- **Each topic folder** has an `*Examples.cs` class that calls 3–5 **small, focused** demos.
- **XML documentation** on public methods/classes to practice communication.
- **Console output** is intentionally verbose to explain *why* a result happens.
- **Realistic names** (Employee, Product, Order) to build intuition.

> ⚠️ Namespaces for folders starting with digits use an underscore:  
> `namespace JuniorInterviewPractice._01_DataTypes { ... }`  
> This keeps C# identifiers valid while preserving the section numbering.

---

## Topics & Coverage

> The app contains 15 topical sections. Each section aims for 3–5 example classes and a small README.

### 01 — Data Types (implemented)
- `ValueVsReferenceTypes.cs` — value vs reference semantics, copies, `ref`
- `BoxingUnboxing.cs` — when boxing happens, performance, avoiding it with generics
- `NullableTypes.cs` — `Nullable<T>`, `?.`, `??`, `??=`
- `TypeConversions.cs` — implicit/explicit casts, `Parse` vs `TryParse`, `Convert`
- `Constants.cs` — `const` vs `readonly` vs `static readonly`, versioning implications

**Key takeaways**
- Prefer **generics** to avoid boxing with value types.  
- Use `TryParse` for user input; `Parse` only when you *expect* valid input.  
- Use `static readonly` for values that may change across versions (avoid public `const` in libraries).

---

### 02 — OOP
- `Employee.cs` (base), `Manager.cs` (inheritance), `IWorkable.cs` (interface),
  `Developer.cs` (class + interface)
- `AbstractShape.cs`, `Circle.cs`, `Rectangle.cs`
- `AccessModifiers.cs` (public/private/protected/internal)

**Interview angles:** abstraction vs encapsulation, interface-driven design, when to use abstract classes, LSP, and why C# disallows multiple *class* inheritance.

---

### 03 — Collections
- `ListExamples.cs`, `DictionaryExamples.cs`, `ArrayExamples.cs`,
  `StackQueueExamples.cs`, `SetExamples.cs`, `CollectionPerformance.cs`

**Interview angles:** Big-O trade-offs, mutation vs immutability, key equality & hashing.

---

### 04 — Exception Handling
- `BasicExceptions.cs`, `CustomExceptions.cs`, `ExceptionTypes.cs`,
  `ExceptionBestPractices.cs`, `LoggingExceptions.cs`

**Interview angles:** when to catch vs rethrow, guard clauses, exception filters, logging scope.

---

### 05 — LINQ
- `BasicQueries.cs`, `GroupingJoining.cs`, `AggregateOperations.cs`,
  `QueryVsMethod.cs`, `LinqPerformance.cs`, `LinqToObjects.cs`

**Interview angles:** deferred execution, materialization (`ToList()`), composition.

---

### 06 — String Manipulation
- `StringVsStringBuilder.cs`, `StringInterpolation.cs`, `StringMethods.cs`,
  `RegularExpressions.cs`, `StringComparison.cs`, `StringImmutability.cs`

**Interview angles:** immutability cost, culture-aware comparisons, regex basics.

---

### 07 — File I/O
- `BasicFileOperations.cs`, `DirectoryOperations.cs`, `StreamExamples.cs`,
  `PathOperations.cs`, `JsonSerialization.cs`, `ConfigurationFiles.cs`

**Interview angles:** streams & buffering, `using`/`await using`, relative vs absolute paths, JSON options.

---

### 08 — Delegates & Events
- `BasicDelegates.cs` (Action/Func/Predicate), `MulticastDelegates.cs`,
  `EventExamples.cs`, `AnonymousMethods.cs`, `CallbackExamples.cs`

**Interview angles:** event patterns, publisher/subscriber, lambdas vs method groups.

---

### 09 — Generics
- `GenericClasses.cs`, `GenericMethods.cs`, `GenericConstraints.cs`,
  `GenericCollections.cs`, `Covariance.cs` (in/out)

**Interview angles:** constraints (`where T : class, new()`), variance, type inference.

---

### 10 — Async Programming
- `BasicAsync.cs`, `TaskExamples.cs`, `AsyncHttpCalls.cs`, `ParallelExecution.cs`,
  `CancellationTokens.cs`, `AsyncBestPractices.cs`

**Interview angles:** `async`/`await`, deadlocks, `ConfigureAwait`, exception flow, cancellation.

---

### 11 — Memory Management
- `GarbageCollection.cs`, `IDisposableExample.cs`, `UsingStatements.cs`,
  `WeakReferences.cs`, `MemoryProfiling.cs`

**Interview angles:** GC roots, LOH, finalizers, `IDisposable` patterns.

---

### 12 — Debugging
- `BreakpointExamples.cs`, `LoggingExamples.cs`, `ConditionalDebugging.cs`,
  `PerformanceProfiling.cs`

**Interview angles:** tracing vs logging, conditional compilation, Stopwatch, perf basics.

---

### 13 — Unit Testing
- `CalculatorTests.cs` (xUnit), `MockingExamples.cs` (Moq),
  `TestDataExamples.cs` (Theory/InlineData), `TestFixtures.cs` (setup/teardown)

> Tests will live under a separate `tests/` project when added.

---

### 14 — Design Patterns
- `SingletonPattern.cs` (thread-safe), `FactoryPattern.cs`, `ObserverPattern.cs`,
  `RepositoryPattern.cs`, `DependencyInjection.cs` (DI container basics)

**Interview angles:** when to apply, trade-offs, overuse warnings.

---

### 15 — Advanced
- `ReflectionExamples.cs`, `AttributeExamples.cs`, `ExtensionMethods.cs`,
  `OperatorOverloading.cs`, `IndexersProperties.cs`, `RecordTypes.cs`,
  `PatternMatching.cs`

**Interview angles:** reflection cost, metadata vs behavior, modern pattern matching.

---

## How the menu is wired

`Program.cs` registers a number → action mapping and keeps the menu **menu-only**:

```csharp
// Program.cs (snippet)
using JuniorInterviewPractice._01_DataTypes;

private static readonly Dictionary<string, (string Title, Action Run)> Menu =
    new()
    {
        ["1"]  = ("01 - Data Types", DataTypesExamples.RunAllExamples),
        ["2"]  = ("02 - OOP", ComingSoon("OOP")),
        // ...
        ["0"]  = ("Exit", () => { })
    };
```

Each topic has an `*Examples.RunAllExamples()` method that prints section headers and calls its demos.

---

## Coding Standards

- **XML docs** on public methods/classes
- **Clear console output** explaining what & why
- **Error handling** at the menu boundary (so demos can safely throw)
- **Performance comments** where relevant (e.g., boxing, string immutability)
- **Testability**: small, pure methods where possible

---

## Troubleshooting

- **`dotnet` not recognized** → install .NET 8 SDK or use *Developer PowerShell for VS*.
- **Solution can’t find project** → re-add the project path:
  ```bash
  dotnet sln .\JuniorInterviewPractice.sln add .\JuniorInterviewPractice.csproj
  ```
- **Compiler can’t find types in numbered folders** → ensure namespaces like:
  `namespace JuniorInterviewPractice._01_DataTypes` (note the leading underscore).
- **Files not compiling** → in SDK-style projects, any `*.cs` is compiled by default; ensure the file is inside the project folder.

---

## Suggested Learning Path

1. **01_DataTypes** → 03_Collections → 05_LINQ  
2. **04_ExceptionHandling** → 10_AsyncProgramming  
3. **14_DesignPatterns** (Singleton/Factory/Observer)  
4. Fill in remaining sections based on your gaps.

---

## Interview Talking Points

- “I structured the app with a **menu-only Program** and **topic orchestrators** to keep concerns separate and make demos easy to find.”  
- “Each example prints what it’s doing and why, and includes **pitfalls** and **performance notes** (e.g., boxing, string immutability).”  
- “I prefer **generics** to avoid boxing; choose `TryParse` for user input; and use `static readonly` instead of public `const` for versioned values.”  
- “I wrote the code to be **testable** (small methods, clear boundaries) and to model **real-world** objects (Employee, Order, Product).”

---

## Extending the Project

- Add a new example to a topic:
  1. Create `YourExample.cs` inside the topic folder.
  2. Add a static `Run()` method.
  3. Call it from `*Examples.RunAllExamples()` with a readable header.
- New topic? Create a new numbered folder and add a `*Examples.cs`, then wire the menu.

---
## License

This project is licensed under the [MIT License](LICENSE.txt).

---

## Acknowledgements

Inspired by common interview question sets and everyday patterns used in .NET back-end work (APIs, services, data access).
