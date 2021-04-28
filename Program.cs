using System;

namespace classAndMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating an object of the class to pass in the parameters and using the printFullName
            //method to display the fullname in the console.
         // student Andrey = new student("Andrew","Gabriel",24);
          //non static mehthod being called with an instance of the student class
         // Andrey.printFullName();
          //static method being used using the class name and the method. 
          //student.printFullName("Andrew","Gabriel",34);  

        classAndMethodsExample sam = new classAndMethodsExample(011,"09067856743","7 Adeboku ayaba lagos okeke barracks.","Sam Allardyce");
        classAndMethodsExample john = new classAndMethodsExample(022,"08078345612","10 Ayaba kabisku lagos kotun egbe barracks.","John Terry");
        Console.WriteLine("Student Details.\n===================\n==============");       
        sam.printDetails();
        Console.WriteLine();
        john.printDetails();

        Console.WriteLine();
        Triangle.calculateArea(10,9);
        Triangle.calculatePerimeter(12,8,9);
      

        }
    }

    //creating a class using the class keyword and class name.
    //also a class requires a constructor to help us access the variables of that class
    //a constructor is declared using the public key word and a class name.
    //so a class is a complex data type that help stores data of complex data types..
    //basically a class is just like a big variable..that holds dataTypes of various dataTypes and helps
    //store the together..so its more effective and very efficient.
    public class student 
    {
        string _firstname ;
        string _lastname;
        int _age;
        public student(string firstname, string lastname, int age)
    {
        _firstname = firstname;
        _lastname = lastname;
        _age = age;
    }

      public void addNumbers(int Number1, int Number2)
    {
        int  result = Number1 + Number2;
        Console.WriteLine($"The Addition of {Number1} + {Number2} = {result}");
    }

    //Why do we not use static key word along with the method definition..
    //This is because using a static key word only means we cant create copies of this method class.
    //in another way we can say we cannot add object of the class to the call the method
    //or we can say a staic method can not call the method with and instance of the class.
    //A static (method,variable,or constructor ) can't be called with and instance..the only way to access it is.
    //calling the variable name then the static method to access it.e.g(student.printFullname("Andrew","Gabriel");)  
    
    //creating a static method.
    public static void printFullName(string firstname,string lastname, int age)
    {
      
        Console.WriteLine($"The Firstname is {firstname} and lastname is {lastname} and am {age}");
    }

    //non-static method being created.
     public void printFullName()
    {
      
        Console.WriteLine($"The Firstname is {_firstname} and lastname is {_lastname} and am {_age}");
    }
}
    }

    
