namespace Chat_Bot
{
    partial class FormUser
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
            this.label_name = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.button_start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(149, 121);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(93, 16);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "Введите имя:";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(152, 155);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(152, 22);
            this.textBox_name.TabIndex = 1;
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(152, 206);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(152, 23);
            this.button_start.TabIndex = 2;
            this.button_start.Text = "Запустить бота";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 344);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_name);
            this.Name = "FormUser";
            this.Text = "Имя пользователя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Button button_start;
    }
}

