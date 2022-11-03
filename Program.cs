//Welcome messages
Console.WriteLine("Please select a Conversion Method");
//counter for while loop

char choice;
//While loop
do
{
    //Error handling checks that the user input is correct and prompts them to try again
    try
    {
        //Selection Integer
        int ConverSel;
        //Selection Menu
        Console.WriteLine("\n1. Celsius to Farenheit \n2. Farenheit to Celsius \n3.Exit");
        ConverSel = Convert.ToInt32(Console.ReadLine());

        //Celcius to FarenheitS
        if (ConverSel == 1)
        {
            double CelsiusIn;
            Console.WriteLine("\nPlease Enter your Temperature in Celsius");
            CelsiusIn = Convert.ToInt32(Console.ReadLine());
            //Calculations For Celsius to Farenheit
            double FarenheitCalc = CelsiusIn * 9 / 5 + 32;

            Console.WriteLine("The Temperature is " + FarenheitCalc + "°F");

        }

        //Farenheit to celcius calculation
        if (ConverSel == 2)
        {
            double FarenIn;
            Console.WriteLine("\nPlease Enter your Temperature in Farenheit");
            FarenIn = Convert.ToInt32(Console.ReadLine());
            //Caluclations for Farenheit to Celsius
            double CelciusCalc = (FarenIn - 32) * 5 / 9;

            Console.WriteLine("The temperature is " + CelciusCalc + "°C");

        }
        //Stuff for exitting the application
        if (ConverSel == 3)
        {
            Environment.Exit(0);
        }
    //Message that display to user when an incorrect input is used
    }
    catch
    {
        Console.WriteLine("Incorrect Input");
    }
    //Offers user chance to close the program without going back to the Menu or to carry on and do more conversions
    Console.WriteLine("\nDo you want to exit the program?\n Y or N");
    choice = Convert.ToChar(Console.ReadLine());
}
while (choice != 'Y');

Console.ReadKey();