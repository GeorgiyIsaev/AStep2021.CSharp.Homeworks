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
                 countPaymentForDay =1,
                 countDay =1,
                 fineForDay =100,
                 countDayNotPayment=0
            };
            Console.WriteLine(payment);
            SaveXmlSerializer("test.txt", payment);
            ReadXmlSerializer("test.txt");

        }
        private static void SaveXmlSerializer(string namefile, Payment payment)
        {
            payment = new Payment();

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
