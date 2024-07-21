# Advanced SOLID Patterns Implementation - Open/Closed Principle (OCP)

Welcome to the Advanced SOLID Patterns Open/Closed Principle (OCP) Implementation project! This repository is dedicated to providing comprehensive examples and explanations of the SOLID principles in software design, showcasing advanced usage and implementation patterns.

## Overview

The SOLID principles are a set of design principles intended to make software designs more understandable, flexible, and maintainable. 

- **O**pen/Closed Principle (OCP)

This project aims to demonstrate how these principles can be implemented in real-world scenarios using advanced patterns and techniques.

## Table of Contents

- [Getting Started](#getting-started)
- [Project Structure](#project-structure)
- [Examples](#examples)
  - [Open/Closed Principle (OCP)](#openclosed-principle-ocp)
- [Running the Project](#running-the-project)
- [Contributing](#contributing)
- [License](#license)

## Getting Started

To get started with this project, clone the repository and install the necessary dependencies.

```bash
git clone https://github.com/oneananda/Advanced_SOLID_Patterns_Implementation.git
cd Advanced_SOLID_Patterns_Implementation
```

### Project Structure

The project is organized as follows:

```
Advanced_SOLID_Patterns_Implementation/
│
├── Advanced_SOLID_Patterns_Implementation/
│   ├── Open_Closed_Principle/
├── Advanced_SOLID_Patterns_Implementation.Tests/
│   ├── Open_Closed_Principle/
└── README.md
```


## Open/Closed Principle (OCP)

### Explanation

The Open/Closed Principle (OCP) which states that software entities (classes, modules, functions, etc.) should be open for extension but closed for modification.

### Example #1: Payment Processing System

Suppose you have a payment processing system that initially only supports credit card payments. Later, you want to add support for PayPal and Bitcoin payments without modifying the existing code

This can't be possible with the current code

### Refactored for OCP

- Create an Interface:
- Implement Concrete Payment Methods:
- Modify the PaymentProcessor to Use the New Interface:

### Detailed Examples

For a more detailed examples, refer to the SRP Example in the Single_Responsiblity_Principle directory.

### Conclusion

Applying the Single Responsibility Principle is a foundational practice in object-oriented design that leads to more modular, maintainable, and understandable code. By carefully designing classes with a single responsibility, developers can create systems that are easier to manage, extend, and scale.

For detailed examples and implementation guidelines, refer to the relevant directories and documentation within this repository.


## License
This project is licensed under the MIT License. See the LICENSE file for details.

```
Feel free to modify the sections according to your project's specific needs.
```
