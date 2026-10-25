using System;public class HelloWorld {
   enum DaysofWeek{
      Monday = 1,
      Tuesday,
      Wednesday,
      Thursday,
      Friday,
      Saturday,
      Sunday,
 }
  public static void Main(string[] args) {
      Console.WriteLine("StudentID: 66568, Name: Abiha Rahim, Date: 10/25/2026");
      Console.WriteLine("Enter the number(1-7):");
      var daynumber= Console.ReadLine();// i used var to input of every data type
      int dayNumber;

    if (int.TryParse(daynumber, out dayNumber) && // here i used a method to convert the value into integer
    dayNumber >= 1 && dayNumber <= 7)// here i check that whether it fulfills the condition or not
  {
    DaysofWeek day = (DaysofWeek)dayNumber;// i used this to create an object 
    Console.WriteLine(day);
   }
    else
  {
    Console.WriteLine("Invalid number");
    }
 }
}
