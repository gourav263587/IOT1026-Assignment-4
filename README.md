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

The IRobotCommand interface is created in InterfaceCommand file to make the reference from abstract class to IRobotCommand class.
Then IRobotCommand is updated in all command classes for the InterfaceCommand file to implement the IRobotCommand interface instead 
of inheriting from the RobotCommand abstract class. 
The XML documentation within Robot class shows what each line of specific code gets and sets with proper getter and setter especially
in X-coordinate and Y-coordinate including the excaption of InvalidOperationExceptio which tells the usser that the Robot will not 
move if it is not powered on. A string format is given to X, Y and power status of robot. The default number of commands that can be given
to robot is set to 6. commandloaded is zero initially. also the loaded commands should be less than number of commands that are performed 
by default or it will return false as a result. 
The program file contains RobotTester class to input commands in form of strings and loads the command into robot instances and 
shows the status after each command.
        
        
![WhatsApp Image 2023-06-09 at 15 32 30](https://github.com/gourav263587/IOT1026-Assignment-4/assets/133707861/c04a5609-e271-48fa-818e-4ede43a6e1a0)

        
[Assignment Instructions](docs/instructions.md)  
[How to start coding](docs/how-to-use.md)  
[How to update status badges](docs/how-to-update-badges.md)
