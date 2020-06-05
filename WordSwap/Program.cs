using System;
using System.Text;

namespace WordSwap
{
    class Program
    {
        static void Main(string[] args)
        {

            //Change default console settings to support UTF8 encoding for vowels like "ęść"
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            //Change default colors because fuck you and your console custmozation <3
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            //Create log class, this class is responsible for output any debug information, errors etc.
            var log = new Log();

            int userOption;
            bool colseClose = false;

            //Main loop
            while (!colseClose)
            {
                //Super smoll and cute menu
                Console.Clear();
                log.DebugCheck();
                Console.WriteLine("----------- Lubie placki a ty? ----------");
                Console.WriteLine("1. Spierdalaj, lol");
                Console.WriteLine("2. żęść 2 ");
                Console.WriteLine("3. cos 3");
                Console.WriteLine("4. cos 4");
                Console.WriteLine("5. Wypierdlaj (Exit)");
                Console.Write("> ");
                string input = Console.ReadLine();

                //Check if user input is actually an number
                if (Int32.TryParse(input, out userOption))
                {
                    log.DebugMessage("User input, succesfull conversion to int, result -> \"" + userOption + "\"");
                    switch (userOption)
                    {
                        case 1:
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        case 5:
                            colseClose = true;
                            Console.WriteLine("Closing application");
                            break;
                        //Super duper debug only option to check if evrything looks fine
#if DEBUG
                        case 69:
                            Console.Clear();
                            Console.WriteLine("> LOG: function test");
                            log.DebugCheck();
                            log.DebugMessage("log -> Debug message");
                            log.Warn("log -> Warn");
                            log.DebugMessage("Error test -> press 0 to start, anything other to abort");

                            //Preform an small log.Error test
                            string y = Console.ReadLine();
                            int z = 0;
                            if (int.TryParse(y, out z))
                            {
                                try
                                {
                                    int _x = 0 / z;
                                }
                                catch (Exception e)
                                {
                                    log.Error(e, "TEST ERROR EXCEPTION!");
                                }

                            }
                            break;
#endif

                        //It is number but there is no any option assigned to it
                        default:
                            log.Warn("Option does not exist!");
                            break;

                    }
                }
                //User is an idiot and he cant write a fricking number, how sad...
                else
                {
                    log.DebugMessage("User input, failed conversion to int, input -> \"" + input + "\"");
                    log.Warn("Option does not exist, maybe use an number...");
                }
            }
        }
    }
}
