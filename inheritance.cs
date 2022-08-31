using System;
namespace HelloWorld
{


//let say there are two floor is building, floor1 & floor2 and parking is common for all.
// since parking is common for both so we can declear it in one class 
// inherite in both class floor1 & floor2, which helps in code reuseability
    class floor1 {

        public void print(){
        Console.WriteLine("This is floor 1");
        } 
    }

    class floor2:parking{
        public void print(){
        Console.WriteLine("This is floor 2");
        } 
    }

    class parking{
       
        public parking(){
        Console.WriteLine("parking is common for all");
        } 
    }

    class Hello
    {
        static void Main()
        {
            floor2 fl= new floor2();
            fl.print();
        }
    }
}
