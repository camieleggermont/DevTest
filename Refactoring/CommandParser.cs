using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring
{
    internal enum Command
    {
        create,
        print,
        reset,
        exit
    }

    internal class Instruction
    {
        public Command Command { get; set; }
        public string[] Arguments { get; set; }
    }

    internal class CommandParser
    {
        public string ShowCommands()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("commands:");
            sb.AppendLine("- create square {double} (create a new square)");
            sb.AppendLine("- create circle {double} (create a new circle)");
            sb.AppendLine("- create rectangle {height} {width} (create a new rectangle)");
            sb.AppendLine("- create triangle {height} {width} (create a new triangle)");
            sb.AppendLine("- create trapezoid {base1} {base2} {height} (create a new trapezoid)");
            sb.AppendLine("- print (print the calculated surface areas)");
            //sb.AppendLine("- calculate (calulate the surface areas of the created shapes)");
            sb.AppendLine("- reset (reset)");
            sb.AppendLine("- exit (exit the loop)");

            return sb.ToString();
        }

        public Instruction Parse(string commandLine)
        {
            var segments = commandLine.Split(' ');
            if (segments.Length == 0) throw new ArgumentException("No command provided.");

            if(Enum.TryParse<Command>(segments[0], out var cmd)) {
                return new Instruction
                {
                    Command = cmd,
                    Arguments = segments.Skip(1).ToArray()
                };
            }

            throw new ArgumentException("Unknown command provided.");
        }

    }
}
