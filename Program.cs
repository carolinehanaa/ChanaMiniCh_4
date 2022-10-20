/*Caroline Hana
10-19-2022
Greater then less then
input two numbers and the console will tell u if its greater, less or equal
*/

Console.Clear();

string? playAgain = "yes";
while (playAgain == "yes")

{
    string? input1, input2;
    int number1, number2;

    Console.WriteLine("Enter a number: ");
    input1 = Console.ReadLine();

    Console.WriteLine("Enter another number: ");
    input2 = Console.ReadLine();

    bool validNum1 = int.TryParse(input1, out number1);
    bool validNum2 = int.TryParse(input2, out number2);

    if (!validNum1 && !validNum2)
    {
        Console.WriteLine("Invalid Number");
        playAgain = "yes";
    }

    else if (number1 > number2)
    {
        Console.WriteLine($"{number1} > {number2}");
    }
    else if (number1 < number2)
    {
        Console.WriteLine($"{number1} < {number2}");
    }
    else
    {
        Console.WriteLine($"{number1} = {number2}");
    }


    string? answer = "";
    while (answer != "yes" && answer != "no")
    {
        Console.WriteLine("Would you like to play again? (yes or no)");
        answer = Console.ReadLine();
        answer = answer.ToLower();
        if (answer == "yes")
        {
            playAgain = answer;
        }
        else if (answer == "no")
        {
            playAgain = answer;
        }
        else
        {
            Console.WriteLine("Invalid Answer");
        }

    }

}


