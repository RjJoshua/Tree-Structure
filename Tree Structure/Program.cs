using System;

class Program
{
    static void Main(string[] args)
    {
        string userChoice = "";
        bool exit = false;

    Home:
        if (!exit)
        {
            Console.WriteLine("Home");
            Console.WriteLine("a. Software Development Process");
            Console.WriteLine("b. Programming Paradigms");
            Console.WriteLine("c. Close");
            Console.Write("Enter your choice (a/b/c): ");
            userChoice = Console.ReadLine().ToLower();

            if (userChoice == "a")
            {
                goto SoftwareDevelopmentProcess;
            }
            else if (userChoice == "b")
            {
                goto ProgrammingParadigms;
            }
            else if (userChoice == "c")
            {
                exit = true;
                goto End;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
                goto Home;
            }

            Console.WriteLine();
        }

    SoftwareDevelopmentProcess:
        Console.WriteLine("Software Development Process");
        Console.WriteLine("a. Traditional");
        Console.WriteLine("b. Agile");
        Console.WriteLine("c. Back");
        Console.Write("Enter your choice (a/b/c): ");
        userChoice = Console.ReadLine().ToLower();

        if (userChoice == "a")
        {
            goto Traditional;
        }
        else if (userChoice == "b")
        {
            goto Agile;
        }
        else if (userChoice == "c")
        {
            goto Home;
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
            goto SoftwareDevelopmentProcess;
        }

    Traditional:
        Console.WriteLine("Traditional");
        Console.WriteLine("a. Waterfall Model");
        Console.WriteLine("b. V-Model");
        Console.WriteLine("c. Back");
        Console.Write("Enter your choice (a/b/c): ");
        userChoice = Console.ReadLine().ToLower();

        if (userChoice == "a")
        {
            Console.WriteLine("Waterfall Model");
        }
        else if (userChoice == "b")
        {
            Console.WriteLine("V-Model");
        }
        else if (userChoice == "c")
        {
            goto SoftwareDevelopmentProcess;
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
            goto Traditional;
        }
        Console.WriteLine();
        goto Traditional;

    Agile:
        Console.WriteLine("Agile");
        Console.WriteLine("a. Scrum");
        Console.WriteLine("b. Kanban");
        Console.WriteLine("c. Back");
        Console.Write("Enter your choice (a/b/c): ");
        userChoice = Console.ReadLine().ToLower();

        if (userChoice == "a")
        {
            Console.WriteLine("Scrum");
        }
        else if (userChoice == "b")
        {
            Console.WriteLine("Kanban");
        }
        else if (userChoice == "c")
        {
            goto SoftwareDevelopmentProcess;
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
            goto Agile;
        }
        Console.WriteLine();
        goto Agile;

    ProgrammingParadigms:
        Console.WriteLine("Programming Paradigms");
        Console.WriteLine("a. Imperative");
        Console.WriteLine("b. Declarative");
        Console.WriteLine("c. Back");
        Console.Write("Enter your choice (a/b/c): ");
        userChoice = Console.ReadLine().ToLower();

        if (userChoice == "a")
        {
            goto Imperative;
        }
        else if (userChoice == "b")
        {
            goto Declarative;
        }
        else if (userChoice == "c")
        {
            goto Home;
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
            goto ProgrammingParadigms;
        }

    Imperative:
        Console.WriteLine("Imperative");
        Console.WriteLine("a. Procedural Programming");
        Console.WriteLine("b. Object-Oriented Programming");
        Console.WriteLine("c. Back");
        Console.Write("Enter your choice (a/b/c): ");
        userChoice = Console.ReadLine().ToLower();

        if (userChoice == "a")
        {
            Console.WriteLine("Procedural Programming");
        }
        else if (userChoice == "b")
        {
            Console.WriteLine("Object-Oriented Programming");
        }
        else if (userChoice == "c")
        {
            goto ProgrammingParadigms;
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
            goto Imperative;
        }
        Console.WriteLine();
        goto Imperative;

    Declarative:
        Console.WriteLine("Declarative");
        Console.WriteLine("a. Functional Programming");
        Console.WriteLine("b. Logic Programming");
        Console.WriteLine("c. Back");
        Console.Write("Enter your choice (a/b/c): ");
        userChoice = Console.ReadLine().ToLower();

        if (userChoice == "a")
        {
            Console.WriteLine("Functional Programming");
        }
        else if (userChoice == "b")
        {
            Console.WriteLine("Logic Programming");
        }
        else if (userChoice == "c")
        {
            goto ProgrammingParadigms;
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
            goto Declarative;
        }
        Console.WriteLine();
        goto Declarative;

    End:
        Console.WriteLine("Closing the program...");
    }
}