# CancellationToken Implementation

## Overview

This project demonstrates the use of `CancellationToken` in an asynchronous operation using C#. The example showcases how to implement cancellation in a long-running task and how to handle the cancellation request gracefully.

## Features

- **CancellationTokenSource**: Manages the cancellation token and signals when cancellation is requested.
- **CancellationToken**: Propagates the notification that operations should be canceled.
- **Task.Run**: Executes a long-running task with periodic checks for cancellation.
- **Task.Delay**: Simulates a delay before requesting cancellation.
- **Exception Handling**: Catches `OperationCanceledException` and other exceptions to handle the task cancellation properly.

## How It Works

1. **Initialization**:
   - A `CancellationTokenSource` is created to manage the cancellation.
   - A `CancellationToken` is obtained from the source.

2. **Task Execution**:
   - A task is started that performs a loop, simulating work with a delay.
   - The task periodically checks the cancellation token to see if cancellation has been requested.

3. **Cancellation**:
   - After a delay, the cancellation is requested by calling `Cancel` on the `CancellationTokenSource`.

4. **Task Completion**:
   - The task checks the token, and if cancellation is requested, it exits the loop and completes the task.
   - The completion or cancellation of the task is awaited, and any exceptions are caught and handled.

## Usage

To use this implementation in your own project, follow these steps:

1. **Add the Implementation**:
   - Copy the `WithAwaitOperation` class into your project.

2. **Call the Method**:
   - Invoke the `DoWork` method to see the cancellation in action.

3. **Modify as Needed**:
   - Adjust the delay and iteration count to suit your specific requirements.

## Contributing

If you find any issues or have suggestions for improvements, feel free to open an issue or submit a pull request.

## License

This project is licensed under the MIT License.
