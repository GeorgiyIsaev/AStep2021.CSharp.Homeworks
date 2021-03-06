using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            Console.Clear();
            Console.WriteLine($"Тамагочи {name} прожил {(e.SignalTime - dateTime).ToString("ss")} секунд");
            Console.WriteLine($"Статы: ХП={health/10} Голод={satiety / 10} Счастье={joy / 10} Энергия={energy / 10}");   
            
            RequestNow();
            RandomRequest();

            if (ifDead)
                Dead();           
        }

        private void RequestNow()
        {
            satiety--;
            joy--;
            energy -= 5;

            switch (request)
            {
                case Request.Wiat:
                    if (energy < 2)
                    {
                        Console.WriteLine($"Тамагочи {name} очень устал и идет спать.\n Он растроен, что его не уложили спать вовремя");
                        request = Request.Sleep;
                        joy -= 350;
                    }
                    if (joy < 20 || satiety < 20)
                    {
                        health -= 25;
                        joy += 200;
                    }
                    Menu();
                    break;
                case Request.Sleep:
                    Console.WriteLine($"Тамагочи {name} спит, не мешайте ему!");
                    if (health < 10 || energy > 940) request = Request.Wiat;
                    else energy += 100;
                    break;
                case Request.Feed:
                    Console.WriteLine($"Тамагочи {name} ест печенье!");
                    if (health < 10 || satiety > 940) request = Request.Wiat;
                    else satiety += 70;
                    break;
                case Request.Walk:
                    Console.WriteLine($"Тамагочи {name} радостно гуляет вместе с Вами!");
                    if (health < 10 || joy > 981) request = Request.Wiat;
                    else joy += 25;
                    break;
                case Request.Play:
                    Console.WriteLine($"Тамагочи {name} счастлив играть с Вами!");
                    if (health < 10 || joy > 980) request = Request.Wiat;
                    else joy += 40;
                    break;
                case Request.Treat:
                    Console.WriteLine($"Вы лечите тамагочи {name}!");
                    if (health > 910) request = Request.Wiat;
                    else health += 150;
                    break;
            }
        }

        private void Dead()
        {           
            aTimer.Stop();
            aTimer.Dispose();
            Console.Clear();
            Console.WriteLine($"Тамагочи {name} умер");
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
                    request = Request.Play;
                    break;
                case 2:             
                    request = Request.Walk;
                    break;
                case 3:          
                    request = Request.Feed;
                    break;
                case 4:                   
                    request = Request.Sleep;
                    break;
                case 5:
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


        bool ifDialogNow = false;
        public void RandomRequest()
        {
            if (ifDialogNow || request != Request.Wiat) return;
            Random rnd = new Random();
            int randomVal = rnd.Next(0, 25);
            if (health < 250)
                DialogTamagochi($"Скорее вылечи меня!", Request.Treat);
            if (satiety < 150)
                DialogTamagochi($"Мне срочна нужна еда", Request.Treat);
            if (randomVal == 0 && joy < 760)
                DialogTamagochi($"{name} хочет погулять!", Request.Walk);
            else if (randomVal == 1 && joy<760)
              DialogTamagochi($"Эй, давай сыграем в игру!", Request.Play);
            else if (randomVal == 2 && energy < 300)
                DialogTamagochi($"Я хочу кушать!", Request.Feed);
            else if (randomVal == 3 && satiety < 300)
                DialogTamagochi($"Прочитай мне сказку на ночь! ", Request.Sleep);   
            else if (randomVal == 5 && joy < 300)
                DialogTamagochi($"Эй, эй я тоже хочу играть!", Request.Play);
        }

       [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
            static extern int MessageBoxTimeout(IntPtr hwnd, String text, String title,
                                     uint type, Int16 wLanguageId, Int32 milliseconds);         
        private void DialogTamagochi(string task, Request status)
        {
            ifDialogNow = true;
             var result = MessageBoxTimeout((System.IntPtr)0, task, "Тамагочи хочет внимания!", 1, 0, 5000);
            //32000 - нет нажатия //отмена 2  // да 1
            if (result == 1)
            {               
                request = status;
            }
            else
            {
                health -= 200;
                joy -= 200;
                Console.WriteLine($"{name} растроен из-за того что вы не смогли выполнить его просьбу ");
            }
            ifDialogNow = false;
        }
    }
}
