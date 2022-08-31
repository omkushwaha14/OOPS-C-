using System;
namespace HelloWorld
{
// method overriding
// it is example of run time polymorphism
// if method defined in base class is same as method defined in derived class then it is called method overriding
// u have to use "virtual" keyword in base class and "override" keyword in derived class to achieve overriding

//it is used to provide specific implementation of method in child class which is already in parent class
 class parent{
   //base class
   public virtual void print(){
       Console.WriteLine("this is parent");
   }
    
 }

 class child: parent{
  // derived class
       public override void print(){
       Console.WriteLine("this is child");
   }
 }

    class Hello
    {
        static void Main()
        {
             parent p= new child();
             p.print();
        }
    }
}
