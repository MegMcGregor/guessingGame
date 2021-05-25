using System;

Main();

void Main()
{
    Console.WriteLine("Guess a number!");
    string UserAnswer = Console.ReadLine();
    // Console.WriteLine($"{UserAnswer} is your answer!");

    string SecretNumber = "42";

    void GuessSecretNumber()
    {
        if (SecretNumber == UserAnswer)
        {
            Console.WriteLine("Bingo!");
        }
        else
        {
            Console.WriteLine("You should try again :(!");
        }
    }

    GuessSecretNumber();
}

