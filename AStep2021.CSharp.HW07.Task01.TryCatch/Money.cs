using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStep2021.CSharp.HW07.Task01.TryCatch
{
    class Money
    {       
        int rub = 0;
        int kop = 0;
        public int GetRub => rub;
        public int GetKop => kop;

        private void reset()
        {
            while (kop > 99)
            {
                rub++;
                kop -= 100;
            }
            while (kop < 0)
            {
                rub--;
                kop += 100;
            }
            if (rub < 0) throw new BankruptException();
        }

        public void add(int rub, int kop = 0)
        {
            this.rub += rub;
            this.kop += kop;
            reset();
        }
        public override string ToString()
        {
            string val = rub.ToString() + "руб. ";
            if (kop != 0) val += kop.ToString() + "коп. ";
            return val;
        }

        /*Операции*/
        public static Money operator -(Money a, Money b)
        {
            Money money = new Money();
            money.rub = a.rub - b.rub;
            money.kop = a.kop - b.kop;
            money.reset();
            return money;

        }
        public static Money operator +(Money a, Money b)
        {
            Money money = new Money();
            money.rub = a.rub + b.rub;
            money.kop = a.kop + b.kop;
            money.reset();
            return money;

        }
        public static Money operator /(Money a, int b)
        {
            Money money = new Money();

            money.rub = a.rub / b;
            int ostatok = ((a.rub*100) / b) %100;
            money.kop = a.kop / b;
            money.kop += ostatok;          
            money.reset();
            return money;
        }
        public static Money operator *(Money a, int b)
        {
            Money money = new Money();

            money.rub = a.rub * b;         
            money.kop = a.kop * b;       
            money.reset();
            return money;
        }

        public static Money operator ++(Money money)
        {
            money.kop++;
            money.reset();
            return money;
        }
        public static Money operator --(Money money)
        {
            money.kop--;
            money.reset();
            return money;
        }


        /*Сравнения*/
        public static bool operator ==(Money a, Money b)
        {         
            
            return ((a.rub == b.kop) && (b.rub == a.kop));
        }
        public static bool operator !=(Money a, Money b)
        {
            return !(a == b);
        }
        public static bool operator >(Money a, Money b)
        {
            return ((a.rub > b.kop) && (b.rub > a.kop));
        }
        public static bool operator <(Money a, Money b)
        {
            return !(a > b);
        }
        public static bool operator <=(Money a, Money b)
        {
            return ((a.rub <= b.kop) && (b.rub <= a.kop));
        }
        public static bool operator >=(Money a, Money b)
        {
            return !(a <= b);
        }
    }
}
