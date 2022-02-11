//Conceptual Questions:

//Question 1:  The six combinations of access modifier keywords and their effects are
//described in the following list:
//private: This modifier makes a member only visible inside the class.
//internal: This modifier makes a member only visible inside the class or within
//the same assembly.
//protected: This modifier makes a member only visible inside the class or
//derived classes.
//internal protected: This modifier makes a member only visible inside the
//class, derived classes, or within the same assembly.
// private protected: This modifier makes a member only visible inside the class
//or derived classes and within the same assembly.
//public: This modifier makes a member visible everywhere.

//Question 2:  The difference between the static, const, and readonly keywords when
//applied to a type member are described in the following list:
//static: This keyword makes the member shared by all instances and it must be
//accessed through the type, not an instance of the type.
//const: This keyword makes the field a fixed literal value that must never change
//because during the compilation, assemblies that use the field copy the literal
//value at the time of compilation.
//readonly: This keyword restricts the field so that it can only be assigned to
//using a constructor or field initializer at runtime.

//Question 3:  A constructor allocates memory and initializes field values.

//Question 4:  If you don't apply the [Flags] attribute to an enum type when you want to
//store combined values, then a stored enum value that is a combination will return as the
//stored integer value instead of a comma-separated list of text values.

//Question 5: You can use the partial keyword to split the definition of a type over multiple
//files.

//Question 6:  A data structure consisting of multiple parts. They are used when you want to
//store multiple values as a unit without defining a type for them.

//Question 7:  The C# record keyword defines a data structure that is immutable to enable
//a more functional programming style. Like a class, a record can have properties and
//methods, but the values of properties can only be set during initialization.

//Question 8:  Overloading is when you define more than one method with the same method
//name and different input parameters.

//Question 9:  A field is a data storage location that can be referenced. A property is one or a
//pair of methods that get and/or set a value. The value for a property is often stored in a
//private field.

//Question 10: You make a method parameter optional by assigning a default value to it in
//the method signature.

//Question 11: An abstract class allows you to create functionality that subclasses can implement or override. 
// An interface only allows you to define functionality, not implement it. And whereas a class can extend 
// only one abstract class, it can take advantage of multiple interfaces. 

//Question 12: Public

// True False Questions

    //1.True
    //2.True
    //3.False
    //4.False
    //5.True 
    //6.True
    //7.True
    //8.False
    //9.False
    //10.True
    //11.False
    //12.True

// All the coding questions in this assignement are combineed in the same order as in the assignemnet page below:
// Question 1 (Reverse Array)

static void Main(string[] args)
{
    int[] numbers = GenerateNumbers();
    Reverse(numbers);
    PrintNumbers(numbers);
}

// Generates array of numbers and returns array
static int[] GenerateNumbers()
{
    int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    return numbers;
}

// Reverses array to print backwards from 10 to 1
static void Reverse(int[] numbers)
{
    for (int i = 0; i < number.Length / 2; i++)
    {
        int tmp = numbers[index];
        numbers[index] = numbers[numbers.Length - index - 1];
        numbers[numbers.Length - index - 1] = tmp;
    }
}

// Prints numbers in array after order has been reversed
static void PrintNumbers(int[] numbers)
{
    for (int index = 0; index < numbers.Length; index++)
    {
        Console.WriteLine(numbers[index]);
    }

    Console.WriteLine();
}

// Question 2 (Fibonacci)

public static int GetNthFibonacci_Ite(int n)
{
    int number = n - 1; //Need to decrement by 1 since we are starting from 0  
    int[] Fib = new int[number + 1];
    Fib[0] = 0;
    Fib[1] = 1;
    for (int i = 2; i <= number; i++)
    {
        Fib[i] = Fib[i - 2] + Fib[i - 1];
    }
    return Fib[number];
}

// Question 3

