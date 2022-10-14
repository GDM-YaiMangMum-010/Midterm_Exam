using System;
public class Collegian : Users
{
    private int id_student;
    private Admin admin;
    public Collegian(string name_prefix,string name,string surname,int id_student,int age,string allergy,string religion,bool admin,string email,string password)
    : base(name_prefix,name,surname,age,allergy,religion,admin)
    {
        this.id_student = id_student;
        this.admin = new Admin(email,password);
    }
    public string GetEmail()
    {
        return this.admin.GetEmail();
    }
    public string GetPassword()
    {
        return this.admin.GetPassword();
    }
    public int GetIDStudent()
    {
        return this.id_student;
    }
}