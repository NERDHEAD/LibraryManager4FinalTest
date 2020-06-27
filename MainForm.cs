using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 도서판매관리_1512035_류주성.DBManager;
using 도서판매관리_1512035_류주성.LayoutSetting;

namespace 도서판매관리_1512035_류주성
{
    public partial class MainForm : Form
    {
        //로그인에서 정보를 받음
        private readonly string mode="admin";


        private BookDBManager bookManager = new BookDBManager();
        private LinkedList<BookDTO> bookList = new LinkedList<BookDTO>();
        private Dictionary<string, LinkedList<SalesDTO>> salesList = new Dictionary<string, LinkedList<SalesDTO>>();


        public MainForm()
        {
            InitializeComponent();

            radioButton1.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            radioButton2.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            radioButton3.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            radioButton4.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            setMode(mode);

            
        }

        //user와 admin에 따라 기능을 제한함
        private void setMode(String mode)
        {
            cbSearchList.Items.Add("도서명");
            cbSearchList.Items.Add("출판사");
            cbSearchList.SelectedIndex=0;


            setBookData();
            

            if (mode.Equals("admin"))
            {
                this.Text += " - 관리자 모드";
                btnEditMode.Visible = true;
                btnSalesList.Visible = true;

                setSalesData();
            }
            else if (mode.Equals("user"))
            {
                this.Text += " - 사용자 모드";
            }
            else
            {
                //비정상적인 접근 경고창 팝업후 종료
            }
        }





        //도서 리스트 출력
        private void setBookData()
        {
            bookList = bookManager.getBookList();

            dataGridView.DataSource = bookManager.convert2DataTable(bookList);

            new GridViewSetting().setBookListLayout(dataGridView);
        }

        //매출 리스트 출력
        private void setSalesData()
        {
            salesList = bookManager.getSalesList();

            string key = getRadioButtonValue();
            dataGridView1.DataSource = bookManager.convert2DataTable(key, salesList[key]);

            new GridViewSetting().setSalesListLayout(dataGridView1);
        }

        private string getRadioButtonValue()
        {
            string value="";
            if (radioButton1.Checked) value = radioButton1.Text;
            else if (radioButton2.Checked) value = radioButton2.Text;
            else if (radioButton3.Checked) value = radioButton3.Text;
            else if (radioButton4.Checked) value = radioButton4.Text;

            return value;
        }






        private void btnBookList_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void btnSalesList_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }
        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {
            string key = getRadioButtonValue();
            dataGridView1.DataSource = bookManager.convert2DataTable(key, salesList[key]);

            new GridViewSetting().setSalesListLayout(dataGridView1);
        }

        private void btnEditMode_Click(object sender, EventArgs e)
        {
                
            string str=btnEditMode.Text;
            if (str.Equals("편집 모드"))
            {
                btnEditMode.Text = "편집 취소";

                btnInsert.Visible = true;
                btnUpdate.Visible = true;
                btnDelete.Visible = true;
            }
            else
            {
                btnEditMode.Text = "편집 모드";

                btnInsert.Visible = false;
                btnUpdate.Visible = false;
                btnDelete.Visible = false;
            }
        }




        //마우스를 드래그 해도 하나만 선택하게 설정함
        private void dataGridView_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataGridView.ClearSelection();
            dataGridView.Rows[e.RowIndex].Selected = true;
        }

        private void dataGridView_DoubleClick(object sender, EventArgs e)
        {
            openBookInfoForm("Info");
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            openBookInfoForm("Update");
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            openBookInfoForm("New");
        }


        //mode를 전달하면 bookInfoForm을 역할에 맞게 엶.
        private void openBookInfoForm(String mode)
        {
            BookDTO bookInfo = new BookDTO();
            switch (mode)
            {
                case "Info":
                    bookInfo.Id = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value.ToString());
                    bookInfo.BookName = Convert.ToString(dataGridView.CurrentRow.Cells[1].Value.ToString());
                    bookInfo.Publisher = Convert.ToString(dataGridView.CurrentRow.Cells[2].Value.ToString());
                    bookInfo.Stock = Convert.ToInt32(dataGridView.CurrentRow.Cells[3].Value.ToString());
                    bookInfo.Price = Convert.ToInt32(dataGridView.CurrentRow.Cells[4].Value.ToString());
                    break;
                case "New":
                    int rowIndex = dataGridView.Rows.Count - 1;
                    bookInfo.Id = Convert.ToInt32(dataGridView.Rows[rowIndex].Cells[0].Value.ToString())+1;
                    break;
                case "Update":
                    bookInfo.Id = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value.ToString());
                    bookInfo.BookName = Convert.ToString(dataGridView.CurrentRow.Cells[1].Value.ToString());
                    bookInfo.Publisher = Convert.ToString(dataGridView.CurrentRow.Cells[2].Value.ToString());
                    bookInfo.Stock = Convert.ToInt32(dataGridView.CurrentRow.Cells[3].Value.ToString());
                    bookInfo.Price = Convert.ToInt32(dataGridView.CurrentRow.Cells[4].Value.ToString());
                    break;
            }
            BookInfoForm bookInfoForm = new BookInfoForm(mode, bookInfo);
            bookInfoForm.Owner = this;
            bookInfoForm.ShowDialog();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            setBookData();
        }

        public void reloadBookList()
        {
            setBookData();
            setSalesData();
        }

        
    }
}
