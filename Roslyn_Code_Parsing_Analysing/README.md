# Roslyn Code Parsing Analysing

This project demonstrates how to use Roslyn, the .NET Compiler Platform, to parse and analyze a simple C# code snippet.

## Introduction

Roslyn provides rich APIs to interact with C# and VB.NET compilers. This example showcases the basic steps to:

- Parse a C# code snippet into a syntax tree.
- Analyze the syntax tree to extract information about the code.

## Prerequisites

To run this example, you need:

- Visual Studio 2019 or later
- .NET Core SDK 3.1 or later

## Setup Instructions

1. **Create a new Console Application:**
   - Open Visual Studio.
   - Create a new Console App (.NET Core) project.

2. **Install the necessary NuGet packages:**
   - Right-click on your project in the Solution Explorer.
   - Select "Manage NuGet Packages."
   - Install the following packages:
     - `Microsoft.CodeAnalysis.CSharp`
     - `Microsoft.CodeAnalysis.Workspaces.MSBuild`

3. **Add the code to your `Program.cs` file:**
   - Add the provided example code to your `Program.cs` file.

## Explanation

### Sample C# Code
A string containing a simple C# program is defined and will be used for parsing and analysis.

### Parse the Code
The code is parsed into a `SyntaxTree` using Roslyn's `CSharpSyntaxTree.ParseText` method.

### Get the Root Node
The root `SyntaxNode` of the syntax tree is retrieved using the `GetRoot` method.

### Display the Syntax Tree
The entire syntax tree structure is printed to the console for inspection.

### Find and Display Method Declarations
All method declarations in the syntax tree are found and their details (names and return types) are printed to the console.

## Running the Example

- Run the console application.
- The output will display the syntax tree structure of the sample code and details about the method declarations found in the code.

## Conclusion

This example provides a basic understanding of how to use Roslyn to parse and analyze C# code. You can expand this example to perform more complex code analysis and manipulation tasks.

## References

- [Roslyn GitHub Repository](https://github.com/dotnet/roslyn)
- [Roslyn Documentation](https://docs.microsoft.com/en-us/dotnet/roslyn-sdk/)
