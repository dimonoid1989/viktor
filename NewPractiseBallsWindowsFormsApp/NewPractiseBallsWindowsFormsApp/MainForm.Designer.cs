namespace NewPractiseBallsWindowsFormsApp
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
            this.startMoving = new System.Windows.Forms.Button();
            this.addBalls = new System.Windows.Forms.Button();
            this.endGame = new System.Windows.Forms.Button();
            this.viewCatchedBalls = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startMoving
            // 
            this.startMoving.Location = new System.Drawing.Point(583, 12);
            this.startMoving.Name = "startMoving";
            this.startMoving.Size = new System.Drawing.Size(87, 35);
            this.startMoving.TabIndex = 0;
            this.startMoving.Text = "Начать движение";
            this.startMoving.UseVisualStyleBackColor = true;
            this.startMoving.Click += new System.EventHandler(this.startMoving_Click);
            // 
            // addBalls
            // 
            this.addBalls.Location = new System.Drawing.Point(692, 12);
            this.addBalls.Name = "addBalls";
            this.addBalls.Size = new System.Drawing.Size(84, 35);
            this.addBalls.TabIndex = 1;
            this.addBalls.Text = "Добавить шарики";
            this.addBalls.UseVisualStyleBackColor = true;
            this.addBalls.Click += new System.EventHandler(this.addBalls_Click);
            // 
            // endGame
            // 
            this.endGame.Location = new System.Drawing.Point(458, 11);
            this.endGame.Name = "endGame";
            this.endGame.Size = new System.Drawing.Size(91, 36);
            this.endGame.TabIndex = 2;
            this.endGame.Text = "Закончить игру";
            this.endGame.UseVisualStyleBackColor = true;
            this.endGame.Click += new System.EventHandler(this.endGame_Click);
            // 
            // viewCatchedBalls
            // 
            this.viewCatchedBalls.AutoSize = true;
            this.viewCatchedBalls.Location = new System.Drawing.Point(42, 33);
            this.viewCatchedBalls.Name = "viewCatchedBalls";
            this.viewCatchedBalls.Size = new System.Drawing.Size(0, 13);
            this.viewCatchedBalls.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.viewCatchedBalls);
            this.Controls.Add(this.endGame);
            this.Controls.Add(this.addBalls);
            this.Controls.Add(this.startMoving);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startMoving;
        private System.Windows.Forms.Button addBalls;
        private System.Windows.Forms.Button endGame;
        private System.Windows.Forms.Label viewCatchedBalls;
    }
}

