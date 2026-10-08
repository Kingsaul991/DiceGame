Random random = new Random();
string playAgain = "y";

while (playAgain == "y")
{
    int die1 = random.Next(1, 7);
    int die2 = random.Next(1, 7);
    int total = die1 + die2;

    Console.WriteLine("Die 1: " + die1);
    Console.WriteLine("Die 2: " + die2);
    Console.WriteLine("Total: " + total);

    if (total == 12)
    {
        Console.WriteLine("Congratulations");
        Console.WriteLine("You have Won");
    }

    Console.Write("Do you want to play again? (y/n): ");
    playAgain = Console.ReadLine()?.ToLower() ?? "n";
}

Console.WriteLine("Thank you for playing!");

