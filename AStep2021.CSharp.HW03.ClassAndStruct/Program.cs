using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStep2021.CSharp.HW03.ClassAndStruct
{

    class Student
    {
        string surname;
        string name;
        string patronymic;
        string group;
        int age;
        public int[][] ratingMassive = new int[3][] { new int[0], new int[0], new int[0] };

        public Student(string surname, string name, string patronymic = "")
        {
            this.surname = surname;
            this.name = name;
            this.patronymic = patronymic;        
        }
        public void SetGroup(string val) => group = val;
        public void SetAge(int val) => age = val;
        public void Print()
        {
            Console.WriteLine("Студент ФИО: " + surname + " " + name + " "
                + patronymic + " Возраст: " + age + " Группа:" + group);
        }
        public void SettRating(int inedexTheme, int rating)
        {
            /*оценок по программированию,  -0
             * администрированию -1
             * и дизайну -2*/
            int[][] ratingTemp = new int[3][];
            for (int i = 0; i < 3; i++)
            {
                
                    if (i == inedexTheme) ratingTemp[inedexTheme] = new int[ratingMassive[inedexTheme].Length + 1];
                    else ratingTemp[i] = new int[ratingMassive[i].Length];
               
            }
            int a = ratingMassive.GetUpperBound(0);
            for (int i = 0; i < ratingMassive.GetUpperBound(0) + 1; i++)
            {
               int b = ratingMassive[i].Length;
                for (int j = 0; j < ratingMassive[i].Length; j++)
                {
                    ratingTemp[i][j] = ratingMassive[i][j];
                }
            }
            ratingTemp[inedexTheme][ratingMassive[inedexTheme].Length] = rating;

            ratingMassive = ratingTemp;
        }
        public void PrintRating()
        {
            string[] nameThema = { "Программированиe", "Администрирование", "Дизайн" };

            for (int i = 0; i < ratingMassive.GetUpperBound(0) + 1; i++)
            {
                Console.Write(nameThema[i] + ": ");
                for (int j = 0; j < ratingMassive[i].Length; j++)
                {
                    Console.Write(ratingMassive[i][j] + " ");
                }
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Исаев", "Георгий", "Юрьевич");
            student.SetAge(29);
            student.SetGroup("124_3");
            student.Print();

            Random rand = new Random();
            for (int i = 0; i < 3; i++)
            {
                int tempCountRatting = rand.Next(5, 10);
                int rattingIt = rand.Next(4, 5);
                for (int j = 0; j < tempCountRatting; j++)
                {
                    student.SettRating(i, rattingIt);
                }
            }
            student.PrintRating();

        }
    }
}
