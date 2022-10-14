using System;
public class Admin
{
    private string email;
    private string password;
    public Admin(string email,string password)
    {
        this.email = email;
        this.password = password;
    }
    public string GetEmail()
    {
        return this.email;
    }
    public string GetPassword()
    {
        return this.password;
    }
}