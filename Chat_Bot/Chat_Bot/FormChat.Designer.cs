namespace Chat_Bot
{
    partial class FormChat
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
            this.textBox_chat = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox_request = new System.Windows.Forms.TextBox();
            this.button_request = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_chat
            // 
            this.textBox_chat.Location = new System.Drawing.Point(26, 49);
            this.textBox_chat.Multiline = true;
            this.textBox_chat.Name = "textBox_chat";
            this.textBox_chat.Size = new System.Drawing.Size(482, 422);
            this.textBox_chat.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(764, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // textBox_request
            // 
            this.textBox_request.Location = new System.Drawing.Point(549, 236);
            this.textBox_request.Name = "textBox_request";
            this.textBox_request.Size = new System.Drawing.Size(182, 22);
            this.textBox_request.TabIndex = 2;
            // 
            // button_request
            // 
            this.button_request.Location = new System.Drawing.Point(549, 264);
            this.button_request.Name = "button_request";
            this.button_request.Size = new System.Drawing.Size(182, 35);
            this.button_request.TabIndex = 3;
            this.button_request.Text = "Отправить запрос";
            this.button_request.UseVisualStyleBackColor = true;
            this.button_request.Click += new System.EventHandler(this.button_request_Click);
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(26, 487);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(169, 35);
            this.button_clear.TabIndex = 4;
            this.button_clear.Text = "Очистить поле";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // FormChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 535);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_request);
            this.Controls.Add(this.textBox_request);
            this.Controls.Add(this.textBox_chat);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormChat";
            this.Text = "Чат-бот";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormChat_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_chat;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox_request;
        private System.Windows.Forms.Button button_request;
        private System.Windows.Forms.Button button_clear;
    }
}