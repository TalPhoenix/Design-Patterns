namespace ProxyPattern
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
            this.tb_1 = new System.Windows.Forms.TextBox();
            this.tb_2 = new System.Windows.Forms.TextBox();
            this.tb_3 = new System.Windows.Forms.TextBox();
            this.tb_4 = new System.Windows.Forms.TextBox();
            this.pnl_MyColor = new System.Windows.Forms.Panel();
            this.btn_ShowDialog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_1
            // 
            this.tb_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_1.Location = new System.Drawing.Point(39, 41);
            this.tb_1.Name = "tb_1";
            this.tb_1.Size = new System.Drawing.Size(475, 30);
            this.tb_1.TabIndex = 0;
            // 
            // tb_2
            // 
            this.tb_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_2.Location = new System.Drawing.Point(39, 105);
            this.tb_2.Name = "tb_2";
            this.tb_2.Size = new System.Drawing.Size(475, 30);
            this.tb_2.TabIndex = 1;
            // 
            // tb_3
            // 
            this.tb_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_3.Location = new System.Drawing.Point(39, 165);
            this.tb_3.Name = "tb_3";
            this.tb_3.Size = new System.Drawing.Size(475, 30);
            this.tb_3.TabIndex = 2;
            // 
            // tb_4
            // 
            this.tb_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_4.Location = new System.Drawing.Point(39, 225);
            this.tb_4.Name = "tb_4";
            this.tb_4.Size = new System.Drawing.Size(475, 30);
            this.tb_4.TabIndex = 3;
            // 
            // pnl_MyColor
            // 
            this.pnl_MyColor.BackColor = System.Drawing.Color.White;
            this.pnl_MyColor.Location = new System.Drawing.Point(546, 179);
            this.pnl_MyColor.Name = "pnl_MyColor";
            this.pnl_MyColor.Size = new System.Drawing.Size(275, 264);
            this.pnl_MyColor.TabIndex = 4;
            // 
            // btn_ShowDialog
            // 
            this.btn_ShowDialog.BackColor = System.Drawing.Color.Black;
            this.btn_ShowDialog.Font = new System.Drawing.Font("Papyrus", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ShowDialog.ForeColor = System.Drawing.Color.BlueViolet;
            this.btn_ShowDialog.Location = new System.Drawing.Point(133, 311);
            this.btn_ShowDialog.Name = "btn_ShowDialog";
            this.btn_ShowDialog.Size = new System.Drawing.Size(261, 86);
            this.btn_ShowDialog.TabIndex = 5;
            this.btn_ShowDialog.Text = "Select Color";
            this.btn_ShowDialog.UseVisualStyleBackColor = false;
            this.btn_ShowDialog.Click += new System.EventHandler(this.btn_ShowDialog_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(857, 472);
            this.Controls.Add(this.btn_ShowDialog);
            this.Controls.Add(this.pnl_MyColor);
            this.Controls.Add(this.tb_4);
            this.Controls.Add(this.tb_3);
            this.Controls.Add(this.tb_2);
            this.Controls.Add(this.tb_1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_1;
        private System.Windows.Forms.TextBox tb_2;
        private System.Windows.Forms.TextBox tb_3;
        private System.Windows.Forms.TextBox tb_4;
        private System.Windows.Forms.Panel pnl_MyColor;
        private System.Windows.Forms.Button btn_ShowDialog;
    }
}

