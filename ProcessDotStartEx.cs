using System;
using System.Diagnostics;
using System.ComponentModel;

namespace ProcessDotStartEx
{
    class ProcessDotStartEx
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Using Process.Start Example: \n" +
                "Process.Start() calls the external applications and pass the command with the desired arguments");

            string line = "";
            string Param = "In 0";

            try
            {
                ProcessStartInfo psInfo = new ProcessStartInfo();
                psInfo.FileName = @"netcoreapp3.1\ConsoleCmdLineArgs.exe";
                psInfo.Arguments = Param;

                Process proc = new Process();
                proc.StartInfo = psInfo;
                proc.StartInfo.RedirectStandardOutput = true;
                proc.Start();

                while (!proc.StandardOutput.EndOfStream)
                {
                    line = proc.StandardOutput.ReadLine();
                }

                proc.WaitForExit();

                // Return stdout as in the terminal/command prompt
                Console.WriteLine("Return: " + line);
            }
            catch (Win32Exception ex)
            {
                Console.WriteLine(ex.Message);
            }   
        }
    }
}

/* Output */
// Return: ConsoleCmdLineArgs is 0
// Using the exe from ConsoleCmdLineArgsEx.cs
