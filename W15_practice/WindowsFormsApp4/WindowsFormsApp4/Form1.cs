﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'database1DataSet.姓名_期中考成績' 資料表。您可以視需要進行移動或移除。
            this.姓名_期中考成績TableAdapter.Fill(this.database1DataSet.姓名_期中考成績);
            // TODO: 這行程式碼會將資料載入 'database1DataSet.姓名_學號_系級' 資料表。您可以視需要進行移動或移除。
            this.姓名_學號_系級TableAdapter.Fill(this.database1DataSet.姓名_學號_系級);
            // TODO: 這行程式碼會將資料載入 'database1DataSet.學號_宿舍' 資料表。您可以視需要進行移動或移除。
            this.學號_宿舍TableAdapter.Fill(this.database1DataSet.學號_宿舍);
            // TODO: 這行程式碼會將資料載入 'database1DataSet1.姓名_學號_系級' 資料表。您可以視需要進行移動或移除。
            // TODO: 這行程式碼會將資料載入 'database1DataSet1.學號_宿舍' 資料表。您可以視需要進行移動或移除。
            // TODO: 這行程式碼會將資料載入 'database1DataSet.姓名_期中考成績' 資料表。您可以視需要進行移動或移除。
            this.姓名_期中考成績TableAdapter.Fill(this.database1DataSet.姓名_期中考成績);
            // TODO: 這行程式碼會將資料載入 'database1DataSet.姓名_學號_系級' 資料表。您可以視需要進行移動或移除。
            this.姓名_學號_系級TableAdapter.Fill(this.database1DataSet.姓名_學號_系級);
            // TODO: 這行程式碼會將資料載入 'database1DataSet.學號_宿舍' 資料表。您可以視需要進行移動或移除。
            this.學號_宿舍TableAdapter.Fill(this.database1DataSet.學號_宿舍);

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
