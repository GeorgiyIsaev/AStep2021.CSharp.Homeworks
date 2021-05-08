using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStep2021.CSharp.HW03.ClassAndStruct
{
    
    
    
    public struct Article
    {
        public int idCod;
        public string name;
        public int price;
        public ArticleType articleType;
    }
    public struct Client
    {
        public string FIO;
        public string address;
        public string telefon;
        public int countOrder;
        public int fullOrderPrice;
        public ClientType clientType;
    }
    public struct RequestItem
    {
        public string name;
        public int count;
    }
    public struct Request
    {
        public int idCod;
        public Client client;
        public string data;
        public List<Article> articles;
        public PayType payType;

        public int fulPrice
        {
            get
            {
                int fullPriceit = 0;
                foreach(Article article in articles)
                {
                    fullPriceit += article.price;
                }
                return fullPriceit;
            }
        }
    }

    public enum ArticleType
    {
        low,
        medium,
        premium
    }
    public enum ClientType
    {
        common,
        vip
    }
    public enum PayType
    {
        cash, 
        card, 
        check
    }


    class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
}
