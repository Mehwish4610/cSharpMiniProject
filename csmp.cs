using System;
using System.IO;
using System.Collections.Generic;

public interface IResizable
{
    void ResizeWidth(int width);
    void ResizeHeight(int height);
}

public class Rectangle : IResizable
{
    private int width;
    private int height;

    public Rectangle(int width, int height)
    {
        this.width = width;
        this.height = height;
    }

    public void ResizeWidth(int newWidth)
    {
        width = newWidth;
    }

    public void ResizeHeight(int newHeight)
    {
        height = newHeight;
    }

    public void PrintSize()
    {
        Console.WriteLine("Width: " + width + ", Height: " + height);
    }
}

// Abstract class representing a geometric shape
public abstract class Shape
{
    // Abstract method to calculate perimeter
    public abstract double CalculatePerimeter();
}

// Concrete class representing a rectangle
public class Rectangle1 : Shape
{
    public double Length { get; set; }
    public double Width { get; set; }

    // Constructor for initializing length and width
    public Rectangle1(double length, double width)
    {
        Length = length;
        Width = width;
    }

    // Implementation of abstract method to calculate perimeter
    public override double CalculatePerimeter()
    {
        return 2 * (Length + Width);
    }
}

// Concrete class representing a circle
public class Circle1 : Shape
{
    public double Radius { get; set; }

    // Constructor for initializing the radius
    public Circle1(double radius)
    {
        Radius = radius;
    }

    // Implementation of abstract method to calculate perimeter
    public override double CalculatePerimeter()
    {
        return 2 * Math.PI * Radius;
    }
}

public abstract class Shapez
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing Shape");
    }

    public virtual void Erase()
    {
        Console.WriteLine("Erasing Shape");
    }
}

public class Circlez : Shapez
{
    public override void Draw()
    {
        Console.WriteLine("Drawing Circle");
    }
    public override void Erase()
    {
        Console.WriteLine("Erasing Circle");
    }
}

public class Trianglez : Shapez
{
    public override void Draw()
    {
        Console.WriteLine("Drawing Triangle");
    }
    public override void Erase()
    {
        Console.WriteLine("Erasing Triangle");
    }
}

public class Squarez : Shapez
{
    public override void Draw()
    {
        Console.WriteLine("Drawing Square");
    }

    public override void Erase()
    {
        Console.WriteLine("Erasing Square");
    }
}

public class Program10
{
    public static void polymorphism()
    {
        Shapez[] shapesz = new Shapez[3];
        shapesz[0] = new Circlez();
        shapesz[1] = new Trianglez();
        shapesz[2] = new Squarez();
        foreach (Shapez shapez in shapesz)
        {
            shapez.Draw();
            shapez.Erase();
        }
    }
}

