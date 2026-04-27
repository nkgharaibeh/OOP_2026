# OOP Encapsulation and Properties Examples

This repository contains small C# examples that support the lecture slides:

**C# OOP - Encapsulation and Properties**

The examples are designed for beginner students who are learning how to move from simple classes and fields into proper encapsulation using properties.

---

## Main Learning Ideas

The slides focus on the following ideas:

1. Classes usually contain private fields.
2. Other classes may need to read or change field values.
3. Direct access to fields can be dangerous.
4. C# properties provide a clean way to control access.
5. A property can be:
   - read-only
   - read-write
   - validated
   - computed
   - static

---

## Project Structure

| File | Purpose |
|---|---|
| `Program.cs` | Runs all examples |
| `BadStudent.cs` | Shows the problem of public fields |
| `Student.cs` | Shows private fields + properties + validation |
| `Employee.cs` | Shows read-only, read-write, and computed properties |
| `Location.cs` | Supporting class used by Employee |
| `TimeSheet.cs` | Shows static property |
| `Course.cs` | Shows auto-implemented properties |

---

## Example 1: The Problem with Public Fields

`BadStudent` uses public fields:

```csharp
public string Name;
public double GPA;
```

This allows invalid values such as:

```csharp
badStudent.GPA = 9.5;
```

This is a problem because GPA should be controlled.

---

## Example 2: Encapsulation with Properties

`Student` uses private fields:

```csharp
private int id;
private string name;
private double gpa;
```

Then it provides properties:

```csharp
public double GPA
{
    get { return gpa; }

    set
    {
        if (value >= 0.0 && value <= 4.0)
        {
            gpa = value;
        }
        else
        {
            Console.WriteLine("Invalid GPA value.");
        }
    }
}
```

This demonstrates **data hiding** and **controlled access**.

---

## Example 3: Employee Properties

This follows the slide idea:

| Attribute | Property |
|---|---|
| `name` | `Name` get only |
| `username` | `Username` get only |
| `currentLocation` | no public property; changed by `Move()` |
| `phoneNumber` | `PhoneNumber` get and set |
| none | `Email` computed from username |

Important idea:

```csharp
public string Email
{
    get { return username + "@example.com"; }
}
```

`Email` is not stored as a field. It is computed.

---

## Example 4: Static Property

`TimeSheet` contains a static property:

```csharp
public static int MaxEntries
{
    get { return maxEntries; }
    private set { ... }
}
```

Static means the value belongs to the class itself, not to one object.

Usage:

```csharp
Console.WriteLine(TimeSheet.MaxEntries);
TimeSheet.IncreaseMaxEntriesBy(10);
```

---

## How to Run

1. Open Visual Studio Community.
2. Choose **Open a project or solution**.
3. Open:

```text
OOP_Encapsulation_Properties_Examples.csproj
```

4. Run the project using **Ctrl + F5**.

---

## Suggested Teaching Flow

1. Start with `BadStudent` to show the problem.
2. Move to `Student` to show the solution.
3. Use `Employee` to show different property styles.
4. Use `TimeSheet` to introduce static properties.
5. End with `Course` as a modern short syntax example.

---

## Key Vocabulary

- Encapsulation
- Data hiding
- Private field
- Public property
- Getter
- Setter
- Validation
- Computed property
- Static property
- Auto-implemented property
