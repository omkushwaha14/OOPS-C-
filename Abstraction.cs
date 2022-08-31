using System;
namespace HelloWorld
//Abstraction in oops basically means data hiding
//Here in program "bankdetails" function is private and all the data here are hidden;
// The function "Accountdetail" is calling function "bankdetails" it doesn't know what kind of data are stored there it only can call it;
// Data in "bankdetails" is hidden;
{ 
    class Abstraction {
    
    void bankdetails(){
        int bankaccountnumber=1212122122;
        string accountname="Raju gupta";
        long atmcardnumber=987654567867800012;
        int atmcvv=089;
        int atmpin=1234;
        Console.WriteLine("Bankaccount number is:{0}",bankaccountnumber);
        Console.WriteLine("Account name:{0}",accountname);
        Console.WriteLine("atmcardnumber:{0}",atmcardnumber);
        Console.WriteLine("atmcvv:{0}",atmcvv);
        Console.WriteLine("atmpin:{0}",atmpin);
    }

    public void Accountdetail(){
        Console.WriteLine("This is account details of bank account: ");
        bankdetails();
    }
  }

    class Oops
    {
        static void Main()
        {
            Abstraction ab= new Abstraction();
            ab.Accountdetail(); 
           
        }
    }
}
