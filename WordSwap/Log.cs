using System;
using System.Diagnostics;


namespace WordSwap
{
    ///<summary>
    ///Class created to help find out what is fucked up
    ///</summary>
    public static class Log
    {

        ///<summary>If appllication is runing in debug mode display an message</summary>
        [Conditional("DEBUG")]
        public static void DebugCheck()
        {
            Console.WriteLine("Mode: DEBUG");
        }

        ///<summary>I think it's self explanatory, output an messege visible only in debug mode</summary>
        [Conditional("DEBUG")]
        public static void DebugMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("> DEBUG: " + message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        ///<summary>I think it's self explanatory, output an Warning, used when:
        ///<list type="bullet">
        ///<item>User do something stupid like typing an string when we ned int</item>
        ///<item>Something is wrong it does not have big inpact on how program work</item>
        ///<item>To warn about program limitations</item>
        ///</list>
        ///</summary>
        public static void Warn(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("> WARN: " + message);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("> Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }

        ///<summary>
        ///I think it's self explanatory, Error means something fucked up to hard and application is dead ;-;
        ///</summary>
        public static void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("> ERROR: " + message);
            Console.ForegroundColor = ConsoleColor.White;

        }
        ///<summary>
        ///I think it's self explanatory, Error means something fucked up to hard and application is dead ;-;
        ///</summary>
        public static void Error(Exception exception ,string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("> ERROR: " + message);
            Console.WriteLine("> ERROR: " + exception);
            Console.ForegroundColor = ConsoleColor.White;

            System.Environment.Exit(exception.GetHashCode());
        }

        ///<summary>
        ///I think it's self explanatory, used to output an information, used when:
        ///<list type="bullet">
        ///<item>Want to inform about end of task</item>
        ///<item>Want to inform about start of a task </item>
        ///<item>Want to use green color because it have sedative properties</item>
        /// </list>
        ///</summary>
        public static void Info(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("> INFO: " + message);
            Console.ForegroundColor = ConsoleColor.White;
        }


        /// <summary>
        /// Preform an function test, only aviable in debug mode
        /// </summary>
        [Conditional("DEBUG")]
        public static void LogOutputTest()
        {
            Console.Clear();
            Info("function test");
            DebugCheck();
            DebugMessage("log -> Debug message");
            Warn("log -> Warn");
            DebugMessage("Error test -> press 0 to start, anything other to abort");

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
                    Error(e, "TEST ERROR EXCEPTION!");
                }

            }
            else
            {
                Info("Test canceled");
            }
        }
    }
}
