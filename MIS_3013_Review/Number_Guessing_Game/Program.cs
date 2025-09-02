
// data_type variable_name = value
Random r = new Random();

	//input upper and lower bounds
	Console.WriteLine("Please input lower bound value <<");
	string answer = Console.ReadLine();
	int lowerbound = int.Parse(answer);

	Console.WriteLine("Please input upper bound value <<");
	answer = Console.ReadLine();
	int upperbound = int.Parse(answer);

for (int i = 0; i < int.MaxValue; i++)
{
	var rando = r.Next(lowerbound, upperbound); //Generate a random number between lowerbound and upperbound
	Console.WriteLine($"Generated a random number with the value: {rando}");

	//initialize guess
	int guess;
	//initialize and declare count
	int count = 0;



	do
	{
		Console.WriteLine("Please guess a number between " + lowerbound + " and " + upperbound + " << ");
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

    Console.WriteLine("Do you want to try your luck again? yes or no <<");

	answer = Console.ReadLine();

	if (answer != "yes")
	{
		break;
		//i = int.maxvalue;
		//return;
	}
}

Console.WriteLine("Thank you for playing our game, come back soon!");