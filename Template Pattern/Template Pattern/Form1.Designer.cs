namespace Template_Pattern
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
            this.btn_DisplayColors = new System.Windows.Forms.Button();
            this.tb_Colors = new System.Windows.Forms.TextBox();
            this.tb_ARGB = new System.Windows.Forms.TextBox();
            this.btn_ARGB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_DisplayColors
            // 
            this.btn_DisplayColors.BackColor = System.Drawing.Color.Blue;
            this.btn_DisplayColors.Font = new System.Drawing.Font("Papyrus", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DisplayColors.ForeColor = System.Drawing.Color.White;
            this.btn_DisplayColors.Location = new System.Drawing.Point(93, 502);
            this.btn_DisplayColors.Name = "btn_DisplayColors";
            this.btn_DisplayColors.Size = new System.Drawing.Size(202, 64);
            this.btn_DisplayColors.TabIndex = 0;
            this.btn_DisplayColors.Text = "Colors";
            this.btn_DisplayColors.UseVisualStyleBackColor = false;
            this.btn_DisplayColors.Click += new System.EventHandler(this.btn_DisplayColors_Click);
            // 
            // tb_Colors
            // 
            this.tb_Colors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Colors.Location = new System.Drawing.Point(42, 36);
            this.tb_Colors.Multiline = true;
            this.tb_Colors.Name = "tb_Colors";
            this.tb_Colors.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_Colors.Size = new System.Drawing.Size(311, 442);
            this.tb_Colors.TabIndex = 1;
            // 
            // tb_ARGB
            // 
            this.tb_ARGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ARGB.Location = new System.Drawing.Point(458, 36);
            this.tb_ARGB.Multiline = true;
            this.tb_ARGB.Name = "tb_ARGB";
            this.tb_ARGB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_ARGB.Size = new System.Drawing.Size(311, 442);
            this.tb_ARGB.TabIndex = 3;
            // 
            // btn_ARGB
            // 
            this.btn_ARGB.BackColor = System.Drawing.Color.Red;
            this.btn_ARGB.Font = new System.Drawing.Font("Papyrus", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ARGB.ForeColor = System.Drawing.Color.White;
            this.btn_ARGB.Location = new System.Drawing.Point(509, 502);
            this.btn_ARGB.Name = "btn_ARGB";
            this.btn_ARGB.Size = new System.Drawing.Size(202, 64);
            this.btn_ARGB.TabIndex = 2;
            this.btn_ARGB.Text = "ARGB";
            this.btn_ARGB.UseVisualStyleBackColor = false;
            this.btn_ARGB.Click += new System.EventHandler(this.btn_ARGB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(807, 588);
            this.Controls.Add(this.tb_ARGB);
            this.Controls.Add(this.btn_ARGB);
            this.Controls.Add(this.tb_Colors);
            this.Controls.Add(this.btn_DisplayColors);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_DisplayColors;
        private System.Windows.Forms.TextBox tb_Colors;
        private System.Windows.Forms.TextBox tb_ARGB;
        private System.Windows.Forms.Button btn_ARGB;
    }
}

