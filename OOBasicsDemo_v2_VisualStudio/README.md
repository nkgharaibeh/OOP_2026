# OOBasicsDemo_v2

## Overview
This project demonstrates basic Object-Oriented Programming (OOP) concepts in C# in a style that matches the topics of Chapters 2 and 3 from the slides.

## Main Concepts Covered
- Object-Oriented Programming
- Objects and Classes
- Fields / Instance Variables
- Constructors
- Methods
- Method Signatures
- Encapsulation
- Collaboration through Messages
- Relationships:
  - has-a
  - uses-a
- Main method as the application entry point

## Project Structure
- `Program.cs` → creates objects and starts interaction between them
- `Employee.cs` → main domain class used in the examples
- `Location.cs` → used to demonstrate the has-a relationship
- `TimeSheet.cs` → used to demonstrate collaboration and uses-a
- `Department.cs` → demonstrates a collection of Employee objects
- `OOBasicsDemo_v2.csproj` → Visual Studio / .NET project file

## UML Notes
### Class Diagram idea
You can draw these classes as UML class boxes:
- Employee
- Location
- TimeSheet
- Department
<img width="883" height="424" alt="image" src="https://github.com/user-attachments/assets/d1a60f1f-fe88-4180-bb74-4b43a6401af4" />
### Object Diagram idea
At runtime, objects such as the following are created:
- `emp1 : Employee`
- `emp2 : Employee`
- `emp3 : Employee`
- `irbidOffice : Location`
- `ammanOffice : Location`
- `timeSheet : TimeSheet`
<img width="599" height="262" alt="image" src="https://github.com/user-attachments/assets/9d0ef6e1-abd3-476c-b018-23ad293d20da" />

### Sequence Diagram idea
A key interaction is:
1. `Program` calls `emp2.RecordOvertime(timeSheet, 3)`
2. `Employee` calls `timeSheet.AddEntry(...)`
<img width="846" height="309" alt="image" src="https://github.com/user-attachments/assets/30678b67-a3b0-4ca3-95c5-ab0274760faa" />

This matches the slide discussion about sending messages between objects.

## How to Open in Visual Studio Community
1. Extract the zip file.
2. Open Visual Studio Community.
3. Choose **Open a project or solution**.
4. Open `OOBasicsDemo_v2.csproj`.
5. Run the project.

## How to Upload to GitHub
1. Test the project first in Visual Studio.
2. Create a new repository on GitHub.
3. Upload the project folder contents.
4. Do **not** upload `bin`, `obj`, or `.vs`.
