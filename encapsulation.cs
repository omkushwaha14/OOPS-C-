using System;
namespace HelloWorld
{
  //encapsulation basically means using access modifiers to manage public, private and protected functions
  //it is used for purpose of data hiding


   class enc{
      
      private void print(){
          Console.WriteLine("This is encapsulation");
      }

      public void nextprint(){
          Console.WriteLine("This is Nextencapsulation");
          print();
      }

   }


    class Hello
    {
        static void Main()
        {
             enc x= new enc();
             x.nextprint();


             
        }
    }
}
