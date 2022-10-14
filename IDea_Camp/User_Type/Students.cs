using System;
public class Students: Users
{
    private string school;
    private int level_education;
    public Students(string name_prefix,string name,string surname,int age,int level_education,string allergy,string religion,string school)
    : base(name_prefix, name,surname,age,allergy,religion,false)
    {
        this.level_education = level_education;
        this.school = school;
    }
    public int GetLevelEducation()
    {
        return this.level_education;
    }
    public string GetSchool()
    {
        return this.school;
    }
}