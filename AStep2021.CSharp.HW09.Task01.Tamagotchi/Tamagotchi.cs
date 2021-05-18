﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStep2021.CSharp.HW09.Task01.Tamagotchi
{
    enum Request
    {
        Wiat, Sleep, Feed, Walk, Play, Treat
    }



    class Tamagotchi
    {
        private System.Timers.Timer aTimer;
        DateTime dateTime; 
        Request request = 0; 

        string name;
        int health = 1000;
        int satiety = 1000;
        int joy = 1000;
        int energy = 1000;




        public Tamagotchi(string name)
        {
            this.name = name;
            dateTime = DateTime.Now;
            request = Request.Wiat;

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
        }

        private void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            Console.Clear();
            Console.WriteLine($"Тамагочи {name} прожил {(e.SignalTime - dateTime).ToString("ss")} секунд");
            Console.WriteLine($"Статы: ХП={health/10} Голод={satiety / 10} Счастье={joy / 10} Энергия={energy / 10}");   
            
            RequestNow();   
            
            if (ifDead)
                Dead();           
        }

        private void RequestNow()
        {
            if (request == Request.Wiat)
            {               
                satiety--;
                joy--;
                energy -= 5;

                if (energy < 2)
                {
                    Console.WriteLine($"Тамагочи {name} очень устал и идет спать.\n Он растроен, что его не уложили спать вовремя");
                    joy -= 35;                                   
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
                Menu();
            }
            else if (request == Request.Sleep)
            {               
                energy += 10;
                Console.WriteLine($"Тамагочи {name} спит, не мешайте ему!");

                if ((health < 10) || energy > 99)
                {
                    request = Request.Wiat;
                }
            }
            else if (request == Request.Feed)
            {            
                Console.WriteLine($"Тамагочи {name} ест печенье!");
                for (int i = 4; i > 0; i--)
                {
                    if (health < 10 || satiety > 99) request = Request.Wiat;
                    else satiety++;
                }
            }
            else if (request == Request.Walk)
            {            
                Console.WriteLine($"Тамагочи {name} радостно гуляет вместе с Вами!");
                if (health < 10 || joy > 99) request = Request.Wiat;
                else joy+=4;
                
            }
            else if (request == Request.Play)
            {             
                Console.WriteLine($"Тамагочи {name} счастлив играть с Вами!");
                if (health < 10 || joy>99) request = Request.Wiat;
                else joy+=10;
                
            }
            else if (request == Request.Treat)
            {
                health += 10;
                Console.WriteLine($"Вы лечите тамагочи {name}!");
                
                    if (health > 99) request = Request.Wiat;                    
                    else health+=10;                    
                
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
            if (request != Request.Wiat) return;
            switch (val)
            {
                case 1:
                    Console.WriteLine("1 - Поиграть");
                    request = Request.Play;
                    break;
                case 2:
                    Console.WriteLine("2 - Погульять");
                    request = Request.Walk;
                    break;
                case 3:
                    Console.WriteLine("3 - Покормить");
                    request = Request.Feed;
                    break;
                case 4:
                    Console.WriteLine("4 - Отправить спать");
                    request = Request.Sleep;
                    break;
                case 5:
                    Console.WriteLine("5 - Лечить");
                    request = Request.Treat;
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
