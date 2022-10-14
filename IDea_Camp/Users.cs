using System;
public class Users
{
    private string name_prefix;
    private string name;
    private string surname;
    private int age;
    private string allergy;
    private string religion;
    private bool admin;

    public Users(string name_prefix,string name,string surname,int age,string allergy,string religion,bool admin)
    {
        this.name_prefix = name_prefix;
        this.name = name;
        this.surname = surname;
        this.age = age;
        this.allergy = allergy;
        this.religion = religion;
        this.admin = admin;
    }
    public bool GetAdmin()
    {
        return this.admin;
    }
    public string GetNamePrefix()
    {
        return this.name_prefix;
    }
    public string GetName()
    {
        return this.name;
    }
    public string GetSurname()
    {
        return this.surname;
    }
    public int GetAge()
    {
        return this.age;
    }
    public string GetAllergy()
    {
        return this.allergy;
    }
    public string GetReligion()
    {
        return this.religion;
    }
}