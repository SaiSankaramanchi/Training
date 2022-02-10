//Conceptual questions (All the conceptual questions for both the assignments are together below)

//1. What type would you choose for the following “numbers”? 
// int, int, int, String, double, string, double, double, long, ulong, long
// 2. Boxing is the process of converting a value type to the type object or to any interface type implemented by this value type. When the common language runtime (CLR) boxes a value type, it wraps the value inside a System.Object instance and stores it on the managed heap. Unboxing extracts the value type from the object. Boxing is implicit; unboxing is explicit. The concept of boxing and unboxing underlies the C# unified view of the type system in which a value of any type can be treated as an object.
//3. Managed resources are those that are pure . NET code and managed by the runtime and are under its direct control. Unmanaged resources are those that are not. File handles, pinned memory, COM objects, database connections etc.
// 4. . NET's garbage collector manages the allocation and release of memory for your application. Each time you create a new object, the common language runtime allocates memory for the object from the managed heap.
// 5. Dividing by zero is an operation that has no meaning in ordinary arithmetic and is, therefore, undefined.
// 6. Dividing a floating-point value by zero doesn't throw an exception; it results in positive infinity, negative infinity, or not a number (NaN)
// 7. If an integer addition overflows, then the result is the low-order bits of the mathematical sum as represented in some sufficiently large two's-complement format. If overflow occurs, then the sign of the result is not the same as the sign of the mathematical sum of the two operand values
// 8. The difference between the two lies in their return values. The prefix increment returns the value of a variable after it has been incremented.
// 9. A break statement results in the termination of the statement to which it applies ( switch , for , do , or while ). A continue statement is used to end the current loop iteration and return control to the loop statement.
// 10. Similar to a While loop, a For loop consists of three parts: the keyword For that starts the loop, the condition being tested, and the EndFor keyword that terminates the loop.
// 11. = is used for assigning the value to a variable and ==  is used for comparing two values. It returns 1 if both the values are equal otherwise returns 0.
// 12. No it wont compile.
// 13. The underscore (_) character replaces the default keyword to signify that it should match anything if reached. The bodies are now expressions instead of statements. The selected body becomes the switch expression's result.
// 14. The IEnumerable interface permits enumeration by using a foreach loop.
// 15. If a string is going to remain constant throughout the program, then use String class object because a String object is immutable. If a string can change (example: lots of logic and operations in the construction of the string) then using a StringBuilder is the best option.
// 16. Array class provides methods for creating, manipulating, searching, and sorting arrays, thereby serving as the base class for all arrays in the common language runtime.
// 17. Array.Sort()
// 18. Length property
// 19. No, we cannot store multiple datatype in an Array, we can store similar datatype only in an Array.
// 20. The Clone() method returns a new array (a shallow copy) object containing all the elements in the original array. The CopyTo() method copies the elements into another existing array. Both perform a shallow copy. A shallow copy means the contents (each array element) contains references to the same object as the elements in the original array. A deep copy (which neither of these methods performs) would create a new instance of each element's object, resulting in a different, yet identical object.
// Coding questions (together below)
// Question 1
using static System.Console;

WriteLine("--------------------------------------------------------------------------");
WriteLine("Type    Byte(s) of memory               Min                            Max");
WriteLine("--------------------------------------------------------------------------");
WriteLine($"sbyte   {sizeof(sbyte),-4} {sbyte.MinValue,30} {sbyte.MaxValue,30}");
WriteLine($"byte    {sizeof(byte),-4} {byte.MinValue,30} {byte.MaxValue,30}");
WriteLine($"short   {sizeof(short),-4} {short.MinValue,30} {short.MaxValue,30}");
WriteLine($"ushort  {sizeof(ushort),-4} {ushort.MinValue,30} {ushort.MaxValue,30}");
WriteLine($"int     {sizeof(int),-4} {int.MinValue,30} {int.MaxValue,30}");
WriteLine($"uint    {sizeof(uint),-4} {uint.MinValue,30} {uint.MaxValue,30}");
WriteLine($"long    {sizeof(long),-4} {long.MinValue,30} {long.MaxValue,30}");
WriteLine($"ulong   {sizeof(ulong),-4} {ulong.MinValue,30} {ulong.MaxValue,30}");
WriteLine($"float   {sizeof(float),-4} {float.MinValue,30} {float.MaxValue,30}");
WriteLine($"double  {sizeof(double),-4} {double.MinValue,30} {double.MaxValue,30}");
WriteLine($"decimal {sizeof(decimal),-4} {decimal.MinValue,30} {decimal.MaxValue,30}");
WriteLine("--------------------------------------------------------------------------");

//Question 2

using System;
using System.Numerics;

