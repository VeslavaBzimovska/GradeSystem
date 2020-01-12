using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfGrades = new List<int>();
            UserInput(listOfGrades);
            Console.WriteLine("");
            ShowGrades(listOfGrades);
            Console.ReadLine();
            decimal average = AverageGrade(listOfGrades);
            Console.WriteLine(average);
            Console.ReadLine();


        }
        private static void UserInput(List<int> listOfGrades)
        {
            Console.WriteLine("Please enter grades: ");
            int grade = 0;
            do
            {
                Console.WriteLine("Please enter next grade: ");
                grade = Convert.ToInt32(Console.ReadLine());
                if(grade != 0)
                {
                    listOfGrades.Add(grade);
                }
            }
            while (grade != 0);


        }
        private static void ShowGrades(List<int> listOfGrades)
        {
            for (int i = 0; i < listOfGrades.Count; i++)
            {
                if (i == listOfGrades.Count - 1)
                {
                    Console.Write(listOfGrades[i]);
                }
                else
                {
                    Console.Write(listOfGrades[i] + ", ");
                }
            }
        }
        private static decimal AverageGrade(List<int> listOfGrades)
        {
            decimal sum = 0;
            decimal average = 0;
            for (int i = 0; i < listOfGrades.Count; i++)
            {
                sum = sum + listOfGrades[i];
            }
            average = sum / Convert.ToDecimal(listOfGrades.Count);
            average = Math.Round(average, 2);
            return average;
        }
    }
}
