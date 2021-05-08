using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStep2021.CSharp.HW03.ClassAndStruct
{


    class Program
    {
        static void Main(string[] args)
        {
            //Task08();
            Task10();
        }

        static void Task08()
        {
            Student student = new Student("Исаев", "Георгий", "Юрьевич");
            student.SetAge(29);
            student.SetGroup("124_3");
            student.Print();

            Random rand = new Random();
            for (int i = 0; i < 3; i++)
            {
                int tempCountRatting = rand.Next(2, 15);           
                for (int j = 0; j < tempCountRatting; j++)
                {
                    //int rattingIt = rand.Next(4, 5);
                    student.SettRating(i, rand.Next(4, 6));
                }
            }
            student.PrintRating();
        }

        static void Task10()
        {
            int[] Cyties = new int[]
            {
                England.London.Population,
                Russia.Moscow.Population,
                China.Beijing.Population
            };


            if(Russia.Moscow.Population > England.London.Population)
            {
                Console.WriteLine("Население г." + Russia.Moscow.name + " больше населния г." + England.London.name );
            }
            else
            {
                Console.WriteLine("Население г." + Russia.Moscow.name + " меньше населния г." + England.London.name);
            }

            if (Russia.Moscow.Population > China.Beijing.Population)
            {
                Console.WriteLine("Население г." + Russia.Moscow.name + " больше населния г." + China.Beijing.name);
            }
            else
            {
                Console.WriteLine("Население г." + Russia.Moscow.name + " меньше населния г." + China.Beijing.name);
            }


            Console.ReadKey();
        }

    }
}
