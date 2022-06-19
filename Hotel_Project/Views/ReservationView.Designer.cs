namespace Hotel_Project.Views
{
    partial class ReservationView
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
            this.label1 = new System.Windows.Forms.Label();
            this.borderRaduis1 = new HotelManagement.DesignTools.BorderRaduis();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.placeHolderTextBox3 = new Hotel_Project.PlaceHolderTextBox();
            this.placeHolderTextBox10 = new Hotel_Project.PlaceHolderTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.borderRaduis2 = new HotelManagement.DesignTools.BorderRaduis();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(451, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reservation";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // borderRaduis1
            // 
            this.borderRaduis1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(69)))), ((int)(((byte)(77)))));
            this.borderRaduis1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(69)))), ((int)(((byte)(77)))));
            this.borderRaduis1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.borderRaduis1.BorderRadius = 20;
            this.borderRaduis1.BorderSize = 0;
            this.borderRaduis1.FlatAppearance.BorderSize = 0;
            this.borderRaduis1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borderRaduis1.ForeColor = System.Drawing.Color.White;
            this.borderRaduis1.Location = new System.Drawing.Point(583, 558);
            this.borderRaduis1.Name = "borderRaduis1";
            this.borderRaduis1.Size = new System.Drawing.Size(248, 60);
            this.borderRaduis1.TabIndex = 42;
            this.borderRaduis1.Text = "submit";
            this.borderRaduis1.TextColor = System.Drawing.Color.White;
            this.borderRaduis1.UseVisualStyleBackColor = false;
            this.borderRaduis1.Click += new System.EventHandler(this.borderRaduis1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(546, 353);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(300, 31);
            this.dateTimePicker1.TabIndex = 48;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(546, 413);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(300, 31);
            this.dateTimePicker2.TabIndex = 49;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 50;
            this.label2.Text = "Entry date :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 419);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 51;
            this.label3.Text = "Release date :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // placeHolderTextBox3
            // 
            this.placeHolderTextBox3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.placeHolderTextBox3.ForeColor = System.Drawing.Color.Gray;
            this.placeHolderTextBox3.Location = new System.Drawing.Point(366, 186);
            this.placeHolderTextBox3.Margin = new System.Windows.Forms.Padding(0);
            this.placeHolderTextBox3.MaxLength = 39;
            this.placeHolderTextBox3.MinimumSize = new System.Drawing.Size(409, 38);
            this.placeHolderTextBox3.Name = "placeHolderTextBox3";
            this.placeHolderTextBox3.PlaceholderText = "Enter your email";
            this.placeHolderTextBox3.PlaceHolderText = "Enter your email";
            this.placeHolderTextBox3.Size = new System.Drawing.Size(409, 38);
            this.placeHolderTextBox3.TabIndex = 57;
            this.placeHolderTextBox3.Text = "Enter reservation name";
            this.placeHolderTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.placeHolderTextBox3.TextChanged += new System.EventHandler(this.placeHolderTextBox3_TextChanged);
            // 
            // placeHolderTextBox10
            // 
            this.placeHolderTextBox10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.placeHolderTextBox10.ForeColor = System.Drawing.Color.Gray;
            this.placeHolderTextBox10.Location = new System.Drawing.Point(366, 264);
            this.placeHolderTextBox10.Margin = new System.Windows.Forms.Padding(0);
            this.placeHolderTextBox10.MaxLength = 39;
            this.placeHolderTextBox10.MinimumSize = new System.Drawing.Size(409, 38);
            this.placeHolderTextBox10.Name = "placeHolderTextBox10";
            this.placeHolderTextBox10.PlaceHolderText = "";
            this.placeHolderTextBox10.Size = new System.Drawing.Size(409, 38);
            this.placeHolderTextBox10.TabIndex = 52;
            this.placeHolderTextBox10.Text = "Enter Arrhes";
            this.placeHolderTextBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.placeHolderTextBox10.TextChanged += new System.EventHandler(this.placeHolderTextBox10_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(346, 478);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 25);
            this.label4.TabIndex = 59;
            this.label4.Text = "Payement Arrhes date :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(546, 478);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(300, 31);
            this.dateTimePicker3.TabIndex = 58;
            this.dateTimePicker3.ValueChanged += new System.EventHandler(this.dateTimePicker3_ValueChanged);
            // 
            // borderRaduis2
            // 
            this.borderRaduis2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(69)))), ((int)(((byte)(77)))));
            this.borderRaduis2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(69)))), ((int)(((byte)(77)))));
            this.borderRaduis2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.borderRaduis2.BorderRadius = 20;
            this.borderRaduis2.BorderSize = 0;
            this.borderRaduis2.FlatAppearance.BorderSize = 0;
            this.borderRaduis2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borderRaduis2.ForeColor = System.Drawing.Color.White;
            this.borderRaduis2.Location = new System.Drawing.Point(292, 558);
            this.borderRaduis2.Name = "borderRaduis2";
            this.borderRaduis2.Size = new System.Drawing.Size(248, 60);
            this.borderRaduis2.TabIndex = 60;
            this.borderRaduis2.Text = "cancel";
            this.borderRaduis2.TextColor = System.Drawing.Color.White;
            this.borderRaduis2.UseVisualStyleBackColor = false;
            this.borderRaduis2.Click += new System.EventHandler(this.borderRaduis2_Click);
            // 
            // ReservationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(161)))), ((int)(((byte)(163)))));
            this.ClientSize = new System.Drawing.Size(1132, 630);
            this.Controls.Add(this.borderRaduis2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.placeHolderTextBox3);
            this.Controls.Add(this.placeHolderTextBox10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.borderRaduis1);
            this.Controls.Add(this.label1);
            this.Name = "ReservationView";
            this.Text = "Facture";
            this.Load += new System.EventHandler(this.Reservation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private HotelManagement.DesignTools.BorderRaduis borderRaduis1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label2;
        private Label label3;
        private PlaceHolderTextBox placeHolderTextBox3;
        private PlaceHolderTextBox placeHolderTextBox10;
        private Label label4;
        private DateTimePicker dateTimePicker3;
        private HotelManagement.DesignTools.BorderRaduis borderRaduis2;
    }
}