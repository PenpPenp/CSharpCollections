using System;

namespace ConsoleCmdLineArgs
{
    class ConsoleCmdLineArgsEx
    {
        static void Main(string[] args)
        {
            // Display the number of command line arguments.
            //Console.WriteLine(args.Length);

            // Test if input arguments were supplied.
            if (args.Length == 0)
            {
                Console.WriteLine("Example Usage :");
                Console.WriteLine("ConsoleCmdLineArgs.exe In <0 - 1> (Pin Number) ");
                Console.WriteLine("ConsoleCmdLineArgs.exe Out <0 - 1> <2 - 3> (Pin Number Data) ");
            }
            // If ConsoleCmdLineArgs.exe In <0 - 1> (Pin Number)
            else if (args.Length == 2 && args[0] == "In")
            {
                for (int i = 1; i < args.Length; i++)
                {
                    if(args[i] == "0")
                    {
                        Console.WriteLine("ConsoleCmdLineArgs is " + args[i]);
                    }
                    else if (args[i] == "1")
                    {
                        Console.WriteLine("ConsoleCmdLineArgs is " + args[i]);
                    }
                    else
                    {
                        Console.WriteLine("Incorrect Args, please refer to Example Usage");
                    }
                }
            }
            // If ConsoleCmdLineArgs.exe Out <0 - 1> <2 - 3> (Pin Number, Data) 
            else if (args.Length == 3 && args[0] == "Out")
            {
                if ((args[1] == "0" || args[1] == "1") && args[2] == "2")
                {
                    Console.WriteLine("ConsoleCmdLineArgs is " + args[1] + " and " + args[2]);
                }
                else if ((args[1] == "0" || args[1] == "1") && args[2] == "3")
                {
                    Console.WriteLine("ConsoleCmdLineArgs is " + args[1] + " and " + args[2]);
                }
                else
                {
                    Console.WriteLine("Incorrect Args, please refer to Example Usage");
                }
            }
        }
    }
}


/* Output:
 * 
D:\ConsoleCmdLineArgs.exe
Example Usage :
ConsoleCmdLineArgs.exe In <0 - 1> (Pin Number)
ConsoleCmdLineArgs.exe Out <0 - 1> <2 - 3> (Pin Number, Data)

D:\ConsoleCmdLineArgs.exe In 0
ConsoleCmdLineArgs is 0

D:\ConsoleCmdLineArgs.exe In 1
ConsoleCmdLineArgs is 1

D:\ConsoleCmdLineArgs.exe In 2
Incorrect Args, please refer to Example Usage

D:\ConsoleCmdLineArgs.exe Out 0 2
ConsoleCmdLineArgs is 0 and 2

D:\ConsoleCmdLineArgs.exe Out 1 3
ConsoleCmdLineArgs is 1 and 3

D:\ConsoleCmdLineArgs.exe Out 2 3
Incorrect Args, please refer to Example Usage

D:\ConsoleCmdLineArgs.exe Out 1 1
Incorrect Args, please refer to Example Usage
 
*/

