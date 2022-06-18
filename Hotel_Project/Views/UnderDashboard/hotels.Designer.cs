namespace Hotel_Project.Views.UnderDashboard
{
    partial class hotels
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.add_hotel = new HotelManagement.DesignTools.BorderRaduis();
            this.address = new System.Windows.Forms.Label();
            this.classement = new System.Windows.Forms.Label();
            this.num_tel = new System.Windows.Forms.Label();
            this.hotel_title = new System.Windows.Forms.Label();
            this.Id_hotel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(69)))), ((int)(((byte)(77)))));
            this.panel1.Controls.Add(this.add_hotel);
            this.panel1.Controls.Add(this.address);
            this.panel1.Controls.Add(this.classement);
            this.panel1.Controls.Add(this.num_tel);
            this.panel1.Controls.Add(this.hotel_title);
            this.panel1.Controls.Add(this.Id_hotel);
            this.panel1.ForeColor = System.Drawing.Color.Snow;
            this.panel1.Location = new System.Drawing.Point(2, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(891, 56);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // add_hotel
            // 
            this.add_hotel.BackColor = System.Drawing.Color.Black;
            this.add_hotel.BackgroundColor = System.Drawing.Color.Black;
            this.add_hotel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.add_hotel.BorderRadius = 20;
            this.add_hotel.BorderSize = 0;
            this.add_hotel.FlatAppearance.BorderSize = 0;
            this.add_hotel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_hotel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(161)))), ((int)(((byte)(163)))));
            this.add_hotel.Location = new System.Drawing.Point(653, 6);
            this.add_hotel.Name = "add_hotel";
            this.add_hotel.Size = new System.Drawing.Size(175, 42);
            this.add_hotel.TabIndex = 2;
            this.add_hotel.Text = "Add Hotel";
            this.add_hotel.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(161)))), ((int)(((byte)(163)))));
            this.add_hotel.UseVisualStyleBackColor = false;
            this.add_hotel.Click += new System.EventHandler(this.add_hotel_Click);
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Location = new System.Drawing.Point(490, 15);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(82, 25);
            this.address.TabIndex = 14;
            this.address.Text = "address";
            // 
            // classement
            // 
            this.classement.AutoSize = true;
            this.classement.Location = new System.Drawing.Point(336, 14);
            this.classement.Name = "classement";
            this.classement.Size = new System.Drawing.Size(111, 25);
            this.classement.TabIndex = 13;
            this.classement.Text = "classement";
            // 
            // num_tel
            // 
            this.num_tel.AutoSize = true;
            this.num_tel.Location = new System.Drawing.Point(220, 12);
            this.num_tel.Name = "num_tel";
            this.num_tel.Size = new System.Drawing.Size(36, 25);
            this.num_tel.TabIndex = 12;
            this.num_tel.Text = "tel";
            this.num_tel.Click += new System.EventHandler(this.num_tel_Click);
            // 
            // hotel_title
            // 
            this.hotel_title.AutoSize = true;
            this.hotel_title.Location = new System.Drawing.Point(112, 12);
            this.hotel_title.Name = "hotel_title";
            this.hotel_title.Size = new System.Drawing.Size(50, 25);
            this.hotel_title.TabIndex = 11;
            this.hotel_title.Text = "title";
            this.hotel_title.Click += new System.EventHandler(this.title_Click);
            // 
            // Id_hotel
            // 
            this.Id_hotel.AutoSize = true;
            this.Id_hotel.Location = new System.Drawing.Point(26, 14);
            this.Id_hotel.Name = "Id_hotel";
            this.Id_hotel.Size = new System.Drawing.Size(30, 25);
            this.Id_hotel.TabIndex = 10;
            this.Id_hotel.Text = "Id";
            // 
            // hotels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(161)))), ((int)(((byte)(163)))));
            this.ClientSize = new System.Drawing.Size(895, 534);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "hotels";
            this.Text = "hotels";
            this.Load += new System.EventHandler(this.hotels_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label address;
        private Label classement;
        private Label num_tel;
        private Label hotel_title;
        private Label Id_hotel;
        private HotelManagement.DesignTools.BorderRaduis add_hotel;
    }
}