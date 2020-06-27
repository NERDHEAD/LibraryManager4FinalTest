using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 도서판매관리_1512035_류주성.DBManager
{
    public class BookDTO
    {
        string[] filter = { "ID", "도서명", "출판사", "재고", "단가" };

        private String bookName, publisher;
        private int id, stock, price;


        public string[] Filter { get => filter; }
        public string BookName { get => bookName; set => bookName = value; }
        public string Publisher { get => publisher; set => publisher = value; }
        public int Id { get => id; set => id = value; }
        public int Stock { get => stock; set => stock = value; }
        public int Price { get => price; set => price = value; }
    }
}
