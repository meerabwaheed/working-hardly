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
class student : Person
{
    private int rollNumber;
    public void study()
    {
        Console.WriteLine("student is inherited by person");
    }
}