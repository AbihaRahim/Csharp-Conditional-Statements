using System;

public class HelloWorld {
    public static void Main(string[] args) {
     double disc;
    double amount;

     Console.WriteLine("StudentID: 66568, Name: Abiha Rahim, Date: 10/25/2026");
    Console.WriteLine("Enter the Amount:");
    double a= double.Parse(Console.ReadLine());

      
       if(a>=5000){
           disc=a*20/100;// to calculate the discount 
           amount=a-disc;// to calculate the amount left after subtracting the discount
           Console.WriteLine("discount percent is 20%.");//To print the discount percent applied
           Console.WriteLine($"Discount is={disc}");//To print the  discount amount
     Console.WriteLine($"Amount after discount={amount}");//To print the amount payable
           } 

        
        else if(a>=2000&&a<5000){
           disc =a*10/100;// to calculate the discount 
           amount=a-disc;// to calculate the amount left after subtracting the discount
            
          Console.WriteLine("discount percent is 10%.");//To print the discount percent applied
          Console.WriteLine($"Discount is={disc}");//To print the  discount amount
      Console.WriteLine($"Amount after discount={amount}"); //To print the amount payable
        }

        
        else{
            amount=a;// to calculate the amount left after subtracting the discount
            disc=0;// to calculate the discount 
            Console.WriteLine("discount percent is 0%.");//To print the discount percent applied
            Console.WriteLine($"Discount is={disc}");//To print the  discount amount
        Console.WriteLine($"Amount after discount={amount}");//To print the amount payable
        }     
    }
}