public class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("CCCCC       #     #     MMMMMMM IIIII NN    N IIIII  PPPP   RRRR   OOOOO JJJJJ EEEE CCCC TTTTT");
            Console.WriteLine("C       ## # ### # #    M  M  M   I   N N   N   I   P    P R    R  O   O   J   E    C      T");
            Console.WriteLine("C         #     #       M  M  M   I   N  N  N   I   PPPPP  R R R   O   O   J   EEEE C      T");
            Console.WriteLine("C     ## # ### # #      M  M  M   I   N   N N   I   P      R    R  O   O   J   E    C      T");
            Console.WriteLine("CCCCC   #     #         M  M  M IIIII N    NN IIIII P      R     R OOOOO JJJ   EEEE CCCC   T");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("+--------------------------------------------------------------------------------------------+ ");
			Console.WriteLine("+ Name : MEHWISH                                    Submitted to: Victor Ikechukwu Agughasi  +");
			Console.WriteLine("+ USN: 4MH21CS050                                       Department of Computer Science       +");
			Console.WriteLine("+ Semester:5                                                     and Engineering             +");
			Console.WriteLine("+ Section: 'A'                                          Maharaja Institute of Technology     +");
			Console.WriteLine("+--------------------------------------------------------------------------------------------+ ");
			Console.WriteLine(" ");
			Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("+--------------------------------------------------------------------------------------------+ ");
            Console.WriteLine("+  Select a program to run (1-12):                                                           +");
            Console.WriteLine("+--------------------------------------------------------------------------------------------+ ");
            Console.WriteLine("+ 1.  + Arithmetic Operations                                                                +");
            Console.WriteLine("+-----+--------------------------------------------------------------------------------------+ ");
            Console.WriteLine("+ 2.  + Armstrong Number                                                                     +");
            Console.WriteLine("+-----+--------------------------------------------------------------------------------------+ ");
            Console.WriteLine("+ 3.  + Find Substrings                                                                      +");
            Console.WriteLine("+-----+--------------------------------------------------------------------------------------+ ");
            Console.WriteLine("+ 4.  + Divide by Zero Exception                                                             +");
            Console.WriteLine("+-----+--------------------------------------------------------------------------------------+ ");
            Console.WriteLine("+ 5.  + Pascal's Triangle                                                                    +");
            Console.WriteLine("+-----+--------------------------------------------------------------------------------------+ ");
            Console.WriteLine("+ 6.  + Floyd's Triangle                                                                     +");
            Console.WriteLine("+-----+--------------------------------------------------------------------------------------+ ");
            Console.WriteLine("+ 7.  + Read and Copy Text File                                                              +");
            Console.WriteLine("+-----+--------------------------------------------------------------------------------------+ ");
            Console.WriteLine("+ 8.  + Stack Operations                                                                     +");
            Console.WriteLine("+-----+--------------------------------------------------------------------------------------+ ");
            Console.WriteLine("+ 9.  + Complex Numbers                                                                      +");
            Console.WriteLine("+-----+--------------------------------------------------------------------------------------+ ");
            Console.WriteLine("+ 10. + Polymorphic Shape Drawer                                                             +");
            Console.WriteLine("+-----+--------------------------------------------------------------------------------------+ ");
            Console.WriteLine("+ 11. + Perimeter Calculator for Rectangle and Circle                                        +");
            Console.WriteLine("+-----+--------------------------------------------------------------------------------------+ ");
            Console.WriteLine("+ 12. + Resizable Rectangle                                                                  +");
            Console.WriteLine("+-----+--------------------------------------------------------------------------------------+ ");
            Console.WriteLine("+ 13. + Exit                                                                                 +");
            Console.WriteLine("+-----+--------------------------------------------------------------------------------------+ ");
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Aop.PerformArithmeticOperations();
                    break;
                case 2:
                    Ap.CheckArmstrongNumber();
                    break;
                case 3:
                    sub.FindSubstrings();
                    break;
                case 4:
                    div.DivideByZeroException();
                    break;
                case 5:
                    pt.DrawPascalsTriangle();
                    break;
                case 6:
                    ft.DrawFloydsTriangle();
                    break;
                case 7:
                    ractf.ReadAndCopyTextFile();
                    break;
                case 8:
                    sop.PerformStackOperations();
                    break;
                case 9:
                    compop.PerformComplexNumberOperations();
                    break;
                case 10:
                    Program10.polymorphism();
                    break;
                case 11:
                    Console.Write("Enter the length of the rectangle: ");
                    double rectangleLength = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter the width of the rectangle: ");
                    double rectangleWidth = Convert.ToDouble(Console.ReadLine());

                    Rectangle1 rectangle = new Rectangle1(rectangleLength, rectangleWidth);
                    Console.WriteLine("Dimensions of Rectangle: length = " + rectangleLength + " and width = " + rectangleWidth);
                    Console.WriteLine("Perimeter of Rectangle: " + rectangle.CalculatePerimeter());

                    // Create a circle by taking user input for radius
                    Console.Write("Enter the radius of the circle: ");
                    double circleRadius = Convert.ToDouble(Console.ReadLine());

                    Circle1 circle = new Circle1(circleRadius);
                    Console.WriteLine("Radius of Circle: " + circleRadius);
                    Console.WriteLine("Perimeter of Circle: " + circle.CalculatePerimeter());
                    break;
                case 12:
                    prr.PerformResizableRectangle();
                    break;
                case 13:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine(" ");
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 13.");
                    break;
            }
            Console.ResetColor();
            Console.WriteLine(" ");
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}

