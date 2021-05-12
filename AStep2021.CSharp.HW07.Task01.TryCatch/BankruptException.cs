using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStep2021.CSharp.HW07.Task01.TryCatch
{
    public class BankruptException : Exception
    {       
        public override string Message
        {
            get
            {
                return "ERRPR: Вы банкрот!";
            }
        }

        //Стандартные конструкторы
        public BankruptException() : base() { }
        public BankruptException(string message) : base(message) { }
        public BankruptException(string message, Exception innerException) : base(message, innerException) { }        
    }    
}
