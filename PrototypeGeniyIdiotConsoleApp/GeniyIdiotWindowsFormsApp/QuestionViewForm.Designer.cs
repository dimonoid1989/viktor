namespace GeniyIdiotWindowsFormsApp
{
    partial class QuestionViewForm
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
            this.questionView = new System.Windows.Forms.DataGridView();
            this.questionText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionAnswer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.questionView)).BeginInit();
            this.SuspendLayout();
            // 
            // questionView
            // 
            this.questionView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.questionView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.questionText,
            this.questionAnswer});
            this.questionView.Location = new System.Drawing.Point(0, 0);
            this.questionView.Name = "questionView";
            this.questionView.Size = new System.Drawing.Size(676, 323);
            this.questionView.TabIndex = 0;
            // 
            // questionText
            // 
            this.questionText.HeaderText = "Текст вопроса";
            this.questionText.Name = "questionText";
            // 
            // questionAnswer
            // 
            this.questionAnswer.HeaderText = "Ответ на вопрос";
            this.questionAnswer.Name = "questionAnswer";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(530, 182);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(103, 23);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Удалить вопрос";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // QuestionViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 323);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.questionView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QuestionViewForm";
            this.Text = "QuestionViewForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.QuestionViewForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.questionView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView questionView;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionText;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionAnswer;
        private System.Windows.Forms.Button deleteButton;
    }
}