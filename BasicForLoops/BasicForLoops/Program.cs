// See https://aka.ms/new-console-template for more information
bool goAgain = false;
do
{
    Console.WriteLine("Please enter a number");
    int userNumber = int.Parse(Console.ReadLine());
    int sumOfNumbers = 0;
    for (int i = 1; i <= userNumber; i++)
    {
        sumOfNumbers += i;
    }
    Console.WriteLine($"Sum of numbers: {sumOfNumbers}");
// Play again?
    Console.WriteLine("Would you like to continue? y/n");
    string userChoice = Console.ReadLine().ToLower();

    if (userChoice == "y")
    {
        goAgain = true;
        sumOfNumbers = 0;
    }else
    {
        goAgain = false;
        Console.WriteLine("Goodbye!");
    }

}while (goAgain==true);