public class CenturiesToNanoseconds
{
    public static void Main()
    {
        int centuries = int.Parse(Console.ReadLine());
        int years = centuries * 100;
        int days = (int)(years * 365.2422);
        long hours = (long)(days * 24);
        long minutes = hours * 60;
        ulong seconds = (ulong)(minutes * 60);
        ulong miliseconds = (ulong)(seconds * 1000);
        BigInteger microseconds = miliseconds * 1000;
        BigInteger nanoseconds = microseconds * 1000;

        Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {miliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
    }
}

//Question 3

using static System.Console;

for (int i = 1; i <= 100; i++)
{
    if (i % 15 == 0)
    {
        Write("FizzBuzz");
    }
    else if (i % 5 == 0)
    {
        Write("Buzz");
    }
    else if (i % 3 == 0)
    {
        Write("Fizz");
    }
    else
    {
        Write(i);
    }

    
    if (i < 100) Write(", ");

    
    if (i % 10 == 0) WriteLine();
}
WriteLine();

//Question 4 (Star Pattern)

public class Program
{

    public static void Main()
    {
        int number, i, k, count = 1;
        Console.Write("Enter number of rows\n");
        number = int.Parse(Console.ReadLine());
        count = number - 1;
        for (k = 1; k <= number; k++)
        {
            for (i = 1; i <= count; i++)
                Console.Write(" ");
            count--;
            for (i = 1; i <= 2 * k - 1; i++)
                Console.Write("*");
            Console.WriteLine();
        }
        count = 1;
        for (k = 1; k <= number - 1; k++)
        {
            for (i = 1; i <= count; i++)
                Console.Write(" ");
            count++;
            for (i = 1; i <= 2 * (number - k) - 1; i++)
                Console.Write("*");
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}

/*
           Write a program that greets the user using the appropriate greeting for the time of day. 
           Use only if, not else or switch, statements to do so. Be sure to include the following greetings:
           •"Good Morning"
           •"Good Afternoon"
           •"Good Evening"
           •"Good Night"

           It's up to you which times should serve as the starting and ending ranges for each of the greetings. 
           If you need a refresher on how to get the current time, see Working with Dates and Times lesson. 
           When testing your program, you'll probably want to use a DateTime variable you define, rather than the current time. 
           Once you're confident the program works correctly, you can substitute DateTime.Now for your variable 
           (or keep your variable and just assign DateTime.Now as its value, which is often a better approach).			
       */
// Message prompt which greets according to time.
namespace ConsoleApplication
{
    public class Program
    {
       

        public static void Main()
        {


            DateTime currentDateTime = DateTime.Now;
            int currentHour = currentDateTime.Hour;
            int startMorningHour = 6;
            int startAfternoonHour = 12;
            int startEveningHour = 17;
            int startNightHour = 22;

            if (startMorningHour <= currentHour && currentHour < startAfternoonHour)
            {
                Console.WriteLine("Good morning!");
            }

            ;
            if (startAfternoonHour <= currentHour && currentHour < startEveningHour)
            {
                Console.WriteLine("Good Afternoon!");
            }

            ;
            if (startEveningHour <= currentHour && currentHour < startNightHour)
            {
                Console.WriteLine("Good Evening!");
            }

            ;
            if (startNightHour <= currentHour || currentHour < startMorningHour)
            {
                Console.WriteLine("Good Night!");
            }

            ;

            Console.WriteLine("Right now it is {0}:{1} o'clock.", currentDateTime.Hour, currentDateTime.Minute);
        }
    }
}

//Prime numbers

class GFG
{
    
    static public void Main()
    {

        
        int a, b, i, j, flag;

        
        Console.Write(
          "Enter lower bound of the interval: ");
        a = Convert.ToInt32(
          Console.ReadLine()); 

        
        Console.Write(
          "\nEnter upper bound of the interval: ");
        b = Convert.ToInt32(
          Console.ReadLine()); 

        
        Console.Write("\nPrime numbers between " + a
                      + " and " + b + " are: ");

       
     
        if (a == 1)
        {
            Console.Write(a + " ");
            a++;
            if (b >= 2)
            {
                Console.Write(a + " ");
                a++;
            }
        }
        if (a == 2)
        {
            Console.Write(a + " ");
        }

        
        
        if (a % 2 == 0)
        {
            a++;
        }


        for (i = a; i <= b; i = i + 2)
        {

         
            flag = 1;

          
            for (j = 2; j * j <= i; ++j)
            {
                if (i % j == 0)
                {
                    flag = 0;
                    break;
                }
            }

          
            if (flag == 1)
            {
                Console.Write(i + " ");
            }
        }
    }
}
