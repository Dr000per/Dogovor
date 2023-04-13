namespace Dogovor
{
    partial class NewPassword
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
            this.textBox_log = new System.Windows.Forms.TextBox();
            this.textBox_new_pass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_accept = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_log
            // 
            this.textBox_log.Location = new System.Drawing.Point(83, 61);
            this.textBox_log.Name = "textBox_log";
            this.textBox_log.Size = new System.Drawing.Size(207, 20);
            this.textBox_log.TabIndex = 0;
            // 
            // textBox_new_pass
            // 
            this.textBox_new_pass.Location = new System.Drawing.Point(83, 105);
            this.textBox_new_pass.Name = "textBox_new_pass";
            this.textBox_new_pass.Size = new System.Drawing.Size(207, 20);
            this.textBox_new_pass.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Новый пароль:";
            // 
            // button_accept
            // 
            this.button_accept.Location = new System.Drawing.Point(130, 131);
            this.button_accept.Name = "button_accept";
            this.button_accept.Size = new System.Drawing.Size(99, 28);
            this.button_accept.TabIndex = 4;
            this.button_accept.Text = "Принять";
            this.button_accept.UseVisualStyleBackColor = true;
            this.button_accept.Click += new System.EventHandler(this.button_accept_Click);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(145, 165);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(71, 30);
            this.button_close.TabIndex = 5;
            this.button_close.Text = "Отмена";
            this.button_close.UseVisualStyleBackColor = true;
            // 
            // NewPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 237);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_accept);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_new_pass);
            this.Controls.Add(this.textBox_log);
            this.Name = "NewPassword";
            this.Text = "NewPassword";
            this.Load += new System.EventHandler(this.NewPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_log;
        private System.Windows.Forms.TextBox textBox_new_pass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_accept;
        private System.Windows.Forms.Button button_close;
    }
}