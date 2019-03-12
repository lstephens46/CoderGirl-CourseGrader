using System;
using System.Collections.Generic;
using System.Linq;
namespace CourseGrader
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            int[] testScores = new int [] { 80, 50, 95, 75, 40 };
            Console.WriteLine(SumTestScores(testScores));
            Console.ReadLine();
        }


        public static double  SumTestScores(int [] testScores)
        {
            double sum = 0;
            foreach (int grade in testScores)
            {
               sum += grade;
            }
            double average = sum / testScores.Length;
            return average;
            
        }



       

    }

}
         
 
