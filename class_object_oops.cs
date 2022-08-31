using System;
namespace HelloWorld
{

   class Fruits{
     
     public void print1(){
           Console.WriteLine("This is apple");
       }
        public void print2(){
           Console.WriteLine("This is mango");
       }
   }

    class vehicle{
    
     public void print1(){
           Console.WriteLine("This is car");
       }

       public void print2(){
           Console.WriteLine("This is bus");
       }
       
   }

   
    class Hello
    {
        static void Main()
        {
            //Here we have created "apple" as class and "ap" is object of it
            // using object "ap" we have called print() function;
            Fruits ap= new Fruits();
            ap.print1();
            ap.print2();
             
            // similarly we can create multiple class and object
            //Again "Vehicle" is class and "vh" is its objects

            vehicle vh = new vehicle();
            vh.print1();
            vh.print2();

        }
    }
}
