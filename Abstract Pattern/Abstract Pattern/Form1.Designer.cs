namespace Abstract_Pattern
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
            this.btn_Battle = new System.Windows.Forms.Button();
            this.tb_Outcome = new System.Windows.Forms.TextBox();
            this.rb_Cindaquill = new System.Windows.Forms.RadioButton();
            this.rb_Charamander = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btn_Battle
            // 
            this.btn_Battle.BackColor = System.Drawing.Color.Fuchsia;
            this.btn_Battle.Font = new System.Drawing.Font("Papyrus", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Battle.ForeColor = System.Drawing.Color.White;
            this.btn_Battle.Location = new System.Drawing.Point(158, 269);
            this.btn_Battle.Name = "btn_Battle";
            this.btn_Battle.Size = new System.Drawing.Size(195, 73);
            this.btn_Battle.TabIndex = 0;
            this.btn_Battle.Text = "Battle";
            this.btn_Battle.UseVisualStyleBackColor = false;
            this.btn_Battle.Click += new System.EventHandler(this.btn_Battle_Click);
            // 
            // tb_Outcome
            // 
            this.tb_Outcome.Location = new System.Drawing.Point(536, 62);
            this.tb_Outcome.Multiline = true;
            this.tb_Outcome.Name = "tb_Outcome";
            this.tb_Outcome.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_Outcome.Size = new System.Drawing.Size(582, 264);
            this.tb_Outcome.TabIndex = 1;
            // 
            // rb_Cindaquill
            // 
            this.rb_Cindaquill.AutoSize = true;
            this.rb_Cindaquill.Font = new System.Drawing.Font("Papyrus", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Cindaquill.ForeColor = System.Drawing.Color.White;
            this.rb_Cindaquill.Location = new System.Drawing.Point(158, 56);
            this.rb_Cindaquill.Name = "rb_Cindaquill";
            this.rb_Cindaquill.Size = new System.Drawing.Size(195, 52);
            this.rb_Cindaquill.TabIndex = 5;
            this.rb_Cindaquill.TabStop = true;
            this.rb_Cindaquill.Text = "Cindaquill";
            this.rb_Cindaquill.UseVisualStyleBackColor = true;
            // 
            // rb_Charamander
            // 
            this.rb_Charamander.AutoSize = true;
            this.rb_Charamander.Font = new System.Drawing.Font("Papyrus", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Charamander.ForeColor = System.Drawing.Color.White;
            this.rb_Charamander.Location = new System.Drawing.Point(158, 144);
            this.rb_Charamander.Name = "rb_Charamander";
            this.rb_Charamander.Size = new System.Drawing.Size(242, 52);
            this.rb_Charamander.TabIndex = 6;
            this.rb_Charamander.TabStop = true;
            this.rb_Charamander.Text = "Charamander";
            this.rb_Charamander.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(1187, 389);
            this.Controls.Add(this.rb_Charamander);
            this.Controls.Add(this.rb_Cindaquill);
            this.Controls.Add(this.tb_Outcome);
            this.Controls.Add(this.btn_Battle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Battle;
        private System.Windows.Forms.TextBox tb_Outcome;
        private System.Windows.Forms.RadioButton rb_Cindaquill;
        private System.Windows.Forms.RadioButton rb_Charamander;
    }
}

