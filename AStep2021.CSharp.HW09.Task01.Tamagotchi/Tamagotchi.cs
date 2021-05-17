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

        string name;
        Request request = 0;     
        public Tamagotchi(string name)
        {
            this.name = name;

            aTimer = new System.Timers.Timer(2000);
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }
        public void Stop()
        {
            aTimer.Stop();
        }
        public void Dispose()
        {
            aTimer.Dispose();
        }

        private void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
             Console.Clear();
            Console.WriteLine("The Elapsed event was raised at {0:HH:mm:ss}",
                              e.SignalTime);
           
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
