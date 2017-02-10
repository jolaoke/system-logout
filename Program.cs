using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SleepSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--CLEAN UP PC STORAGE--\n");
            Console.WriteLine("This program will clean up your system storage\nby deleting useless and unwanted junk files from your hard drive.\n");
            Console.WriteLine("Press Enter to begin.");
            var start = Console.ReadLine();

            // Write the cmd command and store it in a variable
            string cmdCommand;
            cmdCommand = "shutdown -l";

            //Create a new process to launch the command line
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();

            // Execute the command and close the command line
            cmd.StandardInput.WriteLine(cmdCommand);
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
            Console.WriteLine(cmd.StandardOutput.ReadToEnd());
        }
    }
}
