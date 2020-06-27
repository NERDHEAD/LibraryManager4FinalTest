using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 도서판매관리_1512035_류주성.DBManager;

namespace 도서판매관리_1512035_류주성
{
    public partial class BookInfoForm : Form
    {
        

        public BookInfoForm(String mode, BookDTO book)
        {
            InitializeComponent();
            setMode(mode, book);
            
        }
        private void setMode(String mode, BookDTO book)
        {
            txtID.Enabled = false;
            switch (mode)
            {                 
                case "Info":                   
                    txtBookname.Enabled = false;
                    txtPublisher.Enabled = false;
                    txtStock.Enabled = false;
                    txtPrice.Enabled = false;

                    setTextBoxList(book);
                    btnOK.Text = "확인";
                    break;
                case "New":
                    txtBookname.Enabled = true;
                    txtPublisher.Enabled = true;
                    txtStock.Enabled = true;
                    txtPrice.Enabled = true;

                    txtBookname.ReadOnly = false;
                    txtPublisher.ReadOnly = false;
                    txtStock.ReadOnly = false;
                    txtPrice.ReadOnly = false;

                    txtID.Text = book.Id.ToString();

                    btnOK.Text = "저장";
                    break;
                case "Update":
                    txtBookname.Enabled = true;
                    txtPublisher.Enabled = true;
                    txtStock.Enabled = true;
                    txtPrice.Enabled = true;

                    txtBookname.ReadOnly = false;
                    txtPublisher.ReadOnly = false;
                    txtStock.ReadOnly = false;
                    txtPrice.ReadOnly = false;

                    setTextBoxList(book);
                    btnOK.Text = "적용";
                    break;

            }
        }

        //BookDTO에서 값을 전달 받음
        private void setTextBoxList(BookDTO book)
        {
            txtID.Text=book.Id.ToString();
            txtBookname.Text = book.BookName.ToString();
            txtPublisher.Text = book.Publisher.ToString();
            txtStock.Text = book.Stock.ToString();
            txtPrice.Text = book.Price.ToString();
        }

        //textBox내부의 값을 BookDTO에 담아 전달함
        private BookDTO getTextBoxList()
        {
            BookDTO book = new BookDTO();

            book.Id = Convert.ToInt32(txtID.Text);
            book.BookName = Convert.ToString(txtBookname.Text);
            book.Publisher = Convert.ToString(txtPublisher.Text);
            book.Stock = Convert.ToInt32(txtStock.Text);
            book.Price = Convert.ToInt32(txtPrice.Text);

            return book;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Boolean status = false;
            BookDBManager manager = new BookDBManager();
            BookDTO book = new BookDTO();
            switch (btnOK.Text)
            {
                case "확인":
                    MainForm form = (MainForm)this.Owner;
                    form.reloadBookList();
                    this.Close();
                    break;
                case "저장": 
                    book = getTextBoxList();

                    status=manager.insertBook(book);
                    btnOK.Text = "확인";
                    break;
                case "적용":                    
                    book = getTextBoxList();

                    status=manager.updateBook(book);
                    btnOK.Text = "확인";
                    break;
            }
        }
    }
}
