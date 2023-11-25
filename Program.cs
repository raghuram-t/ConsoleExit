using ConsoleExit4;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

ConsoleKeyInfo cki;

Console.Clear();

// Establish an event handler to process key press events

Console.CancelKeyPress += new ConsoleCancelEventHandler(ConsoleExit4.MyClass.myHandler);
Console.WriteLine("I am doing some task");
Thread.Sleep(10000);

