namespace PractWork5
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
            this.PTextBox = new System.Windows.Forms.TextBox();
            this.QTextBox = new System.Windows.Forms.TextBox();
            this.PLabel = new System.Windows.Forms.Label();
            this.QLabel = new System.Windows.Forms.Label();
            this.OriginTextBox = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.OriginLabel = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.PathButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PTextBox
            // 
            this.PTextBox.Location = new System.Drawing.Point(36, 24);
            this.PTextBox.Name = "PTextBox";
            this.PTextBox.Size = new System.Drawing.Size(100, 20);
            this.PTextBox.TabIndex = 0;
            this.PTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PTextBox_KeyPress);
            // 
            // QTextBox
            // 
            this.QTextBox.Location = new System.Drawing.Point(191, 24);
            this.QTextBox.Name = "QTextBox";
            this.QTextBox.Size = new System.Drawing.Size(100, 20);
            this.QTextBox.TabIndex = 1;
            this.QTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QTextBox_KeyPress);
            // 
            // PLabel
            // 
            this.PLabel.AutoSize = true;
            this.PLabel.Location = new System.Drawing.Point(33, 8);
            this.PLabel.Name = "PLabel";
            this.PLabel.Size = new System.Drawing.Size(13, 13);
            this.PLabel.TabIndex = 2;
            this.PLabel.Text = "p";
            // 
            // QLabel
            // 
            this.QLabel.AutoSize = true;
            this.QLabel.Location = new System.Drawing.Point(188, 5);
            this.QLabel.Name = "QLabel";
            this.QLabel.Size = new System.Drawing.Size(13, 13);
            this.QLabel.TabIndex = 3;
            this.QLabel.Text = "q";
            // 
            // OriginTextBox
            // 
            this.OriginTextBox.Enabled = false;
            this.OriginTextBox.Location = new System.Drawing.Point(36, 112);
            this.OriginTextBox.Name = "OriginTextBox";
            this.OriginTextBox.Size = new System.Drawing.Size(255, 20);
            this.OriginTextBox.TabIndex = 4;
            this.OriginTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OriginTextBox_KeyPress);
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Enabled = false;
            this.ResultTextBox.Location = new System.Drawing.Point(36, 211);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(255, 20);
            this.ResultTextBox.TabIndex = 5;
            // 
            // OriginLabel
            // 
            this.OriginLabel.AutoSize = true;
            this.OriginLabel.Location = new System.Drawing.Point(33, 96);
            this.OriginLabel.Name = "OriginLabel";
            this.OriginLabel.Size = new System.Drawing.Size(82, 13);
            this.OriginLabel.TabIndex = 6;
            this.OriginLabel.Text = "Выберите путь";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(33, 195);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(123, 13);
            this.ResultLabel.TabIndex = 7;
            this.ResultLabel.Text = "Зашифрованный текст";
            // 
            // EncryptButton
            // 
            this.EncryptButton.Location = new System.Drawing.Point(36, 258);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(100, 23);
            this.EncryptButton.TabIndex = 8;
            this.EncryptButton.Text = "Шифровать";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // DecryptButton
            // 
            this.DecryptButton.Location = new System.Drawing.Point(191, 258);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(100, 23);
            this.DecryptButton.TabIndex = 9;
            this.DecryptButton.Text = "Дешифровать";
            this.DecryptButton.UseVisualStyleBackColor = true;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // PathButton
            // 
            this.PathButton.Location = new System.Drawing.Point(297, 112);
            this.PathButton.Name = "PathButton";
            this.PathButton.Size = new System.Drawing.Size(26, 20);
            this.PathButton.TabIndex = 10;
            this.PathButton.Text = "...";
            this.PathButton.UseVisualStyleBackColor = true;
            this.PathButton.Click += new System.EventHandler(this.PathButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 303);
            this.Controls.Add(this.PathButton);
            this.Controls.Add(this.DecryptButton);
            this.Controls.Add(this.EncryptButton);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.OriginLabel);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.OriginTextBox);
            this.Controls.Add(this.QLabel);
            this.Controls.Add(this.PLabel);
            this.Controls.Add(this.QTextBox);
            this.Controls.Add(this.PTextBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(366, 342);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(366, 342);
            this.Name = "MainForm";
            this.Text = "Главная RSA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PTextBox;
        private System.Windows.Forms.TextBox QTextBox;
        private System.Windows.Forms.Label PLabel;
        private System.Windows.Forms.Label QLabel;
        private System.Windows.Forms.TextBox OriginTextBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Label OriginLabel;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.Button DecryptButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button PathButton;
    }
}

