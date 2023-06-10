// Change to 'using Assignment.InterfaceCommand' when you are ready to test your interface implementation
using Assignment.InterfaceCommand;

namespace Assignment;

public class Robot
{
    // These are properties, you can replace these with traditional getters/setters if you prefer.
    /// <summary>
    /// Gets the number of commands loaded in the robot.
    /// </summary>
    public int NumCommands { get; }

    /// <summary>
    /// Gets or sets the X-coordinate of the robot.
    /// </summary>
    private int _x;
    /// <summary>
    /// Gets or sets the X coordinate of the robot's position.
    /// </summary>
    /// <value>The X coordinate value.</value>
    /// <exception cref="InvalidOperationException">Thrown when the robot is not powered on.</exception>
    public int X
    {
        get { return _x; }
        set
        {
            if (IsPowered)
                _x = value;
            else
                throw new InvalidOperationException("Cannot move the robot when it is not powered on.");
        }
    }
    
    /// <summary>
    /// Gets or sets the Y-coordinate of the robot.
    /// </summary>
    /// <summary>
    /// Represents the Y coordinate of the robot's position.
    /// </summary>
    private int _y;

    /// <summary>
    /// Gets or sets the Y coordinate of the robot's position.
    /// </summary>
    /// <value>The Y coordinate value.</value>
    /// <exception cref="InvalidOperationException">Thrown when the robot is not powered on.</exception>
    public int Y
    {
        get { return _y; }
        set
        {
            if (IsPowered)
                _y = value;
            else
                throw new InvalidOperationException("Cannot move the robot when it is not powered on.");
        }
    }
    
    /// <summary>
    /// Gets or sets a value indicating whether the robot is powered on.
    /// </summary>
    public bool IsPowered { get; set; }

    private const int DefaultCommands = 6;
    // An array is not the preferred data structure here.
    // You will get bonus marks if you replace the array with the preferred data structure
    // Hint: It is NOT a list either,
    private readonly IRobotCommand[] _commands;
    private int _commandsLoaded = 0;

    /// <summary>
    /// Returns a string that represents the current robot coordinates and power status.
    /// </summary>        
    /// <returns>A string representation of the robot.</returns>
    public override string ToString()
    {
        return $"[{X} {Y} {IsPowered}]";
    }

    // You should not have to use any of the methods below here but you should
    // provide XML documentation for the argumented constructor, the Run method and one
    // of the LoadCommand methods.
    public Robot() : this(DefaultCommands) { }

    /// <summary>
    /// Constructor that initializes the robot with the capacity to store a user specified
    /// number of commands
    /// </summary>
    /// <param name="numCommands">The maximum number of commands the robot can store</param>
    public Robot(int numCommands)
    {
        _commands = new IRobotCommand[numCommands];
        NumCommands = numCommands;
    }

    /// <summary>
    /// 
    /// </summary>
    public void Run()
    {
        for (var i = 0; i < _commandsLoaded; ++i)
        {
            _commands[i].Run(this);
            Console.WriteLine(this);
        }
    }

    /// <summary>
    /// Returns false if commandloaded is more than numcommands and if not will return true
    /// </summary>
    /// <param name="command"></param>
    /// <returns></returns>
    public bool LoadCommand(IRobotCommand command)
    {
        if (_commandsLoaded >= NumCommands)
            return false;
        _commands[_commandsLoaded++] = command;
        return true;
    }
}
