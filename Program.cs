namespace MSSA_CSharpCalculator;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Console.WriteLine("this is a new branch named test");

<<<<<<< HEAD
        Console.Write("enter your name:");

        string name = Console.ReadLine();

        if (name == null)
        {
            Console.WriteLine("No valid input revieved");
            return;
        }

        Console.WriteLine($"Hello, {name}");
=======
        Console.Write("Enter your favorite number:");

        int num = int.Parse(Console.ReadLine());

        Console.WriteLine($"your favorite number is {num}");

>>>>>>> main
    }
}
