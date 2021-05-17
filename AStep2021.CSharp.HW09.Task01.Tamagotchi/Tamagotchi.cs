using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStep2021.CSharp.HW09.Task01.Tamagotchi
{
    enum Request
    {
        Feed, Walk, Sleep, Treat, Play
    }



    class Tamagotchi
    {
        private System.Timers.Timer aTimer;
        DateTime dateTime; 
        Request request = 0; 

        string name;
        int health = 100;
        int satiety = 100;
        int joy = 100;




        public Tamagotchi(string name)
        {
            this.name = name;


            dateTime = DateTime.Now;
            aTimer = new System.Timers.Timer(1000);
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }
        public void Stop()
        {
            aTimer.Stop();
        }
        public void Start()
        {
            aTimer.Start();
            //aTimer.
        }

        private void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            Console.Clear();
            Console.WriteLine($"Тамагочи {name} прожил {(e.SignalTime - dateTime).ToString("ss")} секунд");
            Console.WriteLine($"Статы: ХП={health} Голод={satiety} Счастье={joy}");
            satiety--;
            Random rnd = new Random();
            joy -= rnd.Next(1, 5);
            Menu();
            RequestNow();
            
            if (ifDead)
                Dead();
           
        }

        private void RequestNow()
        {
            if (health < 50)
            {
                Console.WriteLine($"Выличите {name}!");
            }
            if (satiety < 50)
            {
                Console.WriteLine($"{name} голоден!");
            }
            if (joy < 50)
            {
                Console.WriteLine($"Поиграйте с {name}!");
            }
            if (joy < 20)
            {
                health -= 25;
                joy += 30;
            }
            if (satiety < 20)
            {
                health -= 25;
                satiety += 30;
            }
        }

        private void Dead()
        {           
            aTimer.Stop();
            aTimer.Dispose();
            Console.Clear();
            Console.WriteLine($"Тамагочи {name} умер");
        }


        public string  DialogStr()
        {
            string dialog;
            dialog = "Тамагочи \"" + "\" хочет ";
            RandomRequest();
            dialog += request.ToString();
            return dialog;
        }
        private void RandomRequest()
        {      
            Random rnd = new Random();
            Request requestIT = (Request)rnd.Next(0, 5);
            if (requestIT == request)
                RandomRequest();
            request = requestIT;          
        }

        public void Menu()
        {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1 - Поиграть");
            Console.WriteLine("2 - Погульять");
            Console.WriteLine("3 - Покормить");
            Console.WriteLine("4 - Отправить спать");
            Console.WriteLine("5 - Лечить");         
        }
        public void Аctivities(int val)
        {
            switch (val)
            {
                case 1:
                    Console.WriteLine("1 - Поиграть");
                    break;
                case 2:
                    Console.WriteLine("2 - Погульять");
                    break;
                case 3:
                    Console.WriteLine("3 - Покормить");
                    break;
                case 4:
                    Console.WriteLine("4 - Отправить спать");
                    break;
                case 5:
                    Console.WriteLine("5 - Лечить");
                    break;
            };           

        }
        public bool ifDead
        {
            get
            {
               if(health <=0)
                  return true;
               return false;
            }
        }



        private void Feed()
        {

        }
        private void Walk()
        {

        }
        private void Sleep()
        {

        }
        private void Treat()
        {

        }
        private void Play()
        {

        }
    }
}
