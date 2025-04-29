using System;

namespace Lab12a;

public class Dog
{
    public string name; //name field added
    public int age; //age field added
    private string breed; //private access modifier breed added
    private string color; //private access modifier color added

    public Dog()
    {

    }
    public string getName()
    {
        return this.name;
    }
    public void setName(string name)
    {
        this.name = name;
    }
}
