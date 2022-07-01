namespace week7_practice_2
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
            this.choice_label = new System.Windows.Forms.Label();
            this.water_button = new System.Windows.Forms.RadioButton();
            this.fire_button = new System.Windows.Forms.RadioButton();
            this.tree_button = new System.Windows.Forms.RadioButton();
            this.start_button = new System.Windows.Forms.Button();
            this.attribute_label = new System.Windows.Forms.Label();
            this.scores_label = new System.Windows.Forms.Label();
            this.timer_label = new System.Windows.Forms.Label();
            this.attribute_text = new System.Windows.Forms.Label();
            this.scores_text = new System.Windows.Forms.Label();
            this.timer_text = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // choice_label
            // 
            this.choice_label.AutoSize = true;
            this.choice_label.Font = new System.Drawing.Font("新細明體", 12F);
            this.choice_label.Location = new System.Drawing.Point(234, 103);
            this.choice_label.Name = "choice_label";
            this.choice_label.Size = new System.Drawing.Size(104, 16);
            this.choice_label.TabIndex = 0;
            this.choice_label.Text = "選擇初始屬性";
            // 
            // water_button
            // 
            this.water_button.AutoSize = true;
            this.water_button.Checked = true;
            this.water_button.Location = new System.Drawing.Point(237, 137);
            this.water_button.Name = "water_button";
            this.water_button.Size = new System.Drawing.Size(35, 16);
            this.water_button.TabIndex = 1;
            this.water_button.TabStop = true;
            this.water_button.Text = "水";
            this.water_button.UseVisualStyleBackColor = true;
            // 
            // fire_button
            // 
            this.fire_button.AutoSize = true;
            this.fire_button.Location = new System.Drawing.Point(237, 159);
            this.fire_button.Name = "fire_button";
            this.fire_button.Size = new System.Drawing.Size(35, 16);
            this.fire_button.TabIndex = 2;
            this.fire_button.Text = "火";
            this.fire_button.UseVisualStyleBackColor = true;
            // 
            // tree_button
            // 
            this.tree_button.AutoSize = true;
            this.tree_button.Location = new System.Drawing.Point(237, 181);
            this.tree_button.Name = "tree_button";
            this.tree_button.Size = new System.Drawing.Size(35, 16);
            this.tree_button.TabIndex = 3;
            this.tree_button.Text = "木";
            this.tree_button.UseVisualStyleBackColor = true;
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(237, 214);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(75, 23);
            this.start_button.TabIndex = 4;
            this.start_button.Text = "開始";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // attribute_label
            // 
            this.attribute_label.AutoSize = true;
            this.attribute_label.Font = new System.Drawing.Font("新細明體", 12F);
            this.attribute_label.Location = new System.Drawing.Point(458, 54);
            this.attribute_label.Name = "attribute_label";
            this.attribute_label.Size = new System.Drawing.Size(76, 16);
            this.attribute_label.TabIndex = 11;
            this.attribute_label.Text = "目前屬性:";
            this.attribute_label.Visible = false;
            // 
            // scores_label
            // 
            this.scores_label.AutoSize = true;
            this.scores_label.Font = new System.Drawing.Font("新細明體", 12F);
            this.scores_label.Location = new System.Drawing.Point(458, 91);
            this.scores_label.Name = "scores_label";
            this.scores_label.Size = new System.Drawing.Size(76, 16);
            this.scores_label.TabIndex = 12;
            this.scores_label.Text = "目前分數:";
            this.scores_label.Visible = false;
            // 
            // timer_label
            // 
            this.timer_label.AutoSize = true;
            this.timer_label.Font = new System.Drawing.Font("新細明體", 12F);
            this.timer_label.Location = new System.Drawing.Point(458, 126);
            this.timer_label.Name = "timer_label";
            this.timer_label.Size = new System.Drawing.Size(76, 16);
            this.timer_label.TabIndex = 13;
            this.timer_label.Text = "剩餘時間:";
            this.timer_label.Visible = false;
            // 
            // attribute_text
            // 
            this.attribute_text.AutoSize = true;
            this.attribute_text.Font = new System.Drawing.Font("新細明體", 12F);
            this.attribute_text.Location = new System.Drawing.Point(546, 54);
            this.attribute_text.Name = "attribute_text";
            this.attribute_text.Size = new System.Drawing.Size(24, 16);
            this.attribute_text.TabIndex = 14;
            this.attribute_text.Text = "火";
            this.attribute_text.Visible = false;
            // 
            // scores_text
            // 
            this.scores_text.AutoSize = true;
            this.scores_text.Font = new System.Drawing.Font("新細明體", 12F);
            this.scores_text.Location = new System.Drawing.Point(554, 91);
            this.scores_text.Name = "scores_text";
            this.scores_text.Size = new System.Drawing.Size(16, 16);
            this.scores_text.TabIndex = 15;
            this.scores_text.Text = "0";
            this.scores_text.Visible = false;
            // 
            // timer_text
            // 
            this.timer_text.AutoSize = true;
            this.timer_text.Font = new System.Drawing.Font("新細明體", 12F);
            this.timer_text.Location = new System.Drawing.Point(554, 126);
            this.timer_text.Name = "timer_text";
            this.timer_text.Size = new System.Drawing.Size(16, 16);
            this.timer_text.TabIndex = 16;
            this.timer_text.Text = "0";
            this.timer_text.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 451);
            this.Controls.Add(this.timer_text);
            this.Controls.Add(this.scores_text);
            this.Controls.Add(this.attribute_text);
            this.Controls.Add(this.timer_label);
            this.Controls.Add(this.scores_label);
            this.Controls.Add(this.attribute_label);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.fire_button);
            this.Controls.Add(this.water_button);
            this.Controls.Add(this.tree_button);
            this.Controls.Add(this.choice_label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label choice_label;
        private System.Windows.Forms.RadioButton water_button;
        private System.Windows.Forms.RadioButton fire_button;
        private System.Windows.Forms.RadioButton tree_button;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Label attribute_label;
        private System.Windows.Forms.Label scores_label;
        private System.Windows.Forms.Label timer_label;
        private System.Windows.Forms.Label attribute_text;
        private System.Windows.Forms.Label scores_text;
        private System.Windows.Forms.Label timer_text;
        private System.Windows.Forms.Timer timer1;
    }
}

