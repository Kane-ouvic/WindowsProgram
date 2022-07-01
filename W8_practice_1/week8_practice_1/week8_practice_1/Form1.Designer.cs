namespace week8_practice_1
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.round_label = new System.Windows.Forms.Label();
            this.player_label = new System.Windows.Forms.Label();
            this.P1score_label = new System.Windows.Forms.Label();
            this.P2score_label = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.start_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // round_label
            // 
            this.round_label.AutoSize = true;
            this.round_label.Font = new System.Drawing.Font("新細明體", 20F);
            this.round_label.Location = new System.Drawing.Point(244, 21);
            this.round_label.Name = "round_label";
            this.round_label.Size = new System.Drawing.Size(174, 27);
            this.round_label.TabIndex = 0;
            this.round_label.Text = "第1回合 輪到:";
            this.round_label.Visible = false;
            // 
            // player_label
            // 
            this.player_label.AutoSize = true;
            this.player_label.Font = new System.Drawing.Font("新細明體", 20F);
            this.player_label.Location = new System.Drawing.Point(424, 21);
            this.player_label.Name = "player_label";
            this.player_label.Size = new System.Drawing.Size(39, 27);
            this.player_label.TabIndex = 1;
            this.player_label.Text = "P1";
            this.player_label.Visible = false;
            // 
            // P1score_label
            // 
            this.P1score_label.AutoSize = true;
            this.P1score_label.Font = new System.Drawing.Font("新細明體", 20F);
            this.P1score_label.Location = new System.Drawing.Point(583, 199);
            this.P1score_label.Name = "P1score_label";
            this.P1score_label.Size = new System.Drawing.Size(86, 27);
            this.P1score_label.TabIndex = 2;
            this.P1score_label.Text = "P1:0分";
            this.P1score_label.Visible = false;
            // 
            // P2score_label
            // 
            this.P2score_label.AutoSize = true;
            this.P2score_label.Font = new System.Drawing.Font("新細明體", 20F);
            this.P2score_label.Location = new System.Drawing.Point(38, 199);
            this.P2score_label.Name = "P2score_label";
            this.P2score_label.Size = new System.Drawing.Size(86, 27);
            this.P2score_label.TabIndex = 3;
            this.P2score_label.Text = "P2:0分";
            this.P2score_label.Visible = false;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // start_button
            // 
            this.start_button.Font = new System.Drawing.Font("新細明體", 15F);
            this.start_button.Location = new System.Drawing.Point(272, 199);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(164, 39);
            this.start_button.TabIndex = 4;
            this.start_button.Text = "遊戲開始";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.P2score_label);
            this.Controls.Add(this.P1score_label);
            this.Controls.Add(this.player_label);
            this.Controls.Add(this.round_label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label round_label;
        private System.Windows.Forms.Label player_label;
        private System.Windows.Forms.Label P1score_label;
        private System.Windows.Forms.Label P2score_label;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button start_button;
    }
}

