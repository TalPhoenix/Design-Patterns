namespace Command_and_Adapter
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
            this.btn_Undo = new System.Windows.Forms.Button();
            this.btn_Redo = new System.Windows.Forms.Button();
            this.tb_Display = new System.Windows.Forms.TextBox();
            this.tb_Operator = new System.Windows.Forms.TextBox();
            this.btn_OperatorPlus = new System.Windows.Forms.Button();
            this.btn_OperatorMinus = new System.Windows.Forms.Button();
            this.tb_NewValue = new System.Windows.Forms.TextBox();
            this.btn_OperatorMultiply = new System.Windows.Forms.Button();
            this.btn_OperatorDivide = new System.Windows.Forms.Button();
            this.btn_Value1 = new System.Windows.Forms.Button();
            this.btn_Value2 = new System.Windows.Forms.Button();
            this.btn_Value3 = new System.Windows.Forms.Button();
            this.btn_Value6 = new System.Windows.Forms.Button();
            this.btn_Value5 = new System.Windows.Forms.Button();
            this.btn_Value4 = new System.Windows.Forms.Button();
            this.btn_Value9 = new System.Windows.Forms.Button();
            this.btn_Value8 = new System.Windows.Forms.Button();
            this.btn_Value7 = new System.Windows.Forms.Button();
            this.btn_ValueDecimalPoint = new System.Windows.Forms.Button();
            this.btn_Value0 = new System.Windows.Forms.Button();
            this.btn_ValueDelete = new System.Windows.Forms.Button();
            this.btn_SubmitChange = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Undo
            // 
            this.btn_Undo.BackColor = System.Drawing.Color.BlueViolet;
            this.btn_Undo.Font = new System.Drawing.Font("Papyrus", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Undo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Undo.Location = new System.Drawing.Point(700, 605);
            this.btn_Undo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_Undo.Name = "btn_Undo";
            this.btn_Undo.Size = new System.Drawing.Size(210, 109);
            this.btn_Undo.TabIndex = 1;
            this.btn_Undo.Text = "Undo";
            this.btn_Undo.UseVisualStyleBackColor = false;
            this.btn_Undo.Click += new System.EventHandler(this.btn_Undo_Click_1);
            // 
            // btn_Redo
            // 
            this.btn_Redo.BackColor = System.Drawing.Color.BlueViolet;
            this.btn_Redo.Font = new System.Drawing.Font("Papyrus", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Redo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Redo.Location = new System.Drawing.Point(700, 736);
            this.btn_Redo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_Redo.Name = "btn_Redo";
            this.btn_Redo.Size = new System.Drawing.Size(210, 109);
            this.btn_Redo.TabIndex = 2;
            this.btn_Redo.Text = "Redo";
            this.btn_Redo.UseVisualStyleBackColor = false;
            this.btn_Redo.Click += new System.EventHandler(this.btn_Redo_Click);
            // 
            // tb_Display
            // 
            this.tb_Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Display.Location = new System.Drawing.Point(72, 125);
            this.tb_Display.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tb_Display.Name = "tb_Display";
            this.tb_Display.Size = new System.Drawing.Size(835, 62);
            this.tb_Display.TabIndex = 13;
            this.tb_Display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_Operator
            // 
            this.tb_Operator.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Operator.Location = new System.Drawing.Point(653, 353);
            this.tb_Operator.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tb_Operator.Name = "tb_Operator";
            this.tb_Operator.Size = new System.Drawing.Size(252, 62);
            this.tb_Operator.TabIndex = 14;
            this.tb_Operator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_OperatorPlus
            // 
            this.btn_OperatorPlus.BackColor = System.Drawing.Color.LawnGreen;
            this.btn_OperatorPlus.Font = new System.Drawing.Font("Papyrus", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OperatorPlus.Location = new System.Drawing.Point(474, 420);
            this.btn_OperatorPlus.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_OperatorPlus.Name = "btn_OperatorPlus";
            this.btn_OperatorPlus.Size = new System.Drawing.Size(117, 102);
            this.btn_OperatorPlus.TabIndex = 15;
            this.btn_OperatorPlus.Text = "+";
            this.btn_OperatorPlus.UseVisualStyleBackColor = false;
            this.btn_OperatorPlus.Click += new System.EventHandler(this.btn_OperatorPlus_Click);
            // 
            // btn_OperatorMinus
            // 
            this.btn_OperatorMinus.BackColor = System.Drawing.Color.LawnGreen;
            this.btn_OperatorMinus.Font = new System.Drawing.Font("Papyrus", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OperatorMinus.Location = new System.Drawing.Point(474, 529);
            this.btn_OperatorMinus.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_OperatorMinus.Name = "btn_OperatorMinus";
            this.btn_OperatorMinus.Size = new System.Drawing.Size(117, 102);
            this.btn_OperatorMinus.TabIndex = 16;
            this.btn_OperatorMinus.Text = "-";
            this.btn_OperatorMinus.UseVisualStyleBackColor = false;
            this.btn_OperatorMinus.Click += new System.EventHandler(this.btn_OperatorMinus_Click);
            // 
            // tb_NewValue
            // 
            this.tb_NewValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_NewValue.Location = new System.Drawing.Point(72, 237);
            this.tb_NewValue.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tb_NewValue.Name = "tb_NewValue";
            this.tb_NewValue.Size = new System.Drawing.Size(835, 62);
            this.tb_NewValue.TabIndex = 17;
            this.tb_NewValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_OperatorMultiply
            // 
            this.btn_OperatorMultiply.BackColor = System.Drawing.Color.LawnGreen;
            this.btn_OperatorMultiply.Font = new System.Drawing.Font("Papyrus", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OperatorMultiply.Location = new System.Drawing.Point(474, 640);
            this.btn_OperatorMultiply.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_OperatorMultiply.Name = "btn_OperatorMultiply";
            this.btn_OperatorMultiply.Size = new System.Drawing.Size(117, 102);
            this.btn_OperatorMultiply.TabIndex = 18;
            this.btn_OperatorMultiply.Text = "*";
            this.btn_OperatorMultiply.UseVisualStyleBackColor = false;
            this.btn_OperatorMultiply.Click += new System.EventHandler(this.btn_OperatorMultiply_Click);
            // 
            // btn_OperatorDivide
            // 
            this.btn_OperatorDivide.BackColor = System.Drawing.Color.LawnGreen;
            this.btn_OperatorDivide.Font = new System.Drawing.Font("Papyrus", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OperatorDivide.Location = new System.Drawing.Point(474, 749);
            this.btn_OperatorDivide.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_OperatorDivide.Name = "btn_OperatorDivide";
            this.btn_OperatorDivide.Size = new System.Drawing.Size(117, 102);
            this.btn_OperatorDivide.TabIndex = 19;
            this.btn_OperatorDivide.Text = "/";
            this.btn_OperatorDivide.UseVisualStyleBackColor = false;
            this.btn_OperatorDivide.Click += new System.EventHandler(this.btn_OperatorDivide_Click);
            // 
            // btn_Value1
            // 
            this.btn_Value1.BackColor = System.Drawing.Color.BlueViolet;
            this.btn_Value1.Font = new System.Drawing.Font("Papyrus", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Value1.ForeColor = System.Drawing.Color.White;
            this.btn_Value1.Location = new System.Drawing.Point(72, 420);
            this.btn_Value1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_Value1.Name = "btn_Value1";
            this.btn_Value1.Size = new System.Drawing.Size(117, 102);
            this.btn_Value1.TabIndex = 20;
            this.btn_Value1.Text = "1";
            this.btn_Value1.UseVisualStyleBackColor = false;
            this.btn_Value1.Click += new System.EventHandler(this.btn_Value1_Click);
            // 
            // btn_Value2
            // 
            this.btn_Value2.BackColor = System.Drawing.Color.BlueViolet;
            this.btn_Value2.Font = new System.Drawing.Font("Papyrus", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Value2.ForeColor = System.Drawing.Color.White;
            this.btn_Value2.Location = new System.Drawing.Point(198, 420);
            this.btn_Value2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_Value2.Name = "btn_Value2";
            this.btn_Value2.Size = new System.Drawing.Size(117, 102);
            this.btn_Value2.TabIndex = 21;
            this.btn_Value2.Text = "2";
            this.btn_Value2.UseVisualStyleBackColor = false;
            this.btn_Value2.Click += new System.EventHandler(this.btn_Value2_Click);
            // 
            // btn_Value3
            // 
            this.btn_Value3.BackColor = System.Drawing.Color.BlueViolet;
            this.btn_Value3.Font = new System.Drawing.Font("Papyrus", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Value3.ForeColor = System.Drawing.Color.White;
            this.btn_Value3.Location = new System.Drawing.Point(324, 420);
            this.btn_Value3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_Value3.Name = "btn_Value3";
            this.btn_Value3.Size = new System.Drawing.Size(117, 102);
            this.btn_Value3.TabIndex = 22;
            this.btn_Value3.Text = "3";
            this.btn_Value3.UseVisualStyleBackColor = false;
            this.btn_Value3.Click += new System.EventHandler(this.btn_Value3_Click);
            // 
            // btn_Value6
            // 
            this.btn_Value6.BackColor = System.Drawing.Color.BlueViolet;
            this.btn_Value6.Font = new System.Drawing.Font("Papyrus", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Value6.ForeColor = System.Drawing.Color.White;
            this.btn_Value6.Location = new System.Drawing.Point(324, 529);
            this.btn_Value6.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_Value6.Name = "btn_Value6";
            this.btn_Value6.Size = new System.Drawing.Size(117, 102);
            this.btn_Value6.TabIndex = 25;
            this.btn_Value6.Text = "6";
            this.btn_Value6.UseVisualStyleBackColor = false;
            this.btn_Value6.Click += new System.EventHandler(this.btn_Value6_Click);
            // 
            // btn_Value5
            // 
            this.btn_Value5.BackColor = System.Drawing.Color.BlueViolet;
            this.btn_Value5.Font = new System.Drawing.Font("Papyrus", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Value5.ForeColor = System.Drawing.Color.White;
            this.btn_Value5.Location = new System.Drawing.Point(198, 529);
            this.btn_Value5.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_Value5.Name = "btn_Value5";
            this.btn_Value5.Size = new System.Drawing.Size(117, 102);
            this.btn_Value5.TabIndex = 24;
            this.btn_Value5.Text = "5";
            this.btn_Value5.UseVisualStyleBackColor = false;
            this.btn_Value5.Click += new System.EventHandler(this.btn_Value5_Click);
            // 
            // btn_Value4
            // 
            this.btn_Value4.BackColor = System.Drawing.Color.BlueViolet;
            this.btn_Value4.Font = new System.Drawing.Font("Papyrus", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Value4.ForeColor = System.Drawing.Color.White;
            this.btn_Value4.Location = new System.Drawing.Point(72, 529);
            this.btn_Value4.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_Value4.Name = "btn_Value4";
            this.btn_Value4.Size = new System.Drawing.Size(117, 102);
            this.btn_Value4.TabIndex = 23;
            this.btn_Value4.Text = "4";
            this.btn_Value4.UseVisualStyleBackColor = false;
            this.btn_Value4.Click += new System.EventHandler(this.btn_Value4_Click);
            // 
            // btn_Value9
            // 
            this.btn_Value9.BackColor = System.Drawing.Color.BlueViolet;
            this.btn_Value9.Font = new System.Drawing.Font("Papyrus", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Value9.ForeColor = System.Drawing.Color.White;
            this.btn_Value9.Location = new System.Drawing.Point(324, 640);
            this.btn_Value9.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_Value9.Name = "btn_Value9";
            this.btn_Value9.Size = new System.Drawing.Size(117, 102);
            this.btn_Value9.TabIndex = 28;
            this.btn_Value9.Text = "9";
            this.btn_Value9.UseVisualStyleBackColor = false;
            this.btn_Value9.Click += new System.EventHandler(this.btn_Value9_Click);
            // 
            // btn_Value8
            // 
            this.btn_Value8.BackColor = System.Drawing.Color.BlueViolet;
            this.btn_Value8.Font = new System.Drawing.Font("Papyrus", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Value8.ForeColor = System.Drawing.Color.White;
            this.btn_Value8.Location = new System.Drawing.Point(198, 640);
            this.btn_Value8.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_Value8.Name = "btn_Value8";
            this.btn_Value8.Size = new System.Drawing.Size(117, 102);
            this.btn_Value8.TabIndex = 27;
            this.btn_Value8.Text = "8";
            this.btn_Value8.UseVisualStyleBackColor = false;
            this.btn_Value8.Click += new System.EventHandler(this.btn_Value8_Click);
            // 
            // btn_Value7
            // 
            this.btn_Value7.BackColor = System.Drawing.Color.BlueViolet;
            this.btn_Value7.Font = new System.Drawing.Font("Papyrus", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Value7.ForeColor = System.Drawing.Color.White;
            this.btn_Value7.Location = new System.Drawing.Point(72, 640);
            this.btn_Value7.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_Value7.Name = "btn_Value7";
            this.btn_Value7.Size = new System.Drawing.Size(117, 102);
            this.btn_Value7.TabIndex = 26;
            this.btn_Value7.Text = "7";
            this.btn_Value7.UseVisualStyleBackColor = false;
            this.btn_Value7.Click += new System.EventHandler(this.btn_Value7_Click);
            // 
            // btn_ValueDecimalPoint
            // 
            this.btn_ValueDecimalPoint.BackColor = System.Drawing.Color.LawnGreen;
            this.btn_ValueDecimalPoint.Font = new System.Drawing.Font("Papyrus", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ValueDecimalPoint.Location = new System.Drawing.Point(72, 750);
            this.btn_ValueDecimalPoint.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_ValueDecimalPoint.Name = "btn_ValueDecimalPoint";
            this.btn_ValueDecimalPoint.Size = new System.Drawing.Size(117, 102);
            this.btn_ValueDecimalPoint.TabIndex = 29;
            this.btn_ValueDecimalPoint.Text = ".";
            this.btn_ValueDecimalPoint.UseVisualStyleBackColor = false;
            this.btn_ValueDecimalPoint.Visible = false;
            this.btn_ValueDecimalPoint.Click += new System.EventHandler(this.btn_ValueDecimalPoint_Click);
            // 
            // btn_Value0
            // 
            this.btn_Value0.BackColor = System.Drawing.Color.BlueViolet;
            this.btn_Value0.Font = new System.Drawing.Font("Papyrus", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Value0.ForeColor = System.Drawing.Color.White;
            this.btn_Value0.Location = new System.Drawing.Point(198, 749);
            this.btn_Value0.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_Value0.Name = "btn_Value0";
            this.btn_Value0.Size = new System.Drawing.Size(117, 102);
            this.btn_Value0.TabIndex = 30;
            this.btn_Value0.Text = "0";
            this.btn_Value0.UseVisualStyleBackColor = false;
            this.btn_Value0.Click += new System.EventHandler(this.button13_Click);
            // 
            // btn_ValueDelete
            // 
            this.btn_ValueDelete.BackColor = System.Drawing.Color.LawnGreen;
            this.btn_ValueDelete.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ValueDelete.Location = new System.Drawing.Point(324, 749);
            this.btn_ValueDelete.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_ValueDelete.Name = "btn_ValueDelete";
            this.btn_ValueDelete.Size = new System.Drawing.Size(117, 102);
            this.btn_ValueDelete.TabIndex = 31;
            this.btn_ValueDelete.Text = "Del";
            this.btn_ValueDelete.UseVisualStyleBackColor = false;
            this.btn_ValueDelete.Click += new System.EventHandler(this.btn_ValueDelete_Click);
            // 
            // btn_SubmitChange
            // 
            this.btn_SubmitChange.BackColor = System.Drawing.Color.BlueViolet;
            this.btn_SubmitChange.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SubmitChange.ForeColor = System.Drawing.Color.White;
            this.btn_SubmitChange.Location = new System.Drawing.Point(698, 450);
            this.btn_SubmitChange.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_SubmitChange.Name = "btn_SubmitChange";
            this.btn_SubmitChange.Size = new System.Drawing.Size(210, 136);
            this.btn_SubmitChange.TabIndex = 32;
            this.btn_SubmitChange.Text = "Submit Change";
            this.btn_SubmitChange.UseVisualStyleBackColor = false;
            this.btn_SubmitChange.Click += new System.EventHandler(this.btn_SubmitChange_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Papyrus", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(642, 311);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 42);
            this.label1.TabIndex = 33;
            this.label1.Text = "Selected Operator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Papyrus", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 197);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 42);
            this.label2.TabIndex = 34;
            this.label2.Text = "Value Entered";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Papyrus", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 42);
            this.label3.TabIndex = 35;
            this.label3.Text = "Display Results";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(1010, 939);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_SubmitChange);
            this.Controls.Add(this.btn_ValueDelete);
            this.Controls.Add(this.btn_Value0);
            this.Controls.Add(this.btn_ValueDecimalPoint);
            this.Controls.Add(this.btn_Value9);
            this.Controls.Add(this.btn_Value8);
            this.Controls.Add(this.btn_Value7);
            this.Controls.Add(this.btn_Value6);
            this.Controls.Add(this.btn_Value5);
            this.Controls.Add(this.btn_Value4);
            this.Controls.Add(this.btn_Value3);
            this.Controls.Add(this.btn_Value2);
            this.Controls.Add(this.btn_Value1);
            this.Controls.Add(this.btn_OperatorDivide);
            this.Controls.Add(this.btn_OperatorMultiply);
            this.Controls.Add(this.tb_NewValue);
            this.Controls.Add(this.btn_OperatorMinus);
            this.Controls.Add(this.btn_OperatorPlus);
            this.Controls.Add(this.tb_Operator);
            this.Controls.Add(this.tb_Display);
            this.Controls.Add(this.btn_Redo);
            this.Controls.Add(this.btn_Undo);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Tori\'s Calculator - Command/Adapter Pattern";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Undo;
        private System.Windows.Forms.Button btn_Redo;
        private System.Windows.Forms.TextBox tb_Display;
        private System.Windows.Forms.TextBox tb_Operator;
        private System.Windows.Forms.Button btn_OperatorPlus;
        private System.Windows.Forms.Button btn_OperatorMinus;
        private System.Windows.Forms.TextBox tb_NewValue;
        private System.Windows.Forms.Button btn_OperatorMultiply;
        private System.Windows.Forms.Button btn_OperatorDivide;
        private System.Windows.Forms.Button btn_Value1;
        private System.Windows.Forms.Button btn_Value2;
        private System.Windows.Forms.Button btn_Value3;
        private System.Windows.Forms.Button btn_Value6;
        private System.Windows.Forms.Button btn_Value5;
        private System.Windows.Forms.Button btn_Value4;
        private System.Windows.Forms.Button btn_Value9;
        private System.Windows.Forms.Button btn_Value8;
        private System.Windows.Forms.Button btn_Value7;
        private System.Windows.Forms.Button btn_ValueDecimalPoint;
        private System.Windows.Forms.Button btn_Value0;
        private System.Windows.Forms.Button btn_ValueDelete;
        private System.Windows.Forms.Button btn_SubmitChange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

