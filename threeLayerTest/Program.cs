// See https://aka.ms/new-console-template for more information
using Core.Classes;
using Dal.Classes;
using System.Runtime.InteropServices;

MathGuyObject mathGuyObject = new MathGuyObject(new Numbers());

Console.WriteLine("Hi please add first number. when your done sendt anything that isn't an number");

bool running = true;

while (running)
{
    Console.Write("Next Number: ");

    string read = Console.ReadLine();
    if (int.TryParse(read,out int Value))
    {
        mathGuyObject.AddNumber(Value);
    }
    else
    {
        running = false;
    }
}
Console.Write("Final Number: ");
Console.Write(mathGuyObject.GetAllNumbers());