using System;
class LogIn
{
    public static bool Login_Status;
    public static void Login_Control()
    {
        UserControl user_control = new UserControl();
        Console.Write("Email : ");
        string email = Console.ReadLine();
        Exit(email);
        Console.Write("Password : ");
        string password = Console.ReadLine();
        if (user_control.LogInCheck(email,password))
        {
            Login_Status = true;
            Program.Main();
        }
        else
        {
            Incorrect();
        }
    }
    public static void Logout()
    {
        Login_Status = false;
        Console.WriteLine("--- Log Out Complete ---");
        Console.WriteLine("----- Please Enter -----");
        Console.ReadLine();
    }
    
    private static void PrintLogInComplete()
    {
        Console.WriteLine("----- LogIn Complete -----");
        Console.WriteLine("------ Please Enter ------");
        Console.ReadLine();
    }
    private static void Incorrect()
    {
        Console.WriteLine("Incorrect email or password. Please try again.");
        Console.WriteLine("------ Please Enter ------");
        Console.ReadLine();
        LogIn.Login_Control();
    }public static void Exit(string exit)
    {
        switch(exit)
        {
            case "exit": case "Exit":
            {
                Console.Clear();
                Program.Main();
            }
            break;
        }
    }

}