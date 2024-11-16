using System;
using System.CommandLine;
using System.CommandLine.Invocation;
using System.Threading.Tasks;
using System.Linq;
using ColorLibrary;

namespace ColorApp
{
    class Program
    {
        static async Task<int> Main(string[] args)
        {
            // Create a root command with a description
            var rootCommand = new RootCommand
            {
                Description = "Color app that output color string"
            };

            // Define the red command
            var redCommand = new Command("--red", "Display text red");
            redCommand.AddAlias("-r");

            redCommand.SetHandler(() =>
            {
                Console.WriteLine("You select {0}", Colors.GetRed());
            });

            // Define the blue command
            var blueCommand = new Command("--blue", "Display text blue");
            blueCommand.AddAlias("-b");

            blueCommand.SetHandler(() =>
            {
                Console.WriteLine("You select {0}", Colors.GetBlue());
            });

            // Define the green command
            var greenCommand = new Command("--green", "Display text green");
            greenCommand.AddAlias("-g");

            greenCommand.SetHandler(() =>
            {
                Console.WriteLine("You select {0}", Colors.GetGreen());
            });

            // Define the yellow command
            var yellowCommand = new Command("--yellow", "Display text yellow");
            yellowCommand.AddAlias("-y");

            yellowCommand.SetHandler(() =>
            {
                Console.WriteLine("You select {0}", Colors.GetYellow());
            });

            // Add the subcommands to the root command
            rootCommand.AddCommand(redCommand);
            rootCommand.AddCommand(blueCommand);
            rootCommand.AddCommand(greenCommand);
            rootCommand.AddCommand(yellowCommand);

            // Check if no arguments are provided and display help
            if (args.Length == 0)
            {
                rootCommand.Invoke("-h");
                return 0;
            }

            // Invoke the root command
            return await rootCommand.InvokeAsync(args);
        }
    }
}