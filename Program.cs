Console.WriteLine("Please enter a number?");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter a second number");
int numberTwo = Convert.ToInt32(Console.ReadLine());
int result = numberOne + numberTwo;
Console.WriteLine($"{numberOne} + {numberTwo} = {result}");