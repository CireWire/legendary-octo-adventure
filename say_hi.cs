using System;

class MainClass 
{
  public class Person
  {
    protected int age {get; set;}
    protected string name {get; set;}
  }

  private class Patient: Person
  {
    public Patient(string nm)
    {
      name = nm;
    }

    public void Greeting()
    {
      Console.WriteLine("Hello World! My name is "+name+"!");
    }
  }



  public static void Main (string[] args) 
  {
    Patient p = new Patient("Kyle Oliver");
    p.Greeting();
  }
}
