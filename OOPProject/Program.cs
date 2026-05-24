// using System;
// class Animal { 
//     public void eat()
//     {
//         Console.WriteLine("animal is eating");
//     }
// }
// class dog : Animal
// { 
//     public void bark()
//     {
//         Console.WriteLine("dog is barking");
//     }
// }
// class Program
// { 
//     static void Main()
//     {
//         dog d = new dog();
//         d.bark();
//         d.eat();
//         Console.WriteLine("this code is written by meerab");
//     }
// }





//     //             +----------------------+
//     //             |       Animal         |
//     //             +----------------------+
//     //             | - name : string      |
//     //             +----------------------+
//     //             | + Eat() : void       |
//     //             +----------------------+
//     //                        ▲
//     //                        |
//     //            -----------------------
//     //            |                     |
//     //            |                     |
//     //   +----------------+    +----------------+
//     //   |      Dog       |    |      Cat       |
//     //   +----------------+    +----------------+
//     //   | - breed:string |    | - color:string |
//     //   +----------------+    +----------------+
//     //   | + Bark() :void |    | + Meow() :void |
//     //   +----------------+    +----------------+

// using System;
// class Animal
// {
//     private string name;
//     public void eat()
//     {
//         Console.WriteLine("animals are eating");
//     }
// }
// class dog: Animal
// {
//     private string breed;
//     public void bark()
//     {
//         Console.WriteLine("dogs bark");
//     }
// }
// class cat : Animal
// {
//     private string color;
//     public void meow()
//     {
//         Console.WriteLine("cat making meow sound");
//     }
// }
// class Program
// {
//     static void Main()
//     {
//         dog d = new dog();
//         d.bark();
//         d.eat();

//         cat c = new cat();
//         c.eat();
//         c.meow();
//         Console.WriteLine("this code is written by me")
//     }
// }



//                 +----------------------+
//                 |        Person        |
//                 +----------------------+
//                 | - name : string      |
//                 | - age : int          |
//                 +----------------------+
//                 | + Display() : void   |
//                 +----------------------+
//                            ▲
//                            |
//          -----------------------------------
//          |                                 |
//          |                                 |
// +----------------------+     +----------------------+
// |       Student        |     |       Teacher       |
// +----------------------+     +----------------------+
// | - rollNo : int       |     | - subject : string  |
// +----------------------+     +----------------------+
// | + Study() : void     |     | + Teach() : void    |
// +----------------------+     +----------------------+

using System;
class Person
{
    private string name;
    private int age;
    public void display()
    {
        Console.WriteLine("person info displaying");
    }
}
class Student : Person
{
    private int rollNumber;
    public void Study()
    {
        Console.WriteLine("student inherits from person");
    }
}
class Teacher:Person
{
    private string subject;
    public void Teach()
    {
        Console.WriteLine("teacher are inherited by person");
    }
}
class Program
{
    static void Main()
    {
        Student s1 = new Student();
        s1.Study();
        s1.display();
        Teacher t1 = new Teacher();
        t1.Teach();
        t1.display();
    }
}

    //              +----------------------+
    //              |       Vehicle        |
    //              +----------------------+
    //              | - brand : string     |
    //              | - speed : int        |
    //              +----------------------+
    //              | + Start() : void     |
    //              +----------------------+
    //                         ▲
    //            -------------------------
    //            |                       |
    //   +----------------+      +----------------+
    //   |      Car       |      |      Bike      |
    //   +----------------+      +----------------+
    //   | - doors : int  |      | - helmet:bool  |
    //   +----------------+      +----------------+
    //   | + Drive()      |      | + Ride()       |
    //   +----------------+      +----------------+
    using System;
    class Vehicle
{
    private string Brand;
    private int Speed;
    public void start()
    {
        Console.WriteLine("the vehicle is the main class program");
    }
}
class Car : Vehicle
{
    private int door;
    public void drive()
    {
        Console.WriteLine("car is inherited from vehicle");
    }
}
class Bike: Vehicle
{
    private bool helmet;
    public void ride()
    {
        Console.WriteLine("bike is derived from parent class vehicle");
    }
}
class Program
{
    static void Main()
    {
        Car c1 = new Car();
        c1.door();
        c1.drive();

        bike b1 = new bike();
        b1.helmet();
        b1.ride();
    }
}