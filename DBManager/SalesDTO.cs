using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 도서판매관리_1512035_류주성.DBManager
{
    public class SalesDTO
    {
        private String filter, sales;

        public string Filter { get => filter; set => filter = value; }
        public string Sales { get => sales; set => sales = value; }
    }
}