class Aop
{
    public static void PerformArithmeticOperations()
    {
        try
        {
            while (true)
            {
                Console.WriteLine(" ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" CCCC  AAAAA  L      CCCC  U   U  L      AAAA TTTTT OOO  RRRR ");
                Console.WriteLine("C      A   A  L     C      U   U  L     A   A   T  O   O R   R");
                Console.WriteLine("C      AAAAA  L     C      U   U  L     AAAAA   T  O   O RRRR ");
                Console.WriteLine("C      A   A  L     C      U   U  L     A   A   T  O   O R   R");
                Console.WriteLine(" CCCC  A   A  LLLLL  CCCC   UUU   LLLLL A   A   T   OOO  R    R");
                Console.WriteLine(" ");

                Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("+-----------------------+ ");
                Console.WriteLine("+ Choose an operation:  +");
				Console.WriteLine("+-----------------------+ ");
                Console.WriteLine("+ 1. + Addition         +");
				Console.WriteLine("+-----------------------+ ");
                Console.WriteLine("+ 2. + Subtraction      +");
				Console.WriteLine("+-----------------------+ ");
                Console.WriteLine("+ 3. + Multiplication   +");
				Console.WriteLine("+-----------------------+");
                Console.WriteLine("+ 4. + Division         +");
				Console.WriteLine("+-----------------------+ ");
				Console.WriteLine("+ 5. + Exponential      +");
				Console.WriteLine("+-----------------------+ ");
				Console.WriteLine("+ 6. + Square root      +");
				Console.WriteLine("+-----------------------+ ");
				Console.WriteLine("+ 7. + Cube root        +");
				Console.WriteLine("+-----------------------+ ");
                Console.WriteLine("+ 8. + Exit             +");
				Console.WriteLine("+-----------------------+ ");
				
				Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        PerformOperation('+');
                        break;
                    case "2":
                        PerformOperation('-');
                        break;
                    case "3":
                        PerformOperation('*');
                        break;
                    case "4":
                        PerformOperation('/');
                        break;
					case "5":
						PerformOperation('5');
						break;
					case "6":
						PerformOperation('6');
						break;
					case "7":
						PerformOperation('7');
						break;
                    case "8":
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }
            }
        }
        catch (FormatException)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid input. Please enter valid numeric values.");
        }
        catch (DivideByZeroException ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(ex.Message);
        }
    }

    private static void PerformOperation(char operation)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Enter first number: ");
        double num1 = ConvertToValidNumeric(Console.ReadLine());

        Console.Write("Enter second number: ");
        double num2 = ConvertToValidNumeric(Console.ReadLine());

        double result2 = 0;

        switch (operation)
        {
            case '+':
                result2 = num1 + num2;
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.WriteLine("Sum of given two numbers is: " + result2);
				Console.ResetColor();
                break;
            case '-':
                result2 = num1 - num2;
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.WriteLine("Difference of given to numbers is: " + result2);
				Console.ResetColor();
                break;
            case '*':
                result2 = num1 * num2;
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.WriteLine("Product of given two numbers is: " + result2);
				Console.ResetColor();
                break;
            case '/':
                if (num2 == 0)
                {
                    throw new DivideByZeroException("Division by zero is not allowed.");
                }
                result2 = num1 / num2;
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.WriteLine("Quotient of "+num1 +" divided by "+num2 +" is: " + result2);
				Console.ResetColor();
                break;
			case '5':
				result2 =Math.Pow(num1, num2);
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.WriteLine("Exponential value of "+ num1 + " to the power of "+ num2+" is: " + result2);
				Console.ResetColor();
				break;
			case '6':
				double sq1 =Math.Sqrt(num1);
				double sq2=  Math.Sqrt(num2);
				Console.WriteLine("Square Root of " + num1 + ": " +sq1.ToString("F2"));
				Console.WriteLine("Square Root of " + num2 + ": " +sq2.ToString("F2"));
				break;
			case '7':
				double cb1=Math.Pow(num1, 1.0 / 3);
				double cb2=Math.Pow(num2, 1.0 / 3);
			    Console.WriteLine("Cube Root of " + num1 + ": " +cb1.ToString("F2") );
				Console.WriteLine("Cube Root of " + num2 + ": " +cb2.ToString("F2") );
				break;
        }
    }
	
    private static double ConvertToValidNumeric(string input)
    {
		double result1;
        if (!double.TryParse(input, out result1))
        {
            throw new FormatException("Input is not a valid integer or float.");
        }
        return result1;
    }
}

