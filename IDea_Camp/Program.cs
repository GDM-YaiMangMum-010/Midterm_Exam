using System;
class Program
{
    public static void Main()
    {
        UserControl list_user = new UserControl();
        if (LogIn.Login_Status == false)
        {
            Console.WriteLine("--------- IDEA CAMP-----------");
            Console.WriteLine("1. Register for the event");
            Console.WriteLine("2. Exhibitor statistics");
            Console.WriteLine("3. SignIn");
            string input = Input();
            switch(input)
                {
                    case "1":
                    {
                        Console.Clear();
                        Register.Register_Control();
                    }
                        break;
                    case "2":
                    {
                        list_user.ShowAllList();
                        Console.Clear();
                        Main();
                    }
                        break;
                    case "3":
                    {
                        Console.Clear();
                        LogIn.Login_Control();
                    }
                        break;
                    default:
                    {
                        Console.Clear();
                        Main();
                    }
                        break;
                }
        }
        if (LogIn.Login_Status == true)
        {
            Console.WriteLine("1. Register for the event");
            Console.WriteLine("2. Information of all current students");
            Console.WriteLine("3. Information of all participating students");
            Console.WriteLine("4. Information of all participating teachers");
            Console.WriteLine("5. Logout");
            string input = Input();
            switch(input)
                {
                    case "1":
                    {
                        Console.Clear();
                        Register.Register_Control();
                    }
                        break;
                    case "2":
                    {
                        list_user.ShowlistCollegian();
                        Console.Clear();
                        Main();
                    }
                        break;
                    case "3":
                    {
                        list_user.ShowlistStudent();
                        Console.Clear();
                        Main();
                    }
                        break;
                    case "4":
                    {
                        list_user.ShowlistTeacher();
                        Console.Clear();
                        Main();
                    }
                        break;
                    case "5":
                    {
                        Console.Clear();
                        LogIn.Login_Status = false;
                        Console.WriteLine("--- Log Out Complete ---");
                        Console.WriteLine("----- Please Enter -----");
                        Console.ReadLine();
                        Console.Clear();
                        Main();
                    }
                        break;
                    default:
                        break;
                }
        }        
    }
    
    
    public static string Input()
    {
        return Console.ReadLine();
    }
    
}