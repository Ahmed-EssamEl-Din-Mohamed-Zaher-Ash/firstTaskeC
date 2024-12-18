// See https://aka.ms/new-console-template for more information
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
             //13---------------------
             int d;
             d = Convert.ToInt32( !(30 < 20) );  // مفروض يرجع قيمة ما المقارنة بخطأ وانت عاكسها يبقي بقيمة صحيحة ومش القيمة الصحيحة بواحد !ولا هي مش زي الجافاسكربت؟

        //5------------مش فاهم السؤال هنا عاوز تعدل علي متغير بس ؟--------------------
     /*   int num1 = 5;
        num1 += 5;  //ليها اكتر من طريقة الكونسبت بس 
               بعدين حخزن المتغير ده بقيمته الجديدة في متغير تاني 
        int num2 = num1;
        Console.WriteLine(num2);  //هو ده اللي عاوزه ولا لا 10*/

        //6- مفهمتش المطلوب هو تقريبا في حكاية وان رفرنس هي اللي لخبطتنيWrite C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen**/
        //1--------------------------------
        //  Console.WriteLine("Enter a number: ");
        // int num = Convert.ToInt32(Console.ReadLine());
        //  Console.WriteLine("Enter a number: " + num);
        //2--------------------------------
        // string txt = "Hello World";
        //convert string to int
        //  int num1 = Convert.ToInt32(txt);
        //  Console.WriteLine("string" + num1);
        //Unhandled exception. System.FormatException: The input string 'Hello World' was not in a correct format
        //3----------------------------
        //  float num1 = 2.75f;
        //   float num2 = 1.5f;
        //  float sum  = num1 + num2; float sub = num1 - num2; float mal = num1 * num2; float div = num1 / num2;
        //     Console.WriteLine("Sum: " + sum);
        //     Console.WriteLine("sub: " + sub);
        //      Console.WriteLine("mal: " + mal);
        //    Console.WriteLine("div: " + div); 
        //4--------------------------------
        // string txt1      = "ahmed ashour";
        //  string substring = txt1.Substring(3, 5);
        // Console.WriteLine(substring);
        //7----------------------------------
        // string str1 = "Hello, "; string str2 = "World!";
        // string str3 = str1 + str2;
        //  Console.WriteLine(str3);
        //8----------------------------------
        //(principal * rate * time) / 100;
     /*   Console.WriteLine("Enter the principal, rate and time amount: ");
        double principal = Convert.ToInt32(Console.ReadLine());
        double rate = Convert.ToInt32(Console.ReadLine());
        double time = Convert.ToInt32(Console.ReadLine());
        double interest = (principal * rate * time) / 100;
        Console.WriteLine("Simple Interest: " + interest);*/
        //9----------------------------------
        //BMI = (Weight)/(Height*Height)
     /*   Console.WriteLine("Enter the weight and height amount: ");
        double weight = Convert.ToInt32(Console.ReadLine());
        double height = Convert.ToInt32(Console.ReadLine());
        double BMI = (weight) / (height * height);
        Console.WriteLine("BMI: " + BMI);*/
        //10---------------------
      /*  Console.WriteLine("Enter the temperature amount: ");
        int temperature = Convert.ToInt32(Console.ReadLine());
        string result = temperature < 10 ? "Just Cold" : temperature > 30 ? "Just Hot" : "Just Good";
        Console.WriteLine(result);*/
          //11---------------------
       /*    Console.WriteLine("-------must be anumer------ ");
      Console.WriteLine("Enter the day : ");
        int day = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the month: ");
        int month = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Today's date: {day} , {month} , {year}");
        Console.WriteLine($"Today's date: {day} / {month} / {year}");
        Console.WriteLine($"Today's date: {day} – {month} – {year}"); */
                                                                                                             //12---------------------
       // DateTime date = new DateTime(2024, 6, 14); Console.WriteLine($"The event is on {date:MM/dd/yyyy}");  //c ) The event is on 06/14/2024
           Console.WriteLine(13 / 2 + " " + 13 % 2);      //d 6 1                                                                                        
   
        int num = 1, z = 5;


if (!(num <= 0))
    Console.WriteLine( ++num + z++ + " " + ++z ); 
else
    Console.WriteLine( --num + z-- + " " + --z ); 
    } //d 77
}
