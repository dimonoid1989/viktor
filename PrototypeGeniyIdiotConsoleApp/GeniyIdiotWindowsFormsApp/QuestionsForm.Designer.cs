namespace GeniyIdiotWindowsFormsApp
{
    partial class QuestionsForm
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
            this.questionTextBox = new System.Windows.Forms.TextBox();
            this.questionQuestionFormButton = new System.Windows.Forms.Button();
            this.questionFormLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.answeTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // questionTextBox
            // 
            this.questionTextBox.Location = new System.Drawing.Point(70, 121);
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.Size = new System.Drawing.Size(100, 20);
            this.questionTextBox.TabIndex = 0;
            // 
            // questionQuestionFormButton
            // 
            this.questionQuestionFormButton.Location = new System.Drawing.Point(70, 178);
            this.questionQuestionFormButton.Name = "questionQuestionFormButton";
            this.questionQuestionFormButton.Size = new System.Drawing.Size(75, 23);
            this.questionQuestionFormButton.TabIndex = 1;
            this.questionQuestionFormButton.Text = "Отправить";
            this.questionQuestionFormButton.UseVisualStyleBackColor = true;
            this.questionQuestionFormButton.Click += new System.EventHandler(this.questionFormbutton_Click);
            // 
            // questionFormLabel
            // 
            this.questionFormLabel.AutoSize = true;
            this.questionFormLabel.Location = new System.Drawing.Point(67, 68);
            this.questionFormLabel.Name = "questionFormLabel";
            this.questionFormLabel.Size = new System.Drawing.Size(88, 13);
            this.questionFormLabel.TabIndex = 2;
            this.questionFormLabel.Text = "Введите вопрос";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введите ответ";
            // 
            // answeTextBox
            // 
            this.answeTextBox.Location = new System.Drawing.Point(284, 121);
            this.answeTextBox.Name = "answeTextBox";
            this.answeTextBox.Size = new System.Drawing.Size(100, 20);
            this.answeTextBox.TabIndex = 5;
            // 
            // QuestionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 272);
            this.Controls.Add(this.answeTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.questionFormLabel);
            this.Controls.Add(this.questionQuestionFormButton);
            this.Controls.Add(this.questionTextBox);
            this.Name = "QuestionsForm";
            this.Text = "QuestionsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox questionTextBox;
        private System.Windows.Forms.Button questionQuestionFormButton;
        private System.Windows.Forms.Label questionFormLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox answeTextBox;
    }
}