class Ap
{
    public static void CheckArmstrongNumber()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("                                                               ''' ");
        Console.WriteLine("AAAAA  RRRR  MMMMMMM SSSSS TTTTT  RRRR   OOOOO NN   NN GGGGG   '' SSSSS");
        Console.WriteLine("A   A R    R M  M  M S       T   R    R  O   O N N   N G        ' S");
        Console.WriteLine("AAAAA R R R  M  M  M SSSSS   T   R R R   O   O N  N  N G  GG   '  SSSSS");
        Console.WriteLine("A   A R   R  M  M  M     S   T   R    R  O   O N   N N G   G          S");
        Console.WriteLine("A   A R    R M  M  M SSSSS   T   R     R OOOOO N    NN GGGGG      SSSSS");
        Console.WriteLine(" ");
        Console.WriteLine("NN   NN U  U MMMMMMM  BBBB  EEEEE  RRRR   SSSSS");
        Console.WriteLine("N N   N U  U M  M  M B    B E     R    R  S");
        Console.WriteLine("N  N  N U  U M  M  M BBBBB  EEEEE R R R   SSSSS");
        Console.WriteLine("N   N N U  U M  M  M B    B E     R    R      S");
        Console.WriteLine("N    NN UUUU M  M  M BBBBB  EEEEE R     R SSSSS");
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("+--------------------------------------------------------------------------------------------------+");
        Console.WriteLine("+  Armstrong numbers are the sum of their own digits to the third power of the number of digits.   + ");
        Console.WriteLine("+                             Example: 153 = 1*1*1 +5*5*5 + 3*3*3                                  +");
        Console.WriteLine("+--------------------------------------------------------------------------------------------------+");
        Console.WriteLine(" ");
        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("+ 1. + Check if the number entered is Armstrong's Number or not?  +");
            Console.WriteLine("+----+------------------------------------------------------------+");
            Console.WriteLine("+ 2. + List all the Armstrong's Numbers within the given range.   +");
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("+ 3. + Return to main menu                                        +");
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine(" ");
            Console.ResetColor();
            Console.Write(" Enter your choice: ");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Csan.CheckSingleArmstrongNumber();
                    break;
                case 2:
                    lar.ListArmstrongNumbersInRange();
                    break;
                case 3:
                    return;
                default:
                    Console.WriteLine(" Invalid choice. Please enter a number between 1 and 2.");
                    break;
            }
        }
    }
}

class Csan
{
    public static void CheckSingleArmstrongNumber()
    {
        Console.Write(" Enter a number to check if it's an Armstrong number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int originalNumber = num;
        int sum = 0;
        int digitCount = cod.CountDigits1(num);

        while (num > 0)
        {
            int digit = num % 10;
            sum += (int)Math.Pow(digit, digitCount);
            num /= 10;
        }

        if (sum == originalNumber)
        {
            Console.WriteLine(originalNumber + " is an Armstrong number.");
        }
        else
        {
            Console.WriteLine(originalNumber + " is not an Armstrong number.");
        }
    }
}

class lar
{
    public static void ListArmstrongNumbersInRange()
    {
        Console.Write(" Enter the starting number of the range: ");
        int start = int.Parse(Console.ReadLine());

        Console.Write(" Enter the ending number of the range: ");
        int end = int.Parse(Console.ReadLine());

        Console.WriteLine(" Armstrong numbers between " + start + " and " + end + " are:");

        for (int number = start; number <= end; number++)
        {
            if (Ian.IsArmstrongNumber(number))
            {
                Console.WriteLine(number);
            }
        }
    }
}

class cod
{
    public static int CountDigits1(int num)
    {
        int count = 0;
        while (num != 0)
        {
            num /= 10;
            count++;
        }
        return count;
    }
}

class Ian
{
    public static bool IsArmstrongNumber(int num)
    {
        int originalNumber = num;
        int sum = 0;
        int digitCount = cod.CountDigits1(num);

        while (num > 0)
        {
            int digit = num % 10;
            sum += (int)Math.Pow(digit, digitCount);
            num /= 10;
        }

        return sum == originalNumber;
    }
}

class sub
{
    public static void FindSubstrings()
    {
        Console.WriteLine("");
        Console.Write(" Enter a string: ");
        string input = Console.ReadLine();

        Console.WriteLine(" Substrings:");

        for (int i = 0; i < input.Length; i++)
        {
            for (int j = 1; j <= input.Length - i; j++)
            {
                Console.WriteLine(input.Substring(i, j));
            }
        }
    }
}

class div
{
    public static void DivideByZeroException()
    {
        try
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("DDDD   IIIII V       V IIIII DDDD   EEEE");
            Console.WriteLine("D   D    I    V     V    I   D   D  E");
            Console.WriteLine("D    D   I     V   V     I   D    D EEEE");
            Console.WriteLine("D   D    I      V V      I   D   D  E");
            Console.WriteLine("DDDD   IIIII     V     IIIII DDDD   EEEE");
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" Enter numerator: ");
            int numerator = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Enter denominator: ");
            int denominator = Convert.ToInt32(Console.ReadLine());

