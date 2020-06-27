using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace 도서판매관리_1512035_류주성.DBManager
{
    //preparedStatement ??? 쓸것
    public class BookDBManager
    {
        private readonly String BOOK_TABLE_PATH = "D:\\College_Homework\\C#\\homework_final\\도서판매관리_1512035_류주성\\DBManager\\BookDB.accdb";
        private string[] filter = new BookDTO().Filter;
        private DBConn conn;


        //DAO DTO 구조로 할까
        //DTO를
        //id를 기준으로 sql문에서 update, delete 할것
        //처음에 테이블을 가져올때 dto에 저장.
        //수정, 삭제할때도 dto 기준으로 sql문을 돌리고-


        //0. DTO는 다음과 같은 형식 : SETTER/GETTER 및 listview에 바로 출력 가능하게 이루어 질 것. (매출이던 조회던 같은 함수)
        //1. 불러올때 쿼리문으로 전부 불러와서 ArrayList<BookDTO> bookList=new ArrayList<> 에 쌓기.
        //2. 매출은 종류별로 기준이 다름 -> 매출에서 수정이 이루어지진 않으므로 SalesListDTO(Stirng 조건)->(조건, 매출)로 정의 할것 *출력시 편할수있게






        //변경사항
        //ArrayList<BookDTO> BookListArray =new ArrayList<>(); -> DTO에는 책 하나의 정보를 담고, ArrayList가 책들의 DTO를 갖기 때문


        //booklist 가져오기( 바코드(id) 도서명 출판사 재고 단가 판매여부 )
        //public ArrayList<BookListDTO> getBookList() {}

        //booklist 추가하기 *입력받은 값을 BookListDTO
        //public Boolean insertBook(BookListDTO booklist){}

        //booklist 수정하기 *수정 후 자동으로 최신화 할 것
        //public Boolean updateBook(BookListDTO booklist){}

        //booklist 삭제하기
        //public Boolean deleteBook(BookListDTO booklist){}

        //saleslist 조회하기






        public Boolean insertBook(BookDTO book)
        {
            Boolean status = false;

            string sqlBook= "INSERT INTO [t도서목록]([도서명],[출판사])"+
                " VALUES(@bookname, @publisher);";
            string sqlStock= "INSERT INTO[t도서재고]([ID],[재고],[단가])" +
                " VALUES(@id ,@stock, @price);";

            
            conn = new DBConn(BOOK_TABLE_PATH);
            OleDbCommand cmd1 = new OleDbCommand(sqlBook, conn.GetConn());
            cmd1.Parameters.AddWithValue("@bookname", book.BookName);
            cmd1.Parameters.AddWithValue("@publisher", book.Publisher);

            OleDbCommand cmd2 = new OleDbCommand(sqlStock, conn.GetConn());
            cmd2.Parameters.AddWithValue("@id", book.Id);
            cmd2.Parameters.AddWithValue("@stock", book.Stock);
            cmd2.Parameters.AddWithValue("@price", book.Price);
            
            try
            {
                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                status = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.StackTrace);
            }






            conn.Close();
            return status;
        }
        public Boolean updateBook(BookDTO book)
        {
            Boolean status = false;

            string sqlBook = "UPDATE [t도서목록] set [도서명]=@bookname, [출판사]=@publisher"+
                " where [ID]=@id;";
            string sqlStock = "update [t도서재고] set [재고]=@stock, [단가]=@price" +
                " where [ID]=@id;";

            conn = new DBConn(BOOK_TABLE_PATH);
            OleDbCommand cmd1 = new OleDbCommand(sqlBook, conn.GetConn());
            cmd1.Parameters.AddWithValue("@bookname", book.BookName);
            cmd1.Parameters.AddWithValue("@publisher", book.Publisher);
            cmd1.Parameters.AddWithValue("@id", book.Id);

            OleDbCommand cmd2 = new OleDbCommand(sqlStock, conn.GetConn());
            cmd2.Parameters.AddWithValue("@stock", book.Stock);
            cmd2.Parameters.AddWithValue("@price", book.Price);
            cmd2.Parameters.AddWithValue("@id", book.Id);
            try
            {
                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                status = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.StackTrace);
                status = false;
            }

            

            


            conn.Close();
            return status;
        }


        public LinkedList<BookDTO> getBookList()
        {
            
            string sql = "select * from q도서조회";
            LinkedList<BookDTO> bookList = new LinkedList<BookDTO>();

            conn = new DBConn(BOOK_TABLE_PATH);
            OleDbDataReader reader = conn.ExecuteReader(sql);
            while (reader.Read())
            {
                BookDTO book = new BookDTO();
                book.Id=
                    Convert.ToInt32(reader[filter[0]]);
                book.BookName = 
                    Convert.ToString(reader[filter[1]]);
                book.Publisher = 
                    Convert.ToString(reader[filter[2]]);
                book.Stock = 
                    Convert.ToInt32(reader[filter[3]]);
                book.Price = 
                    Convert.ToInt32(reader[filter[4]]);

                bookList.AddLast(book);
            }

            reader.Close();
            conn.Close();

            return bookList;
        }
        public Dictionary<string, LinkedList<SalesDTO>> getSalesList()
        {
            Dictionary<string, string> sqlDic = new Dictionary<string, string>();
            Dictionary<string, LinkedList<SalesDTO>> salesGroup = new Dictionary<string, LinkedList<SalesDTO>>();
            


            sqlDic.Add("도서", "select * from [q도서매출(도서)]");
            sqlDic.Add("일", "select * from [q도서매출(일별)]");
            sqlDic.Add("월", "select * from [q도서매출(월별)]");
            sqlDic.Add("출판사", "select * from [q도서매출(출판사)]");

            String sql;
            foreach(string key in sqlDic.Keys)
            {
                sql = sqlDic[key];
                conn = new DBConn(BOOK_TABLE_PATH);
                OleDbDataReader reader = conn.ExecuteReader(sql);

                LinkedList<SalesDTO> salesList = new LinkedList<SalesDTO>(); ;
                while (reader.Read())
                {
                    SalesDTO sales = new SalesDTO();
                    
                    sales.Filter =
                        Convert.ToString(reader[0]);
                    sales.Sales =
                        Convert.ToString(reader[1]);

                    salesList.AddLast(sales);
                }
                reader.Close();
                conn.Close();
                salesGroup.Add(key, salesList);
            }
            return salesGroup;
        }




        public DataTable convert2DataTable(LinkedList<BookDTO> booklist)
        {

            DataTable table = new DataTable();
            table.Columns.Add(filter[0], typeof(int));
            table.Columns.Add(filter[1], typeof(string));
            table.Columns.Add(filter[2], typeof(string));
            table.Columns.Add(filter[3], typeof(int));
            table.Columns.Add(filter[4], typeof(int));

            foreach(BookDTO book in booklist)
            {
                table.Rows.Add(book.Id, book.BookName, book.Publisher, book.Stock, book.Price);
            }

            return table;
        }
        public DataTable convert2DataTable(String key, LinkedList<SalesDTO> salesList)
        {
            DataTable table = new DataTable();
            table.Columns.Add(key, typeof(string));
            table.Columns.Add("매출액", typeof(string));

            foreach (SalesDTO sales in salesList)
            {
                table.Rows.Add(sales.Filter, sales.Sales);
            }

            return table;
        }


    }
}
