namespace Assignment.InterfaceCommand 
{
    public class RobotTester
    {
        public void Run()
        {
            Robot robot = new Robot();

            Console.WriteLine("Enter command strings (separated by commas):");
            string input = Console.ReadLine();

            string[] commandStrings = input.Split(',');
            foreach (string commandString in commandStrings)
            {
                IRobotCommand command = CreateCommand(commandString);
                if (command != null)
                {
                    robot.LoadCommand(command);
                }
                if (commandString.Trim().ToLower() == "off")
                {
                    break;
                }
            }

            robot.Run();
        }

         private IRobotCommand CreateCommand(string commandString)
         {
            commandString = commandString.Trim().ToLower();

            switch (commandString)
            {
                case "on":
                    return new OnCommand();
                case "off":
                    return new OffCommand();
                case "west":
                    return new WestCommand();
                case "east":
                    return new EastCommand();
                case "south":
                    return new SouthCommand();
                case "north":
                    return new NorthCommand();
                default:
                    Console.WriteLine($"Invalid command: {commandString}");
                    return null;
            }
         }
    }

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Give 6 commands to the robot, possible commands are:");
            Console.WriteLine("on");
            Console.WriteLine("off");
            Console.WriteLine("north");
            Console.WriteLine("south");
            Console.WriteLine("east");
            Console.WriteLine("west");
            RobotTester tester = new RobotTester();
            tester.Run();
        }
    }
}
