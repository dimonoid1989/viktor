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
            this.questionFormTextBox = new System.Windows.Forms.TextBox();
            this.questionQuestionFormButton = new System.Windows.Forms.Button();
            this.questionFormLabel = new System.Windows.Forms.Label();
            this.answerQuestionFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // questionFormTextBox
            // 
            this.questionFormTextBox.Location = new System.Drawing.Point(70, 121);
            this.questionFormTextBox.Name = "questionFormTextBox";
            this.questionFormTextBox.Size = new System.Drawing.Size(100, 20);
            this.questionFormTextBox.TabIndex = 0;
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
            this.questionFormLabel.Size = new System.Drawing.Size(57, 13);
            this.questionFormLabel.TabIndex = 2;
            this.questionFormLabel.Text = "Действие";
            // 
            // answerQuestionFormButton
            // 
            this.answerQuestionFormButton.Location = new System.Drawing.Point(70, 178);
            this.answerQuestionFormButton.Name = "answerQuestionFormButton";
            this.answerQuestionFormButton.Size = new System.Drawing.Size(75, 23);
            this.answerQuestionFormButton.TabIndex = 3;
            this.answerQuestionFormButton.Text = "Отправить";
            this.answerQuestionFormButton.UseVisualStyleBackColor = true;
            this.answerQuestionFormButton.Click += new System.EventHandler(this.answerQuestionFormButton_Click);
            // 
            // QuestionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 272);
            this.Controls.Add(this.answerQuestionFormButton);
            this.Controls.Add(this.questionFormLabel);
            this.Controls.Add(this.questionQuestionFormButton);
            this.Controls.Add(this.questionFormTextBox);
            this.Name = "QuestionsForm";
            this.Text = "QuestionsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox questionFormTextBox;
        private System.Windows.Forms.Button questionQuestionFormButton;
        private System.Windows.Forms.Label questionFormLabel;
        private System.Windows.Forms.Button answerQuestionFormButton;
    }
}