using System;

public abstract class Monster
{
 protected virtual int NumAttacks {get{return 0;}}
 protected virtual int Defense{get{return 0;}}

 public void PrintNumAttacks()
 {
     Console.WriteLine(
         string.Format(" - Has {0} stored moves",
         this.NumAttacks));
 }
 public void printDefense()
 {
     Console.WriteLine(
         string.Format(" - Defense is rated {0}",
         this.Defense));
 }
}

public class Spawn : Monster
{
    protected override int NumAttacks {get{ return 1;}}
    protected override int Defense {get{return 1;}}
}

public class Orc : Spawn
{
    protected override int NumAttacks { get { return 3; } }
    protected override int Defense {get{return 5;}}
    public virtual void moves()  
    { 
        Console.WriteLine(String.Format(" - Has {0} stored moves", this.NumAttacks));         
    } 
    public virtual void block()  
    { 
        Console.WriteLine(String.Format(" - Defense is rated {0}", this.Defense));         
    } 
    public void orc()
    {
        Console.WriteLine("Fear me for I am a mighty Orc!");
    }
    public void IQ()
    {
        Console.WriteLine(" - IQ is rated at a 4");
    }
   public void Strength()
    {
        Console.WriteLine(" - Strength is rated at a 8");
    }
    public void Speed()
    {
        Console.WriteLine(" - Speed is rated at a 6");
    }
}

public class Fairy : Spawn
{
    protected override int NumAttacks { get { return 4; } }
    protected override int Defense {get{return 2;}}
    public virtual void moves()  
    { 
        Console.WriteLine(String.Format(" - Has {0} stored moves", this.NumAttacks));         
    } 
    public virtual void block()  
    { 
        Console.WriteLine(String.Format(" - Defense is rated {0}", this.Defense));         
    } 
    public void fairy()
    {
        Console.WriteLine("Hello, I am a mystical Fairy.");
    }
    public void IQ()
    {
        Console.WriteLine(" - IQ is rated at a 10");
    }
   public void Strength()
    {
        Console.WriteLine(" - Strength is rated at a 2");
    }
    public void Speed()
    {
        Console.WriteLine(" - Speed is rated at a 8");
    }
}

public class Golem : Spawn
{
    protected override int NumAttacks { get { return 2; } }
    protected override int Defense {get{return 10;}}
    public virtual void moves()  
    { 
        Console.WriteLine(String.Format(" - Has {0} stored moves", this.NumAttacks));         
    } 
    public virtual void block()  
    { 
        Console.WriteLine(String.Format(" - Defense is rated {0}", this.Defense));         
    } 
    public void golem()
    {
        Console.WriteLine("Me golem.");
    }
    public void IQ()
    {
        Console.WriteLine(" - IQ is rated at a 1");
    }
   public void Strength()
    {
        Console.WriteLine(" - Strength is rated at a 10");
    }
    public void Speed()
    {
        Console.WriteLine(" - Speed is rated at a 2");
    }
}

public class Encounter
{
    static void Main(string[] args)
    {
    Orc mob1 = new Orc();
    Console.WriteLine("A angry orc appeared");
    mob1.orc();
    mob1.moves();
    mob1.block();
    mob1.IQ();
    mob1.Strength();
    mob1.Speed();

    Fairy mob2 = new Fairy();
    Console.WriteLine("A friendly fairy appeared");
    mob2.fairy();
    mob2.moves();
    mob2.block();
    mob2.IQ();
    mob2.Strength();
    mob2.Speed();

    Golem mob3 = new Golem();
    Console.WriteLine("A giant golem appeared");
    mob3.golem();
    mob3.moves();
    mob3.block();
    mob3.IQ();
    mob3.Strength();
    mob3.Speed();
    }
}