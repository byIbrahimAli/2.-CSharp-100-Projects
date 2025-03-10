# Console RPG Battle Simulator

## Overview
This project is a text-based RPG battle simulator built with C#. The goal is to create an engaging, console-based game that allows players to engage in battles between various character classes and monsters. The project is designed to showcase strong Object-Oriented Programming (OOP) skills and principles, as well as Test Driven Development (TDD) practices.

## Tech Stack
- **Language:** C#
- **Platform:** .NET (Console Application)
- **Development Environment:** JetBrains Rider
- **Version Control:** Git
- **Testing Framework:** NUnit (with the .NET testing framework)

## Project Features
- **Battle Simulation:** Engage in turn-based battles between different character classes.
- **Multiple Character Classes:** Examples include `Warrior`, `Mage`, and `Archer`, each with unique abilities.
- **Monster Encounters:** Diverse enemies with varying strengths and weaknesses.
- **Customizable Weapons & Abilities:** Characters can be equipped with different weapons affecting battle outcomes.
- **Extensible Design:** The code structure is designed to easily incorporate new features, such as additional characters, items, or battle mechanics.
- **Test Driven Development:** Core functionalities are covered by unit tests to ensure code quality and maintainability.

## OOP Principles Demonstrated
This project is built to highlight several key OOP concepts:

### 1. Classes & Objects
- **Example:** Creating classes like `Character`, `Monster`, and `Weapon` to represent the entities in the game.
- **Benefit:** Encapsulates data and behavior into reusable components.

### 2. Inheritance & Polymorphism
- **Example:** A base `Character` class with derived classes such as `Warrior`, `Mage`, and `Archer` that override methods like `Attack()`.
- **Benefit:** Enables code reuse and flexibility in extending the application.

### 3. Encapsulation
- **Example:** Private fields for health, mana, etc., with public methods such as `TakeDamage()` and `Heal()`.
- **Benefit:** Protects the internal state of objects and promotes modular design.

### 4. Interfaces & Abstraction
- **Example:** Implementing interfaces such as `IAttackable` to define common behaviors for any object that can participate in combat.
- **Benefit:** Promotes loose coupling and enhances code maintainability.

### 5. Composition
- **Example:** A `Character` object contains a `Weapon` object, allowing for dynamic changes to character behavior based on the weapon equipped.
- **Benefit:** Provides flexibility in building complex types from simpler ones without deep inheritance trees.

## Test Driven Development (TDD)
This project uses TDD practices to ensure robust and maintainable code. The process involves:
- **Writing Unit Tests First:** Use NUnit to define the expected behavior for critical components (e.g., attack calculations, health management, and battle outcomes).
- **Continuous Refactoring:** Code is continuously improved to meet the tests, ensuring that new features don’t break existing functionality.
- **Automated Testing:** Run tests using the `dotnet test` command to quickly verify that the application behaves as expected.

## Setup & Usage

### Prerequisites
- [.NET SDK](https://dotnet.microsoft.com/download) installed on your machine.
- A C# compatible IDE like Visual Studio or Visual Studio Code.

### Running the Application
1. **Clone the Repository:**
   ```bash
   git clone # repo link
   cd # into repo
   ```
2. **Build the Project**
   ```bash
    dotnet build
   ```
3. **Run the Application**
    ```bash
    dotnet run
    ```
4. **Follow the on-screen instructions to simulate a battle**

### Running the Tests
1. **Navigate to the Test Directory (if separated):**
    ```bash
   cd # into test dir
    ```
2. **Run the Unit Tests:**
    ```bash
   dotnet test
    ```
   
## Project Structure
```bash
ConsoleRpgBattleSimulator/
│
├── src/
│   ├── Program.cs          # Entry point of the application
│   ├── Models/             # Contains classes such as Character, Monster, and Weapon
│   ├── Interfaces/         # Contains interface definitions (e.g., IAttackable)
│   └── Utils/              # Helper classes and utilities for battle logic
│
├── tests/
│   └── ConsoleRpgBattleSimulator.Tests/  # Contains unit tests for core functionalities using NUnit
│
├── README.md               # Project documentation
└── ConsoleRpgBattleSimulator.sln  # Solution file

```