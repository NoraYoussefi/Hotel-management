namespace Hotel_Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.borderRaduis2 = new HotelManagement.DesignTools.BorderRaduis();
            this.borderRaduis1 = new HotelManagement.DesignTools.BorderRaduis();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(69)))), ((int)(((byte)(77)))));
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(80, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(393, 35);
            this.label3.TabIndex = 4;
            this.label3.Text = "Create your account or sign in";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(69)))), ((int)(((byte)(77)))));
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(161)))), ((int)(((byte)(163)))));
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Lucida Calligraphy", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(27, 405);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(541, 129);
            this.label4.TabIndex = 6;
            this.label4.Text = resources.GetString("label4.Text");
            this.label4.UseCompatibleTextRendering = true;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(161)))), ((int)(((byte)(163)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(9, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(549, 340);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(69)))), ((int)(((byte)(77)))));
            this.panel1.Controls.Add(this.borderRaduis2);
            this.panel1.Controls.Add(this.borderRaduis1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(-8, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(572, 666);
            this.panel1.TabIndex = 8;
            // 
            // borderRaduis2
            // 
            this.borderRaduis2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(161)))), ((int)(((byte)(163)))));
            this.borderRaduis2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(161)))), ((int)(((byte)(163)))));
            this.borderRaduis2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.borderRaduis2.BorderRadius = 20;
            this.borderRaduis2.BorderSize = 0;
            this.borderRaduis2.FlatAppearance.BorderSize = 0;
            this.borderRaduis2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borderRaduis2.Font = new System.Drawing.Font("Andalus", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.borderRaduis2.ForeColor = System.Drawing.Color.Black;
            this.borderRaduis2.Location = new System.Drawing.Point(145, 417);
            this.borderRaduis2.Name = "borderRaduis2";
            this.borderRaduis2.Size = new System.Drawing.Size(265, 51);
            this.borderRaduis2.TabIndex = 7;
            this.borderRaduis2.Text = "Register";
            this.borderRaduis2.TextColor = System.Drawing.Color.Black;
            this.borderRaduis2.UseVisualStyleBackColor = false;
            this.borderRaduis2.Click += new System.EventHandler(this.borderRaduis2_Click);
            // 
            // borderRaduis1
            // 
            this.borderRaduis1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(161)))), ((int)(((byte)(163)))));
            this.borderRaduis1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(161)))), ((int)(((byte)(163)))));
            this.borderRaduis1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.borderRaduis1.BorderRadius = 20;
            this.borderRaduis1.BorderSize = 0;
            this.borderRaduis1.FlatAppearance.BorderSize = 0;
            this.borderRaduis1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borderRaduis1.Font = new System.Drawing.Font("Andalus", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.borderRaduis1.ForeColor = System.Drawing.Color.Black;
            this.borderRaduis1.Location = new System.Drawing.Point(145, 326);
            this.borderRaduis1.Name = "borderRaduis1";
            this.borderRaduis1.Size = new System.Drawing.Size(265, 51);
            this.borderRaduis1.TabIndex = 6;
            this.borderRaduis1.Text = "LogIn";
            this.borderRaduis1.TextColor = System.Drawing.Color.Black;
            this.borderRaduis1.UseVisualStyleBackColor = false;
            this.borderRaduis1.Click += new System.EventHandler(this.borderRaduis1_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(161)))), ((int)(((byte)(163)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(561, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(571, 663);
            this.panel2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(27, 534);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(507, 113);
            this.label1.TabIndex = 8;
            this.label1.Text = "Our penthouses evoke an elegant residential style, all appointed with expansive o" +
    "utside terraces complete with exceptional views across the capital";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 656);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1154, 712);
            this.MinimumSize = new System.Drawing.Size(1154, 712);
            this.Name = "Form1";
            this.Text = "welcome to hour hotels";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Label label3;
        private PictureBox pictureBox1;
        private Label label4;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private HotelManagement.DesignTools.BorderRaduis borderRaduis2;
        private HotelManagement.DesignTools.BorderRaduis borderRaduis1;
    }
}