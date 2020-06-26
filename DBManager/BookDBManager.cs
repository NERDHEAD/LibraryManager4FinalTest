using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 도서판매관리_1512035_류주성.DBManager
{
    //preparedStatement ??? 쓸것
    class BookDBManager
    {
        private readonly String BOOK_TABLE_PATH = "D:\\College_Homework\\C#\\homework_final\\도서판매관리_1512035_류주성\\DBManager\\BookDB.accdb";
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

    }
}
