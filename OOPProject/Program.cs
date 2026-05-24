using System;
class Animal { 
    public void eat()
    {
        Console.WriteLine("animal is eating");
    }
}
class dog : Animal
{ 
    public void bark()
    {
        Console.WriteLine("dog is barking");
    }
}
class Program
{ 
    static void Main()
    {
        dog d = new dog();
        d.bark();
        d.eat();
        Console.WriteLine("this code is written by meerab");
    }
}



