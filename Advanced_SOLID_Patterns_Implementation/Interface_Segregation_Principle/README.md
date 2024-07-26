# Advanced SOLID Patterns Implementation - Interface Segregation Principle (ISP)

Welcome to the Advanced SOLID Patterns  Interface Segregation Principle (ISP) Implementation project! This repository is dedicated to providing comprehensive examples and explanations of the SOLID principles in software design, showcasing advanced usage and implementation patterns.

## Overview

The SOLID principles are a set of design principles intended to make software designs more understandable, flexible, and maintainable. 

- **I**nterface Segregation Principle (ISP)

This project aims to demonstrate how these principles can be implemented in real-world scenarios using advanced patterns and techniques.

## Table of Contents

- [Getting Started](#getting-started)
- [Project Structure](#project-structure)
- [Examples](#examples)
  - [Interface Segregation Principle (ISP)](#interface-segregation-principle-isp)
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
│   ├── Interface_Segregation_Principle/
│
├── Advanced_SOLID_Patterns_Implementation.Tests/
│   ├── Interface_Segregation_Principle/
└── README.md
```

## Single Responsibility Principle (SRP)

### Explanation

The Interface Segregation Principle helps in designing a system where clients only need to know about the methods that are relevant to them, avoiding the drawbacks of "fat" interfaces. By adhering to ISP, you can create a more flexible and decoupled system.

## Project Structure

The project is organized into the following sections:

- **Before Refactoring:** Examples that demonstrate violations of ISP with "fat" interfaces.
- **After Refactoring:** Examples that adhere to ISP by splitting larger interfaces into smaller, more specific ones.
- **Use Cases:** Various real-world scenarios where ISP can be applied, such as plugin systems, e-commerce payment processing, and more.

ISP states that no client should be forced to depend on methods it does not use. In other words, larger interfaces should be split into smaller, more specific ones so that clients only need to know about the methods that are of interest to them.

For detailed examples and implementation guidelines, refer to the relevant directories and documentation within this repository.

### Scenario : MultiFunctionDevice and Basic Printer

- **Interfaces**: Define specific methods for each functionality (Fax, Print, Staple, Scan).
- **MultiFunctionDevice**: Implements all four interfaces, providing comprehensive functionality.
- **BasicPrinter**: Implements only the `IPrinter` interface, focusing on printing.


### Scenario : Plugin System

We have an interface `Before_ISP_IPlugin` which contains the following methods,

```
void Initialize();
void LoadData();
void SaveData();
void Render();
void Log(string message);
```

When implementing this to `DataPlugin`, 

- This plugin does not need to render
- This plugin does not need to log

Both the implementations are not at all required, which is violating ISP


## License
This project is licensed under the MIT License. See the LICENSE file for details.

```
Feel free to modify the sections according to your project's specific needs.
```

