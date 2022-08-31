using System;
namespace HelloWorld

{
    class Poly {
        public string str;
        public int num;
        
        public static Poly operator +(Poly obj1, Poly obj2){
              Poly obj3= new Poly();
              obj3.str =obj1.str+obj2.str;
              obj3.num= obj1.num +obj2.num;
              return obj3;
        }
    }

    class Hello
    {
        static void Main()
        {

            //we can concatinate string using + operator:: "ram" + "rai"=> ram rai
            // we can add using + operator : 5+10 =>15
            // but To add two objects we need : 0bj3=obj1+obj2 we need operator overloading concept as shown below
            // Note: It is eaxmple of compile time polymorphism
             // Note: during compile time compiler knowns which function to be called

           Poly obj1= new Poly();
           obj1.str="om";
           obj1.num=10;

           Poly obj2= new Poly();
           obj2.str="nath";
           obj2.num=20;

           Poly obj3= new Poly();
           obj3=obj1+obj2;

            Console.WriteLine(obj3.str);
            Console.WriteLine(obj3.num);
        }
    }

   
}
