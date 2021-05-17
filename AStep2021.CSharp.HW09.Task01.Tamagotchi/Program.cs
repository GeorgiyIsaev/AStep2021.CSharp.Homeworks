using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStep2021.CSharp.HW09.Task01.Tamagotchi
{
    
    
    
    class Program
    {
        static void Main(string[] args)
        {
                      
            Tamagotchi tamagotchi = new Tamagotchi("Покемон");
            
            while (!tamagotchi.ifDead)
            {
                tamagotchi.Аctivities(IntKey());              
            }     
      
        }
         static int IntKey()
         {
            int val = 0;
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                int res;           
                if(Int32.TryParse(key.KeyChar.ToString(), out res))
                {
                   if(res>0 && res <6)
                    val = res;
                    break;
                }
            }
            return val;
         }
    }

  
}
