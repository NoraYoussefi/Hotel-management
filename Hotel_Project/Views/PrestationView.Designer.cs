namespace Hotel_Project.Views
{
    partial class PrestationView
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
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.borderRaduis1 = new HotelManagement.DesignTools.BorderRaduis();
            this.label1 = new System.Windows.Forms.Label();
            this.placeHolderTextBox1 = new Hotel_Project.PlaceHolderTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.placeHolderTextBox2 = new Hotel_Project.PlaceHolderTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 64;
            this.label2.Text = "Entry date :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(340, 327);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(300, 31);
            this.dateTimePicker1.TabIndex = 62;
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
            this.borderRaduis1.Location = new System.Drawing.Point(255, 408);
            this.borderRaduis1.Name = "borderRaduis1";
            this.borderRaduis1.Size = new System.Drawing.Size(248, 60);
            this.borderRaduis1.TabIndex = 61;
            this.borderRaduis1.Text = "submit";
            this.borderRaduis1.TextColor = System.Drawing.Color.White;
            this.borderRaduis1.UseVisualStyleBackColor = false;
            this.borderRaduis1.Click += new System.EventHandler(this.borderRaduis1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(255, -46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 48);
            this.label1.TabIndex = 60;
            this.label1.Text = "Reservation";
            // 
            // placeHolderTextBox1
            // 
            this.placeHolderTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.placeHolderTextBox1.ForeColor = System.Drawing.Color.Gray;
            this.placeHolderTextBox1.Location = new System.Drawing.Point(200, 126);
            this.placeHolderTextBox1.Name = "placeHolderTextBox1";
            this.placeHolderTextBox1.PlaceHolderText = "Enter Name";
            this.placeHolderTextBox1.Size = new System.Drawing.Size(347, 31);
            this.placeHolderTextBox1.TabIndex = 70;
            this.placeHolderTextBox1.Text = "Enter Name";
            this.placeHolderTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(255, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 34);
            this.label5.TabIndex = 71;
            this.label5.Text = "Add Prestation";
            // 
            // placeHolderTextBox2
            // 
            this.placeHolderTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.placeHolderTextBox2.ForeColor = System.Drawing.Color.Gray;
            this.placeHolderTextBox2.Location = new System.Drawing.Point(200, 189);
            this.placeHolderTextBox2.Name = "placeHolderTextBox2";
            this.placeHolderTextBox2.PlaceholderText = "Enter Price";
            this.placeHolderTextBox2.PlaceHolderText = "Enter Price";
            this.placeHolderTextBox2.Size = new System.Drawing.Size(347, 31);
            this.placeHolderTextBox2.TabIndex = 72;
            this.placeHolderTextBox2.Text = "Enter ";
            this.placeHolderTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(200, 248);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(347, 33);
            this.comboBox1.TabIndex = 73;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Prestation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(161)))), ((int)(((byte)(163)))));
            this.ClientSize = new System.Drawing.Size(790, 467);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.placeHolderTextBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.placeHolderTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.borderRaduis1);
            this.Controls.Add(this.label1);
            this.Name = "Prestation";
            this.Text = "Prestation";
            this.Load += new System.EventHandler(this.Prestation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private HotelManagement.DesignTools.BorderRaduis borderRaduis1;
        private Label label1;
        private PlaceHolderTextBox placeHolderTextBox1;
        private Label label5;
        private PlaceHolderTextBox placeHolderTextBox2;
        private ComboBox comboBox1;
    }
}