            if (denominator == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                throw new DivideByZeroException(" Denominator cannot be zero.");
            }
            Console.WriteLine(" Result: " + numerator / (double)denominator);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(" Error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(" Error: " + ex.Message);
        }
    }
}

class pt
{
    public static void DrawPascalsTriangle()
    {
        Console.Write("Enter the number of rows for Pascal's Triangle: ");
        int rows = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < rows; i++)
        {
            int number = 1;

            for (int j = 0; j <= i; j++)
            {
                Console.Write(number + " ");
                number = number * (i - j) / (j + 1);
            }
            Console.WriteLine();
        }
    }
}

class ft
{
    public static void DrawFloydsTriangle()
    {
        Console.Write("Enter the number of rows for Floyd's Triangle: ");
        int rows = Convert.ToInt32(Console.ReadLine());

        int number = 1;

        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(number + " ");
                number++;
            }
            Console.WriteLine();
        }
    }
}

class ractf
{
    public static void ReadAndCopyTextFile()
    {
		Console.Write("Enter the path of the text file: NOTE=> Please exclude the double qoutes");
        string filePath = Console.ReadLine();

        try
        {
            string content = System.IO.File.ReadAllText(filePath);
            Console.WriteLine("File content:\n" + content);

            Console.Write("Enter the path to copy the file: ");
            string copyPath = Console.ReadLine();

            System.IO.File.Copy(filePath, copyPath, true);
            Console.WriteLine("File copied successfully.");
        }
        catch (System.IO.FileNotFoundException)
        {
            Console.WriteLine("File not found.");
        }
        catch (System.UnauthorizedAccessException)
        {
            Console.WriteLine("Unauthorized access to the file.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}

class sop
{
    public static void PerformStackOperations()
    {
         Stack<int> stack = new Stack<int>();
		
		Console.ForegroundColor = ConsoleColor.Green;
		Console.WriteLine("+---------------------+");
        Console.WriteLine("+  Stack Operations:  +");
		Console.WriteLine("+---------------------+");
        Console.WriteLine("+ 1. + Push           +");
		Console.WriteLine("+---------------------+");
        Console.WriteLine("+ 2. + Pop            +");
		Console.WriteLine("+---------------------+");
        Console.WriteLine("+ 3. + Display        +");
		Console.WriteLine("+---------------------+");
        Console.WriteLine("+ 4. + Exit           +");
		Console.WriteLine("+---------------------+");
		Console.ResetColor();
        while (true)
        {
            Console.Write("Enter your choice: ");
            int stackChoice = Convert.ToInt32(Console.ReadLine());

            switch (stackChoice)
            {
                case 1:
                    Console.Write("Enter element to push: ");
                    int element = Convert.ToInt32(Console.ReadLine());
                    stack.Push(element);
                    break;
                case 2:
                    if (stack.Count > 0)
                    {
                        int poppedElement = stack.Pop();
                        Console.WriteLine("Popped element: " + poppedElement);
                    }
                    else
                    {
                        Console.WriteLine("Stack is empty.");
                    }
                    break;
                case 3:
                    Console.WriteLine("Stack elements:");
                    foreach (var item in stack)
                    {
                        Console.Write(item + " ");
                    }
                    Console.WriteLine();
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                    break;
            }
        }
    }
}

class compop
{
	public static void PerformComplexNumberOperations()
    {
        try
        {
            Console.Write("Enter real part of first complex number: ");
            double real1 = ConvertToValidNumeric(Console.ReadLine());

            Console.Write("Enter imaginary part of first complex number: ");
            double imag1 = ConvertToValidNumeric(Console.ReadLine());

            Console.Write("Enter real part of second complex number: ");
            double real2 = ConvertToValidNumeric(Console.ReadLine());

            Console.Write("Enter imaginary part of second complex number: ");
            double imag2 = ConvertToValidNumeric(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Sum: " + (real1 + real2) + " + " + (imag1 + imag2) + "i");
            Console.WriteLine("Difference: " + (real1 - real2) + " + " + (imag1 - imag2) + "i");
        }
        catch (FormatException)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid input. Please enter a valid integer or float value.");
        }
		finally
        {
            Console.ResetColor(); // Reset console color
        }
    }

    private static double ConvertToValidNumeric(string input)
    {
		double result;
        if (!double.TryParse(input, out result))
        {
            throw new FormatException("Input is not a valid integer or float.");
        }
        return result;
    }
}

class ComplexNumber
{
    private double real;
    private double imaginary;

    public ComplexNumber(double real, double imaginary)
    {
        this.real = real;
        this.imaginary = imaginary;
    }

    public override string ToString()
    {
        return real + " + " + imaginary + "i";
    }

    public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
    {
        return new ComplexNumber(c1.real + c2.real, c1.imaginary + c2.imaginary);
    }

    public static ComplexNumber operator -(ComplexNumber c1, ComplexNumber c2)
    {
        return new ComplexNumber(c1.real - c2.real, c1.imaginary - c2.imaginary);
    }

    public static ComplexNumber operator *(ComplexNumber c1, ComplexNumber c2)
    {
        double real = (c1.real * c2.real) - (c1.imaginary * c2.imaginary);
        double imaginary = (c1.real * c2.imaginary) + (c2.real * c1.imaginary);
        return new ComplexNumber(real, imaginary);
    }
}

class prr
{
    public static void PerformResizableRectangle()
    {
        Console.Write("Enter the initial width of the rectangle: ");
        int initialWidth = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the initial height of the rectangle: ");
        int initialHeight = Convert.ToInt32(Console.ReadLine());
		
        ResizableRectangle resizableRectangle = new ResizableRectangle(initialWidth, initialHeight);

        while (true)
        {
            Console.WriteLine(" ");
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("+-----------------------------+ ");
            Console.WriteLine("+ What do you want to do?     +");
			Console.WriteLine("+-----------------------------+ ");
            Console.WriteLine("+ 1. + Resize Width           +");
			Console.WriteLine("+-----------------------------+ ");
            Console.WriteLine("+ 2. + Resize Height          +");
			Console.WriteLine("+-----------------------------+ ");
            Console.WriteLine("+ 3. + Print Size             +");
			Console.WriteLine("+-----------------------------+ ");
            Console.WriteLine("+ 4.  Exit                    +");
			Console.WriteLine("+-----------------------------+ ");
			Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
			Console.ResetColor();
            switch (choice)
            {
                case 1:
                    Console.Write("Enter the new width: ");
                    int newWidth = Convert.ToInt32(Console.ReadLine());
                    resizableRectangle.ResizeWidth(newWidth);
                    Console.WriteLine("Width resized to " + newWidth);
                    break;
                case 2:
                    Console.Write("Enter the new height: ");
                    int newHeight = Convert.ToInt32(Console.ReadLine());
                    resizableRectangle.ResizeHeight(newHeight);
                    Console.WriteLine("Height resized to " + newHeight);
                    break;
                case 3:
                    resizableRectangle.PrintSize();
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                    break;
            }
        }
    }
}

class ResizableRectangle : IResizable
{
    private int width;
    private int height;

    public ResizableRectangle(int width, int height)
    {
        this.width = width;
        this.height = height;
    }

    public void ResizeWidth(int newWidth)
    {
        width = newWidth;
    }

    public void ResizeHeight(int newHeight)
    {
        height = newHeight;
    }

    public void PrintSize()
    {
        Console.WriteLine("Width: " + width + ", Height: " + height);
    }
}
