using System;

namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length == 2)
            {
                //Print File Version.
                if (Validations_FileVersion.ValidateFirstArgument(args[0]))
                {
                    Console.WriteLine(FileVersion.PrintFileVersion(args[1]));
                }

                //Print File Size
                //if (Validations_FileSize.ValidateFirstArgument(args[0]))
                //{
                //    Console.WriteLine(FileSize.PrintFileSize(args[1]));
                //}
            }
            else
            {
                Console.WriteLine("Maximum 2 arguments can be passed.");
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}
