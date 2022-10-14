using System;
public class Teachers : Users
{
    private string rank;
    private bool use_car;
    private string id_car;
    private Admin admin;
    public Teachers(string name_prefix,string name,string surname,int age,string allergy,string religion,bool admin,string email,string password,string rank,bool use_car, string id_car)
    : base(name_prefix,name,surname,age,allergy,religion,admin)
    {
        this.rank = rank;
        this.use_car = use_car;
        this.id_car = id_car;
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

}