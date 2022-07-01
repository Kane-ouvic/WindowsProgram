namespace week7_practice_1
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
            this.score_label = new System.Windows.Forms.Label();
            this.number_label = new System.Windows.Forms.Label();
            this.score_print = new System.Windows.Forms.Label();
            this.number_print = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer_label = new System.Windows.Forms.Label();
            this.timer_print = new System.Windows.Forms.Label();
            this.easy_mode = new System.Windows.Forms.Button();
            this.normal_mode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // score_label
            // 
            this.score_label.AutoSize = true;
            this.score_label.Font = new System.Drawing.Font("新細明體", 12F);
            this.score_label.Location = new System.Drawing.Point(416, 37);
            this.score_label.Name = "score_label";
            this.score_label.Size = new System.Drawing.Size(76, 16);
            this.score_label.TabIndex = 0;
            this.score_label.Text = "當前分數:";
            this.score_label.Visible = false;
            // 
            // number_label
            // 
            this.number_label.AutoSize = true;
            this.number_label.Font = new System.Drawing.Font("新細明體", 12F);
            this.number_label.Location = new System.Drawing.Point(416, 83);
            this.number_label.Name = "number_label";
            this.number_label.Size = new System.Drawing.Size(76, 16);
            this.number_label.TabIndex = 1;
            this.number_label.Text = "當前數字:";
            this.number_label.Visible = false;
            // 
            // score_print
            // 
            this.score_print.AutoSize = true;
            this.score_print.Font = new System.Drawing.Font("新細明體", 12F);
            this.score_print.Location = new System.Drawing.Point(498, 37);
            this.score_print.Name = "score_print";
            this.score_print.Size = new System.Drawing.Size(16, 16);
            this.score_print.TabIndex = 2;
            this.score_print.Text = "0";
            this.score_print.Visible = false;
            // 
            // number_print
            // 
            this.number_print.AutoSize = true;
            this.number_print.Font = new System.Drawing.Font("新細明體", 12F);
            this.number_print.Location = new System.Drawing.Point(498, 83);
            this.number_print.Name = "number_print";
            this.number_print.Size = new System.Drawing.Size(16, 16);
            this.number_print.TabIndex = 3;
            this.number_print.Text = "2";
            this.number_print.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer_label
            // 
            this.timer_label.AutoSize = true;
            this.timer_label.Font = new System.Drawing.Font("新細明體", 12F);
            this.timer_label.Location = new System.Drawing.Point(416, 132);
            this.timer_label.Name = "timer_label";
            this.timer_label.Size = new System.Drawing.Size(76, 16);
            this.timer_label.TabIndex = 4;
            this.timer_label.Text = "倒數計時:";
            this.timer_label.Visible = false;
            // 
            // timer_print
            // 
            this.timer_print.AutoSize = true;
            this.timer_print.Font = new System.Drawing.Font("新細明體", 12F);
            this.timer_print.Location = new System.Drawing.Point(498, 132);
            this.timer_print.Name = "timer_print";
            this.timer_print.Size = new System.Drawing.Size(16, 16);
            this.timer_print.TabIndex = 5;
            this.timer_print.Text = "0";
            this.timer_print.Visible = false;
            // 
            // easy_mode
            // 
            this.easy_mode.Location = new System.Drawing.Point(198, 152);
            this.easy_mode.Name = "easy_mode";
            this.easy_mode.Size = new System.Drawing.Size(191, 47);
            this.easy_mode.TabIndex = 6;
            this.easy_mode.Text = "簡單模式";
            this.easy_mode.UseVisualStyleBackColor = true;
            this.easy_mode.Click += new System.EventHandler(this.easy_mode_Click);
            // 
            // normal_mode
            // 
            this.normal_mode.Location = new System.Drawing.Point(198, 250);
            this.normal_mode.Name = "normal_mode";
            this.normal_mode.Size = new System.Drawing.Size(191, 49);
            this.normal_mode.TabIndex = 7;
            this.normal_mode.Text = "普通模式";
            this.normal_mode.UseVisualStyleBackColor = true;
            this.normal_mode.Click += new System.EventHandler(this.normal_mode_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(612, 503);
            this.Controls.Add(this.normal_mode);
            this.Controls.Add(this.easy_mode);
            this.Controls.Add(this.timer_print);
            this.Controls.Add(this.timer_label);
            this.Controls.Add(this.number_print);
            this.Controls.Add(this.score_print);
            this.Controls.Add(this.number_label);
            this.Controls.Add(this.score_label);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label score_label;
        private System.Windows.Forms.Label number_label;
        private System.Windows.Forms.Label score_print;
        private System.Windows.Forms.Label number_print;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timer_label;
        private System.Windows.Forms.Label timer_print;
        private System.Windows.Forms.Button easy_mode;
        private System.Windows.Forms.Button normal_mode;
    }
}

