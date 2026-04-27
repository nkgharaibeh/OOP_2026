# OOP Namespaces, Access Modifiers, and this Keyword Examples

This repository contains small C# examples that support the lecture slides:

**C# OOP - Namespaces, Access Modifiers, Classes, and this Keyword**

The examples are designed for beginner students who are learning how C# programs are organized into many classes and namespaces.

---

## Main Learning Ideas

This project focuses on:

1. Many classes can exist in one program.
2. Namespaces organize related classes.
3. `using` statements allow one file to use classes from another namespace.
4. Access modifiers control visibility:
   - `public`
   - `private`
   - `protected`
   - `internal`
5. The `this` keyword refers to the current object.
6. A class usually contains:
   - fields
   - constructors
   - methods

---

## Project Structure

```text
OOP_Namespaces_AccessModifiers_ThisKeyword_Examples/
│
├── Program.cs
├── AccessModifierNotes.cs
│
├── Models/
│   ├── Student.cs
│   └── Course.cs
│
├── Services/
│   └── StudentReportService.cs
│
└── Utilities/
    └── Printer.cs
```

---

## Example 1: Namespaces

The `Student` class is inside:

```csharp
namespace OOP_Namespaces_AccessModifiers_ThisKeyword_Examples.Models
```

The `Printer` class is inside:

```csharp
namespace OOP_Namespaces_AccessModifiers_ThisKeyword_Examples.Utilities
```

To use them in `Program.cs`, we write:

```csharp
using OOP_Namespaces_AccessModifiers_ThisKeyword_Examples.Models;
using OOP_Namespaces_AccessModifiers_ThisKeyword_Examples.Utilities;
```

---

## Example 2: Access Modifiers

In `Student.cs`, the fields are private:

```csharp
private int id;
private string name;
private double gpa;
```

This means they cannot be accessed directly from `Program.cs`.

This line is not allowed:

```csharp
student.name = "New Name";
```

Instead, the class exposes public methods:

```csharp
public string GetSummary()
```

---

## Example 3: this Keyword

In the constructor:

```csharp
public Student(int id, string name, double gpa)
{
    this.id = id;
    this.name = name;
    this.gpa = gpa;
}
```

The keyword `this` means:

> the current object

So:

- `this.id` is the field.
- `id` is the parameter.

---

## Example 4: Service Class

`StudentReportService` is in the `Services` namespace.

It uses:

- `Student` from `Models`
- `Printer` from `Utilities`

This demonstrates how larger programs can be organized into logical namespaces.

---

## Suggested Teaching Flow

1. Start with `Program.cs`.
2. Show that `Program` uses several classes.
3. Open `Student.cs` and explain fields, constructor, and methods.
4. Explain why fields are private.
5. Explain how `this` distinguishes fields from parameters.
6. Open folders:
   - Models
   - Services
   - Utilities
7. Explain that folders are not the same as namespaces, but we often organize them together.

---

## How to Run

1. Open Visual Studio Community.
2. Choose **Open a project or solution**.
3. Open:

```text
OOP_Namespaces_AccessModifiers_ThisKeyword_Examples.csproj
```

4. Run the project using **Ctrl + F5**.

---

## Key Vocabulary

- Class
- Namespace
- using statement
- Access modifier
- public
- private
- protected
- internal
- field
- constructor
- method
- this keyword
- current object
