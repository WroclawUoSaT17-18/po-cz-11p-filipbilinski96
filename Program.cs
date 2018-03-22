using System;

namespace ConsoleApp1
{
    public class Program
    {
        class Student
        {
            double o_mechanika = 0;
            double o_programowanie = 0;
            double o_wuef = 0;
            double o_ptm = 0;

            public Student(double o1, double o2, double o3, double o4)
            {
                o_mechanika = o1;
                o_programowanie = o2;
                o_wuef = o3;
                o_ptm = o4;
            }

            public double srednia()
            {
                return (o_mechanika + o_programowanie + o_wuef + o_ptm) / 4;
            }

        }

        public static void Main()
        {
            Console.WriteLine("Dziennik Ocen");
            Student Filip = new Student(5.0, 3.5, 5.0, 5.0);
            Student Mikolaj = new Student(2.0, 3.5, 5.0, 2.0);
            Console.WriteLine("Srednia Filipa: {0}", Filip.srednia());
            Console.WriteLine("Srednia Mikolaja: {0}", Mikolaj.srednia());
            Console.ReadKey();
        }
    }
}
