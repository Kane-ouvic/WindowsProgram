namespace week5_p2
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
            this.history = new System.Windows.Forms.ListBox();
            this.money_title = new System.Windows.Forms.Label();
            this.money = new System.Windows.Forms.Label();
            this.stats_title = new System.Windows.Forms.Label();
            this.emotion_label = new System.Windows.Forms.Label();
            this.weight_title = new System.Windows.Forms.Label();
            this.satisfaction_title = new System.Windows.Forms.Label();
            this.emotion_title = new System.Windows.Forms.Label();
            this.event_title = new System.Windows.Forms.Label();
            this.weight_label = new System.Windows.Forms.Label();
            this.event_label = new System.Windows.Forms.Label();
            this.health_title = new System.Windows.Forms.Label();
            this.health_label = new System.Windows.Forms.Label();
            this.satisfaction_label = new System.Windows.Forms.Label();
            this.feed_button = new System.Windows.Forms.Button();
            this.play_button = new System.Windows.Forms.Button();
            this.clean_button = new System.Windows.Forms.Button();
            this.doctor_button = new System.Windows.Forms.Button();
            this.name_button = new System.Windows.Forms.Button();
            this.name_text = new System.Windows.Forms.TextBox();
            this.end_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // history
            // 
            this.history.FormattingEnabled = true;
            this.history.ItemHeight = 12;
            this.history.Location = new System.Drawing.Point(12, 12);
            this.history.Name = "history";
            this.history.ScrollAlwaysVisible = true;
            this.history.Size = new System.Drawing.Size(321, 340);
            this.history.TabIndex = 0;
            // 
            // money_title
            // 
            this.money_title.AutoSize = true;
            this.money_title.Font = new System.Drawing.Font("新細明體", 12F);
            this.money_title.Location = new System.Drawing.Point(346, 12);
            this.money_title.Name = "money_title";
            this.money_title.Size = new System.Drawing.Size(40, 16);
            this.money_title.TabIndex = 1;
            this.money_title.Text = "金錢";
            // 
            // money
            // 
            this.money.AutoSize = true;
            this.money.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.money.Location = new System.Drawing.Point(364, 42);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(32, 17);
            this.money.TabIndex = 2;
            this.money.Text = "0 元";
            // 
            // stats_title
            // 
            this.stats_title.AutoSize = true;
            this.stats_title.Font = new System.Drawing.Font("新細明體", 12F);
            this.stats_title.Location = new System.Drawing.Point(346, 95);
            this.stats_title.Name = "stats_title";
            this.stats_title.Size = new System.Drawing.Size(40, 16);
            this.stats_title.TabIndex = 3;
            this.stats_title.Text = "狀態";
            // 
            // emotion_label
            // 
            this.emotion_label.AutoSize = true;
            this.emotion_label.Location = new System.Drawing.Point(439, 243);
            this.emotion_label.Name = "emotion_label";
            this.emotion_label.Size = new System.Drawing.Size(20, 12);
            this.emotion_label.TabIndex = 4;
            this.emotion_label.Text = "0%";
            // 
            // weight_title
            // 
            this.weight_title.AutoSize = true;
            this.weight_title.Location = new System.Drawing.Point(374, 172);
            this.weight_title.Name = "weight_title";
            this.weight_title.Size = new System.Drawing.Size(32, 12);
            this.weight_title.TabIndex = 5;
            this.weight_title.Text = "體重:";
            // 
            // satisfaction_title
            // 
            this.satisfaction_title.AutoSize = true;
            this.satisfaction_title.Location = new System.Drawing.Point(373, 207);
            this.satisfaction_title.Name = "satisfaction_title";
            this.satisfaction_title.Size = new System.Drawing.Size(44, 12);
            this.satisfaction_title.TabIndex = 6;
            this.satisfaction_title.Text = "飽足感:";
            this.satisfaction_title.Click += new System.EventHandler(this.satisfaction_title_Click);
            // 
            // emotion_title
            // 
            this.emotion_title.AutoSize = true;
            this.emotion_title.Location = new System.Drawing.Point(374, 243);
            this.emotion_title.Name = "emotion_title";
            this.emotion_title.Size = new System.Drawing.Size(32, 12);
            this.emotion_title.TabIndex = 7;
            this.emotion_title.Text = "心情:";
            // 
            // event_title
            // 
            this.event_title.AutoSize = true;
            this.event_title.Font = new System.Drawing.Font("新細明體", 12F);
            this.event_title.Location = new System.Drawing.Point(339, 274);
            this.event_title.Name = "event_title";
            this.event_title.Size = new System.Drawing.Size(40, 16);
            this.event_title.TabIndex = 8;
            this.event_title.Text = "事件";
            // 
            // weight_label
            // 
            this.weight_label.AutoSize = true;
            this.weight_label.Location = new System.Drawing.Point(439, 172);
            this.weight_label.Name = "weight_label";
            this.weight_label.Size = new System.Drawing.Size(17, 12);
            this.weight_label.TabIndex = 9;
            this.weight_label.Text = "0g";
            // 
            // event_label
            // 
            this.event_label.AutoSize = true;
            this.event_label.Location = new System.Drawing.Point(374, 302);
            this.event_label.Name = "event_label";
            this.event_label.Size = new System.Drawing.Size(77, 12);
            this.event_label.TabIndex = 10;
            this.event_label.Text = "請幫寵物取名";
            // 
            // health_title
            // 
            this.health_title.AutoSize = true;
            this.health_title.Font = new System.Drawing.Font("新細明體", 9F);
            this.health_title.Location = new System.Drawing.Point(374, 140);
            this.health_title.Name = "health_title";
            this.health_title.Size = new System.Drawing.Size(32, 12);
            this.health_title.TabIndex = 11;
            this.health_title.Text = "健康:";
            // 
            // health_label
            // 
            this.health_label.AutoSize = true;
            this.health_label.Location = new System.Drawing.Point(439, 140);
            this.health_label.Name = "health_label";
            this.health_label.Size = new System.Drawing.Size(20, 12);
            this.health_label.TabIndex = 12;
            this.health_label.Text = "0%";
            // 
            // satisfaction_label
            // 
            this.satisfaction_label.AutoSize = true;
            this.satisfaction_label.Location = new System.Drawing.Point(439, 207);
            this.satisfaction_label.Name = "satisfaction_label";
            this.satisfaction_label.Size = new System.Drawing.Size(20, 12);
            this.satisfaction_label.TabIndex = 13;
            this.satisfaction_label.Text = "0%";
            // 
            // feed_button
            // 
            this.feed_button.Enabled = false;
            this.feed_button.Location = new System.Drawing.Point(390, 339);
            this.feed_button.Name = "feed_button";
            this.feed_button.Size = new System.Drawing.Size(75, 23);
            this.feed_button.TabIndex = 14;
            this.feed_button.Text = "餵食";
            this.feed_button.UseVisualStyleBackColor = true;
            this.feed_button.Click += new System.EventHandler(this.feed_button_Click);
            // 
            // play_button
            // 
            this.play_button.Enabled = false;
            this.play_button.Location = new System.Drawing.Point(471, 339);
            this.play_button.Name = "play_button";
            this.play_button.Size = new System.Drawing.Size(75, 23);
            this.play_button.TabIndex = 15;
            this.play_button.Text = "玩耍";
            this.play_button.UseVisualStyleBackColor = true;
            this.play_button.Click += new System.EventHandler(this.play_button_Click);
            // 
            // clean_button
            // 
            this.clean_button.Enabled = false;
            this.clean_button.Location = new System.Drawing.Point(552, 339);
            this.clean_button.Name = "clean_button";
            this.clean_button.Size = new System.Drawing.Size(75, 23);
            this.clean_button.TabIndex = 16;
            this.clean_button.Text = "打掃";
            this.clean_button.UseVisualStyleBackColor = true;
            this.clean_button.Click += new System.EventHandler(this.clean_button_Click);
            // 
            // doctor_button
            // 
            this.doctor_button.Enabled = false;
            this.doctor_button.Location = new System.Drawing.Point(633, 339);
            this.doctor_button.Name = "doctor_button";
            this.doctor_button.Size = new System.Drawing.Size(75, 23);
            this.doctor_button.TabIndex = 17;
            this.doctor_button.Text = "看醫生";
            this.doctor_button.UseVisualStyleBackColor = true;
            this.doctor_button.Click += new System.EventHandler(this.doctor_button_Click);
            // 
            // name_button
            // 
            this.name_button.Location = new System.Drawing.Point(253, 374);
            this.name_button.Name = "name_button";
            this.name_button.Size = new System.Drawing.Size(80, 23);
            this.name_button.TabIndex = 18;
            this.name_button.Text = "輸入名字";
            this.name_button.UseVisualStyleBackColor = true;
            this.name_button.Click += new System.EventHandler(this.name_button_Click);
            // 
            // name_text
            // 
            this.name_text.Location = new System.Drawing.Point(21, 374);
            this.name_text.Name = "name_text";
            this.name_text.Size = new System.Drawing.Size(226, 22);
            this.name_text.TabIndex = 19;
            // 
            // end_button
            // 
            this.end_button.Enabled = false;
            this.end_button.Location = new System.Drawing.Point(543, 389);
            this.end_button.Name = "end_button";
            this.end_button.Size = new System.Drawing.Size(156, 23);
            this.end_button.TabIndex = 20;
            this.end_button.Text = "結束這天";
            this.end_button.UseVisualStyleBackColor = true;
            this.end_button.Click += new System.EventHandler(this.end_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.end_button);
            this.Controls.Add(this.name_text);
            this.Controls.Add(this.name_button);
            this.Controls.Add(this.doctor_button);
            this.Controls.Add(this.clean_button);
            this.Controls.Add(this.play_button);
            this.Controls.Add(this.feed_button);
            this.Controls.Add(this.satisfaction_label);
            this.Controls.Add(this.health_label);
            this.Controls.Add(this.health_title);
            this.Controls.Add(this.event_label);
            this.Controls.Add(this.weight_label);
            this.Controls.Add(this.event_title);
            this.Controls.Add(this.emotion_title);
            this.Controls.Add(this.satisfaction_title);
            this.Controls.Add(this.weight_title);
            this.Controls.Add(this.emotion_label);
            this.Controls.Add(this.stats_title);
            this.Controls.Add(this.money);
            this.Controls.Add(this.money_title);
            this.Controls.Add(this.history);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox history;
        private System.Windows.Forms.Label money_title;
        private System.Windows.Forms.Label money;
        private System.Windows.Forms.Label stats_title;
        private System.Windows.Forms.Label emotion_label;
        private System.Windows.Forms.Label weight_title;
        private System.Windows.Forms.Label satisfaction_title;
        private System.Windows.Forms.Label emotion_title;
        private System.Windows.Forms.Label event_title;
        private System.Windows.Forms.Label weight_label;
        private System.Windows.Forms.Label event_label;
        private System.Windows.Forms.Label health_title;
        private System.Windows.Forms.Label health_label;
        private System.Windows.Forms.Label satisfaction_label;
        private System.Windows.Forms.Button feed_button;
        private System.Windows.Forms.Button play_button;
        private System.Windows.Forms.Button clean_button;
        private System.Windows.Forms.Button doctor_button;
        private System.Windows.Forms.Button name_button;
        private System.Windows.Forms.TextBox name_text;
        private System.Windows.Forms.Button end_button;
    }
}

