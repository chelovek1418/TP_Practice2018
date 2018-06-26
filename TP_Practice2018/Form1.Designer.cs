namespace TP_Practice2018
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Clear_button = new System.Windows.Forms.Button();
            this.end_textBox = new System.Windows.Forms.TextBox();
            this.start_textBox = new System.Windows.Forms.TextBox();
            this.action_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Анаграмма";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Исходный текст";
            // 
            // Clear_button
            // 
            this.Clear_button.Location = new System.Drawing.Point(544, 138);
            this.Clear_button.Name = "Clear_button";
            this.Clear_button.Size = new System.Drawing.Size(97, 95);
            this.Clear_button.TabIndex = 9;
            this.Clear_button.Text = "Очистить";
            this.Clear_button.UseVisualStyleBackColor = true;
            this.Clear_button.Click += new System.EventHandler(this.Clear_button_Click);
            // 
            // end_textBox
            // 
            this.end_textBox.Location = new System.Drawing.Point(12, 138);
            this.end_textBox.Multiline = true;
            this.end_textBox.Name = "end_textBox";
            this.end_textBox.Size = new System.Drawing.Size(526, 95);
            this.end_textBox.TabIndex = 8;
            // 
            // start_textBox
            // 
            this.start_textBox.Location = new System.Drawing.Point(12, 24);
            this.start_textBox.Multiline = true;
            this.start_textBox.Name = "start_textBox";
            this.start_textBox.Size = new System.Drawing.Size(526, 95);
            this.start_textBox.TabIndex = 7;
            // 
            // action_button
            // 
            this.action_button.Location = new System.Drawing.Point(544, 24);
            this.action_button.Name = "action_button";
            this.action_button.Size = new System.Drawing.Size(97, 95);
            this.action_button.TabIndex = 6;
            this.action_button.Text = "Преобразовать";
            this.action_button.UseVisualStyleBackColor = true;
            this.action_button.Click += new System.EventHandler(this.action_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 239);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Clear_button);
            this.Controls.Add(this.end_textBox);
            this.Controls.Add(this.start_textBox);
            this.Controls.Add(this.action_button);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Clear_button;
        private System.Windows.Forms.TextBox end_textBox;
        private System.Windows.Forms.TextBox start_textBox;
        private System.Windows.Forms.Button action_button;
    }
}

