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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Имя пользователя";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Кол-во правильных ответов";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Диагноз";
            this.Column3.Name = "Column3";
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.diagnoseLabel);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.rightAnswersCountLabel);
            this.Name = "StatisticsForm";
            this.Text = "Форма Статистики";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label rightAnswersCountLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label diagnoseLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}