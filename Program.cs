using System;
using System.Reflection;

class Program
{
    static void Main()
    {
        // Load assembly dynamically
        Assembly assembly = Assembly.LoadFrom("ExampleAssembly.dll");

        // Iterate through types in the assembly
        foreach(Type type in assembly.GetTypes())
        {
            Console.WriteLine($"Type: {type.FullName}");

            // Create an instance of the type
            object instance = Activator.CreateInstance(type);

            // Invoke a method dynamically
            MethodInfo method = type.GetMethod("ExampleMethod");
            method.Invoke(instance, null);

            // Access properties dynamically
            PropertyInfo property = type.GetProperty("ExampleProperty");
            property.SetValue(instance, "New Value");
            Console.WriteLine($"Property Value: {property.GetValue(instance)}");
        }
    }
}
