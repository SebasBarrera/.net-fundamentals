using Humanizer;
Console.WriteLine("Enter your name");
var name = Console.ReadLine();
Console.WriteLine("Enter your job");
var job = Console.ReadLine();
Console.WriteLine("Enter your age");
var age = int.Parse(Console.ReadLine());


Console.WriteLine($"My name is {name}, mi job is {job} and my age is {age.ToWords()}. Thanks");

