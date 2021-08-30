using System;
namespace ConsoleApp
{
  class Converter
    {
      private double usd;
      private  double euro;
      private  double rub;
     public Converter(double usd ,double euro,double rub)
     {
       this.usd=usd*11.33;
       this.euro=euro*0.15;
       this.rub=rub*13.33;
     }
     public double SomoniToCurrency(string currency,double s)
     {
        switch(currency)
        {
          case "usd":return s/11.33;
         case "euro": return s/13.33;  
          case "rub": return s/0.15; 
        }
        return 0;
     }
        public double CurrencyToSomoni(string currency,double s)
     {
        switch(currency)
        {
          case "usd":return s*11.33;
         case "euro": return s*13.33;  
          case "rub": return s*0.15; 
        }
        return 0;
     }
    }
    class Employee
    {
   private string name;
   private  string surname;
   private string level;
    int salary;
     public Employee(string name,string surname,string level)
     {
         this.name=name;
         this.surname=surname;
         this.level=level;
     }
     public void Salary()
     {
       switch(level)
       {
       case "junior": salary=2000;break;
       case "middle": salary=4000;break;
       case "senior": salary=7000; break;
       default:
       { Console.WriteLine("неправильный введение"); 
       return ;
       }
       }
       Console.WriteLine($"{surname} {name}:, Разработчик C#:, Зарплата {level} разработчик: {salary} сомони ");      
     }
     public void Tax()
     {
       Console.WriteLine($"Налоговый сбор: {salary*14/100}");
     }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Дз2
            Converter con= new Converter(12,23,45);
           Console.WriteLine("На каком валюте вы хотите конвертировать(usd,euro,rub) и сколько");
           string s=Console.ReadLine();
           double r=double.Parse(Console.ReadLine());
           Console.WriteLine($"Результат вашего конвертация из сомони в {s}: {Math.Round(con.SomoniToCurrency(s,r),4)}" );
           Console.WriteLine($"Обратный конвертация на каком валюте(usd,euro,rub) и сколько");
           s=Console.ReadLine();
           r=double.Parse(Console.ReadLine());
           Console.WriteLine($"Результат конвертация из {s} в сомони: {Math.Round(con.CurrencyToSomoni(s,r),4)}\n");
            //Дз3
            Employee empl=new Employee("Shavqat","Kavrakov","junior");
            empl.Salary();
            empl.Tax();
        } 
    }
    
}
