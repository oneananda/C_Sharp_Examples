# Advanced SOLID Patterns Implementation - Single Responsibility Principle (SRP)

## Multi-Layered Architecture Example

This is a console application demonstrating the Single Responsibility Principle (SRP) in a multi-layered architecture. The application manages a list of users, with separate layers for the model, view, and controller.

## Description

The application is divided into three layers:

1. **Model Layer**: Manages the data and business logic of the application.
2. **View Layer**: Handles the presentation logic and user interface.
3. **Controller Layer**: Acts as an intermediary, coordinating the flow between the model and the view.


## Usage

Add User: Prompts the user to enter the details of a new user and adds it to the list.
Display Users: Displays the list of users.
Exit: Exits the application.

To adhere to SRP, we can separate these responsibilities into individual classes:
