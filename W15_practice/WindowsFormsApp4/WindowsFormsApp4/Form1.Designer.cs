﻿namespace WindowsFormsApp4
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.學號宿舍姓名學號系級BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.姓名學號系級姓名期中考成績BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.姓名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.期中考成績DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.學號宿舍BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new WindowsFormsApp4.Database1DataSet();
            this.姓名DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.學號DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.系級DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.學號_宿舍TableAdapter = new WindowsFormsApp4.Database1DataSetTableAdapters.學號_宿舍TableAdapter();
            this.姓名_學號_系級TableAdapter = new WindowsFormsApp4.Database1DataSetTableAdapters.姓名_學號_系級TableAdapter();
            this.姓名_期中考成績TableAdapter = new WindowsFormsApp4.Database1DataSetTableAdapters.姓名_期中考成績TableAdapter();
            this.學號宿舍BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.學號宿舍BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.姓名學號系級姓名期中考成績BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.學號宿舍姓名學號系級BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.學號宿舍BindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.學號宿舍姓名學號系級BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.學號DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.宿舍 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.學號宿舍姓名學號系級BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.姓名學號系級姓名期中考成績BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.學號宿舍BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.學號宿舍BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.學號宿舍BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.姓名學號系級姓名期中考成績BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.學號宿舍姓名學號系級BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.學號宿舍BindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.學號宿舍姓名學號系級BindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.學號DataGridViewTextBoxColumn,
            this.宿舍});
            this.dataGridView2.DataSource = this.學號宿舍BindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(335, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(289, 150);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.姓名DataGridViewTextBoxColumn1,
            this.學號DataGridViewTextBoxColumn1,
            this.系級DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.學號宿舍姓名學號系級BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(335, 200);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(353, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.姓名DataGridViewTextBoxColumn,
            this.期中考成績DataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.姓名學號系級姓名期中考成績BindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(335, 384);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(303, 150);
            this.dataGridView3.TabIndex = 3;
            // 
            // 學號宿舍姓名學號系級BindingSource
            // 
            this.學號宿舍姓名學號系級BindingSource.DataMember = "學號_宿舍_姓名_學號_系級";
            this.學號宿舍姓名學號系級BindingSource.DataSource = this.學號宿舍BindingSource;
            // 
            // 姓名學號系級姓名期中考成績BindingSource
            // 
            this.姓名學號系級姓名期中考成績BindingSource.DataMember = "姓名_學號_系級_姓名_期中考成績";
            this.姓名學號系級姓名期中考成績BindingSource.DataSource = this.學號宿舍姓名學號系級BindingSource;
            // 
            // 姓名DataGridViewTextBoxColumn
            // 
            this.姓名DataGridViewTextBoxColumn.DataPropertyName = "姓名";
            this.姓名DataGridViewTextBoxColumn.HeaderText = "姓名";
            this.姓名DataGridViewTextBoxColumn.Name = "姓名DataGridViewTextBoxColumn";
            // 
            // 期中考成績DataGridViewTextBoxColumn
            // 
            this.期中考成績DataGridViewTextBoxColumn.DataPropertyName = "期中考成績";
            this.期中考成績DataGridViewTextBoxColumn.HeaderText = "期中考成績";
            this.期中考成績DataGridViewTextBoxColumn.Name = "期中考成績DataGridViewTextBoxColumn";
            // 
            // 學號宿舍BindingSource
            // 
            this.學號宿舍BindingSource.DataMember = "學號_宿舍";
            this.學號宿舍BindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 姓名DataGridViewTextBoxColumn1
            // 
            this.姓名DataGridViewTextBoxColumn1.DataPropertyName = "姓名";
            this.姓名DataGridViewTextBoxColumn1.HeaderText = "姓名";
            this.姓名DataGridViewTextBoxColumn1.Name = "姓名DataGridViewTextBoxColumn1";
            // 
            // 學號DataGridViewTextBoxColumn1
            // 
            this.學號DataGridViewTextBoxColumn1.DataPropertyName = "學號";
            this.學號DataGridViewTextBoxColumn1.HeaderText = "學號";
            this.學號DataGridViewTextBoxColumn1.Name = "學號DataGridViewTextBoxColumn1";
            // 
            // 系級DataGridViewTextBoxColumn
            // 
            this.系級DataGridViewTextBoxColumn.DataPropertyName = "系級";
            this.系級DataGridViewTextBoxColumn.HeaderText = "系級";
            this.系級DataGridViewTextBoxColumn.Name = "系級DataGridViewTextBoxColumn";
            // 
            // 學號_宿舍TableAdapter
            // 
            this.學號_宿舍TableAdapter.ClearBeforeFill = true;
            // 
            // 姓名_學號_系級TableAdapter
            // 
            this.姓名_學號_系級TableAdapter.ClearBeforeFill = true;
            // 
            // 姓名_期中考成績TableAdapter
            // 
            this.姓名_期中考成績TableAdapter.ClearBeforeFill = true;
            // 
            // 學號宿舍BindingSource1
            // 
            this.學號宿舍BindingSource1.DataMember = "學號_宿舍";
            this.學號宿舍BindingSource1.DataSource = this.database1DataSet;
            // 
            // 學號宿舍BindingSource2
            // 
            this.學號宿舍BindingSource2.DataMember = "學號_宿舍";
            this.學號宿舍BindingSource2.DataSource = this.database1DataSet;
            // 
            // 姓名學號系級姓名期中考成績BindingSource1
            // 
            this.姓名學號系級姓名期中考成績BindingSource1.DataMember = "姓名_學號_系級_姓名_期中考成績";
            this.姓名學號系級姓名期中考成績BindingSource1.DataSource = this.學號宿舍姓名學號系級BindingSource;
            // 
            // 學號宿舍姓名學號系級BindingSource1
            // 
            this.學號宿舍姓名學號系級BindingSource1.DataMember = "學號_宿舍_姓名_學號_系級";
            this.學號宿舍姓名學號系級BindingSource1.DataSource = this.學號宿舍BindingSource;
            // 
            // 學號宿舍BindingSource3
            // 
            this.學號宿舍BindingSource3.DataMember = "學號_宿舍";
            this.學號宿舍BindingSource3.DataSource = this.database1DataSet;
            // 
            // 學號宿舍姓名學號系級BindingSource2
            // 
            this.學號宿舍姓名學號系級BindingSource2.DataMember = "學號_宿舍_姓名_學號_系級";
            this.學號宿舍姓名學號系級BindingSource2.DataSource = this.學號宿舍BindingSource3;
            // 
            // 學號DataGridViewTextBoxColumn
            // 
            this.學號DataGridViewTextBoxColumn.DataPropertyName = "學號";
            this.學號DataGridViewTextBoxColumn.HeaderText = "學號";
            this.學號DataGridViewTextBoxColumn.Name = "學號DataGridViewTextBoxColumn";
            // 
            // 宿舍
            // 
            this.宿舍.DataPropertyName = "宿舍";
            this.宿舍.HeaderText = "宿舍";
            this.宿舍.Name = "宿舍";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 654);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.學號宿舍姓名學號系級BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.姓名學號系級姓名期中考成績BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.學號宿舍BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.學號宿舍BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.學號宿舍BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.姓名學號系級姓名期中考成績BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.學號宿舍姓名學號系級BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.學號宿舍BindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.學號宿舍姓名學號系級BindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource 學號宿舍BindingSource;
        private Database1DataSetTableAdapters.學號_宿舍TableAdapter 學號_宿舍TableAdapter;
        private System.Windows.Forms.BindingSource 學號宿舍姓名學號系級BindingSource;
        private Database1DataSetTableAdapters.姓名_學號_系級TableAdapter 姓名_學號_系級TableAdapter;
        private System.Windows.Forms.BindingSource 姓名學號系級姓名期中考成績BindingSource;
        private Database1DataSetTableAdapters.姓名_期中考成績TableAdapter 姓名_期中考成績TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 姓名DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 學號DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 系級DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 姓名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 期中考成績DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource 學號宿舍BindingSource1;
        private System.Windows.Forms.BindingSource 學號宿舍BindingSource2;
        private System.Windows.Forms.BindingSource 學號宿舍姓名學號系級BindingSource1;
        private System.Windows.Forms.BindingSource 姓名學號系級姓名期中考成績BindingSource1;
        private System.Windows.Forms.BindingSource 學號宿舍BindingSource3;
        private System.Windows.Forms.DataGridViewTextBoxColumn 學號DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 宿舍;
        private System.Windows.Forms.BindingSource 學號宿舍姓名學號系級BindingSource2;
    }
}

