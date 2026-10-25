using System;

public class HelloWorld {
    public static void Main(string[] args) {
        Console.WriteLine("StudentID: 66568, Name: Abiha Rahim, Date: 10/25/2026");
       Console.WriteLine("Enter the year:");
      int y= int.Parse(Console.ReadLine());
        
    if((y%4==0 && y%100!=0) ||(y%400==0))//here i used the conditions to check whether it is leap year or not
        Console.WriteLine("the year is a leap year");
        
    else// if the year is not leap it will fall into the else category
        Console.WriteLine("the year is not a leap year");
   }
}
