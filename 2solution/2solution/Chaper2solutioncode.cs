// 1. Write an expression that checks whether an integer is odd or even. 
int num = 2;
Console.WriteLine(num % 2 == 0 );

// 2.Write a Boolean expression that checks whether a given integer is divisible by both 5 and 7, without a remainder.

Console.Write("Enter integer (5 / 7) the system checks if its divisible.");
int numm2 = int.Parse(Console.ReadLine());

Console.WriteLine(35 % numm2  == 0 ? "Number is divisible.":"Sorry number indivisble. Try numbers 5 or 7.");

// Write an expression that looks for a given integer if its third digit (right to left) is 7. eg 1785
Console.Write("Write a number: ");
int number = int.Parse(Console.ReadLine());
int result = Math.Abs(number / 100) % 10 == 7;
Console.WriteLine(result);