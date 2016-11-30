namespace State_Example
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
            this.tb_GradeBook = new System.Windows.Forms.TextBox();
            this.cb_Assignments = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Grade = new System.Windows.Forms.TextBox();
            this.btn_GradeBookEntry = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_GradeBook
            // 
            this.tb_GradeBook.Location = new System.Drawing.Point(437, 101);
            this.tb_GradeBook.Multiline = true;
            this.tb_GradeBook.Name = "tb_GradeBook";
            this.tb_GradeBook.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_GradeBook.Size = new System.Drawing.Size(469, 541);
            this.tb_GradeBook.TabIndex = 0;
            // 
            // cb_Assignments
            // 
            this.cb_Assignments.FormattingEnabled = true;
            this.cb_Assignments.Items.AddRange(new object[] {
            "Quiz",
            "Midterm",
            "Final"});
            this.cb_Assignments.Location = new System.Drawing.Point(66, 101);
            this.cb_Assignments.Name = "cb_Assignments";
            this.cb_Assignments.Size = new System.Drawing.Size(214, 37);
            this.cb_Assignments.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Assignment";
            // 
            // tb_Grade
            // 
            this.tb_Grade.Location = new System.Drawing.Point(66, 237);
            this.tb_Grade.Name = "tb_Grade";
            this.tb_Grade.Size = new System.Drawing.Size(265, 35);
            this.tb_Grade.TabIndex = 3;
            // 
            // btn_GradeBookEntry
            // 
            this.btn_GradeBookEntry.BackColor = System.Drawing.Color.DimGray;
            this.btn_GradeBookEntry.Location = new System.Drawing.Point(66, 421);
            this.btn_GradeBookEntry.Name = "btn_GradeBookEntry";
            this.btn_GradeBookEntry.Size = new System.Drawing.Size(209, 71);
            this.btn_GradeBookEntry.TabIndex = 4;
            this.btn_GradeBookEntry.Text = "Post Grade";
            this.btn_GradeBookEntry.UseVisualStyleBackColor = false;
            this.btn_GradeBookEntry.Click += new System.EventHandler(this.btn_GradeBookEntry_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Points Earned";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(432, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Grade Book";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(949, 676);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_GradeBookEntry);
            this.Controls.Add(this.tb_Grade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_Assignments);
            this.Controls.Add(this.tb_GradeBook);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_GradeBook;
        private System.Windows.Forms.ComboBox cb_Assignments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Grade;
        private System.Windows.Forms.Button btn_GradeBookEntry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

