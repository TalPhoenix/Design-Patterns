namespace StrategyPattern
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
            this.btn_SortByName = new System.Windows.Forms.Button();
            this.btn_SortByBrightness = new System.Windows.Forms.Button();
            this.btn_SortByArgbValue = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_SortByName
            // 
            this.btn_SortByName.BackColor = System.Drawing.Color.Indigo;
            this.btn_SortByName.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SortByName.ForeColor = System.Drawing.Color.White;
            this.btn_SortByName.Location = new System.Drawing.Point(30, 37);
            this.btn_SortByName.Name = "btn_SortByName";
            this.btn_SortByName.Size = new System.Drawing.Size(148, 66);
            this.btn_SortByName.TabIndex = 0;
            this.btn_SortByName.Text = "Sort by Name";
            this.btn_SortByName.UseVisualStyleBackColor = false;
            this.btn_SortByName.Click += new System.EventHandler(this.btn_SorByName_Click);
            // 
            // btn_SortByBrightness
            // 
            this.btn_SortByBrightness.BackColor = System.Drawing.Color.Indigo;
            this.btn_SortByBrightness.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SortByBrightness.ForeColor = System.Drawing.Color.White;
            this.btn_SortByBrightness.Location = new System.Drawing.Point(30, 178);
            this.btn_SortByBrightness.Name = "btn_SortByBrightness";
            this.btn_SortByBrightness.Size = new System.Drawing.Size(148, 66);
            this.btn_SortByBrightness.TabIndex = 1;
            this.btn_SortByBrightness.Text = "Sort by Brightness";
            this.btn_SortByBrightness.UseVisualStyleBackColor = false;
            this.btn_SortByBrightness.Click += new System.EventHandler(this.btn_SortByBrightness_Click);
            // 
            // btn_SortByArgbValue
            // 
            this.btn_SortByArgbValue.BackColor = System.Drawing.Color.Indigo;
            this.btn_SortByArgbValue.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SortByArgbValue.ForeColor = System.Drawing.Color.White;
            this.btn_SortByArgbValue.Location = new System.Drawing.Point(30, 329);
            this.btn_SortByArgbValue.Name = "btn_SortByArgbValue";
            this.btn_SortByArgbValue.Size = new System.Drawing.Size(148, 66);
            this.btn_SortByArgbValue.TabIndex = 2;
            this.btn_SortByArgbValue.Text = "Sort by Argb Value";
            this.btn_SortByArgbValue.UseVisualStyleBackColor = false;
            this.btn_SortByArgbValue.Click += new System.EventHandler(this.btn_SortByArgbValue_Click);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.Silver;
            this.textBox5.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(236, 27);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox5.Size = new System.Drawing.Size(812, 563);
            this.textBox5.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.ClientSize = new System.Drawing.Size(1080, 623);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.btn_SortByArgbValue);
            this.Controls.Add(this.btn_SortByBrightness);
            this.Controls.Add(this.btn_SortByName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SortByName;
        private System.Windows.Forms.Button btn_SortByBrightness;
        private System.Windows.Forms.Button btn_SortByArgbValue;
        private System.Windows.Forms.TextBox textBox5;
    }
}

