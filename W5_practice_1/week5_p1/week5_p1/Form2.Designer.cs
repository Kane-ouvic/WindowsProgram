namespace week5_p1
{
    partial class Form2
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
            this.title = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.input_label = new System.Windows.Forms.Label();
            this.output_label = new System.Windows.Forms.Label();
            this.input_text = new System.Windows.Forms.TextBox();
            this.output_text = new System.Windows.Forms.TextBox();
            this.history = new System.Windows.Forms.ListBox();
            this.button5 = new System.Windows.Forms.Button();
            this.code_text = new System.Windows.Forms.TextBox();
            this.alphabet = new System.Windows.Forms.Label();
            this.check = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("新細明體", 24F);
            this.title.Location = new System.Drawing.Point(22, 37);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(111, 32);
            this.title.TabIndex = 13;
            this.title.Text = "替換表";
            this.title.Click += new System.EventHandler(this.title_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(477, 354);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(89, 24);
            this.button6.TabIndex = 12;
            this.button6.Text = "確認";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(600, 257);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(132, 39);
            this.button4.TabIndex = 10;
            this.button4.Text = "歷史紀錄";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(600, 189);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 39);
            this.button3.TabIndex = 9;
            this.button3.Text = "解密";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(600, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 39);
            this.button2.TabIndex = 8;
            this.button2.Text = "加密";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(600, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 39);
            this.button1.TabIndex = 7;
            this.button1.Text = "替換表";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // input_label
            // 
            this.input_label.AutoSize = true;
            this.input_label.Font = new System.Drawing.Font("新細明體", 15F);
            this.input_label.Location = new System.Drawing.Point(12, 143);
            this.input_label.Name = "input_label";
            this.input_label.Size = new System.Drawing.Size(89, 20);
            this.input_label.TabIndex = 14;
            this.input_label.Text = "輸入字串";
            this.input_label.Visible = false;
            // 
            // output_label
            // 
            this.output_label.AutoSize = true;
            this.output_label.Font = new System.Drawing.Font("新細明體", 15F);
            this.output_label.Location = new System.Drawing.Point(12, 235);
            this.output_label.Name = "output_label";
            this.output_label.Size = new System.Drawing.Size(89, 20);
            this.output_label.TabIndex = 15;
            this.output_label.Text = "加密結果";
            this.output_label.Visible = false;
            // 
            // input_text
            // 
            this.input_text.Location = new System.Drawing.Point(107, 141);
            this.input_text.Name = "input_text";
            this.input_text.Size = new System.Drawing.Size(449, 22);
            this.input_text.TabIndex = 16;
            this.input_text.Visible = false;
            // 
            // output_text
            // 
            this.output_text.Location = new System.Drawing.Point(107, 235);
            this.output_text.Name = "output_text";
            this.output_text.Size = new System.Drawing.Size(449, 22);
            this.output_text.TabIndex = 17;
            this.output_text.Visible = false;
            // 
            // history
            // 
            this.history.FormattingEnabled = true;
            this.history.HorizontalScrollbar = true;
            this.history.ItemHeight = 12;
            this.history.Location = new System.Drawing.Point(50, 86);
            this.history.Name = "history";
            this.history.ScrollAlwaysVisible = true;
            this.history.Size = new System.Drawing.Size(506, 292);
            this.history.TabIndex = 29;
            this.history.Visible = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(477, 314);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(89, 24);
            this.button5.TabIndex = 30;
            this.button5.Text = "隨機生成";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // code_text
            // 
            this.code_text.Location = new System.Drawing.Point(46, 274);
            this.code_text.Name = "code_text";
            this.code_text.Size = new System.Drawing.Size(520, 22);
            this.code_text.TabIndex = 31;
            // 
            // alphabet
            // 
            this.alphabet.AutoSize = true;
            this.alphabet.Font = new System.Drawing.Font("新細明體", 15F);
            this.alphabet.Location = new System.Drawing.Point(24, 118);
            this.alphabet.Name = "alphabet";
            this.alphabet.Size = new System.Drawing.Size(555, 20);
            this.alphabet.TabIndex = 32;
            this.alphabet.Text = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            // 
            // check
            // 
            this.check.AutoSize = true;
            this.check.Font = new System.Drawing.Font("新細明體", 15F);
            this.check.Location = new System.Drawing.Point(24, 354);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(195, 20);
            this.check.TabIndex = 35;
            this.check.Text = "-------------------------------";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 432);
            this.Controls.Add(this.check);
            this.Controls.Add(this.alphabet);
            this.Controls.Add(this.code_text);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.history);
            this.Controls.Add(this.output_text);
            this.Controls.Add(this.input_text);
            this.Controls.Add(this.output_label);
            this.Controls.Add(this.input_label);
            this.Controls.Add(this.title);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("新細明體", 9F);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label input_label;
        private System.Windows.Forms.Label output_label;
        private System.Windows.Forms.TextBox input_text;
        private System.Windows.Forms.TextBox output_text;
        private System.Windows.Forms.ListBox history;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox code_text;
        private System.Windows.Forms.Label alphabet;
        private System.Windows.Forms.Label check;
    }
}