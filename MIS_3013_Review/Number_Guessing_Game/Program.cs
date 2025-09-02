
// data_type variable_name = value
Random r = new Random();

	//input upper and lower bounds
	Console.WriteLine("Please input lower bound value <<");
	string answer = Console.ReadLine();
	int lowerbound = 0;

lowerbound = ValidateInput(answer, "Invalid input for lower bound, please try again <<");

//try
//{
//	lowerbound = int.Parse(answer);
//}
//catch (FormatException ex)
//{

//    Console.WriteLine("Please enter a number not a string");
//}
//catch (OverflowException ex)
//{
//    Console.WriteLine("Your value exceeds the limits.");
//}
//catch (Exception ex)
//{
//    Console.WriteLine("I don't know what went wrong.");
//}

Console.WriteLine("Please input upper bound value <<");
	answer = Console.ReadLine();
	int upperbound = ValidateInput(answer, "Invalid input for upper bound, please try again <<");



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

		guess = ValidateInput(user_guess, "Invalid input for guess. Please try again <<");
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



///
static int ValidateInput(string a, string msg = "Invalid input. Please try again <<")
{
    int result;
    while (int.TryParse(a, out result) == false)
    {
        Console.WriteLine(msg);
        a = Console.ReadLine();
    }

    return result;
}