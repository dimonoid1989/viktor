namespace BilliardsBalls
{
    partial class BilliardForm
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
            this.addBalls = new System.Windows.Forms.Button();
            this.startMoving = new System.Windows.Forms.Button();
            this.endGame = new System.Windows.Forms.Button();
            this.upLabel = new System.Windows.Forms.Label();
            this.leftLabel = new System.Windows.Forms.Label();
            this.downLabel = new System.Windows.Forms.Label();
            this.rightLabel = new System.Windows.Forms.Label();
            this.viewCatchedBalls = new System.Windows.Forms.Label();
            this.endBilliardGame = new System.Windows.Forms.Button();
            this.addBilliardBalls = new System.Windows.Forms.Button();
            this.startBilliardMoving = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addBalls
            // 
            this.addBalls.Location = new System.Drawing.Point(704, 12);
            this.addBalls.Name = "addBalls";
            this.addBalls.Size = new System.Drawing.Size(84, 35);
            this.addBalls.TabIndex = 12;
            this.addBalls.Text = "Добавить шарики";
            this.addBalls.UseVisualStyleBackColor = true;
            // 
            // startMoving
            // 
            this.startMoving.Location = new System.Drawing.Point(611, 12);
            this.startMoving.Name = "startMoving";
            this.startMoving.Size = new System.Drawing.Size(87, 35);
            this.startMoving.TabIndex = 13;
            this.startMoving.Text = "Начать движение";
            this.startMoving.UseVisualStyleBackColor = true;
            // 
            // endGame
            // 
            this.endGame.Location = new System.Drawing.Point(514, 12);
            this.endGame.Name = "endGame";
            this.endGame.Size = new System.Drawing.Size(91, 36);
            this.endGame.TabIndex = 14;
            this.endGame.Text = "Закончить игру";
            this.endGame.UseVisualStyleBackColor = true;
            // 
            // upLabel
            // 
            this.upLabel.AutoSize = true;
            this.upLabel.Location = new System.Drawing.Point(318, 4);
            this.upLabel.Name = "upLabel";
            this.upLabel.Size = new System.Drawing.Size(116, 13);
            this.upLabel.TabIndex = 15;
            this.upLabel.Text = "Количество отскоков";
            // 
            // leftLabel
            // 
            this.leftLabel.AutoSize = true;
            this.leftLabel.Location = new System.Drawing.Point(18, 201);
            this.leftLabel.Name = "leftLabel";
            this.leftLabel.Size = new System.Drawing.Size(116, 13);
            this.leftLabel.TabIndex = 14;
            this.leftLabel.Text = "Количество отскоков";
            // 
            // downLabel
            // 
            this.downLabel.AutoSize = true;
            this.downLabel.Location = new System.Drawing.Point(374, 434);
            this.downLabel.Name = "downLabel";
            this.downLabel.Size = new System.Drawing.Size(116, 13);
            this.downLabel.TabIndex = 13;
            this.downLabel.Text = "Количество отскоков";
            // 
            // rightLabel
            // 
            this.rightLabel.AutoSize = true;
            this.rightLabel.Location = new System.Drawing.Point(635, 201);
            this.rightLabel.Name = "rightLabel";
            this.rightLabel.Size = new System.Drawing.Size(116, 13);
            this.rightLabel.TabIndex = 12;
            this.rightLabel.Text = "Количество отскоков";
            // 
            // viewCatchedBalls
            // 
            this.viewCatchedBalls.AutoSize = true;
            this.viewCatchedBalls.Location = new System.Drawing.Point(48, 28);
            this.viewCatchedBalls.Name = "viewCatchedBalls";
            this.viewCatchedBalls.Size = new System.Drawing.Size(0, 13);
            this.viewCatchedBalls.TabIndex = 11;
            // 
            // endBilliardGame
            // 
            this.endBilliardGame.Location = new System.Drawing.Point(464, 6);
            this.endBilliardGame.Name = "endBilliardGame";
            this.endBilliardGame.Size = new System.Drawing.Size(91, 36);
            this.endBilliardGame.TabIndex = 10;
            this.endBilliardGame.Text = "Закончить игру";
            this.endBilliardGame.UseVisualStyleBackColor = true;
            this.endBilliardGame.Click += new System.EventHandler(this.endBilliardGame_Click);
            // 
            // addBilliardBalls
            // 
            this.addBilliardBalls.Location = new System.Drawing.Point(698, 7);
            this.addBilliardBalls.Name = "addBilliardBalls";
            this.addBilliardBalls.Size = new System.Drawing.Size(84, 35);
            this.addBilliardBalls.TabIndex = 9;
            this.addBilliardBalls.Text = "Добавить шарики";
            this.addBilliardBalls.UseVisualStyleBackColor = true;
            this.addBilliardBalls.Click += new System.EventHandler(this.addBilliardBalls_Click_1);
            // 
            // startBilliardMoving
            // 
            this.startBilliardMoving.Location = new System.Drawing.Point(589, 7);
            this.startBilliardMoving.Name = "startBilliardMoving";
            this.startBilliardMoving.Size = new System.Drawing.Size(87, 35);
            this.startBilliardMoving.TabIndex = 8;
            this.startBilliardMoving.Text = "Начать движение";
            this.startBilliardMoving.UseVisualStyleBackColor = true;
            this.startBilliardMoving.Click += new System.EventHandler(this.startBilliardMoving_Click);
            // 
            // BilliardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.upLabel);
            this.Controls.Add(this.leftLabel);
            this.Controls.Add(this.downLabel);
            this.Controls.Add(this.rightLabel);
            this.Controls.Add(this.viewCatchedBalls);
            this.Controls.Add(this.endBilliardGame);
            this.Controls.Add(this.addBilliardBalls);
            this.Controls.Add(this.startBilliardMoving);
            this.Name = "BilliardForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addBalls;
        private System.Windows.Forms.Button startMoving;
        private System.Windows.Forms.Button endGame;
        private System.Windows.Forms.Label upLabel;
        private System.Windows.Forms.Label leftLabel;
        private System.Windows.Forms.Label downLabel;
        private System.Windows.Forms.Label rightLabel;
        private System.Windows.Forms.Label viewCatchedBalls;
        private System.Windows.Forms.Button endBilliardGame;
        private System.Windows.Forms.Button addBilliardBalls;
        private System.Windows.Forms.Button startBilliardMoving;
    }
}

