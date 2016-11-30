namespace Observer_Pattern
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.tb_Message = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Subject = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_MailTo = new System.Windows.Forms.TextBox();
            this.tb_SenderAccount = new System.Windows.Forms.TextBox();
            this.tb_AccountPassword = new System.Windows.Forms.TextBox();
            this.tb_SenderEmailAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(186, 748);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "Send Email";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_Message
            // 
            this.tb_Message.Location = new System.Drawing.Point(34, 416);
            this.tb_Message.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Message.Multiline = true;
            this.tb_Message.Name = "tb_Message";
            this.tb_Message.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_Message.Size = new System.Drawing.Size(465, 318);
            this.tb_Message.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 392);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Type your email message here:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 323);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Type the subject of your email:";
            // 
            // tb_Subject
            // 
            this.tb_Subject.Location = new System.Drawing.Point(34, 346);
            this.tb_Subject.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Subject.Multiline = true;
            this.tb_Subject.Name = "tb_Subject";
            this.tb_Subject.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_Subject.Size = new System.Drawing.Size(465, 34);
            this.tb_Subject.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 252);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(297, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Type who you want to send your email to:";
            // 
            // tb_MailTo
            // 
            this.tb_MailTo.Location = new System.Drawing.Point(34, 275);
            this.tb_MailTo.Margin = new System.Windows.Forms.Padding(2);
            this.tb_MailTo.Multiline = true;
            this.tb_MailTo.Name = "tb_MailTo";
            this.tb_MailTo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_MailTo.Size = new System.Drawing.Size(465, 34);
            this.tb_MailTo.TabIndex = 0;
            this.tb_MailTo.TextChanged += new System.EventHandler(this.tb_MailTo_TextChanged);
            // 
            // tb_SenderAccount
            // 
            this.tb_SenderAccount.Location = new System.Drawing.Point(34, 37);
            this.tb_SenderAccount.Margin = new System.Windows.Forms.Padding(2);
            this.tb_SenderAccount.Multiline = true;
            this.tb_SenderAccount.Name = "tb_SenderAccount";
            this.tb_SenderAccount.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_SenderAccount.Size = new System.Drawing.Size(465, 34);
            this.tb_SenderAccount.TabIndex = 7;
            // 
            // tb_AccountPassword
            // 
            this.tb_AccountPassword.Location = new System.Drawing.Point(34, 99);
            this.tb_AccountPassword.Margin = new System.Windows.Forms.Padding(2);
            this.tb_AccountPassword.Multiline = true;
            this.tb_AccountPassword.Name = "tb_AccountPassword";
            this.tb_AccountPassword.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_AccountPassword.Size = new System.Drawing.Size(465, 34);
            this.tb_AccountPassword.TabIndex = 8;
            this.tb_AccountPassword.Enter += new System.EventHandler(this.tb_AccountPassword_Enter);
            // 
            // tb_SenderEmailAddress
            // 
            this.tb_SenderEmailAddress.Location = new System.Drawing.Point(34, 156);
            this.tb_SenderEmailAddress.Margin = new System.Windows.Forms.Padding(2);
            this.tb_SenderEmailAddress.Multiline = true;
            this.tb_SenderEmailAddress.Name = "tb_SenderEmailAddress";
            this.tb_SenderEmailAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_SenderEmailAddress.Size = new System.Drawing.Size(465, 34);
            this.tb_SenderEmailAddress.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Sender User Account:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 77);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Account Password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 135);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Sender eMail Address:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 804);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_SenderEmailAddress);
            this.Controls.Add(this.tb_AccountPassword);
            this.Controls.Add(this.tb_SenderAccount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_MailTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_Subject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Message);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Assignment Reminder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_Message;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Subject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_MailTo;
        private System.Windows.Forms.TextBox tb_SenderAccount;
        private System.Windows.Forms.TextBox tb_AccountPassword;
        private System.Windows.Forms.TextBox tb_SenderEmailAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

