namespace Fruit_Ninja_ballApp
{
    partial class FruitNinjaForm
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
            this.startButton = new System.Windows.Forms.Button();
            this.lifesCountLabel = new System.Windows.Forms.Label();
            this.ballCoughtLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(677, 12);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(100, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Начать игру";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // lifesCountLabel
            // 
            this.lifesCountLabel.AutoSize = true;
            this.lifesCountLabel.Location = new System.Drawing.Point(68, 22);
            this.lifesCountLabel.Name = "lifesCountLabel";
            this.lifesCountLabel.Size = new System.Drawing.Size(40, 13);
            this.lifesCountLabel.TabIndex = 1;
            this.lifesCountLabel.Text = "кол-во";
            // 
            // ballCoughtLabel
            // 
            this.ballCoughtLabel.AutoSize = true;
            this.ballCoughtLabel.Location = new System.Drawing.Point(303, 22);
            this.ballCoughtLabel.Name = "ballCoughtLabel";
            this.ballCoughtLabel.Size = new System.Drawing.Size(40, 13);
            this.ballCoughtLabel.TabIndex = 2;
            this.ballCoughtLabel.Text = "кол-во";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Жизни";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Счет игры";
            // 
            // FruitNinjaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ballCoughtLabel);
            this.Controls.Add(this.lifesCountLabel);
            this.Controls.Add(this.startButton);
            this.Name = "FruitNinjaForm";
            this.Text = "Form1";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FruitNinjaForm_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label lifesCountLabel;
        private System.Windows.Forms.Label ballCoughtLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

