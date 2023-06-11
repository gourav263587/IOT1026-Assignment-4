<p align="center">
	<a href="https://github.com/gourav263587/IOT1026-Assignment-4/actions/workflows/ci.yml">
    <img src="https://github.com/gourav263587/IOT1026-Assignment-4/actions/workflows/ci.yml/badge.svg"/>
    </a>
	<a href="https://github.com/gourav263587/IOT1026-Assignment-4/actions/workflows/formatting.yml">
    <img src="https://github.com/gourav263587/IOT1026-Assignment-4/actions/workflows/formatting.yml/badge.svg"/>
	<br/>
    <a href="https://codecov.io/gh/gourav263587/IOT1026-Assignment-4" > 
    <img src="https://codecov.io/gh/gourav263587/IOT1026-Assignment-4/branch/main/graph/badge.svg?token=JS0857X5JD"/> 
	<img title="MIT License" alt="license" src="https://img.shields.io/badge/license-MIT-informational?style=flat-square">	
    </a>
</p>

# IOT1026-Assignment-4

To make reference from abstract class to InterfaceCommand IRobotCommand interface is created in InterfaceCommand namespace and in all command classes
of InterfaceCommand file is updated with it.
XML documentation of Robot class is updated with defining x and y coordinate an power state of the code as well. The x coordinate, y coordinate and the
power state of robot is thus stored in a string.
The Run method executes the "Run" method of each element in the _commands array, passing the current instance of the class as a parameter. After each 
execution, it prints the string representation of the current instance to the robot.the LoadCommand method checks if there is space available to load a 
new command. If there is, it adds the command to the _commands array and increments the counter. If the maximum number of commands has already been reached, 
it returns false.
the Run method of the RobotTester class of Robot file prompts the user to enter a series of commands separated by commas, creates instances of command objects 
based on the user's input, loads the commands into a Robot object, and then executes the loaded commands. The loop continues until the user enters the command 
"off" or the maximum number of commands is reached.
The createcommand method takes the sting input of the robot and cheecks commandstring with switch case to perform the specific command on, off, north, south, east,
west.
the main pmethod of program class shows possible commands to user and then creats an instance of the RobotTester class to handle the input and execution of commands.
 It serves as the entry point of the program and initiates the interaction with the user to control the robot.
        


        ![WhatsApp Image 2023-06-10 at 10 05 24 PM](https://github.com/gourav263587/IOT1026-Assignment-4/assets/133707861/291d2611-c23a-456e-8e9d-3f35037d99cf)

[Assignment Instructions](docs/instructions.md)  
[How to start coding](docs/how-to-use.md)  
[How to update status badges](docs/how-to-update-badges.md)
