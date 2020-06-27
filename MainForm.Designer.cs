﻿namespace 도서판매관리_1512035_류주성
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pageBookList = new System.Windows.Forms.TabPage();
            this.btnBookApply = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEditMode = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cbSearchList = new System.Windows.Forms.ComboBox();
            this.pageSalesList = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBookList = new System.Windows.Forms.Button();
            this.btnApplyList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalesList = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.pageBookList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.pageSalesList.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.pageBookList);
            this.tabControl1.Controls.Add(this.pageSalesList);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tabControl1.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl1.Location = new System.Drawing.Point(94, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(833, 450);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // pageBookList
            // 
            this.pageBookList.Controls.Add(this.btnBookApply);
            this.pageBookList.Controls.Add(this.btnUpdate);
            this.pageBookList.Controls.Add(this.btnInsert);
            this.pageBookList.Controls.Add(this.btnDelete);
            this.pageBookList.Controls.Add(this.btnEditMode);
            this.pageBookList.Controls.Add(this.btnInfo);
            this.pageBookList.Controls.Add(this.btnReset);
            this.pageBookList.Controls.Add(this.btnSearch);
            this.pageBookList.Controls.Add(this.dataGridView);
            this.pageBookList.Controls.Add(this.txtSearch);
            this.pageBookList.Controls.Add(this.cbSearchList);
            this.pageBookList.Location = new System.Drawing.Point(4, 5);
            this.pageBookList.Name = "pageBookList";
            this.pageBookList.Padding = new System.Windows.Forms.Padding(3);
            this.pageBookList.Size = new System.Drawing.Size(825, 441);
            this.pageBookList.TabIndex = 0;
            this.pageBookList.UseVisualStyleBackColor = true;
            // 
            // btnBookApply
            // 
            this.btnBookApply.Enabled = false;
            this.btnBookApply.Location = new System.Drawing.Point(738, 11);
            this.btnBookApply.Name = "btnBookApply";
            this.btnBookApply.Size = new System.Drawing.Size(79, 31);
            this.btnBookApply.TabIndex = 10;
            this.btnBookApply.Text = "도서 신청";
            this.btnBookApply.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("굴림", 8F);
            this.btnUpdate.Location = new System.Drawing.Point(773, 299);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(44, 21);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "수정";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("굴림", 8F);
            this.btnInsert.Location = new System.Drawing.Point(773, 272);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(44, 21);
            this.btnInsert.TabIndex = 8;
            this.btnInsert.Text = "등록";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Visible = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("굴림", 8F);
            this.btnDelete.Location = new System.Drawing.Point(773, 326);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(44, 21);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            // 
            // btnEditMode
            // 
            this.btnEditMode.Location = new System.Drawing.Point(738, 353);
            this.btnEditMode.Name = "btnEditMode";
            this.btnEditMode.Size = new System.Drawing.Size(79, 31);
            this.btnEditMode.TabIndex = 6;
            this.btnEditMode.Text = "편집 모드";
            this.btnEditMode.UseVisualStyleBackColor = true;
            this.btnEditMode.Visible = false;
            this.btnEditMode.Click += new System.EventHandler(this.btnEditMode_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Font = new System.Drawing.Font("굴림", 9F);
            this.btnInfo.Location = new System.Drawing.Point(738, 390);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(79, 43);
            this.btnInfo.TabIndex = 5;
            this.btnInfo.Text = "정보 보기";
            this.btnInfo.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(657, 11);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 31);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "초기화";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(576, 11);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 31);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(16, 49);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(716, 384);
            this.dataGridView.TabIndex = 2;
            this.dataGridView.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseUp);
            this.dataGridView.DoubleClick += new System.EventHandler(this.dataGridView_DoubleClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("굴림", 15F);
            this.txtSearch.Location = new System.Drawing.Point(125, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(445, 30);
            this.txtSearch.TabIndex = 1;
            // 
            // cbSearchList
            // 
            this.cbSearchList.Font = new System.Drawing.Font("굴림", 15F);
            this.cbSearchList.FormattingEnabled = true;
            this.cbSearchList.Location = new System.Drawing.Point(16, 12);
            this.cbSearchList.Name = "cbSearchList";
            this.cbSearchList.Size = new System.Drawing.Size(103, 28);
            this.cbSearchList.TabIndex = 0;
            // 
            // pageSalesList
            // 
            this.pageSalesList.Controls.Add(this.groupBox1);
            this.pageSalesList.Controls.Add(this.dataGridView1);
            this.pageSalesList.Location = new System.Drawing.Point(4, 5);
            this.pageSalesList.Name = "pageSalesList";
            this.pageSalesList.Padding = new System.Windows.Forms.Padding(3);
            this.pageSalesList.Size = new System.Drawing.Size(825, 441);
            this.pageSalesList.TabIndex = 1;
            this.pageSalesList.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Location = new System.Drawing.Point(722, 347);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(97, 86);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "필터";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 16);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "도서";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(35, 16);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.Text = "일";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 64);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(59, 16);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.Text = "출판사";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(47, 42);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(35, 16);
            this.radioButton3.TabIndex = 1;
            this.radioButton3.Text = "월";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(713, 386);
            this.dataGridView1.TabIndex = 4;
            // 
            // btnBookList
            // 
            this.btnBookList.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnBookList.Location = new System.Drawing.Point(9, 54);
            this.btnBookList.Name = "btnBookList";
            this.btnBookList.Size = new System.Drawing.Size(79, 43);
            this.btnBookList.TabIndex = 0;
            this.btnBookList.Text = "도서 목록";
            this.btnBookList.UseVisualStyleBackColor = true;
            this.btnBookList.Click += new System.EventHandler(this.btnBookList_Click);
            // 
            // btnApplyList
            // 
            this.btnApplyList.Enabled = false;
            this.btnApplyList.Font = new System.Drawing.Font("굴림", 9F);
            this.btnApplyList.Location = new System.Drawing.Point(9, 104);
            this.btnApplyList.Name = "btnApplyList";
            this.btnApplyList.Size = new System.Drawing.Size(79, 43);
            this.btnApplyList.TabIndex = 1;
            this.btnApplyList.Text = "신청 목록";
            this.btnApplyList.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "메     뉴";
            // 
            // btnSalesList
            // 
            this.btnSalesList.Font = new System.Drawing.Font("굴림", 9F);
            this.btnSalesList.Location = new System.Drawing.Point(9, 395);
            this.btnSalesList.Name = "btnSalesList";
            this.btnSalesList.Size = new System.Drawing.Size(79, 43);
            this.btnSalesList.TabIndex = 3;
            this.btnSalesList.Text = "도서 매출";
            this.btnSalesList.UseVisualStyleBackColor = true;
            this.btnSalesList.Visible = false;
            this.btnSalesList.Click += new System.EventHandler(this.btnSalesList_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 450);
            this.Controls.Add(this.btnSalesList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnApplyList);
            this.Controls.Add(this.btnBookList);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "도서관리프로그램";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.pageBookList.ResumeLayout(false);
            this.pageBookList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.pageSalesList.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage pageBookList;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cbSearchList;
        private System.Windows.Forms.TabPage pageSalesList;
        private System.Windows.Forms.Button btnBookList;
        private System.Windows.Forms.Button btnApplyList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnBookApply;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEditMode;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnSalesList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}