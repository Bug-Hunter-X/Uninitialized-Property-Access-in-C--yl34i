# Uninitialized Property Access in C#

This repository demonstrates a common error in C#: accessing a property before it has been initialized.  Uninitialized properties will have their default values (0 for integers, null for reference types). Accessing them can lead to unexpected behavior or runtime exceptions depending on how the value is used.  The example shows how to properly initialize properties to avoid these issues.

## How to Reproduce

1. Clone this repository.
2. Compile and run `bug.cs`.  Note the output.
3. Examine `bugSolution.cs` to see how to correctly initialize the property.