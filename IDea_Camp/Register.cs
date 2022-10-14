using System;
class Register
{
    static UserControl user_control;
    static void ListUser()
    {
        Register.user_control = new UserControl();
    }
    public static void Register_Control()
    {
        ListUser();
        PrintRegisterHeader();
        SelectType();
    }
    static void SelectType()
    {
        UserControl user_control = new UserControl();
        PrintTypeForChoose();
        switch(Program.Input())
        {
            case "1":
            {
                NewCollegian();
                Console.Clear();
                Program.Main();
            }
            break;
            case "2":
            {
                NewStudent();
                Console.Clear();
                Program.Main();
            }
            break;
            case "3":
            {
                NewTeacher();
                Console.Clear();
                Program.Main();
            }
            break;
            default:
            SelectType();
            break;
        }
    }
    public static void NewCollegian()
    {
        string name_prefix = InputPreFix();
        string name = InputName();
        string surname = InputSurName();
        if (user_control.PrimaryInfoCheck(name_prefix,name,surname))
        {
            Console.WriteLine("User is already registered. Please try again.");
            NewCollegian();
        }
        long id_student = InputIDStudent();
        int age = InputAge();
        string allergy = InputAllergy();
        string religion = InputRiligion();
        bool admin = InputAdmin();
        string email = "";
        string password ="";
        InputEmailAndPassAdmin(admin,ref email,ref password);
        Console.WriteLine("{0} {1}",email,password);
        Console.ReadLine();
        Collegian collegian = new Collegian(name_prefix,name,surname,id_student,age,allergy,religion,admin,email,password);
        Register.user_control.NewUsers(collegian);
        }
    public static void NewStudent()
    {
        string name_prefix = InputPreFix();
        string name = InputName();
        string surname = InputSurName();
        if (user_control.PrimaryInfoCheck(name_prefix,name,surname))
        {
            Console.WriteLine("User is already registered. Please try again.");
            NewCollegian();
        }
        int age = InputAge();
        string allergy = InputAllergy();
        string religion = InputRiligion();
        int level_education = InputLevelEducation();
        string school = InputSchool();
        Students students = new Students(name_prefix,name,surname,age,level_education,allergy,religion,school);
        Register.user_control.NewUsers(students);
    }
    public static void NewTeacher()
    {
        string name_prefix = InputPreFix();
        string name = InputName();
        string surname = InputSurName();
        if (user_control.PrimaryInfoCheck(name_prefix,name,surname))
        {
            Console.WriteLine("User is already registered. Please try again.");
            NewCollegian();
        }
        int age = InputAge();
        string allergy = InputAllergy();
        string religion = InputRiligion();
        bool admin = InputAdmin();
        string email = "";
        string password ="";
        InputEmailAndPassAdmin(admin,ref email,ref password);
        string rank = InputRank();
        bool use_car = InputUseCar();
        string id_car = "";
        if (use_car == true)
        {
            id_car = InputIDCar();
        }
        Teachers teachers = new Teachers(name_prefix,name,surname,age,allergy,religion,admin,email,password,rank,use_car,id_car);
        Register.user_control.NewUsers(teachers);
    }

    private static void InputEmailAndPassAdmin(bool admin,ref string email,ref string pass)
    {
        if(admin == true)
        {
            email = InputEmail();
            pass = InputPassword();
            user_control.EmailCheck(email);
        }
    }
    
