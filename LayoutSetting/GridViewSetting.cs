using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 도서판매관리_1512035_류주성.LayoutSetting
{
    class GridViewSetting
    {
        public void setBookListLayout(DataGridView dataGridView)
        {
            //행단위로 선택
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //마지막 행 빈 Row 숨기기
            dataGridView.AllowUserToAddRows = false;
            //읽을수만 있게
            dataGridView.ReadOnly = true;
            //빈 공간 채우기
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //컬럼 크기 설정
            dataGridView.Columns[0].FillWeight = 30;
            dataGridView.Columns[1].FillWeight = 300;
            dataGridView.Columns[2].FillWeight = 80;
            dataGridView.Columns[3].FillWeight = 80;
            dataGridView.Columns[4].FillWeight = 100;
        }
        public void setSalesListLayout(DataGridView dataGridView)
        {
            //행단위로 선택
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //마지막 행 빈 Row 숨기기
            dataGridView.AllowUserToAddRows = false;
            //읽을수만 있게
            dataGridView.ReadOnly = true;
            //빈 공간 채우기
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //컬럼 크기 설정
            dataGridView.Columns[0].FillWeight = 3;
            dataGridView.Columns[1].FillWeight = 1;
        }
    }
}
