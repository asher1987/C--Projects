using System;


public class HelloWord1
{
    private string message = "Hello World";

    public HelloWord1(string message)
    {
        this.message = message;
    }
    public void SayHello()
    {
        Console.WriteLine(message);
    }


HelloWord1 goodbye = new HelloWord1("goodbye");
goodbye.SayHello(); 


}
