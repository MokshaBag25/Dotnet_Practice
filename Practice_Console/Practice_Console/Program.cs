using System;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;
//int currentAssignments = 5;

//int sophia1 = 93;
//int sophia2 = 87;
//int sophia3 = 98;
//int sophia4 = 95;
//int sophia5 = 100;

//int nicolas1 = 80;
//int nicolas2 = 83;
//int nicolas3 = 82;
//int nicolas4 = 88;
//int nicolas5 = 85;

//int zahirah1 = 84;
//int zahirah2 = 96;
//int zahirah3 = 73;
//int zahirah4 = 85;
//int zahirah5 = 79;

//int jeong1 = 90;
//int jeong2 = 92;
//int jeong3 = 98;
//int jeong4 = 100;
//int jeong5 = 97;

//float sophia_Persent = (sophia1 + sophia2 + sophia3 + sophia4 + sophia5) / currentAssignments;

//float nicolas_Persentage = (nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5)/ currentAssignments;

//float zahirah_persentage = (zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5)/ currentAssignments;

//float jeong_persentage = (jeong1 + jeong2 + jeong3 + jeong4 + jeong5)/ currentAssignments;

//Console.WriteLine("Student\t\t" + "Persentage\t" + "grade");
//Console.WriteLine("Sophia\t\t" + sophia_Persent + "\t\tA");
//Console.WriteLine("Nicolas\t\t"  + nicolas_Persentage + "\t\tB");
//Console.WriteLine("Zahirah\t\t" + zahirah_persentage + "\t\tB");
//Console.WriteLine("Jeong\t\t" +  jeong_persentage + "\t\tA");


//class checknumber
//{
//    static void Main (String  [] args)
//    {
//        Console.WriteLine("Enter any number to check wheather it is positive, negative or 0.");
//        int num = int.Parse(Console.ReadLine());

//        if (num > 0)
//        {
//            Console.WriteLine("Number is Positive.");
//        }
//        else if (num < 0)
//        {
//            Console.WriteLine("Number is Negative.");
//        }
//        else
//        {
//            Console.WriteLine("Number is 0.");
//        }
//    }
//}


//class GreaterNumber
//{
//    static void Main (String[] args)
//    {
//        Console.WriteLine("Enter number1: ");
//        int num1 = int.Parse(Console.ReadLine());

//        Console.WriteLine("Enter number2: ");
//        int num2 = int.Parse(Console.ReadLine());

//        if (num1 > num2)
//        {
//            Console.WriteLine("Number1 is greater than Number2.");
//        }
//        else if (num1< num2)
//        {
//            Console.WriteLine("Number2 is greater than Number1.");
//        }
//        else
//        {
//            Console.WriteLine("Number1 is equal to Number2.");
//        }
//    }
//}


//Console.WriteLine("");
//Console.WriteLine("Floating point types:");
//Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
//Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
//Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");


//int value1 = 11;
//decimal value2 = 6.2m;
//float value3 = 4.3f;

//int result1 = Convert.ToInt32(value1 / value2);
//decimal result2 = value2 / (decimal)value3;
//float result3 = value3 / (float)value1;

//// Your code here to set result1
//// Hint: You need to round the result to nearest integer (don't just truncate)
//Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

//// Your code here to set result2
//Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

//// Your code here to set result3
//Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");

//class Employee
//{
//    public int Age;
//    public int age
//    {
//        get { return Age; }
//        set
//        {
//            if (value < 0)
//            {
//                Console.WriteLine("Age cannot be negative. Setting to 0.");
//                Age = 23; 
//            }
//            else
//            {
//                Age = value;
//            }
//        }
//    }
//}

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        Employee emp1 = new Employee();
//        emp1.age = -30;
//        Console.WriteLine($"Employee Age: {emp1.age}");
//    }
//}

//Part 1: Enumerators(enum)
//Question 1: Habitat Finder
//Create an enum called HabitatType with values for Jungle, Ocean, Desert, and Arctic. Create a class WildAnimal that has a property for Name and its Habitat.

//Hint: Use the enum keyword to define the categories before you use them in the class.

//Sample Output: The Polar Bear lives in the Arctic.

//Question 2: Endangered Status Check
//Create an enum called ConservationStatus with values LeastConcern, Vulnerable, and Endangered. Write a method that takes this enum and returns a warning message.

//Hint: Use a switch statement to return different strings based on the status.

//Sample Output: Alert: The Red Panda is Endangered!

//Part 2: Constructors
//Question 3: The Zoo Arrival
//Create a ZooAnimal class with a Parameterized Constructor that sets the Species and the Weight of the animal when it is registered.

//Hint: Use this.Species = species; inside the constructor to map the input parameters to the class fields.

//Sample Output: Registered: Elephant, Weight: 5000kg.

//Question 4: The Mystery Egg
//Create a Bird class with a Default(Parameterless) Constructor.If no species is provided, the bird's species should be set to "Unknown Bird". Also, add a second constructor that allows you to name the species.

//Hint: This is Constructor Overloading. One constructor takes a string, the other takes nothing.

//Sample Output: A new egg hatched!It is an: Unknown Bird.



enum HabitatType
{
    Jungle,
    Ocean,
    Desert,
    Arctic
}

enum ConversationStatus
{
    LeastConcern,
    Vulnerable,
    Endangered
}


class WildAnimal
{
    public string Name { get; set; }
    public string Habitat { get; set; }

    public WildAnimal(string name, string habitat)
    {
        Name = name;
        Habitat = habitat;
    }
}

class ZooAnimal
{
    public string Species { get; set; }

    public int Weight { get; set; }
    public ZooAnimal(string species, int weight)
    {
        this.Species = species;
        this.Weight = weight;
    }
}

class program
{
    static string Animal(ConversationStatus cs)
    {
        switch (cs)
        {
            case ConversationStatus.LeastConcern:
                return "LeastConcern";
            case ConversationStatus.Vulnerable:
                return "Vulnerable";
            case ConversationStatus.Endangered:
                return "Endangered";
            default:
                return "Invalid";
        }
    }

    public static void Main(string[] args)
    {
        WildAnimal PolarBear = new WildAnimal("Polar Bear", "Arctic");
        Console.WriteLine($"The {PolarBear.Name} lives in {PolarBear.Habitat}");

        ConversationStatus status = ConversationStatus.Endangered;
        Console.WriteLine($"Alert: The Red Panda is {Animal(status)}!");

        ZooAnimal Elephant = new ZooAnimal("Elephant", 5000);
        Console.WriteLine($"Registered: {Elephant.Species}, Weight: {Elephant.Weight} kg");
    }
}