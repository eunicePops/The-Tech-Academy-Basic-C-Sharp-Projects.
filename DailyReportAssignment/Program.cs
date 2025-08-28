// See https://aka.ms/new-console-template for more information
Console.WriteLine("Academy of Learning Career College\nStudent Daily Report");
Console.WriteLine("What is your name?");
string name = Console.ReadLine();
Console.WriteLine("What course are you on?");
string course = Console.ReadLine();
Console.WriteLine("What page number?");
string pagNum = Console.ReadLine();
int pageNumber = Convert.ToInt32(pagNum);
Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"");
string needHelp = Console.ReadLine();
bool  helpNedeed = Convert.ToBoolean(needHelp);
Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
string positiveExp = Console.ReadLine();
Console.WriteLine("How many hours did you study today?");
string hoursStudied = Console.ReadLine();
int hours = Convert.ToInt32(hoursStudied);
Console.WriteLine("Thank you for your answers. An Instructor will respond shortly. Have a great day!");
Console.ReadLine();


