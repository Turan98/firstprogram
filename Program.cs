using System;
using System.Collections.Generic;
using System.Threading.Tasks;

/*class My_first_oop
{
    public int x;
    public int y;
}

class Program
{
    static void Main (string[] args)
    {
      My_first_oop object_1 = new My_first_oop();
      object_1.x = 4; 
      object_1.y = 2;
      Console.WriteLine("X:" + object_1.x + " " + "Y:" + object_1.y);
      
    }
}*/
/*class Program
{
  

static void Main (string[] args)
{
  
  Console.WriteLine(findsum(45, 50));
  Console.WriteLine(findsum(46, 55));
  Console.WriteLine(finddiff(45, 50));
  Console.WriteLine(finddiff(46, 55));
  Console.WriteLine(findfullname());

}
 static int findsum( int a, int b)
 {

   return a+b;

 }
  static int finddiff( int a, int b)
 {

   return Math.Abs(a-b);

 }
 static string findfullname( string name = "Turan", string surname = "Sadiqov")
 {
   
   return  (name + " "  + surname);

 }
}*/
/////////////////////////////////////////////////////////////////////
/*/*class Program
{
  static void Main (string[] args)
  {
    //string name = "Turan";
    //string surname = "Sadiqov";

     Console.WriteLine(fullname("Turan", "Sadiqov"));
     Console.WriteLine(resultlength("Turan", "Sadiqov"));
  
  }

  static string fullname(string name, string surname )
  {
     string result = name + " " + surname;
     return result;
    
    
  }
  static int resultlength(string name, string surname)
  {
    string result1 = name + " " + surname;
    int length = result1.Length;
    return length;
  }

}*//**/

class Program
{
  static void Main(string[] args)
  {
    
    Console.WriteLine(fullname("Turan" , "Sadiqov"));
    Console.WriteLine(lengthFullname ("Turan" , "Sadiqov"));
   // Console.WriteLine(squarelength("Turan" , "Sadiqov"));
   
   if (lengthFullname("Turan" , "Sadiqov") > 10)
   {
    Console.WriteLine(true);
   }
   else
   {
    Console.WriteLine(false);
   }

  }
  static string fullname(string name, string surname) 
  {
     string result = name + " " + surname;
     return result;
  }
  static int lengthFullname(string name, string surname)
  {
     string fulllength = name + "  " + surname;
     int length = fulllength.Length;
     return length;
  }

 /* static int squarelength(string name, string surname)
  { 
    string fulllength = name + " " + surname;
    int length = fulllength.Length;
    int sqrlength = length * length;
     return sqrlength;
  }*/
  }


