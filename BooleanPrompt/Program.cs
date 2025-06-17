bool Value;
Console.Write("Is Raining (true/false): ");
Value = bool.Parse(Console.ReadLine());

if (Value == true)
{
    Console.WriteLine("Take an umbrella!");
}
else
{
    Console.WriteLine("No need for an umbrella.");
}