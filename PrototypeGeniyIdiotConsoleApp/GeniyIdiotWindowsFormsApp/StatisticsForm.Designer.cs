namespace GeniyIdiotWindowsFormsApp
{
    partial class StatisticsForm
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
            this.rightAnswersCountLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.diagnoseLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rightAnswersCountLabel
            // 
            this.rightAnswersCountLabel.AutoSize = true;
            this.rightAnswersCountLabel.Location = new System.Drawing.Point(297, 49);
            this.rightAnswersCountLabel.Name = "rightAnswersCountLabel";
            this.rightAnswersCountLabel.Size = new System.Drawing.Size(173, 13);
            this.rightAnswersCountLabel.TabIndex = 0;
            this.rightAnswersCountLabel.Text = "Количество правильных ответов";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(78, 49);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(103, 13);
            this.userNameLabel.TabIndex = 1;
            this.userNameLabel.Text = "Имя пользователя";
            // 
            // diagnoseLabel
            // 
            this.diagnoseLabel.AutoSize = true;
            this.diagnoseLabel.Location = new System.Drawing.Point(602, 48);
            this.diagnoseLabel.Name = "diagnoseLabel";
            this.diagnoseLabel.Size = new System.Drawing.Size(51, 13);
            this.diagnoseLabel.TabIndex = 2;
            this.diagnoseLabel.Text = "Диагноз";
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.diagnoseLabel);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.rightAnswersCountLabel);
            this.Name = "StatisticsForm";
            this.Text = "Форма Статистики";
            //this.Load += new System.EventHandler(this.StatisticsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label rightAnswersCountLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label diagnoseLabel;
    }
}