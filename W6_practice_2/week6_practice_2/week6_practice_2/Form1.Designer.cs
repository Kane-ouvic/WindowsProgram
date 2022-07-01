namespace week6_practice_2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pre_button = new System.Windows.Forms.Button();
            this.next_button = new System.Windows.Forms.Button();
            this.title_label = new System.Windows.Forms.Label();
            this.fontsize_label = new System.Windows.Forms.Label();
            this.category1 = new System.Windows.Forms.RadioButton();
            this.category2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.category3 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.down_right_radio = new System.Windows.Forms.RadioButton();
            this.down_center_radio = new System.Windows.Forms.RadioButton();
            this.down_left_radio = new System.Windows.Forms.RadioButton();
            this.up_right_radio = new System.Windows.Forms.RadioButton();
            this.up_center_radio = new System.Windows.Forms.RadioButton();
            this.up_left_radio = new System.Windows.Forms.RadioButton();
            this.fontsize_text = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bold_checkbox = new System.Windows.Forms.CheckBox();
            this.italic_checkbox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(25, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(455, 317);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pre_button
            // 
            this.pre_button.Location = new System.Drawing.Point(39, 469);
            this.pre_button.Name = "pre_button";
            this.pre_button.Size = new System.Drawing.Size(75, 23);
            this.pre_button.TabIndex = 1;
            this.pre_button.Text = "前一張";
            this.pre_button.UseVisualStyleBackColor = true;
            this.pre_button.Click += new System.EventHandler(this.pre_button_Click);
            // 
            // next_button
            // 
            this.next_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.next_button.Location = new System.Drawing.Point(384, 469);
            this.next_button.Name = "next_button";
            this.next_button.Size = new System.Drawing.Size(75, 23);
            this.next_button.TabIndex = 2;
            this.next_button.Text = "下一張";
            this.next_button.UseVisualStyleBackColor = true;
            this.next_button.Click += new System.EventHandler(this.next_button_Click);
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.title_label.Location = new System.Drawing.Point(22, 30);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(0, 16);
            this.title_label.TabIndex = 3;
            // 
            // fontsize_label
            // 
            this.fontsize_label.AutoSize = true;
            this.fontsize_label.Location = new System.Drawing.Point(506, 345);
            this.fontsize_label.Name = "fontsize_label";
            this.fontsize_label.Size = new System.Drawing.Size(56, 12);
            this.fontsize_label.TabIndex = 4;
            this.fontsize_label.Text = "字體大小:";
            // 
            // category1
            // 
            this.category1.AutoSize = true;
            this.category1.Checked = true;
            this.category1.Location = new System.Drawing.Point(6, 33);
            this.category1.Name = "category1";
            this.category1.Size = new System.Drawing.Size(59, 16);
            this.category1.TabIndex = 5;
            this.category1.TabStop = true;
            this.category1.Text = "標楷體";
            this.category1.UseVisualStyleBackColor = true;
            this.category1.CheckedChanged += new System.EventHandler(this.category1_CheckedChanged);
            // 
            // category2
            // 
            this.category2.AutoSize = true;
            this.category2.Location = new System.Drawing.Point(97, 33);
            this.category2.Name = "category2";
            this.category2.Size = new System.Drawing.Size(71, 16);
            this.category2.TabIndex = 6;
            this.category2.TabStop = true;
            this.category2.Text = "新明細體";
            this.category2.UseVisualStyleBackColor = true;
            this.category2.CheckedChanged += new System.EventHandler(this.category2_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.category3);
            this.groupBox1.Controls.Add(this.category1);
            this.groupBox1.Controls.Add(this.category2);
            this.groupBox1.Location = new System.Drawing.Point(501, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "字體";
            // 
            // category3
            // 
            this.category3.AutoSize = true;
            this.category3.Location = new System.Drawing.Point(6, 66);
            this.category3.Name = "category3";
            this.category3.Size = new System.Drawing.Size(83, 16);
            this.category3.TabIndex = 7;
            this.category3.TabStop = true;
            this.category3.Text = "微軟正黑體";
            this.category3.UseVisualStyleBackColor = true;
            this.category3.CheckedChanged += new System.EventHandler(this.category3_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.down_right_radio);
            this.groupBox2.Controls.Add(this.down_center_radio);
            this.groupBox2.Controls.Add(this.down_left_radio);
            this.groupBox2.Controls.Add(this.up_right_radio);
            this.groupBox2.Controls.Add(this.up_center_radio);
            this.groupBox2.Controls.Add(this.up_left_radio);
            this.groupBox2.Location = new System.Drawing.Point(501, 225);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 97);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "位置";
            // 
            // down_right_radio
            // 
            this.down_right_radio.AutoSize = true;
            this.down_right_radio.Location = new System.Drawing.Point(189, 66);
            this.down_right_radio.Name = "down_right_radio";
            this.down_right_radio.Size = new System.Drawing.Size(47, 16);
            this.down_right_radio.TabIndex = 5;
            this.down_right_radio.TabStop = true;
            this.down_right_radio.Text = "下右";
            this.down_right_radio.UseVisualStyleBackColor = true;
            this.down_right_radio.CheckedChanged += new System.EventHandler(this.down_right_radio_CheckedChanged);
            // 
            // down_center_radio
            // 
            this.down_center_radio.AutoSize = true;
            this.down_center_radio.Location = new System.Drawing.Point(97, 66);
            this.down_center_radio.Name = "down_center_radio";
            this.down_center_radio.Size = new System.Drawing.Size(47, 16);
            this.down_center_radio.TabIndex = 4;
            this.down_center_radio.TabStop = true;
            this.down_center_radio.Text = "下中";
            this.down_center_radio.UseVisualStyleBackColor = true;
            this.down_center_radio.CheckedChanged += new System.EventHandler(this.down_center_radio_CheckedChanged);
            // 
            // down_left_radio
            // 
            this.down_left_radio.AutoSize = true;
            this.down_left_radio.Location = new System.Drawing.Point(6, 66);
            this.down_left_radio.Name = "down_left_radio";
            this.down_left_radio.Size = new System.Drawing.Size(47, 16);
            this.down_left_radio.TabIndex = 3;
            this.down_left_radio.TabStop = true;
            this.down_left_radio.Text = "下左";
            this.down_left_radio.UseVisualStyleBackColor = true;
            this.down_left_radio.CheckedChanged += new System.EventHandler(this.down_left_radio_CheckedChanged);
            // 
            // up_right_radio
            // 
            this.up_right_radio.AutoSize = true;
            this.up_right_radio.Location = new System.Drawing.Point(189, 30);
            this.up_right_radio.Name = "up_right_radio";
            this.up_right_radio.Size = new System.Drawing.Size(47, 16);
            this.up_right_radio.TabIndex = 2;
            this.up_right_radio.TabStop = true;
            this.up_right_radio.Text = "上右";
            this.up_right_radio.UseVisualStyleBackColor = true;
            this.up_right_radio.CheckedChanged += new System.EventHandler(this.up_right_radio_CheckedChanged);
            // 
            // up_center_radio
            // 
            this.up_center_radio.AutoSize = true;
            this.up_center_radio.Location = new System.Drawing.Point(97, 30);
            this.up_center_radio.Name = "up_center_radio";
            this.up_center_radio.Size = new System.Drawing.Size(47, 16);
            this.up_center_radio.TabIndex = 1;
            this.up_center_radio.Text = "上中";
            this.up_center_radio.UseVisualStyleBackColor = true;
            this.up_center_radio.CheckedChanged += new System.EventHandler(this.up_center_radio_CheckedChanged);
            // 
            // up_left_radio
            // 
            this.up_left_radio.AutoSize = true;
            this.up_left_radio.Checked = true;
            this.up_left_radio.Location = new System.Drawing.Point(6, 30);
            this.up_left_radio.Name = "up_left_radio";
            this.up_left_radio.Size = new System.Drawing.Size(47, 16);
            this.up_left_radio.TabIndex = 0;
            this.up_left_radio.TabStop = true;
            this.up_left_radio.Text = "上左";
            this.up_left_radio.UseVisualStyleBackColor = true;
            this.up_left_radio.CheckedChanged += new System.EventHandler(this.up_left_radio_CheckedChanged);
            // 
            // fontsize_text
            // 
            this.fontsize_text.Location = new System.Drawing.Point(568, 342);
            this.fontsize_text.Name = "fontsize_text";
            this.fontsize_text.Size = new System.Drawing.Size(100, 22);
            this.fontsize_text.TabIndex = 9;
            this.fontsize_text.TextChanged += new System.EventHandler(this.fontsize_text_TextChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(531, 403);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(220, 69);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(618, 388);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "文字";
            // 
            // bold_checkbox
            // 
            this.bold_checkbox.AutoSize = true;
            this.bold_checkbox.Location = new System.Drawing.Point(501, 173);
            this.bold_checkbox.Name = "bold_checkbox";
            this.bold_checkbox.Size = new System.Drawing.Size(48, 16);
            this.bold_checkbox.TabIndex = 12;
            this.bold_checkbox.Text = "粗體";
            this.bold_checkbox.UseVisualStyleBackColor = true;
            this.bold_checkbox.CheckedChanged += new System.EventHandler(this.bold_checkbox_CheckedChanged);
            // 
            // italic_checkbox
            // 
            this.italic_checkbox.AutoSize = true;
            this.italic_checkbox.Location = new System.Drawing.Point(600, 173);
            this.italic_checkbox.Name = "italic_checkbox";
            this.italic_checkbox.Size = new System.Drawing.Size(48, 16);
            this.italic_checkbox.TabIndex = 13;
            this.italic_checkbox.Text = "斜體";
            this.italic_checkbox.UseVisualStyleBackColor = true;
            this.italic_checkbox.CheckedChanged += new System.EventHandler(this.italic_checkbox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 530);
            this.Controls.Add(this.italic_checkbox);
            this.Controls.Add(this.bold_checkbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.fontsize_text);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.fontsize_label);
            this.Controls.Add(this.title_label);
            this.Controls.Add(this.next_button);
            this.Controls.Add(this.pre_button);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button pre_button;
        private System.Windows.Forms.Button next_button;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Label fontsize_label;
        private System.Windows.Forms.RadioButton category1;
        private System.Windows.Forms.RadioButton category2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton category3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton down_right_radio;
        private System.Windows.Forms.RadioButton down_center_radio;
        private System.Windows.Forms.RadioButton down_left_radio;
        private System.Windows.Forms.RadioButton up_right_radio;
        private System.Windows.Forms.RadioButton up_center_radio;
        private System.Windows.Forms.RadioButton up_left_radio;
        private System.Windows.Forms.TextBox fontsize_text;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox bold_checkbox;
        private System.Windows.Forms.CheckBox italic_checkbox;
    }
}

