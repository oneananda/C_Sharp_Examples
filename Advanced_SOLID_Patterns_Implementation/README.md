# Advanced SOLID Patterns Implementation

Welcome to the Advanced SOLID Patterns Implementation project! This repository is dedicated to providing comprehensive examples and explanations of the SOLID principles in software design, showcasing advanced usage and implementation patterns.

## Overview

The SOLID principles are a set of design principles intended to make software designs more understandable, flexible, and maintainable. These principles are:

- **S**ingle Responsibility Principle (SRP)
- **O**pen/Closed Principle (OCP)
- **L**iskov Substitution Principle (LSP)
- **I**nterface Segregation Principle (ISP)
- **D**ependency Inversion Principle (DIP)

This project aims to demonstrate how these principles can be implemented in real-world scenarios using advanced patterns and techniques.

## Table of Contents

- [Getting Started](#getting-started)
- [Project Structure](#project-structure)
- [Examples](#examples)
  - [Single Responsibility Principle (SRP)](#single-responsibility-principle-srp)
  - [Open/Closed Principle (OCP)](#openclosed-principle-ocp)
  - [Liskov Substitution Principle (LSP)](#liskov-substitution-principle-lsp)
  - [Interface Segregation Principle (ISP)](#interface-segregation-principle-isp)
  - [Dependency Inversion Principle (DIP)](#dependency-inversion-principle-dip)
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

Advanced_SOLID_Patterns_Implementation/
│
├── Advanced_SOLID_Patterns_Implementation/
│   ├── SRP/
│   ├── OCP/
│   ├── LSP/
│   ├── ISP/
│   └── DIP/
│
├── tests/
│   ├── SRP/
│   ├── OCP/
│   ├── LSP/
│   ├── ISP/
│   └── DIP/
│
└── README.md

## Single Responsibility Principle (SRP)

### Explanation

The Single Responsibility Principle states that a class should have only one reason to change, meaning it should only have one job or responsibility. This principle helps to reduce the complexity of the code and makes it easier to maintain and understand.

### Example

In this example, we will demonstrate SRP by separating the responsibilities of a `User` class and a `UserService` class.

#### Before Applying SRP

```
public class Before_SRP_User
{
    public string Name { get; set; }
    public string Email { get; set; }

    public void Save()
    {
        // Code to save the user to a database
    }

    public void SendEmail()
    {
        // Code to send an email
    }
}
```

In this example, the `Before_SRP_User` class has multiple responsibilities: managing user data, saving the user to a database, and sending emails. This violates the SRP.

#### After Applying SRP


```
internal class After_SRP_User
{
    public string Name { get; set; }
    public string Email { get; set; }
}
```

```
internal class After_SRP_UserService
{
    public void Save(After_SRP_User user)
    {
        // Code to save the user to a database
    }

    public void SendEmail(After_SRP_User user)
    {
        // Code to send an email
    }
}
```


Now, the `After_SRP_User` class is only responsible for user data, and the `After_SRP_UserService` class handles the saving and emailing functionalities. This adheres to the SRP.

### Detailed Example

For a more detailed example, refer to the SRP Example in the SRP directory.


## License
This project is licensed under the MIT License. See the LICENSE file for details.

```
Feel free to modify the sections according to your project's specific needs.
```
