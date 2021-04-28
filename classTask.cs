using System;

namespace classAndMethods
{
    class classAndMethodsExample
    {
        int _rollNumber;
        string _phoneNumber;
        string _address;
        string _studentName;


        public classAndMethodsExample(int rollNumber,string phoneNumber,string address,string studentName)
        {
            _rollNumber = rollNumber;
            _phoneNumber = phoneNumber;
            _address = address;
            _studentName = studentName;
        }

        public void printDetails()
        {
      
        Console.WriteLine($"Student Name : {_studentName}\nroll Number : {_rollNumber}\nPhone Number : {_phoneNumber}\nAddress : {_address}\nThank You.");
        }
    }

class Triangle
{
    public static void calculateArea(int triangleBase,int height)
    {
        double area = height * triangleBase;
        Console.WriteLine($"The Area of the traingle = {area}.");
    }

    public static void calculatePerimeter(int triangleBase,int width,int height)
    {
        double perimeter = triangleBase + height + width;
        Console.WriteLine($"The Perimeter of {triangleBase} + {height} + {width} = {perimeter}");
    }
}
}