//Abstraction
abstract class MobilePhone
{
    public void Calling();
    public void SendSMS();
}
public class Nokia1400 : MobilePhone { }
public class Nokia2700 : MobilePhone
{
    public void FMRadio();
    public void MP3();
    public void Camera();
}
public class BlackBerry : MobilePhone
{
    public void FMRadio();
    public void MP3();
    public void Camera();
    public void Recording();
    public void ReadAndSendEmails();
}

//Encapsulation

class Bag
{
    Object book;
    Object pen;
    ReadBook();
}

//Inheritance

public class ParentClass
{
    public ParentClass()
    {
        Console.WriteLine("Parent Constructor.");
    }
    public void print()
    {
        Console.WriteLine("I'm a Parent Class.");
    }
}
public class ChildClass : ParentClass
{
    public ChildClass()
    {
        Console.WriteLine("Child Constructor.");
    }
    public static void Main()
    {
        ChildClass child = new ChildClass();
        child.print();
    }
}

// Polymorphism

public class TestData
{
    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }
    public int Add(int a, int b)
    {
        return a + b;
    }
}
class Program
{
    static void Main(string[] args)
    {
        TestData dataClass = new TestData();
        int add2 = dataClass.Add(45, 34, 67);
        int add1 = dataClass.Add(23, 34);
    }
}

// Question 4

abstract class Teacher
{
    public void Class();
    public void Timing();
}
public class ProfessorJanet : Teacher { }

abstract class Student
{
    public void Class();
    public void Schedule();
}
public class StudentJanet : Student { }

// Question 5

class Student
{
    private Object book;
    private Object pen;
    StudySchedule();
}
class Teacher
{
    private Object Laptop;
    private Object ID;
    TeachScedule();
}

// Question 6
//main for color and ball classes

namespace _03.Designing_and_Building_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Ball ballOne = new Ball(20, 30, 20, 30);
            ballOne.Throw();
            Console.WriteLine(ballOne.TimesThrown);
            ballOne.Pop();
            Console.WriteLine(ballOne.Size);
            try
            {
                ballOne.Throw();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
    }
}
//ball.cs
namespace _03.Designing_and_Building_Classes.Classes
{
    public class Ball
    {
        private int size;
        public Color color { get; set; }

        private int timesThrown;

        public Ball(int size, params int[] colors)
        {
            this.Size = size;
            if (colors.Length == 3)
            {
                this.color = new Color(colors[0], colors[1], colors[2]);
            }
            else if (colors.Length == 4)
            {
                this.color = new Color(colors[0], colors[1], colors[2], colors[3]);
            }
            this.TimesThrown = 0;
        }

        public int Size
        {
            get { return this.size; }
            set { this.size = value; }
        }

        public int TimesThrown
        {
            get { return this.timesThrown; }
            set { this.timesThrown = value; }
        }

        public void Pop()
        {
            this.Size = 0;
        }

        public void Throw()
        {
            if (this.Size > 0)
            {
                this.TimesThrown++;
            }
            else
            {
                throw new ArgumentException("The ball has been popped!");
            }
        }

    }
}
//color.cs
namespace _03.Designing_and_Building_Classes.Classes
{
    public class Color
    {
        private int red;
        private int green;
        private int blue;
        private int alpha;

        public Color(int red, int green, int blue, int alpha)
        {
            this.Red = red;
            this.Green = green;
            this.Blue = blue;
            this.Alpha = alpha;
        }

        public Color(int red, int green, int blue)
        {
            this.Red = red;
            this.Green = green;
            this.Blue = blue;
            this.Alpha = 255;
        }

        public int Red
        {
            get { return this.red; }
            set { this.red = value; }
        }

        public int Green
        {
            get { return this.green; }
            set { this.green = value; }
        }

        public int Blue
        {
            get { return this.blue; }
            set { this.blue = value; }
        }

        public int Alpha
        {
            get { return this.alpha; }
            set { this.alpha = value; }
        }


        public int Grayscale()
        {
            return (this.Blue + this.Red + this.Green) / 3;
        }
    }
}
