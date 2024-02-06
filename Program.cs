string? readResult;
Console.WriteLine("Enter a number 5 - 10");
int numericValue = 0;
bool done = false;
bool done2 = false;
bool done3 = false;

do
{
    while (!done2)
    {
        readResult = Console.ReadLine();
        done = int.TryParse(readResult, out numericValue);
        if (!done)
        {
            Console.WriteLine("Please enter a valid number");
        }
        else
        {
            done2 = true;
        }
    }

    while (!done3)
    {
        if (numericValue >= 5 && numericValue <= 10)
        {
            done3 = true;
        }
        else
        {
            Console.WriteLine("Your number was not between 5 - 10, please try again");
            readResult = Console.ReadLine();
            int.TryParse(readResult, out numericValue);
        }
    }
    
    Console.WriteLine($"Your input ({numericValue}) was accepted");
    
    

}while(!done);
