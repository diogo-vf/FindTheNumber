using FindTheNumber;
using FindTheNumber.Enums;

Game? game = null;
do
{
    // Ask the username
    // Let user to choose to leave or start the game (if game != null restart instead of leave)
    // Let User to choose Easy or Medium or Hard mode
    //  - Easy: User has to found the number without limits of time or limits of try
    //  - Medium: User has to found the number without limits
    //  - Hard: User has to found the number
    // Display Game interface
    //  - Top of the console:
    //    - Top left: Username
    //    - Top middle: Last number written by the user and display if it's too large or too small
    //    - Top Right: User tries
    //  - Middle of the console:
    //    - Timer when Hard Mode 
    //  - Bottom the console:
    //    - The question to find number (green color) and return to new line.
    //    - The User response (White color)   
    // Ask to the user the number to find
    
} while (game?.Stats().GameStatus == GameStatus.Running);
