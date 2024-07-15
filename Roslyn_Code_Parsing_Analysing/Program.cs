using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Roslyn_Code_Parsing_Analysing
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sample C# code to analyze
            // We can get this via a file fetch also 
            string code = @"
            using System;
            class Program
            {
                static void Main(string[] args)
                {
                    Console.WriteLine(""Hello, World!"");
                }

                private static void CallAnotherMethod()
                {
                    Console.WriteLine(""In CallAnotherMethod!"");
                }
            }";

            // Parse the code into a syntax tree
            SyntaxTree tree = CSharpSyntaxTree.ParseText(code);

            // Get the root node of the syntax tree
            SyntaxNode root = tree.GetRoot();

            // Display the syntax tree structure
            Console.WriteLine(root);

            // Find all method declarations
            var methodDeclarations = root.DescendantNodes().OfType<MethodDeclarationSyntax>();

            Console.WriteLine("\nMethod Declarations:\n");

            foreach (var method in methodDeclarations)
            {
                Console.WriteLine($"Method Name: {method.Identifier.Text}");
                Console.WriteLine($"Return Type: {method.ReturnType}");
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
