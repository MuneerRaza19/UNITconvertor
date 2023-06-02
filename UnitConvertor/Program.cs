using System;

class UnitConvertor
{
    static void Main(String[] args)
    {
        while (true)
        {
            Console.WriteLine("Welcome to the unit convertor :)");
            Console.WriteLine("Please select an option");
            Console.WriteLine("1. Miles to Kn");
            Console.WriteLine("2. Pounds to KG");
            Console.WriteLine("3. farenheit to Celcius");
            String input = Console.ReadLine();


            // Validat input
            if (input == "1")
            {
                MilesToKG();
            }
            else if (input == "2")
            {
                PoundstoKG();
            }
            else if (input == "3")
            {
               FtoC();
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }

        
    }
    static void MilesToKG()
    {
        Console.WriteLine(" please enter number of miles...") ;  
        double miles = double.Parse(Console.ReadLine());
        double kilometers = miles * 1.609344;
        Console.WriteLine("{0} miles = {1} KM.", miles, kilometers);
    }
    static void PoundstoKG()
    {
        Console.WriteLine(" please enter number of pounds...");
        double pounds = double.Parse(Console.ReadLine());
        double kilograms = pounds * 0.4359237;
        Console.WriteLine("{0} pounds = {1} KG.", pounds, kilograms);
    }
    static void FtoC()
    {
        Console.WriteLine(" please enter temperature in farenheit...");
        double Farenheit = double.Parse(Console.ReadLine());
        double celcius = (Farenheit - 32) * 5 / 9;
        Console.WriteLine("{0} Farenheit = {1} Celcius Degrees.", Farenheit, celcius);
    }
}
