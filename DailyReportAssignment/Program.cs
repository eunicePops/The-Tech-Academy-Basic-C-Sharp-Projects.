// See https://aka.ms/new-console-template for more information
Console.WriteLine("Academy of Learning Career College\nStudent Daily Report");
//Takes input from user and stires in variable name 
Console.WriteLine("What is your name?");
//The user input their name and it is stored in a variable called name with a string data type
string name = Console.ReadLine();
//Asks user for course name and stores it in a variable called course with a string data type
Console.WriteLine("What course are you on?");
string course = Console.ReadLine();
//Asks user for page number and stores it in a variable called pagNum
Console.WriteLine("What page number?");
//the user input is stored as a string because Console.ReadLine() returns a string
string pagNum = Console.ReadLine();
//Converts the string variable pagNum to an integer and stores it in a variable called pageNumber
int pageNumber = Convert.ToInt32(pagNum);
//Asks user if they need help and stores the input in a variable called needHelp
//The escape character \" is used to include double quotes in the string
Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"");
//The user input is stored as a string because Console.ReadLine() returns a string placed in a variable called needHelp
string needHelp = Console.ReadLine();
//Converts the string variable needHelp to a boolean and stores it in a variable called helpNedeed
bool helpNedeed = Convert.ToBoolean(needHelp);
//Asks user for positive experiences and stores the input in a variable called positiveExp
Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
//The user input is stored as a string because Console.ReadLine() returns a string placed in a variable called positiveExp
string positiveExp = Console.ReadLine();
//Asks user for number of hours studied and stores the input in a string variable called hoursStudied
Console.WriteLine("How many hours did you study today?");
string hoursStudied = Console.ReadLine();
//Converts the string variable hoursStudied to an integer and stores it in a variable called hours
int hours = Convert.ToInt32(hoursStudied);
//Thanks the user for their answers and tells them an instructor will respond shortly
Console.WriteLine("Thank you for your answers. An Instructor will respond shortly. Have a great day!");
//Keeps the console window open until the user presses Enter
Console.ReadLine();


