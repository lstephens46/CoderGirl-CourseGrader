using System;
using System.Collections.Generic;
using System.Linq;
namespace CourseGrader
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            int[] testScores = new int [] {};
            Console.WriteLine(GradeTestScores(testScores));
            Console.ReadLine();
        }


        public static string  GradeTestScores(int [] testScores)
        {
            if (testScores.Length == 0)
            {
                return "fail";
            }
            double sum = 0;
            for (int i = 0; i < testScores.Length; i++)
            {
               sum += testScores[i];
            }
          
            double average = sum / testScores.Length;
            string passFail = "fail";
            for (int i = 0; i < testScores.Length; i++)
            {
                if (average >= 70 && testScores[i] <= 50)
                {
                    passFail = "pass";
                    continue;
                }
                else if (average >= 70 && testScores[i] >= 50)
                { 

                    passFail = "pass";
                    continue;
                }
                else if (average < 70 || testScores[i] < 50)
                {
                    passFail = "fail";
                    continue;
                }
                //else if(average >= 70 && testScores[i] <= 50)
                //{
                //    passFail = "fail";
                //}    
            }   


            return passFail;

            
            
        }



       

    }

}
         
 
