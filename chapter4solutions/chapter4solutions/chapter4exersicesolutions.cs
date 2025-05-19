/* Exercises 
1. Write a program that reads from the console three numbers of type int and prints their sum. 
Console.Write("Enter any number: ");
string str = Console.ReadLine();
int number1 ;
bool parsenumber1 = Int32.TryParse(str, out number1) ;
Console.WriteLine(parsenumber1 ? ": " + number1 : "Enter and integer number.");
Console.Write("Enter any number: ");
string str2 = Console.ReadLine();
int number2;
bool parsenumber2 = Int32.TryParse(str2, out number2);
Console.WriteLine(parsenumber2 ? ": " + number2 : "Enter and integer number.");
Console.Write("Enter any number: ");
string str3 = Console.ReadLine();
int number3;
bool parsenumber3 = Int32.TryParse(str3, out number3);
Console.WriteLine(parsenumber3 ? ": " + number3 : "Enter and integer number.\n\n" );

Console.WriteLine("The sum of {0} + {1} +{2} = {3}", number1, number2, number3, number1 + number2 + number3);
2. Write a program that reads from the console the radius "r" of a circle 
and prints its perimeter and area. 
Console.Write("Enter radius of the circle: ");
string str = Console.ReadLine();
int radius;
bool parseArea = Int32.TryParse(str, out radius);
double pi = Math.Abs(3.14);
double Perimeter = Math.Round(2 *  pi * radius, 2) ;
double Area = Math.Round(pi*radius*radius, 2);
Console.Write("With a radius of {0}, the perimeter of circle X is {1}cm and an area size 
of {2}cm^2.", radius, Perimeter, Area);


3. A given company has name, address, phone number, fax number, web 
site and manager. The manager has name, surname and phone number. 
Write a program that reads information about the company and its 
manager and then prints it on the console. 

Console.Write("Company Name: ");
string companyName = Console.ReadLine();
Console.Write("Company Address: ");
string companyAddress = Console.ReadLine();
Console.Write("Phone Number: ");
ulong phoneNumber = ulong.Parse(Console.ReadLine());
Console.Write("Fax Number: ");
int faxNumber = int.Parse(Console.ReadLine());
Console.Write("Website: ");
string Website = Console.ReadLine();
Console.Write("Manager First Name: ");
string managerFirstName = Console.ReadLine();
Console.Write("Manager Last Name: ");
string managerLastName = Console.ReadLine();

Console.WriteLine("\nCompany- {0}, Address - {1}, Phone Number - {2}, Fax Number - {3}, Website - {4}\n",
    companyName, companyAddress, phoneNumber, faxNumber, Website);
Console.WriteLine("{0} manager from {1} will arrive in 10 minites.", managerFirstName + managerLastName, companyName);

4. Write a program that prints three numbers in three virtual columns 
on the console. Each column should have a width of 10 characters and 
the numbers should be left aligned. The first number should be an 
integer in hexadecimal; the second should be fractional positive; and 
the third – a negative fraction. The last two numbers have to be 
rounded to the second decimal place. 

int number1 = 0X10;
double number2 = 1.0/2;
double number3 = -1.0/3;

Console.Write("|{0, -10:X}|", number1);
Console.Write("|{0, -10:F2}|", number2);
Console.Write("|{0, -10:F2}|", number3);
5. Write a program that reads from the console two integer numbers (int) 
and prints how many numbers between them exist, such that the 
remainder of their division by 5 is 0. Example: in the range (14, 25) 
there are 3 such numbers: 15, 20 and 25. 

class Numbersbetween2integersdivisibleby5
{
    static void Main()
    {
        int counter = 0;

        Console.Write("Enter first Integer: ");
        int inTeger1 = int.Parse( Console.ReadLine());
        Console.Write("Enter second Integer: ");
        int inTeger2 = int.Parse(Console.ReadLine());

        for (int i = inTeger1; i <= inTeger2; i++)
        {
            if (i % 5 == 0) counter++;
        }
        Console.WriteLine("The numbers between integers {0} and {1} is {2}", inTeger1, inTeger2, counter);

    }
}
6. Write a program that reads two numbers from the console and prints the 
greater of them. Solve the problem without using conditional 
statements. 
Console.Write("Enter number: ");
int number1 = Int32.Parse(Console.ReadLine());
Console.Write("Enter number: ");
int number2 = Int32.Parse(Console.ReadLine());

int start = Math.Min(number1, number2);
int end = Math.Max(number1, number2);
Console.WriteLine(start < end ? end: start);
7. Write a program that reads five integer numbers and prints their 
sum. If an invalid number is entered the program should prompt the user 
to enter another number. 
8. Write a program that reads five numbers from the console and prints the 
greatest of them. 
9. Write a program that reads an integer number n from the console. After 
that reads n numbers from the console and prints their sum. 
10. Write a program that reads an integer number n from the console and 
prints all numbers in the range [1…n], each on a separate line. 
11. Write a program that prints on the console the first 100 numbers in the 
Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, … 
12. Write a program that calculates the sum (with precision of 0.001) of 
the following sequence: 1 + 1/2 - 1/3 + 1/4 - 1/5 + … */