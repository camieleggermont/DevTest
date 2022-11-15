using Refactoring.Shapes;
using System;
using System.Linq;

namespace Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" -------------------------------------------------------------------------- ");
            Console.WriteLine("| Greetings and salutations fellow developer :D                            |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("| If you are reading this we probably want to know if you know your stuff. |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("| How would you improve this code?                                         |");
            Console.WriteLine("| We challenge you to refactor this and show us how awesome you are ;)     |");
            Console.WriteLine("| We also really like trapezoids so could you also implement that for us?  |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                                                               Good luck! |");
            Console.WriteLine(" --------------------------------------------------------------------------");
            
            CommandParser parser = new CommandParser();
            SurfaceAreaCalculator surfaceAreaCalculator = new SurfaceAreaCalculator();
            ShapeFactory shapeFactory = new ShapeFactory();
            Instruction instruction = null;
            Console.WriteLine(parser.ShowCommands());

            do
            {
                try
                {
                    instruction = parser.Parse(Console.ReadLine());
                    switch (instruction.Command)
                    {
                        case Command.create:
                            var shape = shapeFactory.GetShape(instruction.Arguments);
                            surfaceAreaCalculator.AddShape(shape);
                            Console.WriteLine($"{shape.GetType().Name} created!");
                            break;
                        case Command.reset:
                            surfaceAreaCalculator.Reset();
                            Console.WriteLine("Reset state!!");
                            break;
                        case Command.print:
                            var areas = String.Join("\n", surfaceAreaCalculator.GetSurfaceAreasReadableOutput());
                            Console.WriteLine(areas);
                            break;
                        case Command.exit:
                            break;
                        default:
                            Console.WriteLine(parser.ShowCommands());
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(parser.ShowCommands());
                }
            } while ((instruction == null) || (instruction.Command != Command.exit));
        }
    }
}
