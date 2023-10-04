using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGuide
{
    using System;
    using System.Diagnostics;
    using System.Management;
    using System.Threading;

    class Proc
    {
        static void Main22()
        {
            // Sleep for 5 seconds
            Thread.Sleep(5000);

            // Get current process ID
            var pid = Process.GetCurrentProcess().Id;
            Console.WriteLine($"The process id is : {pid}");

            // Getting the parent process ID is not direct in C#.
            // Therefore, this part is just to illustrate a workaround
            // but may not be the exact equivalent to the C code.
            // You might want to use a more reliable approach such as a third-party library or manage it at a system level.
            try
            {
                var parentPid = Process.GetCurrentProcess().Parent().Id;
                Console.WriteLine($"The parent of process id is : {parentPid}");
            }
            catch (Exception)
            {
                Console.WriteLine("Unable to get the parent process id.");
            }
        }
    }

    // This is a helper extension to try and get a parent process.
    public static class ProcessExtensions
    {
        public static Process Parent(this Process process)
        {
            try
            {
                var parentProcess = new ManagementObjectSearcher($"SELECT * FROM Win32_Process WHERE ProcessId = {process.Id}")
                                            .Get().OfType<ManagementObject>()
                                            .Select(p => Process.GetProcessById((int)(uint)p["ParentProcessId"]))
                                            .FirstOrDefault();
                return parentProcess;
            }
            catch
            {
                return null; // Or handle the exception based on your needs
            }
        }
    }

}
