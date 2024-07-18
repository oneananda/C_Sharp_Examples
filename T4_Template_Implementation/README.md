# T4 Template Implementation

This project demonstrates how to use T4 (Text Template Transformation Toolkit) templates to generate C# code, specifically interfaces, in a .NET project.

## Project Structure

- `GenerateInterface.tt`: T4 template file used to generate an interface with predefined properties.
- `GenerateInterface.cs`: Generated C# file containing the interface definition.
- `Program.cs`: Main entry point of the application where the generated interface is used.

## Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) installed on your machine.
- A code editor such as [Visual Studio](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/).

### Setting Up the Project

1. **Create a New Project**

   Create a new .NET console project using the .NET CLI:

```
   dotnet new console -n T4_Template_Implementation
   cd T4_Template_Implementation
```

2. **Add the T4 Template**

In your project directory, add a new T4 template file named GenerateInterface.tt.

3. **Define the T4 Template**

Open the GenerateInterface.tt file and define the template for generating an interface. This template will include the interface name and the properties you want to generate.

4. **Build the Project**

Save the GenerateInterface.tt file. Visual Studio (or your code editor) will automatically generate the corresponding C# file based on the template content.

5. **Use the Generated Interface**

In your Program.cs file, use the generated interface as needed in your application.


## Output

```
	T4 Template Implementation
	Id: 1
	Name: Customer 1
	Created Date: 7/18/2024 5:46:52 AM
```

### In this demo, we have created a T4 template to generate a C# interface and then used that interface in a simple console application. This process demonstrates how we can automate code generation in C# projects using T4 templates.