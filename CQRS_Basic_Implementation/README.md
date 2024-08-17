# CQRS_Basic_Implementation

This repository contains a simple example of implementing the Command Query Responsibility Segregation (CQRS) pattern in a C# application. The example demonstrates basic CRUD operations for the Product entity using the CQRS pattern, with specific command and query handlers.

### Directories and Files

**Commands/:** Contains commands related to Product.

AddProductCommand.cs: Command to add a product.

(Coming soon)
UpdateProductCommand.cs: Command to update a product.
DeleteProductCommand.cs: Command to delete a product.
ProductCommandHandler.cs: Handles all product-related commands.

**Queries/:** Contains queries related to Product.

GetProductQuery.cs: Query to get a specific product.
GetAllProductsQuery.cs: Query to get all products.
ProductQueryHandler.cs: Handles all product-related queries.

**Models/:**

Product.cs: Represents a product entity.

**Repositories/:**

ProductRepository.cs: Manages product data.