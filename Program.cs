using System;

Main();

void Main()
{

    void GuessSecretNumber()
    {
        int chances = 4;

        while (chances > 0)
        {
            Console.WriteLine("Guess a number!");
            string UserAnswer = Console.ReadLine();
            // Console.WriteLine($"{UserAnswer} is your answer!");

            string SecretNumber = "42";

            {
                if (SecretNumber == UserAnswer)
                {
                    Console.WriteLine("Bingo!");
                    chances--;
                }
                else
                {
                    Console.WriteLine("You should try again :(!");
                    chances--;
                }
            }
        }
    }





    GuessSecretNumber();
}

