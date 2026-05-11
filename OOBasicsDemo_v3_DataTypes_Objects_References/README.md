# OOBasicsDemo_v3_DataTypes_Objects_References

This project is a continuation of **OOBasicsDemo_v2_VisualStudio**.
Can be watched in this video https://www.youtube.com/watch?v=u19_a-bgVfk
Version 2 focused on basic OOP:

- Classes
- Objects
- Constructors
- Methods
- has-a relationship
- uses-a relationship
- Collaboration through messages

Version 3 adds the concepts from Chapter 4:
Can be watched in this video https://www.youtube.com/watch?v=u19_a-bgVfk
**C# Data Types, Objects and References**

---

## Main Learning Goals

This project helps students understand:

1. Data and variables in C#
2. Stack and Heap memory
3. Object references
4. Parameter passing
5. Garbage collection conceptually
6. Value types vs reference types
7. Boxing and unboxing
8. struct
9. enum
10. Build process, assemblies, CLR, and JIT

---

## Project Structure

| File | Purpose |
|---|---|
| `Program.cs` | Runs all demos |
| `Employee.cs` | Reference type class |
| `Location.cs` | Reference type class used by Employee |
| `TimeSheet.cs` | Reference type class using enum PayRate |
| `Department.cs` | Contains `List<Employee>` |
| `PayRate.cs` | enum example |
| `OvertimeEntry.cs` | struct example |
| `MemoryDemo.cs` | value type vs reference type parameter passing |
| `EnumDemo.cs` | enum example using PayRate |
| `StructDemo.cs` | struct as value type |
| `BoxingDemo.cs` | boxing and unboxing |
| `BuildRuntimeDemo.cs` | conceptual build / CLR / JIT explanation |

---

## 1. Value Type Parameter Passing

In `MemoryDemo.cs`:

```csharp
int hours = 5;
ChangeHours(hours);
```

Inside the method:

```csharp
private static void ChangeHours(int hours)
{
    hours = 10;
}
```

The original value remains unchanged because `int` is a value type and a copy of the value is passed.

Expected idea:

```text
Before ChangeHours: hours = 5
Inside ChangeHours: hours = 10
After ChangeHours: hours = 5
```

---

## 2. Reference Type Parameter Passing

In `MemoryDemo.cs`:

```csharp
Employee employee = new Employee(...);
ChangeEmployeeLocation(employee);
```

Inside the method:

```csharp
private static void ChangeEmployeeLocation(Employee employee)
{
    Location amman = new Location("Amman Branch");
    employee.Move(amman);
}
```

The object's state changes because `Employee` is a reference type.  
A copy of the reference is passed, but both references point to the same object on the heap.

---

## 3. enum PayRate

Instead of using:

```csharp
bool isWeekend
```

we use:

```csharp
public enum PayRate
{
    Normal,
    Weekend,
    Holiday
}
```

This is better because real business rules may need more than two cases.

Example:

```csharp
timeSheet.AddEntry("Mona", 4, PayRate.Weekend);
```

---

## 4. struct OvertimeEntry

`OvertimeEntry` is a struct:

```csharp
public struct OvertimeEntry
```

A struct is a value type.  
When it is passed to a method, a copy of the whole value is passed.

This helps students compare:

| class | struct |
|---|---|
| reference type | value type |
| object on heap | value copied |
| good for entities | good for small values |

---

## 5. Boxing and Unboxing

In `BoxingDemo.cs`:

```csharp
int number = 42;

object boxed = number;        // Boxing
int unboxed = (int)boxed;     // Unboxing
```

Boxing converts a value type to a reference type.  
Unboxing converts it back.

Important note:

Modern C# often avoids unnecessary boxing by using **Generics**.

---

## 6. Build Process, CLR, and JIT

In `BuildRuntimeDemo.cs`, the program prints:

```text
.cs source code
   ↓ compiled by C# compiler
MSIL / IL
   ↓ stored inside assembly
.exe or .dll assembly
   ↓ loaded by CLR
JIT compiler translates IL to native machine code
   ↓
CPU executes the program
```

This helps students understand what happens when Visual Studio builds and runs a C# project.

---

## Suggested Teaching Flow

1. Start by running the original OOP basics demo.
2. Explain that `Employee`, `Location`, and `TimeSheet` are reference types.
3. Run the value type demo.
4. Run the reference type demo.
5. Compare `int hours` with `Employee employee`.
6. Introduce enum PayRate instead of bool.
7. Introduce struct OvertimeEntry.
8. Briefly explain boxing and unboxing.
9. End with the build process: `.cs → IL → assembly → CLR/JIT`.

---

## Conceptual Bridge to Advanced OOP

This project prepares students for:

- Inheritance
- Polymorphism
- Interfaces

Why?

Because advanced OOP depends heavily on understanding references.

Later examples such as:

```csharp
Employee emp = new Manager();
```

or:

```csharp
ILogger logger = new FileLogger();
```

cannot be understood deeply unless students know that variables of class/interface types hold references to objects.

---

## How to Open in Visual Studio Community

1. Extract the zip file.
2. Open Visual Studio Community.
3. Choose **Open a project or solution**.
4. Open:

```text
OOBasicsDemo_v3_DataTypes_Objects_References.csproj
```

5. Run using **Ctrl + F5**.

---

## GitHub Notes

Do not upload:

- `bin/`
- `obj/`
- `.vs/`

These are ignored using `.gitignore`.
