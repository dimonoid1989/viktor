namespace GeniyIdiotWindowsFormsApp
{
    partial class GetNameFromUser
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
            this.askUserName = new System.Windows.Forms.Label();
            this.writeUserName = new System.Windows.Forms.TextBox();
            this.enterName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // askUserName
            // 
            this.askUserName.AutoSize = true;
            this.askUserName.Location = new System.Drawing.Point(25, 56);
            this.askUserName.Name = "askUserName";
            this.askUserName.Size = new System.Drawing.Size(152, 13);
            this.askUserName.TabIndex = 0;
            this.askUserName.Text = "Спросить имя пользователя";
            // 
            // writeUserName
            // 
            this.writeUserName.Location = new System.Drawing.Point(28, 99);
            this.writeUserName.Name = "writeUserName";
            this.writeUserName.Size = new System.Drawing.Size(159, 20);
            this.writeUserName.TabIndex = 1;
            this.writeUserName.Text = "Записать имя пользователя";
            // 
            // enterName
            // 
            this.enterName.Location = new System.Drawing.Point(28, 147);
            this.enterName.Name = "enterName";
            this.enterName.Size = new System.Drawing.Size(138, 23);
            this.enterName.TabIndex = 2;
            this.enterName.Text = "Подтверждение ввода";
            this.enterName.UseVisualStyleBackColor = true;
            this.enterName.Click += new System.EventHandler(this.enterName_Click);
            // 
            // GetNameFromUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 213);
            this.Controls.Add(this.enterName);
            this.Controls.Add(this.writeUserName);
            this.Controls.Add(this.askUserName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GetNameFromUser";
            this.Text = "Спросить имя";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GetNameFromUser_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label askUserName;
        public System.Windows.Forms.TextBox writeUserName;
        public System.Windows.Forms.Button enterName;
    }
}