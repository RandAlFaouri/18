/*internal class Program
{
    private static void Main(string[] args)
    {
        
        var e = new Eagle();
        Animal a = e;
        //Falcon f = a as Falcon;
        if(a is Falcon)
        {
            Console.WriteLine("a is a falcon");
        }
        else
        {
            Console.WriteLine("a is not a falcon    ");
        }
        Eagle e2=(Eagle)a;
       e2.Fly() ;
        
    }
}
abstract class Animal
{
    public void Move()
    {
        Console.WriteLine("Moving");

    }
}
sealed class Eagle : Animal
{
    public void Fly()
    {
        Console.WriteLine("Flying");

    }
}
class AmericanEagle: Eagle
class Falcon : Animal
{
    public void Fly()
    {
        Console.WriteLine("Flying");

    }
}*/

using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

/*internal class Program
{
    private static void Main(string[] args)
    {
         Animal a = new Animal();
         //a.Name = "Eagle";
        // Console.WriteLine(typeof(Eagle));*
        Eagle e = new Eagle();
        Console.WriteLine(e.GetType());

    }
       

    }
class Animal
{
    public string Name { get; set; }
    public void Move()
    {
        
        Console.WriteLine($"Animal: {Name} is moving");
    }
    public override string ToString()
    {
        return $"Animal: {Name}";
    }
}
class Eagle : Animal
{

}
*/
/*internal class Program
{
    private static void Main(string[] args)
    {
        Subclass sc = new Subclass(123);
        Console.WriteLine();
    }
}
class Baseclass
{
    public int x;

public Baseclass()
{
    
}
public Baseclass(int value)
{
   x = value;
}}
class Subclass : Baseclass
{
    public Subclass (int scValue) : base(scValue)
    {

    }

}*/


internal class Program
{
    private static void Main(string[] args)
    {
        Manager m = new Manager(1000, "Ali A.", 1800, 10);
       /*  {
            Id = 1000,
            Name = "Ali A.",
            LoggedHours = 180,
            Wage = 10
        };*/
        Maintanence ms = new Maintanence(1000, "Salim M.", 182, 8);
      /*  {
            Id = 1000,
            Name = "Salim M.",
            LoggedHours = 182,
            Wage = 8
        };*/
        Sales s = new Sales(1002, "Sally N.", 176, 9, 0.05m, 1000m);
       /* {
            Id = 1002,
            Name = "Sally N.",
            LoggedHours = 176,
            Wage = 9,
            Commission = 0.05m,
            SalesVolume=1000m
        };*/
        Developer d = new Developer(1003, "Issam N.", 186, 15, true);
       
     /*   {
            Id = 1003,
            Name = "Issam N.",
            LoggedHours = 186,
            Wage = 15,
            TaskCompleted = true
        };*/
        Employee[] employees = { m, ms, s, d };
        foreach (var employee in employees)
        {
            Console.WriteLine("\n--------------------");
            Console.WriteLine(employee);
        }
            Console.WriteLine(m);
    }
}
