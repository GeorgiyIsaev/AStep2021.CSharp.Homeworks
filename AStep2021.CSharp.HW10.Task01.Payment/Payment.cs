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
        static bool ifFormaterSerialize => false;

        public int countPaymentForDay; //оплата за день;
        public int countDay; //количество дней;
        public int fineForDay; //штраф за один день задержки оплаты;
        public int countDayNotPayment; // количество дней задержи оплаты;

        public int SumPaymentNotFine => countPaymentForDay * countDay; // сумма к оплате без штрафа (вычисляемое поле);
        public int SumFine => fineForDay * countDayNotPayment; // штраф (вычисляемое поле);
        public int SumPayment => SumFine + SumPaymentNotFine; // общая сумма к оплате (вычисляемое поле) 

        public void Serialize(BinaryWriter stram)
        {      
            stram.Write(countPaymentForDay);
            stram.Write(countDay);
            stram.Write(fineForDay);
            stram.Write(countDayNotPayment);

            
            if (ifFormaterSerialize)
            {
                stram.Write(SumPaymentNotFine);
                stram.Write(SumFine);
                stram.Write(SumPayment);
            }
        }
        public override string ToString()
        {
            return "Дней: " + countDay + "Оплата за день: " + countPaymentForDay +
                "Штраф " + fineForDay + "Дней задержки: "+ countDayNotPayment;
        }


    }
}

