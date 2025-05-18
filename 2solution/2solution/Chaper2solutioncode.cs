/*/ 1. Write an expression that checks whether an integer is odd or even. 
int num = 2;
Console.WriteLine(num % 2 == 0 );

// 2.Write a Boolean expression that checks whether a given integer is divisible by both 5 and 7, without a remainder.

Console.Write("Enter integer (5 / 7) the system checks if its divisible.");
int numm2 = int.Parse(Console.ReadLine());

Console.WriteLine(35 % numm2 == 0 ? "Number is divisible." : "Sorry number indivisble. Try numbers 5 or 7.");

// Write an expression that looks for a given integer if its third digit (right to left) is 7.
Console.Write("Write a number: ");
int number = int.Parse(Console.ReadLine());
bool result = (Math.Abs(number) / 100) % 10 == 7;
Console.WriteLine(result);

// 4. Write an expression that checks whether the third bit in a given integer  is 1 or 0.

int number = 425;
Console.WriteLine("The third number of {0} is 1? {1}", number, ((number >> 3 & 1) == 1));

//5. Write an expression that calculates the area of a trapezoid by given sides a, b and height h.

float a = 2;
float b = 3;
float h = 1;
float area_Trapezoid = (a + b) * h / 2;
Console.WriteLine("The surface area the trapezoid is {0} ", area_Trapezoid);

// 6. Write a program that prints on the console the perimeter and the area of a rectangle by given side and height entered by the user.
Console.Write("Enter Length of your rectangle: ");
float Length = float.Parse(Console.ReadLine());
Console.Write("Enter Width of your rectangle: ");
float Width = float.Parse(Console.ReadLine());

float Area = Length * Width;
float Perimeter = 2 * (Length + Width);
Console.WriteLine("The area of the rectangle with length {0} and a width {1} is {2}", Length, Width, Area);
Console.WriteLine("The perimeter of the rectangle with length {0} and a width {1} is {2}", Length, Width, Perimeter);*/

// 7. The gravitational field of the Moon is approximately 17% of that on the Earth. Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
Console.Write("Enter man's weight: ");
int Weight = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("With a current weight {0} on earth, the weight of the man in moon is {1}",Weight, Weight * 0.17);