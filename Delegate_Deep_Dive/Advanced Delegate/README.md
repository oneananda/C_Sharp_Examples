## Example: Console Event Handling with Delegates

### Overview

In this example, we delve into the implementation of event handling using delegates within a C# console application. The application listens for the Enter key press and triggers multiple event handlers when the event occurs. This example illustrates how delegates can manage event-driven programming in a console environment.

### Step 1: Declare a Delegate

The first step is to declare a delegate named `KeyPressHandler`. This delegate defines the signature of methods that can handle the key press event. It does not take any parameters and returns `void`.

### Step 2: Define the KeyPress Event

Within the `ConsoleEventHandlingExample` class, an event named `KeyPress` is defined using the `KeyPressHandler` delegate. This event will be triggered whenever the Enter key is pressed.

### Step 3: Create a Method to Listen for Key Presses

The `ListenForKey()` method is responsible for continuously listening for key presses. When the Enter key is detected, the method calls `OnKeyPress()`, which raises the `KeyPress` event. This method keeps running in a loop until the event is triggered.

### Step 4: Subscribe Methods to the Event

In the `ConsoleEventHandling()` method, two methods (`KeyListener_KeyPress1` and `KeyListener_KeyPress2`) are subscribed to the `KeyPress` event. These methods act as event handlers and are executed when the event is raised.

### Step 5: Trigger the Event

The `OnKeyPress()` method checks if there are any subscribers to the `KeyPress` event. If there are, it invokes the event, causing all subscribed methods to execute.

### Summary

This example demonstrates how to use delegates and events to handle key press events in a console application. When the Enter key is pressed, the following occurs:

- The `KeyPress` event is raised by the `OnKeyPress()` method.
- The subscribed methods `KeyListener_KeyPress1` and `KeyListener_KeyPress2` are executed, each printing a message to the console.

This pattern is valuable in scenarios where we need to handle user inputs or other events in a console application, allowing multiple methods to respond to the same event.
