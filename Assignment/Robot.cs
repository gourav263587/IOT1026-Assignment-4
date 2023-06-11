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
    /// Gets or sets x coordinate
    /// </summary>
    private int _x;


    /// <summary>
    /// Gets or sets the x coordinate
    /// </summary>
    /// <value>The x coordinate value.</value>
    /// <exception cref="InvalidOperationException">when robot not powered on</exception>
    public int X
    {
        get { return _x; }
        set
        {
            if (IsPowered)
                _x = value;
            else
                throw new InvalidOperationException("Cannot move the robot when powered off");
        }
    }
    
    /// <summary>
    /// Gets or sets the y coordinate
    /// </summary>
    /// <summary>
    /// Represents the y coordinate
    /// </summary>
    private int _y;

    /// <summary>
    /// Gets or sets the y coordinate 
    /// </summary>
    /// <value>The Y coordinate value.</value>
    /// <exception cref="InvalidOperationException">when robot powered off</exception>
    public int Y
    {
        get { return _y; }
        set
        {
            if (IsPowered)
                _y = value;
            else
                throw new InvalidOperationException("Cannot move the robot when it is off");
        }
    }
    
    /// <summary>
    /// Gets or sets a value of power status
    /// </summary>
    public bool IsPowered { get; set; }

    private const int DefaultCommands = 6;
    // An array is not the preferred data structure here.
    // You will get bonus marks if you replace the array with the preferred data structure
    // Hint: It is NOT a list either,
    //it can use a queue
    private readonly IRobotCommand[] _commands;
    private int _commandsLoaded = 0;

    /// <summary>
    /// current position and power status of robot is returned
    /// </summary>        
    /// <returns>A string representation of the robot status</returns>
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
        return true;
    }
}
