using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleExit4
{
    public class MyClass
    {
        public static void myHandler(object sender, ConsoleCancelEventArgs args) {

            Console.WriteLine("Someone pressed Ctrl C ?");

            args.Cancel = true;

            Console.WriteLine("Initiating routines before closign the program....");

            // Run my code here...

            Console.WriteLine("Done !!!");

            // Run the code here to exit the console app properly...

            Console.WriteLine("Exiting the Application in 3 seconds");
            Thread.Sleep(3000);
            Environment.Exit(0);

        }

    }
}
