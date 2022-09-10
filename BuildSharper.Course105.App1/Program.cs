using BuildSharper.Course105.App1.Models;

Console.WriteLine("***********************");
Console.WriteLine("Welcome to Robo-Rumble!");
Console.WriteLine("***********************");
Console.WriteLine();

//let's instantiate our robots
var robot1 = new Robot("OPTIMUS PRIME", 50, 30);
var robot2 = new Robot("THE TERMINATOR", 70, 20);

Console.WriteLine($"Today's match-up is {robot1.Name} vs. {robot2.Name}!");
Console.WriteLine();
Console.WriteLine($"Press A for {robot1.Name} to attack.  Press L for {robot2.Name} to attack.  Press X to Exit.");

//a random number generator for our damage output
var random = new Random(DateTime.Now.Millisecond);

//a done variable for a while loop
var done = false;

while (!done)
{
    //capture a key input from the user
    var input = Console.ReadKey();
    //move the cursor back so we hide the character they just typed.
    Console.CursorLeft = 0;

    //switch on their input
    switch (input.Key)
    {
        case ConsoleKey.A:
            //Robot1 attacks Robot2
            robot2.TakeDamage(robot1);
            break;
        case ConsoleKey.L:
            //Robot2 attacks Robot1
            robot1.TakeDamage(robot2);
            break;
        case ConsoleKey.X:
            //exit
            done = true;
            break;
        default:
            break;
    }

    if (!robot1.IsAlive)
    {
        //Game Over, Robot2 wins
        Console.WriteLine($"{robot2.Name} WINS!!");
        done = true;
    }
    else if (!robot2.IsAlive)
    {
        //Game Over, Robot1 wins
        Console.WriteLine($"{robot1.Name} WINS!!");
        done = true;
    }
}

Console.WriteLine("Thanks for playing!");
Console.ReadKey();