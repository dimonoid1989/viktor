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
            this.upLabel = new System.Windows.Forms.Label();
            this.rightLabel = new System.Windows.Forms.Label();
            this.downLabel = new System.Windows.Forms.Label();
            this.leftLabel = new System.Windows.Forms.Label();
            this.addBalls = new System.Windows.Forms.Button();
            this.startMoving = new System.Windows.Forms.Button();
            this.endGame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.viewCatchedBalls = new System.Windows.Forms.Label();
            this.endBilliardGame = new System.Windows.Forms.Button();
            this.addBilliardBalls = new System.Windows.Forms.Button();
            this.startBilliardMoving = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // upLabel
            // 
            this.upLabel.AutoSize = true;
            this.upLabel.Location = new System.Drawing.Point(348, 9);
            this.upLabel.Name = "upLabel";
            this.upLabel.Size = new System.Drawing.Size(116, 13);
            this.upLabel.TabIndex = 8;
            this.upLabel.Text = "Количество отскоков";
            // 
            // rightLabel
            // 
            this.rightLabel.AutoSize = true;
            this.rightLabel.Location = new System.Drawing.Point(672, 233);
            this.rightLabel.Name = "rightLabel";
            this.rightLabel.Size = new System.Drawing.Size(116, 13);
            this.rightLabel.TabIndex = 9;
            this.rightLabel.Text = "Количество отскоков";
            // 
            // downLabel
            // 
            this.downLabel.AutoSize = true;
            this.downLabel.Location = new System.Drawing.Point(348, 428);
            this.downLabel.Name = "downLabel";
            this.downLabel.Size = new System.Drawing.Size(116, 13);
            this.downLabel.TabIndex = 10;
            this.downLabel.Text = "Количество отскоков";
            // 
            // leftLabel
            // 
            this.leftLabel.AutoSize = true;
            this.leftLabel.Location = new System.Drawing.Point(12, 233);
            this.leftLabel.Name = "leftLabel";
            this.leftLabel.Size = new System.Drawing.Size(116, 13);
            this.leftLabel.TabIndex = 11;
            this.leftLabel.Text = "Количество отскоков";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Количество отскоков";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Количество отскоков";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(374, 434);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Количество отскоков";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(666, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Количество отскоков";
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
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
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

        private System.Windows.Forms.Label upLabel;
        private System.Windows.Forms.Label rightLabel;
        private System.Windows.Forms.Label downLabel;
        private System.Windows.Forms.Label leftLabel;
        private System.Windows.Forms.Button addBalls;
        private System.Windows.Forms.Button startMoving;
        private System.Windows.Forms.Button endGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label viewCatchedBalls;
        private System.Windows.Forms.Button endBilliardGame;
        private System.Windows.Forms.Button addBilliardBalls;
        private System.Windows.Forms.Button startBilliardMoving;
    }
}

