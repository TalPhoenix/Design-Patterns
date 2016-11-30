namespace Factory_Method_Pattern
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
            this.btn_List = new System.Windows.Forms.Button();
            this.tb_list = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_List
            // 
            this.btn_List.Font = new System.Drawing.Font("Papyrus", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_List.Location = new System.Drawing.Point(54, 228);
            this.btn_List.Name = "btn_List";
            this.btn_List.Size = new System.Drawing.Size(322, 149);
            this.btn_List.TabIndex = 0;
            this.btn_List.Text = "Create Game Template";
            this.btn_List.UseVisualStyleBackColor = true;
            this.btn_List.Click += new System.EventHandler(this.btn_List_Click);
            // 
            // tb_list
            // 
            this.tb_list.Location = new System.Drawing.Point(405, 56);
            this.tb_list.Multiline = true;
            this.tb_list.Name = "tb_list";
            this.tb_list.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_list.Size = new System.Drawing.Size(388, 582);
            this.tb_list.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(850, 666);
            this.Controls.Add(this.tb_list);
            this.Controls.Add(this.btn_List);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_List;
        private System.Windows.Forms.TextBox tb_list;
    }
}

