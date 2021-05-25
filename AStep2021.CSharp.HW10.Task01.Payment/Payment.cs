using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AStep2021.CSharp.HW10.Task01.Payment
{
    public class Payment
    {
        static bool IfFormaterSerialize { get; set; } = false;
        public static void AlterIfFormaterSerialize()
        {
            if (IfFormaterSerialize) IfFormaterSerialize = false;
            else IfFormaterSerialize = true;
        }

        public int countPaymentForDay; //оплата за день;
        public int countDay; //количество дней;
        public int fineForDay; //штраф за один день задержки оплаты;
        public int countDayNotPayment; // количество дней задержи оплаты;

        public int SumPaymentNotFine => countPaymentForDay * countDay; // сумма к оплате без штрафа (вычисляемое поле);
        public int SumFine => fineForDay * countDayNotPayment; // штраф (вычисляемое поле);
        public int SumPayment => SumFine + SumPaymentNotFine; // общая сумма к оплате (вычисляемое поле) 

       
         public void Serialize(TextWriter stram)
         {
            stram.WriteLine("<?xml version=\"1.0\"?>"); 
            stram.WriteLine("<Payment xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">");

            stram.WriteLine($"  <countPaymentForDay>{countPaymentForDay}</countPaymentForDay>");
            stram.WriteLine($"  <countDay>{countDay}</countDay>");
            stram.WriteLine($"  <fineForDay>{fineForDay}</fineForDay>");
            stram.WriteLine($"  <countDayNotPayment>{countDayNotPayment}</countDayNotPayment>");   
            if (IfFormaterSerialize)
            {
                stram.WriteLine($"  <SumPaymentNotFine>{SumPaymentNotFine}</SumPaymentNotFine>");
                stram.WriteLine($"  <SumFine>{SumFine}</SumFine>");
                stram.WriteLine($"  <SumPayment>{SumPayment}</SumPayment>");
            }
            stram.WriteLine("</Payment>");
        }
        public override string ToString()
        {
            return "Дней: " + countDay + "Оплата за день: " + countPaymentForDay +
                "Штраф " + fineForDay + "Дней задержки: "+ countDayNotPayment;
        }


    }
}

