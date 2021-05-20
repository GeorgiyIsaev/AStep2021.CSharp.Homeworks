using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStep2021.CSharp.HW10.Task01.Payment
{
    class Payment
    {
        int countPaymentForDay; //оплата за день;
        int countDay; //количество дней;
        int fineForDay; //штраф за один день задержки оплаты;
        int countDayNotPayment; // количество дней задержи оплаты;
       
        int SumPaymentNotFine; // сумма к оплате без штрафа (вычисляемое поле);
        int SumFine; // штраф (вычисляемое поле);
        int SumPayment; // общая сумма к оплате (вычисляемое поле).  


    }
}
