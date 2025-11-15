# Module 1 Activity 1: Calculate the Average

This is a simple C# console application that calculates the average of three numbers entered by the user. The program ensures valid integer input via error handling and retry logic.

## Features

- Prompts the user for three integers.
- Validates that each input is an integer and provides error messages for invalid entries.
- Calculates and displays both the sum and the average, formatted to three decimal places.

## Requirements

- .NET SDK (version 6.0 or higher recommended)
- Compatible with Windows, macOS, or Linux

## How to Run

### 1. Compile the Application (windows powershell)

Open a terminal and compile the C# file using the following command:

```
dotnet build .\ConsoleApp1.slnx
```

### 2. Run the Application

Run the resulting executable:

```
dotnet run
```
or
```
dotnet run .\Program.cs
```

### 3. Input Example

When prompted, enter three integers:

```
Module 1 Activity 1 Calculate the Average
Enter number 1   : 1
Enter number 2   : 2
Enter number 3   : 5
Sum of values    : 1 + 2 + 5 = 8
Average is       : 2.667
```

If you enter invalid data such as a non-integer (e.g., "abc"), the program will display an error message and prompt you to try again until a valid integer is entered.