    private static bool InputUseCar()
    {
        Console.WriteLine("You are use car? Y/N");
        switch(Program.Input())
        {
            case "Y":case "y":
            {
                return true;
            }
            case "N":case "n":
            {
                return false;
            }
            default:
            break;
        }
        Console.WriteLine("Please Select in this choice");
        return InputUseCar();
    }
    private static void PrintRegisterHeader()
    {
        Console.WriteLine("--------- Register for the event ---------");
    }
    private static void PrintTypeForChoose()
    {
        Console.WriteLine("---------   Please Select Type   ---------");
        Console.WriteLine("1. Collegian");
        Console.WriteLine("2. Student");
        Console.WriteLine("3. Teacher");
        Console.Write("Type : ");
    }
    private static void PrintPrefixForChoose()
    {
        Console.WriteLine("---------   Please Select PreFix   ---------");
        Console.WriteLine("1. Mr.");
        Console.WriteLine("2. Ms.");
        Console.WriteLine("3. Miss");
        Console.WriteLine("........................................");
        Console.Write("PreFix : ");
    }
    private static void PrintReligionForChoose()
    {
        Console.WriteLine("---------   Please Select Religion   ---------");
        Console.WriteLine("1. Buddhist");
        Console.WriteLine("2. Christ");
        Console.WriteLine("3. Islam");
        Console.WriteLine("4. Other");
        Console.WriteLine("........................................");
        Console.Write("Religion : ");
    }
    private static void PrintLevelEducationForChoose()
    {
        Console.WriteLine("---------   Please Select Level Education   ---------");
        Console.WriteLine("1. Secondary school year 4");
        Console.WriteLine("2. Secondary school year 5");
        Console.WriteLine("3. Secondary school year 6");
        Console.WriteLine("........................................");
        Console.Write("Level Education : ");
    }
    private static void PrintRankForChoose()
    {
        Console.WriteLine("---------   Please Select Rank   ---------");
        Console.WriteLine("1. Dean");
        Console.WriteLine("2. Head of department");
        Console.WriteLine("3. Full-time teacher");
        Console.WriteLine("........................................");
        Console.WriteLine("Rank : ");
    }
    public static string InputPreFix()
    {
        PrintPrefixForChoose();
        switch(Program.Input())
        {
            case "1":
            {
                return "Mr.";
            }
            case "2":
            {
                return "Ms.";
            }
            case "3":
            {
                return "Miss";
            }
            default:
            PrintPrefixForChoose();
            break;
        }
        Console.WriteLine("Please Select in this choice"); 
        return InputPreFix();
    }
    public static string InputName()
    {
        Console.Write("Name : ");
        return Program.Input();
    }
    public static string InputSurName()
    {
        Console.Write("Surname : ");
        return Program.Input();
    }
    public static int InputIDStudent()
    {
        Console.Write("ID Student : ");
        return int.Parse(Program.Input());
    }
    public static int InputAge()
    {
        Console.Write("Age : ");
        return int.Parse(Program.Input());
    }
    public static string InputAllergy()
    {
        Console.Write("Allergy : ");
        return Program.Input();
    }
    public static string InputEmail()
    {
        Console.Write("Email : ");
        return Program.Input();
    }
    public static string InputPassword()
    {
        Console.Write("Password : ");
        return Program.Input();
    }
    public static string InputSchool()
    {
        Console.Write("School : ");
        return Program.Input();
    }
    public static string InputIDCar()
    {
        Console.Write("ID Car : ");
        return Program.Input();
    }
    public static string InputRiligion()
    {
        PrintReligionForChoose();
        switch(Program.Input())
        {
            case "1":
            {
                return "Buddhist";
            }
            case "2":
            {
                return "Christ";
            }
            case "3":
            {
                return "Islam";
            }
            case "4":
            {
                return "Other";
            }
            default:
            break;
        }
        Console.WriteLine("Please Select in this choice");
        return InputRiligion();
    }
    public static bool InputAdmin()
    {
        Console.WriteLine("You are Adminstrator? Y/N");
        switch(Program.Input())
        {
            case "Y":case "y":
            {
                return true;
            }
            case "N":case "n":
            {
                return false;
            }
            default:
            InputAdmin();
            break;
        }
        Console.WriteLine("Please Select in this choice");
        return InputAdmin();
    }
    public static int InputLevelEducation()
    {
        PrintLevelEducationForChoose();
        switch(Program.Input())
        {
            case "1":
            {
                return 4;
            }
            case "2":
            {
                return 5;
            }
            case "3":
            {
                return 6;
            }
            default:
            InputLevelEducation();
            break;
        }
        Console.WriteLine("Please Select in this choice");
        return InputLevelEducation();
    }
    public static string InputRank()
    {
        PrintRankForChoose();
        switch(Program.Input())
        {
            case "1":
            {
                return "Dean";
            }
            case "2":
            {
                return "Head of department";
            }
            case "3":
            {
                return "Full-time teacher";
            }
            default:
            InputRank();
            break;
        }
        Console.WriteLine("Please Select in this choice");
        return InputRank();
    }
}