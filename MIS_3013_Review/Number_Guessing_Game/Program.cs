
// data_type variable_name = value
Random r = new Random();

var rando = r.Next(1, 6); //Generate a random number between 1-5
Console.WriteLine($"Generated a random number with the value: {rando}");

int guess;

int count = 0;

do
{
	Console.WriteLine("Please guess a number between 1-5 << ");
	string user_guess = Console.ReadLine();

	 guess = int.Parse(user_guess);
    count++;

    Console.WriteLine("You guessed " + user_guess);

	if (guess != rando)
	{
		if (guess > rando)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("Sorry, you guessed too high");
			Console.ForegroundColor = ConsoleColor.White;

		}
		else
		{
			Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Sorry, you guessed low");
			Console.ForegroundColor = ConsoleColor.White;
        }
    }

} while (guess != rando);

Console.WriteLine("Congratulations, you guessed correctly and it only took " + count + " attempts!");