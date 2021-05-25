using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AStep2021.CSharp.HW10.Task01.Payment
{
    class Program
    {
        static void Main(string[] args)
        {
            Payment payment = new Payment 
            {
                 countPaymentForDay =25,
                 countDay =25,
                 fineForDay =30,
                 countDayNotPayment=4
            };

            Console.WriteLine(payment);
            SaveXmlSerializer("test1.xml", payment);
            ReadXmlSerializer("test1.xml");

            Payment.AlterIfFormaterSerialize();
            SaveXmlSerializer("test2.xml", payment);
            ReadXmlSerializer("test2.xml");

            SaveUserXmlSerializer("usertest1.xml", payment);
            ReadXmlSerializer("usertest1.xml");

            Payment.AlterIfFormaterSerialize();
            SaveUserXmlSerializer("usertest2.xml", payment);
            ReadXmlSerializer("usertest2.xml");
            Console.ReadKey();
        }
        private static void SaveUserXmlSerializer(string namefile, Payment payment)
        {
            using (FileStream fs = new FileStream(namefile, FileMode.Create))
            {
                using (StreamWriter sw = new StreamWriter(fs, Encoding.Unicode))
                {
                    payment.Serialize(sw);
                }
            }     
        }

        private static void SaveXmlSerializer(string namefile, Payment payment)
        {          
            XmlSerializer xmlFormat = new XmlSerializer(typeof(Payment));
            using (Stream fStream = File.Open(namefile, FileMode.OpenOrCreate))
            {
                xmlFormat.Serialize(fStream, payment);
            }
        }
        private static void ReadXmlSerializer(string namefile)
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(Payment));
            var temp = new Payment();
            using (Stream fStream = File.Open(namefile, FileMode.Open))
            {
                temp = (Payment)xmlFormat.Deserialize(fStream);
            }
            Console.WriteLine(temp);
        }

    }
}
