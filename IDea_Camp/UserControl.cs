using System;
public class UserControl
{
    private List<Users> user_Control;
    public UserControl()
    {
        this.user_Control = new List<Users>();
    }
    public void NewUsers(Users user)
    {
        this.user_Control.Add(user);
    }

    public bool PrimaryInfoCheck(string name_prefix,string name,string surname)
    {
        foreach(Users user in this.user_Control)
        {
            if(user.GetNamePrefix() == name_prefix && user.GetName() == name && user.GetSurname() == surname)
            {
                return true;
            }
        }
        return false;
    }
    public bool EmailCheck(string email)
    {
        foreach(Users user in this.user_Control)
        {
            if (user.GetAdmin() == true)
            {
                if (user is Collegian)
                {
                    if (((Collegian)user).GetEmail() == email || email == "exit")
                    {
                        return true;
                    }
                }
                else if (user is Teachers)
                {
                    if (((Teachers)user).GetEmail() == email || email == "exit")
                    {
                        return true;
                    }
                }
            }
        }
        return false;
    }
    public bool LogInCheck(string email,string password)
    {
        foreach(Users user in this.user_Control)
        {
            if (user.GetAdmin() == true)
            {
                if (user is Collegian)
                {
                    if (((Collegian)user).GetEmail() == email && ((Collegian)user).GetPassword() == password)
                    {
                        return true;
                    }
                }
                else if (user is Teachers)
                {
                    if (((Teachers)user).GetEmail() == email && ((Teachers)user).GetPassword() == password)
                    {
                        return true;
                    }
                }
            }
        }
        return false;
    }
    public void ShowlistCollegian()
    {
        Console.WriteLine("List Collegian");
        Console.WriteLine("");
        foreach (Users user in this.user_Control)
        if (user is Collegian)
        {
            Console.WriteLine("{0} {1} {2}",user.GetNamePrefix(), user.GetName(), user.GetSurname());
        }
        Program.Input();
        
    }
    public void ShowlistStudent()
    {
        Console.WriteLine("List Collegian");
        Console.WriteLine("");
        foreach (Users user in this.user_Control)
        if (user is Students)
        {
            Console.WriteLine("{0} {1} {2}",user.GetNamePrefix(), user.GetName(), user.GetSurname());
        }
        Program.Input();
        
    }
    public void ShowlistTeacher()
    {
        Console.WriteLine("List Collegian");
        Console.WriteLine("");
        foreach (Users user in this.user_Control)
        if (user is Teachers)
        {
            Console.WriteLine("{0} {1} {2}",user.GetNamePrefix(), user.GetName(), user.GetSurname());
        }
        Program.Input();
        
    }
    public void ShowAllList()
    {
        int teachers=0, students=0, collegian=0, m4=0, m5=0, m6=0;
        foreach (Users user in this.user_Control)
        {
            if (user is Teachers)
            {
                teachers++;
            }
            else if (user is Students)
            {
                students++;
                switch(((Students)user).GetLevelEducation())
                {
                    case 1:
                    {
                        m4++;
                    }
                    break;
                    case 2:
                    {
                        m5++;
                    }
                    break;
                    case 3:
                    {
                        m6++;
                    }
                    break;
                }
            }
        }
        Console.WriteLine("All Teachers = {0}",teachers);
        Console.WriteLine("All Students = {0}",students);
        Console.WriteLine("All Colligian = {0}",collegian);
        Console.WriteLine("All Level 4 = {0}",m4);
        Console.WriteLine("All Level 5 = {0}",m5);
        Console.WriteLine("All Level 6 = {0}",m6);
    }
    public void ShowLogInInfo()
    {
        Console.WriteLine("List Admin");
        Console.WriteLine("");
        foreach (Collegian collegian in this.user_Control)
        {
            Console.WriteLine("{0} {1}",collegian.GetEmail(), collegian.GetPassword());
        }
        Program.Input();
        
    }

}