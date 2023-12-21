using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore_HHS
{
    public class Book   
    {
        private string _name;

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _number;

        public int number
        {
            get { return _number; }
            set { _number = value; }
        }

        private int _price;

        public int price
        {
            get { return _price; }
            set { _price = value; }
        }

        private int _type;

        public int type
        {
            get { return _type; }
            set { _type = value; }
        }


        public void BookInfo()
        {
            Console.WriteLine($"책명 : {name}");
            Console.WriteLine($"책번호 : {number}");
            Console.WriteLine($"책가격 : {price} 원");
            Console.WriteLine($"분류 : {(type == 1 ? "Comic" : "Novel" )}");
            Console.WriteLine();
        }
    }
}
