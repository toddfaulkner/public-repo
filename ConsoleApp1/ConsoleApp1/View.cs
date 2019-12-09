using System;

namespace BargeDisplacement
{
    /// <summary>
    /// Contains all methods for interacting with user
    /// Current contains CLI method, but GUI method could be added
    /// </summary>
    public class View
    {
        /// <summary>
        /// Handles all CLI interaction with user
        ///     menu display
        ///     parse user selection
        ///     set new property values
        /// </summary>
        public void CommandLine()
        {
            ConsoleKeyInfo input;                   // holds key pressed by user
            Barge barge = new Barge(75, 7, 4);      // provided initial values

            do
            {
                Console.Clear();
                Console.WriteLine("     BARGE DISPLACEMENT CALCULATOR");
                Console.WriteLine("=======================================");
                Console.WriteLine("  1.  Length of Barge:  {0} ft.",       barge.LengthInFeet);
                Console.WriteLine("  2.  Width of Barge:   {0} ft.",       barge.WidthInFeet);
                Console.WriteLine("  3.  Draft of Barge:   {0} ft.",       barge.DraftInFeet);
                Console.WriteLine("      Displacement:     {0:n0} gal.\n", barge.CalculateDisplacement());
                Console.WriteLine("Please select the number you would like to change (1 - 3).");
                Console.WriteLine("Press <Enter> to quit.\n");

                input = Console.ReadKey(true);
                double newValue;

                switch (input.KeyChar)
                {
                    case '1':
                        Console.WriteLine("Enter new length in feet:");
                        if (Double.TryParse(Console.ReadLine(), out newValue) && newValue > 0)
                            barge.LengthInFeet = newValue;
                        break;
                    case '2':
                        Console.WriteLine("Enter new width in feet:");
                        if (Double.TryParse(Console.ReadLine(), out newValue) && newValue > 0)
                            barge.WidthInFeet = newValue;
                        break;
                    case '3':
                        Console.WriteLine("Enter new draft in feet:");
                        if (Double.TryParse(Console.ReadLine(), out newValue) && newValue > 0)
                            barge.DraftInFeet = newValue;
                        break;
                }
            } while (input.Key != ConsoleKey.Enter);
        }
    }
}
