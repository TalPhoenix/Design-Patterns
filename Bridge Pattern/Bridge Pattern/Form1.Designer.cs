namespace Bridge_Pattern
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
            this.btn_AddMovie = new System.Windows.Forms.Button();
            this.tb_list = new System.Windows.Forms.TextBox();
            this.tb_movie = new System.Windows.Forms.TextBox();
            this.btn_NextMovie = new System.Windows.Forms.Button();
            this.btn_PreviousMovie = new System.Windows.Forms.Button();
            this.btn_ShowAll = new System.Windows.Forms.Button();
            this.btn_CurrentMovie = new System.Windows.Forms.Button();
            this.btn_First = new System.Windows.Forms.Button();
            this.btn_Last = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_AddMovie
            // 
            this.btn_AddMovie.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_AddMovie.Font = new System.Drawing.Font("Papyrus", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddMovie.ForeColor = System.Drawing.Color.Cyan;
            this.btn_AddMovie.Location = new System.Drawing.Point(176, 216);
            this.btn_AddMovie.Name = "btn_AddMovie";
            this.btn_AddMovie.Size = new System.Drawing.Size(318, 80);
            this.btn_AddMovie.TabIndex = 0;
            this.btn_AddMovie.Text = "Add Movie";
            this.btn_AddMovie.UseVisualStyleBackColor = false;
            this.btn_AddMovie.Click += new System.EventHandler(this.btn_AddMovie_Click);
            // 
            // tb_list
            // 
            this.tb_list.BackColor = System.Drawing.Color.Silver;
            this.tb_list.Font = new System.Drawing.Font("Papyrus", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_list.ForeColor = System.Drawing.Color.Blue;
            this.tb_list.Location = new System.Drawing.Point(654, 88);
            this.tb_list.Multiline = true;
            this.tb_list.Name = "tb_list";
            this.tb_list.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_list.Size = new System.Drawing.Size(564, 990);
            this.tb_list.TabIndex = 2;
            // 
            // tb_movie
            // 
            this.tb_movie.BackColor = System.Drawing.Color.Silver;
            this.tb_movie.Font = new System.Drawing.Font("Papyrus", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_movie.ForeColor = System.Drawing.Color.Blue;
            this.tb_movie.Location = new System.Drawing.Point(107, 88);
            this.tb_movie.Name = "tb_movie";
            this.tb_movie.Size = new System.Drawing.Size(478, 50);
            this.tb_movie.TabIndex = 3;
            // 
            // btn_NextMovie
            // 
            this.btn_NextMovie.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_NextMovie.Font = new System.Drawing.Font("Papyrus", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NextMovie.ForeColor = System.Drawing.Color.Cyan;
            this.btn_NextMovie.Location = new System.Drawing.Point(176, 450);
            this.btn_NextMovie.Name = "btn_NextMovie";
            this.btn_NextMovie.Size = new System.Drawing.Size(318, 80);
            this.btn_NextMovie.TabIndex = 4;
            this.btn_NextMovie.Text = "Next Movie";
            this.btn_NextMovie.UseVisualStyleBackColor = false;
            this.btn_NextMovie.Click += new System.EventHandler(this.btn_NextMovie_Click);
            // 
            // btn_PreviousMovie
            // 
            this.btn_PreviousMovie.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_PreviousMovie.Font = new System.Drawing.Font("Papyrus", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PreviousMovie.ForeColor = System.Drawing.Color.Cyan;
            this.btn_PreviousMovie.Location = new System.Drawing.Point(176, 565);
            this.btn_PreviousMovie.Name = "btn_PreviousMovie";
            this.btn_PreviousMovie.Size = new System.Drawing.Size(318, 80);
            this.btn_PreviousMovie.TabIndex = 5;
            this.btn_PreviousMovie.Text = "Previous Movie";
            this.btn_PreviousMovie.UseVisualStyleBackColor = false;
            this.btn_PreviousMovie.Click += new System.EventHandler(this.btn_PreviousMovie_Click);
            // 
            // btn_ShowAll
            // 
            this.btn_ShowAll.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_ShowAll.Font = new System.Drawing.Font("Papyrus", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ShowAll.ForeColor = System.Drawing.Color.Cyan;
            this.btn_ShowAll.Location = new System.Drawing.Point(176, 332);
            this.btn_ShowAll.Name = "btn_ShowAll";
            this.btn_ShowAll.Size = new System.Drawing.Size(318, 80);
            this.btn_ShowAll.TabIndex = 6;
            this.btn_ShowAll.Text = "Show All Movies";
            this.btn_ShowAll.UseVisualStyleBackColor = false;
            this.btn_ShowAll.Click += new System.EventHandler(this.btn_ShowAll_Click);
            // 
            // btn_CurrentMovie
            // 
            this.btn_CurrentMovie.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_CurrentMovie.Font = new System.Drawing.Font("Papyrus", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CurrentMovie.ForeColor = System.Drawing.Color.Cyan;
            this.btn_CurrentMovie.Location = new System.Drawing.Point(176, 681);
            this.btn_CurrentMovie.Name = "btn_CurrentMovie";
            this.btn_CurrentMovie.Size = new System.Drawing.Size(318, 80);
            this.btn_CurrentMovie.TabIndex = 7;
            this.btn_CurrentMovie.Text = "Current Movie";
            this.btn_CurrentMovie.UseVisualStyleBackColor = false;
            this.btn_CurrentMovie.Click += new System.EventHandler(this.btn_CurrentMovie_Click);
            // 
            // btn_First
            // 
            this.btn_First.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_First.Font = new System.Drawing.Font("Papyrus", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_First.ForeColor = System.Drawing.Color.Cyan;
            this.btn_First.Location = new System.Drawing.Point(176, 797);
            this.btn_First.Name = "btn_First";
            this.btn_First.Size = new System.Drawing.Size(318, 80);
            this.btn_First.TabIndex = 8;
            this.btn_First.Text = "First Movie";
            this.btn_First.UseVisualStyleBackColor = false;
            this.btn_First.Click += new System.EventHandler(this.btn_First_Click);
            // 
            // btn_Last
            // 
            this.btn_Last.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Last.Font = new System.Drawing.Font("Papyrus", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Last.ForeColor = System.Drawing.Color.Cyan;
            this.btn_Last.Location = new System.Drawing.Point(176, 911);
            this.btn_Last.Name = "btn_Last";
            this.btn_Last.Size = new System.Drawing.Size(318, 80);
            this.btn_Last.TabIndex = 9;
            this.btn_Last.Text = "Last Movie";
            this.btn_Last.UseVisualStyleBackColor = false;
            this.btn_Last.Click += new System.EventHandler(this.btn_Last_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1302, 1162);
            this.Controls.Add(this.btn_Last);
            this.Controls.Add(this.btn_First);
            this.Controls.Add(this.btn_CurrentMovie);
            this.Controls.Add(this.btn_ShowAll);
            this.Controls.Add(this.btn_PreviousMovie);
            this.Controls.Add(this.btn_NextMovie);
            this.Controls.Add(this.tb_movie);
            this.Controls.Add(this.tb_list);
            this.Controls.Add(this.btn_AddMovie);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AddMovie;
        private System.Windows.Forms.TextBox tb_list;
        private System.Windows.Forms.TextBox tb_movie;
        private System.Windows.Forms.Button btn_NextMovie;
        private System.Windows.Forms.Button btn_PreviousMovie;
        private System.Windows.Forms.Button btn_ShowAll;
        private System.Windows.Forms.Button btn_CurrentMovie;
        private System.Windows.Forms.Button btn_First;
        private System.Windows.Forms.Button btn_Last;
    }
}

