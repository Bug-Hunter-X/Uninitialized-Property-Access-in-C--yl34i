public class ExampleClass
{
    public int MyProperty { get; set; } = 0; // Initialize property

    public void MyMethod()
    {
        // Accessing a property that has been initialized.
        Console.WriteLine(MyProperty); 
    }

    public void MyMethod2(int value)
    {
        // Initialize the property before use
        MyProperty = value; 
        Console.WriteLine(MyProperty); 
    }
} 