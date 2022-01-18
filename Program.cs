using System;
using System.Collections.Generic;

namespace EnvConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "OSVersion", "MachineName", "UserDomainName", "UserName", "SystemDirectory", "CurrentDirectory", 
                "CommandLine", "Version", "ProcessorCount", "Is64BitOperatingSystem", "Is64BitProcess", "TickCount64"};

            string[] environments = { Environment.OSVersion.ToString(), Environment.MachineName, Environment.UserDomainName, 
                Environment.UserName, Environment.SystemDirectory, Environment.CurrentDirectory, Environment.CommandLine, 
                Environment.Version.ToString(), Environment.ProcessorCount.ToString(), Environment.Is64BitOperatingSystem.ToString(), 
                Environment.Is64BitProcess.ToString(), Environment.TickCount64.ToString()};

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(DateTime.Now.ToString("F"));

            for (int i = 0; i < names.Length; i++)
            {
                Console.Beep(100, 100);
                Console.WriteLine(
                    format: "{0,-23} {1} {2}",
                    arg0: names[i],
                    arg1: "_ _ _ _ _",
                    arg2: environments[i]);
            }
  
            Console.Beep();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ReadKey();
        }
    }
}
