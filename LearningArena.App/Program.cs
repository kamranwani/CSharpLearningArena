// See https://aka.ms/new-console-template for more information
using LearningArena.ApplicationBlock.Interface;
using LearningArena.ApplicationBlock.Services;

Console.WriteLine("Hello, World!");

try
{
    IUserService userService = new UserService();
    //Console.WriteLine("Enter the message");
    //string message = Console.ReadLine();
    //userService.SendMessage(message);

    string data = userService.GetMessage();
    Console.WriteLine(data);
}
catch(Exception ex)
{
   Console.WriteLine(ex.ToString());    
}