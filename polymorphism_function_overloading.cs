using System;
namespace HelloWorld
{

//in function overloading we can call same function name using:
//1: different paramaters
//2: different data types
//Note: function name should be same
//It is example of compile time polymorphism

class Poly {
     
     public void sum(int a, int b){
           Console.WriteLine(a+b);
     }

     public static int sum(int a, int b, int c){
            return a+b+c;
     }
     public void sum(char a, char b){
           Console.WriteLine(a+b);
     }
    

}

    class Hello
    {
        static void Main()
        {
             Poly obj= new Poly();
             obj.sum(10,12);
             obj.sum('A','B');
            Console.WriteLine(Poly.sum(10,20,30));
        }
    }
}
