using System;
using System.Diagnostics;


namespace WordSwap
{
    ///<summary>
    ///Class created to help find out what is fucked up
    ///</summary>
    public class Log
    {

        ///<summary>If appllication is runing in debug mode display an message</summary>
        [Conditional("DEBUG")]
        public void DebugCheck()
        {
            Console.WriteLine("Mode: DEBUG");
        }

        ///<summary>I think it's self explanatory, output an messege visible only in debug mode</summary>
        [Conditional("DEBUG")]
        public void DebugMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("> DEBUG: " + message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        ///<summary>I think it's self explanatory, output an Warning, used when:
        ///<list type="bullet">
        ///<item><description> User do something stupid like typing an string when we ned int </description></item>
        ///<item><description> Something is wrong it does not have big inpact on how program work </description></item>
        ///<item><description> To warn about program limitations </description></item>
        ///</list>
        ///</summary>
        public void Warn(string message)
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
        public void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("> ERROR: " + message);
            Console.ForegroundColor = ConsoleColor.White;

        }
        ///<summary>
        ///I think it's self explanatory, Error means something fucked up to hard and application is dead ;-;
        ///</summary>
        public void Error(Exception exception ,string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("> ERROR: " + message);
            Console.WriteLine("> ERROR: " + exception);
            Console.ForegroundColor = ConsoleColor.White;

            System.Environment.Exit(exception.GetHashCode());
        }
    }
}
