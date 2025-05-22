/*Exercises 
1. Write an if-statement that takes two integer variables and exchanges 
their values if the first one is greater than the second one. 

SOLUTION 
class Programcheckslargestints
{
    static void Main()
    {
        Console.Write("This programs takes two integer numbers and exchanges \n" +
            "their values if the first one is greater than the second one.");
        Console.Write("\n\nEnter first number: ");
        int number1 = Int32.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int number2 = Int32.Parse(Console.ReadLine());

        if (number1 > number2)
        {
            
            Console.WriteLine("Since number1 is larger than number 2. Number 1 = {1} and Number 2 = {0}", number1, number2);

        }
        else
        {
            Console.WriteLine("The numbers remain the same, number 1 = {0} and number 2= {1}", number1, number2);
        }
        
    }
}
2. Write a program that shows the sign (+ or -) of the product of three real 
numbers, without calculating it. Use a sequence of if operators. 
3. Write a program that finds the biggest of three integers, using nested 
if statements. 
SOLUTION
class ProgramLargestInt
{
    static void Main()
    {
        Console.Write("What is the largest number");
        Console.Write("\n\nEnter first number: ");
        int A = Int32.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int B = Int32.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int C = Int32.Parse(Console.ReadLine());

        if (C > B & C>A)
        {
            
            Console.WriteLine("C is the largest {0}", C);

        }
        else
        {
            if (B>C && B > A)
            {
                Console.WriteLine("B is the largest: {0}", B);
            }
            else
            {
                Console.WriteLine("A is the largest: {0}", A);

            }
            
        }
        
    }
}
4. Sort 3 real numbers in descending order. Use nested if statements. 
5. Write a program that asks for a digit (0-9), and depending on the input, 
shows the digit as a word (in English). Use a switch statement. 
Console.WriteLine("Enter a number between 0-9: ");
int number = int.Parse(Console.ReadLine());
if (number <= 9)
{
    switch (number)
    {
        case 0:
            Console.WriteLine("Number: {0}, Word: {1}", number, "Zero"); break;
        case 1:
            Console.WriteLine("Number: {0}, Word: {1}", number, "One"); break;
        case 2:
            Console.WriteLine("Number: {0}, Word: {1}", number, "Two"); break;
        case 3:
            Console.WriteLine("Number: {0}, Word: {1}", number, "Three"); break;
        case 4:
            Console.WriteLine("Number: {0}, Word: {1}", number, "Four"); break;
        case 5:
            Console.WriteLine("Number: {0}, Word: {1}", number, "Five"); break;
        case 6:
            Console.WriteLine("Number: {0}, Word: {1}", number, "Six"); break;
        case 7:
            Console.WriteLine("Number: {0}, Word: {1}", number, "Seven"); break;
        case 8:
            Console.WriteLine("Number: {0}, Word: {1}", number, "Eight"); break;
        case 9:
            Console.WriteLine("Number: {0}, Word: {1}", number, "Nine"); break;

        default:
            Console.WriteLine("Number is > 9, no response."); break;

    }

}
else
{
    Console.WriteLine("Try a smaller number than 9.");
}
6. Write a program that gets the coefficients a, b and c of a quadratic 
equation: ax2 + bx + c, calculates and prints its real roots (if they exist). 
Quadratic equations may have 0, 1 or 2 real roots. 
7. Write a program that finds the greatest of given 5 numbers. 
8. Write a program that, depending on the user’s choice, inputs int, double 
or string variable. If the variable is int or double, the program 
increases it by 1. If the variable is a string, the program appends "*" at 
the end. Print the result at the console. Use switch statement. 
9. We are given 5 integer numbers. Write a program that finds those 
subsets whose sum is 0. Examples: - If we are given the numbers {3, -2, 1, 1, 8}, the sum of -2, 1 and 1 
is 0. - If we are given the numbers {3, 1, -7, 35, 22}, there are no subsets 
with sum 0. 
Chapter 5. Conditional Statements 209 
10. Write a program that applies bonus points to given scores in the range 
[1…9] by the following rules: - If the score is between 1 and 3, the program multiplies it by 10. 
- If the score is between 4 and 6, the program multiplies it by 100. - If the score is between 7 and 9, 
the program multiplies it by 1000. - If the score is 0 or more than 9, the program prints an error 
message. 
Console.WriteLine("This program gives bonus points.");
Console.Write("Enter number: ");
int score = int.Parse(Console.ReadLine());
if (score>9 || score== 0)
{
    Console.WriteLine("Error Message. Number is too big. ");
}
else if (score<=9 && score >= 7)
{
    Console.WriteLine("Bonus*1000: {0}", score * 1000);
}
else if (score<=3 && score >= 1)
{
    Console.WriteLine("Bonus*10: {0}", score * 10);
}
else
{
    Console.WriteLine("Bonus*10: {0}", score * 100);
}

11. * Write a program that converts a number in the range [0…999] to 
words, corresponding to the English pronunciation. 
Examples: - 0 --> "Zero" - 12 --> "Twelve" - 98 --> "Ninety eight" - 273 --> "Two hundred seventy 
three" - 400 --> "Four hundred" - 501 --> "Five hundred and one" - 711 --> "Seven hundred and eleven" */

/*Write a program that, depending on the user’s choice, inputs int, double 
or string variable. If the variable is int or double, the program 
increases it by 1. If the variable is a string, the program appends "*" at 
the end. Print the result at the console. Use switch statement.*/





