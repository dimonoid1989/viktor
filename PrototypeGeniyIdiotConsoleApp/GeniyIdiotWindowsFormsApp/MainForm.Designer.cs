namespace GeniyIdiotWindowsFormsApp
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.questionTextLabel = new System.Windows.Forms.Label();
            this.nextQuestionButton = new System.Windows.Forms.Button();
            this.questionNumber = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.новаяИграToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.показатьСтатистикуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьСтатистикуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьФайлСтатистикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.добавитьВопросToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьПользовательскиеВопросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьФайлВопросовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.questionAnswerTextBox = new System.Windows.Forms.MaskedTextBox();
            this.questionTimer = new System.Windows.Forms.Timer(this.components);
            this.questionTimerView = new System.Windows.Forms.ProgressBar();
            this.timerProgressBar = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // questionTextLabel
            // 
            this.questionTextLabel.AutoSize = true;
            this.questionTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questionTextLabel.Location = new System.Drawing.Point(51, 79);
            this.questionTextLabel.Name = "questionTextLabel";
            this.questionTextLabel.Size = new System.Drawing.Size(117, 16);
            this.questionTextLabel.TabIndex = 0;
            this.questionTextLabel.Text = "Текст вопроса";
            // 
            // nextQuestionButton
            // 
            this.nextQuestionButton.Location = new System.Drawing.Point(54, 166);
            this.nextQuestionButton.Name = "nextQuestionButton";
            this.nextQuestionButton.Size = new System.Drawing.Size(112, 29);
            this.nextQuestionButton.TabIndex = 2;
            this.nextQuestionButton.Text = "Далее";
            this.nextQuestionButton.UseVisualStyleBackColor = true;
            this.nextQuestionButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // questionNumber
            // 
            this.questionNumber.AutoSize = true;
            this.questionNumber.Location = new System.Drawing.Point(54, 46);
            this.questionNumber.Name = "questionNumber";
            this.questionNumber.Size = new System.Drawing.Size(84, 13);
            this.questionNumber.TabIndex = 3;
            this.questionNumber.Text = "номер вопроса";
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Location = new System.Drawing.Point(321, 46);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(101, 13);
            this.userName.TabIndex = 4;
            this.userName.Text = "имя пользователя";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(530, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.новаяИграToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(46, 20);
            this.toolStripMenuItem1.Text = "Игра";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(133, 6);
            // 
            // новаяИграToolStripMenuItem
            // 
            this.новаяИграToolStripMenuItem.Name = "новаяИграToolStripMenuItem";
            this.новаяИграToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.новаяИграToolStripMenuItem.Text = "Новая игра";
            this.новаяИграToolStripMenuItem.Click += new System.EventHandler(this.новаяИграToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.показатьСтатистикуToolStripMenuItem,
            this.очиститьСтатистикуToolStripMenuItem,
            this.открытьФайлСтатистикиToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(80, 20);
            this.toolStripMenuItem2.Text = "Статистика";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(213, 6);
            // 
            // показатьСтатистикуToolStripMenuItem
            // 
            this.показатьСтатистикуToolStripMenuItem.Name = "показатьСтатистикуToolStripMenuItem";
            this.показатьСтатистикуToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.показатьСтатистикуToolStripMenuItem.Text = "Показать статистику";
            this.показатьСтатистикуToolStripMenuItem.Click += new System.EventHandler(this.показатьСтатистикуToolStripMenuItem_Click);
            // 
            // очиститьСтатистикуToolStripMenuItem
            // 
            this.очиститьСтатистикуToolStripMenuItem.Name = "очиститьСтатистикуToolStripMenuItem";
            this.очиститьСтатистикуToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.очиститьСтатистикуToolStripMenuItem.Text = "Очистить статистику";
            this.очиститьСтатистикуToolStripMenuItem.Click += new System.EventHandler(this.очиститьСтатистикуToolStripMenuItem_Click);
            // 
            // открытьФайлСтатистикиToolStripMenuItem
            // 
            this.открытьФайлСтатистикиToolStripMenuItem.Name = "открытьФайлСтатистикиToolStripMenuItem";
            this.открытьФайлСтатистикиToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.открытьФайлСтатистикиToolStripMenuItem.Text = "Открыть файл статистики";
            this.открытьФайлСтатистикиToolStripMenuItem.Click += new System.EventHandler(this.открытьФайлСтатистикиToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator3,
            this.добавитьВопросToolStripMenuItem,
            this.удалитьПользовательскиеВопросыToolStripMenuItem,
            this.открытьФайлВопросовToolStripMenuItem});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(69, 20);
            this.toolStripMenuItem3.Text = "Вопросы";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(256, 6);
            // 
            // добавитьВопросToolStripMenuItem
            // 
            this.добавитьВопросToolStripMenuItem.Name = "добавитьВопросToolStripMenuItem";
            this.добавитьВопросToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.добавитьВопросToolStripMenuItem.Text = "Добавить вопрос";
            this.добавитьВопросToolStripMenuItem.Click += new System.EventHandler(this.добавитьВопросToolStripMenuItem_Click);
            // 
            // удалитьПользовательскиеВопросыToolStripMenuItem
            // 
            this.удалитьПользовательскиеВопросыToolStripMenuItem.Name = "удалитьПользовательскиеВопросыToolStripMenuItem";
            this.удалитьПользовательскиеВопросыToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.удалитьПользовательскиеВопросыToolStripMenuItem.Text = "Возврат вопросов по умолчанию";
            this.удалитьПользовательскиеВопросыToolStripMenuItem.Click += new System.EventHandler(this.удалитьПользовательскиеВопросыToolStripMenuItem_Click);
            // 
            // открытьФайлВопросовToolStripMenuItem
            // 
            this.открытьФайлВопросовToolStripMenuItem.Name = "открытьФайлВопросовToolStripMenuItem";
            this.открытьФайлВопросовToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.открытьФайлВопросовToolStripMenuItem.Text = "Показать вопросы";
            this.открытьФайлВопросовToolStripMenuItem.Click += new System.EventHandler(this.открытьФайлВопросовToolStripMenuItem_Click);
            // 
            // questionAnswerTextBox
            // 
            this.questionAnswerTextBox.Location = new System.Drawing.Point(54, 119);
            this.questionAnswerTextBox.Mask = "00000";
            this.questionAnswerTextBox.Name = "questionAnswerTextBox";
            this.questionAnswerTextBox.Size = new System.Drawing.Size(39, 20);
            this.questionAnswerTextBox.TabIndex = 6;
            // 
            // questionTimer
            // 
            this.questionTimer.Interval = 10000;
            this.questionTimer.Tick += new System.EventHandler(this.questionTimer_Tick);
            // 
            // questionTimerView
            // 
            this.questionTimerView.Location = new System.Drawing.Point(54, 260);
            this.questionTimerView.Name = "questionTimerView";
            this.questionTimerView.Size = new System.Drawing.Size(368, 23);
            this.questionTimerView.TabIndex = 7;
            // 
            // timerProgressBar
            // 
            this.timerProgressBar.Interval = 1000;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 312);
            this.Controls.Add(this.questionTimerView);
            this.Controls.Add(this.questionAnswerTextBox);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.questionNumber);
            this.Controls.Add(this.nextQuestionButton);
            this.Controls.Add(this.questionTextLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Гений-Идиот";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questionTextLabel;
        private System.Windows.Forms.Button nextQuestionButton;
        private System.Windows.Forms.Label questionNumber;
        public System.Windows.Forms.Label userName;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem новаяИграToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показатьСтатистикуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьСтатистикуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьФайлСтатистикиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьВопросToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьПользовательскиеВопросыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьФайлВопросовToolStripMenuItem;
        private System.Windows.Forms.MaskedTextBox questionAnswerTextBox;
        private System.Windows.Forms.Timer questionTimer;
        private System.Windows.Forms.ProgressBar questionTimerView;
        private System.Windows.Forms.Timer timerProgressBar;
    }
}

