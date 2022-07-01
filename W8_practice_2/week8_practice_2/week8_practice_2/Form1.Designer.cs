namespace week8_practice_2
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
            this.Player2_label = new System.Windows.Forms.Label();
            this.Player1_label = new System.Windows.Forms.Label();
            this.P2_warrior = new System.Windows.Forms.Button();
            this.P2_witcher = new System.Windows.Forms.Button();
            this.P2_Archer = new System.Windows.Forms.Button();
            this.P1_warrior = new System.Windows.Forms.Button();
            this.P1_witcher = new System.Windows.Forms.Button();
            this.P1_Archer = new System.Windows.Forms.Button();
            this.start_btn = new System.Windows.Forms.Button();
            this.P2_chess_A = new System.Windows.Forms.Button();
            this.P2_chess_B = new System.Windows.Forms.Button();
            this.P2_chess_C = new System.Windows.Forms.Button();
            this.P2_chess_D = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.P1_chess_A = new System.Windows.Forms.Button();
            this.P1_chess_B = new System.Windows.Forms.Button();
            this.P1_chess_C = new System.Windows.Forms.Button();
            this.P1_chess_D = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Player2_label
            // 
            this.Player2_label.AutoSize = true;
            this.Player2_label.Font = new System.Drawing.Font("新細明體", 20F);
            this.Player2_label.Location = new System.Drawing.Point(23, 57);
            this.Player2_label.Name = "Player2_label";
            this.Player2_label.Size = new System.Drawing.Size(46, 27);
            this.Player2_label.TabIndex = 0;
            this.Player2_label.Text = "P2:";
            // 
            // Player1_label
            // 
            this.Player1_label.AutoSize = true;
            this.Player1_label.Font = new System.Drawing.Font("新細明體", 20F);
            this.Player1_label.Location = new System.Drawing.Point(602, 57);
            this.Player1_label.Name = "Player1_label";
            this.Player1_label.Size = new System.Drawing.Size(46, 27);
            this.Player1_label.TabIndex = 1;
            this.Player1_label.Text = "P1:";
            // 
            // P2_warrior
            // 
            this.P2_warrior.Font = new System.Drawing.Font("新細明體", 15F);
            this.P2_warrior.Location = new System.Drawing.Point(12, 121);
            this.P2_warrior.Name = "P2_warrior";
            this.P2_warrior.Size = new System.Drawing.Size(107, 42);
            this.P2_warrior.TabIndex = 2;
            this.P2_warrior.Text = "戰士";
            this.P2_warrior.UseVisualStyleBackColor = true;
            this.P2_warrior.Click += new System.EventHandler(this.P2_warrior_Click);
            // 
            // P2_witcher
            // 
            this.P2_witcher.Font = new System.Drawing.Font("新細明體", 15F);
            this.P2_witcher.Location = new System.Drawing.Point(12, 187);
            this.P2_witcher.Name = "P2_witcher";
            this.P2_witcher.Size = new System.Drawing.Size(107, 42);
            this.P2_witcher.TabIndex = 3;
            this.P2_witcher.Text = "法師";
            this.P2_witcher.UseVisualStyleBackColor = true;
            this.P2_witcher.Click += new System.EventHandler(this.P2_witcher_Click);
            // 
            // P2_Archer
            // 
            this.P2_Archer.Font = new System.Drawing.Font("新細明體", 15F);
            this.P2_Archer.Location = new System.Drawing.Point(12, 253);
            this.P2_Archer.Name = "P2_Archer";
            this.P2_Archer.Size = new System.Drawing.Size(107, 42);
            this.P2_Archer.TabIndex = 4;
            this.P2_Archer.Text = "弓箭手";
            this.P2_Archer.UseVisualStyleBackColor = true;
            this.P2_Archer.Click += new System.EventHandler(this.P2_Archer_Click);
            // 
            // P1_warrior
            // 
            this.P1_warrior.Font = new System.Drawing.Font("新細明體", 15F);
            this.P1_warrior.Location = new System.Drawing.Point(607, 121);
            this.P1_warrior.Name = "P1_warrior";
            this.P1_warrior.Size = new System.Drawing.Size(107, 42);
            this.P1_warrior.TabIndex = 5;
            this.P1_warrior.Text = "戰士";
            this.P1_warrior.UseVisualStyleBackColor = true;
            this.P1_warrior.Click += new System.EventHandler(this.P1_warrior_Click);
            // 
            // P1_witcher
            // 
            this.P1_witcher.Font = new System.Drawing.Font("新細明體", 15F);
            this.P1_witcher.Location = new System.Drawing.Point(607, 187);
            this.P1_witcher.Name = "P1_witcher";
            this.P1_witcher.Size = new System.Drawing.Size(107, 42);
            this.P1_witcher.TabIndex = 6;
            this.P1_witcher.Text = "法師";
            this.P1_witcher.UseVisualStyleBackColor = true;
            this.P1_witcher.Click += new System.EventHandler(this.P1_witcher_Click);
            // 
            // P1_Archer
            // 
            this.P1_Archer.Font = new System.Drawing.Font("新細明體", 15F);
            this.P1_Archer.Location = new System.Drawing.Point(607, 253);
            this.P1_Archer.Name = "P1_Archer";
            this.P1_Archer.Size = new System.Drawing.Size(107, 42);
            this.P1_Archer.TabIndex = 7;
            this.P1_Archer.Text = "弓箭手";
            this.P1_Archer.UseVisualStyleBackColor = true;
            this.P1_Archer.Click += new System.EventHandler(this.P1_Archer_Click);
            // 
            // start_btn
            // 
            this.start_btn.Font = new System.Drawing.Font("新細明體", 15F);
            this.start_btn.Location = new System.Drawing.Point(331, 466);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(107, 42);
            this.start_btn.TabIndex = 8;
            this.start_btn.Text = "開始遊戲";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // P2_chess_A
            // 
            this.P2_chess_A.Font = new System.Drawing.Font("新細明體", 15F);
            this.P2_chess_A.Location = new System.Drawing.Point(12, 100);
            this.P2_chess_A.Name = "P2_chess_A";
            this.P2_chess_A.Size = new System.Drawing.Size(146, 42);
            this.P2_chess_A.TabIndex = 9;
            this.P2_chess_A.Text = "普通棋子";
            this.P2_chess_A.UseVisualStyleBackColor = true;
            this.P2_chess_A.Visible = false;
            this.P2_chess_A.Click += new System.EventHandler(this.P2_chess_A_Click);
            // 
            // P2_chess_B
            // 
            this.P2_chess_B.Font = new System.Drawing.Font("新細明體", 15F);
            this.P2_chess_B.Location = new System.Drawing.Point(12, 169);
            this.P2_chess_B.Name = "P2_chess_B";
            this.P2_chess_B.Size = new System.Drawing.Size(146, 42);
            this.P2_chess_B.TabIndex = 10;
            this.P2_chess_B.Text = "橫向棋子";
            this.P2_chess_B.UseVisualStyleBackColor = true;
            this.P2_chess_B.Visible = false;
            this.P2_chess_B.Click += new System.EventHandler(this.P2_chess_B_Click);
            // 
            // P2_chess_C
            // 
            this.P2_chess_C.Font = new System.Drawing.Font("新細明體", 15F);
            this.P2_chess_C.Location = new System.Drawing.Point(12, 235);
            this.P2_chess_C.Name = "P2_chess_C";
            this.P2_chess_C.Size = new System.Drawing.Size(146, 42);
            this.P2_chess_C.TabIndex = 11;
            this.P2_chess_C.Text = "縱向棋子";
            this.P2_chess_C.UseVisualStyleBackColor = true;
            this.P2_chess_C.Visible = false;
            this.P2_chess_C.Click += new System.EventHandler(this.P2_chess_C_Click);
            // 
            // P2_chess_D
            // 
            this.P2_chess_D.Font = new System.Drawing.Font("新細明體", 15F);
            this.P2_chess_D.Location = new System.Drawing.Point(12, 301);
            this.P2_chess_D.Name = "P2_chess_D";
            this.P2_chess_D.Size = new System.Drawing.Size(146, 42);
            this.P2_chess_D.TabIndex = 12;
            this.P2_chess_D.Text = "覆蓋棋子";
            this.P2_chess_D.UseVisualStyleBackColor = true;
            this.P2_chess_D.Visible = false;
            this.P2_chess_D.Click += new System.EventHandler(this.P2_chess_D_Click);
            // 
            // P1_chess_A
            // 
            this.P1_chess_A.Font = new System.Drawing.Font("新細明體", 15F);
            this.P1_chess_A.Location = new System.Drawing.Point(598, 100);
            this.P1_chess_A.Name = "P1_chess_A";
            this.P1_chess_A.Size = new System.Drawing.Size(146, 42);
            this.P1_chess_A.TabIndex = 13;
            this.P1_chess_A.Text = "普通棋子";
            this.P1_chess_A.UseVisualStyleBackColor = true;
            this.P1_chess_A.Visible = false;
            this.P1_chess_A.Click += new System.EventHandler(this.P1_chess_A_Click);
            // 
            // P1_chess_B
            // 
            this.P1_chess_B.Font = new System.Drawing.Font("新細明體", 15F);
            this.P1_chess_B.Location = new System.Drawing.Point(598, 169);
            this.P1_chess_B.Name = "P1_chess_B";
            this.P1_chess_B.Size = new System.Drawing.Size(146, 42);
            this.P1_chess_B.TabIndex = 14;
            this.P1_chess_B.Text = "橫向棋子";
            this.P1_chess_B.UseVisualStyleBackColor = true;
            this.P1_chess_B.Visible = false;
            this.P1_chess_B.Click += new System.EventHandler(this.P1_chess_B_Click);
            // 
            // P1_chess_C
            // 
            this.P1_chess_C.Font = new System.Drawing.Font("新細明體", 15F);
            this.P1_chess_C.Location = new System.Drawing.Point(598, 235);
            this.P1_chess_C.Name = "P1_chess_C";
            this.P1_chess_C.Size = new System.Drawing.Size(146, 42);
            this.P1_chess_C.TabIndex = 15;
            this.P1_chess_C.Text = "縱向棋子";
            this.P1_chess_C.UseVisualStyleBackColor = true;
            this.P1_chess_C.Visible = false;
            this.P1_chess_C.Click += new System.EventHandler(this.P1_chess_C_Click);
            // 
            // P1_chess_D
            // 
            this.P1_chess_D.Font = new System.Drawing.Font("新細明體", 15F);
            this.P1_chess_D.Location = new System.Drawing.Point(598, 301);
            this.P1_chess_D.Name = "P1_chess_D";
            this.P1_chess_D.Size = new System.Drawing.Size(146, 42);
            this.P1_chess_D.TabIndex = 16;
            this.P1_chess_D.Text = "覆蓋棋子";
            this.P1_chess_D.UseVisualStyleBackColor = true;
            this.P1_chess_D.Visible = false;
            this.P1_chess_D.Click += new System.EventHandler(this.P1_chess_D_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 533);
            this.Controls.Add(this.P1_chess_D);
            this.Controls.Add(this.P1_chess_C);
            this.Controls.Add(this.P1_chess_B);
            this.Controls.Add(this.P1_chess_A);
            this.Controls.Add(this.P2_chess_D);
            this.Controls.Add(this.P2_chess_C);
            this.Controls.Add(this.P2_chess_B);
            this.Controls.Add(this.P2_chess_A);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.P1_Archer);
            this.Controls.Add(this.P1_witcher);
            this.Controls.Add(this.P1_warrior);
            this.Controls.Add(this.P2_Archer);
            this.Controls.Add(this.P2_witcher);
            this.Controls.Add(this.P2_warrior);
            this.Controls.Add(this.Player1_label);
            this.Controls.Add(this.Player2_label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Player2_label;
        private System.Windows.Forms.Label Player1_label;
        private System.Windows.Forms.Button P2_warrior;
        private System.Windows.Forms.Button P2_witcher;
        private System.Windows.Forms.Button P2_Archer;
        private System.Windows.Forms.Button P1_warrior;
        private System.Windows.Forms.Button P1_witcher;
        private System.Windows.Forms.Button P1_Archer;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Button P2_chess_A;
        private System.Windows.Forms.Button P2_chess_B;
        private System.Windows.Forms.Button P2_chess_C;
        private System.Windows.Forms.Button P2_chess_D;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button P1_chess_A;
        private System.Windows.Forms.Button P1_chess_B;
        private System.Windows.Forms.Button P1_chess_C;
        private System.Windows.Forms.Button P1_chess_D;
    }
}

