using System;
namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
          {
            //Дз2
            Console.WriteLine("Введите значение usd,uro,rub");
              Converter con=new Converter(double.Parse(Console.ReadLine()),double.Parse(Console.ReadLine()),double.Parse(Console.ReadLine()));
           Console.Write("Сколько сомони вы хотите конвертировать: ");
           double r=double.Parse(Console.ReadLine());
           Console.Write("Конвертации в usd или euro или rub: ");
           string s=Console.ReadLine();
           Console.WriteLine($"Результат конвертация из сомони в {s}: {Math.Round(con.SomoniToCurrency(s,r),4)}" );
           Console.WriteLine($"Обратный конвертация: из {s} в сомони ");
           Console.Write($"Сколько {s} вы хотите конвертировать: ");
           r=double.Parse(Console.ReadLine());
           Console.WriteLine($"Результат: {Math.Round(con.CurrencyToSomoni(s,r),4)}\n");
          }
          {
            //Дз3
            Console.WriteLine("Введите имя, фамилия и уровень разработчика(junior или middle или senior) ");
            Employee empl=new Employee(Console.ReadLine(),Console.ReadLine(),Console.ReadLine());
            empl.Salary();
            empl.Tax();
          }   
        } 
    }
    class Converter
    {
    double usd,euro,rub;
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
    string name,surname,level;
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
       Console.WriteLine($"{surname} {name}, Разработчик C++, Зарплата {level} разработчик: {salary} сомони ");      
     }
     public void Tax()
     {
       Console.WriteLine($"Налоговый сбор: {salary*14/100}");
     }
    }
}
