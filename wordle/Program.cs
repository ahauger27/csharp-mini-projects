Random rand = new Random();

List<string> words = ["PHASE", "CHAIR", "SHORE", "SNAKE", "MASON"];

string word = words[rand.Next(words.Count)];

int guessesMade = 1;

Console.WriteLine("WURDLE\n");

Console.WriteLine("Guess the 5-letter word.");

Console.WriteLine($"You have 6 guesses.\n");

while (guessesMade <= 6)
{
    Console.Write($"GUESS #{guessesMade}: ");

    string guess = Console.ReadLine();

    if (guess.ToUpper() == word)
    {
        Console.WriteLine("You win");
        break;
    }

    guessesMade += 1;
}