namespace Composite_Pattern
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_MixedMedia = new System.Windows.Forms.Button();
            this.btn_Watercolor = new System.Windows.Forms.Button();
            this.btn_Acrylic = new System.Windows.Forms.Button();
            this.tb_DisplayData = new System.Windows.Forms.TextBox();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.acrylicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.waterColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mixedmediaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_MixedMedia
            // 
            this.btn_MixedMedia.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_MixedMedia.Font = new System.Drawing.Font("Papyrus", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MixedMedia.Location = new System.Drawing.Point(20, 313);
            this.btn_MixedMedia.Margin = new System.Windows.Forms.Padding(2);
            this.btn_MixedMedia.Name = "btn_MixedMedia";
            this.btn_MixedMedia.Size = new System.Drawing.Size(129, 58);
            this.btn_MixedMedia.TabIndex = 0;
            this.btn_MixedMedia.Text = "Mixed Media";
            this.btn_MixedMedia.UseVisualStyleBackColor = false;
            this.btn_MixedMedia.Click += new System.EventHandler(this.btn_MixedMedia_Click);
            // 
            // btn_Watercolor
            // 
            this.btn_Watercolor.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_Watercolor.Font = new System.Drawing.Font("Papyrus", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Watercolor.Location = new System.Drawing.Point(20, 216);
            this.btn_Watercolor.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Watercolor.Name = "btn_Watercolor";
            this.btn_Watercolor.Size = new System.Drawing.Size(129, 58);
            this.btn_Watercolor.TabIndex = 1;
            this.btn_Watercolor.Text = "Watercolor";
            this.btn_Watercolor.UseVisualStyleBackColor = false;
            this.btn_Watercolor.Click += new System.EventHandler(this.btn_Watercolor_Click);
            // 
            // btn_Acrylic
            // 
            this.btn_Acrylic.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_Acrylic.Font = new System.Drawing.Font("Papyrus", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Acrylic.Location = new System.Drawing.Point(20, 120);
            this.btn_Acrylic.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Acrylic.Name = "btn_Acrylic";
            this.btn_Acrylic.Size = new System.Drawing.Size(129, 58);
            this.btn_Acrylic.TabIndex = 2;
            this.btn_Acrylic.Text = "Acrylic";
            this.btn_Acrylic.UseVisualStyleBackColor = false;
            this.btn_Acrylic.Click += new System.EventHandler(this.btn_Acrylic_Click);
            // 
            // tb_DisplayData
            // 
            this.tb_DisplayData.BackColor = System.Drawing.Color.DimGray;
            this.tb_DisplayData.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_DisplayData.ForeColor = System.Drawing.Color.DarkOrange;
            this.tb_DisplayData.Location = new System.Drawing.Point(179, 37);
            this.tb_DisplayData.Margin = new System.Windows.Forms.Padding(2);
            this.tb_DisplayData.Multiline = true;
            this.tb_DisplayData.Name = "tb_DisplayData";
            this.tb_DisplayData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_DisplayData.Size = new System.Drawing.Size(444, 465);
            this.tb_DisplayData.TabIndex = 3;
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.BackColor = System.Drawing.Color.Black;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Papyrus", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripTextBox1.ForeColor = System.Drawing.Color.DarkOrange;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(130, 31);
            this.toolStripTextBox1.Text = "Make a Supply List";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.BackColor = System.Drawing.Color.DarkOrange;
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acrylicToolStripMenuItem,
            this.waterColorToolStripMenuItem,
            this.mixedmediaToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(37, 28);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // acrylicToolStripMenuItem
            // 
            this.acrylicToolStripMenuItem.BackColor = System.Drawing.Color.DarkOrange;
            this.acrylicToolStripMenuItem.Name = "acrylicToolStripMenuItem";
            this.acrylicToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.acrylicToolStripMenuItem.Text = "Acrylic";
            this.acrylicToolStripMenuItem.Click += new System.EventHandler(this.acrylicToolStripMenuItem_Click);
            // 
            // waterColorToolStripMenuItem
            // 
            this.waterColorToolStripMenuItem.BackColor = System.Drawing.Color.DarkOrange;
            this.waterColorToolStripMenuItem.Name = "waterColorToolStripMenuItem";
            this.waterColorToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.waterColorToolStripMenuItem.Text = "WaterColor";
            this.waterColorToolStripMenuItem.Click += new System.EventHandler(this.waterColorToolStripMenuItem_Click);
            // 
            // mixedmediaToolStripMenuItem
            // 
            this.mixedmediaToolStripMenuItem.BackColor = System.Drawing.Color.DarkOrange;
            this.mixedmediaToolStripMenuItem.Name = "mixedmediaToolStripMenuItem";
            this.mixedmediaToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.mixedmediaToolStripMenuItem.Text = "Mixed Media";
            this.mixedmediaToolStripMenuItem.Click += new System.EventHandler(this.mixedmediaToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Black;
            this.toolStrip1.Font = new System.Drawing.Font("Papyrus", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(634, 31);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(634, 509);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tb_DisplayData);
            this.Controls.Add(this.btn_Acrylic);
            this.Controls.Add(this.btn_Watercolor);
            this.Controls.Add(this.btn_MixedMedia);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_MixedMedia;
        private System.Windows.Forms.Button btn_Watercolor;
        private System.Windows.Forms.Button btn_Acrylic;
        private System.Windows.Forms.TextBox tb_DisplayData;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem acrylicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem waterColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mixedmediaToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}

