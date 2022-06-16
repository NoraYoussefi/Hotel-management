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
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
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
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.update);
            this.panel1.Controls.Add(this.delete);
            this.panel1.Controls.Add(this.address);
            this.panel1.Controls.Add(this.classement);
            this.panel1.Controls.Add(this.num_tel);
            this.panel1.Controls.Add(this.hotel_title);
            this.panel1.Controls.Add(this.Id_hotel);
            this.panel1.Location = new System.Drawing.Point(29, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 51);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.White;
            this.update.BackgroundImage = global::Hotel_Project.Properties.Resources.cloud_sync1;
            this.update.FlatAppearance.BorderSize = 0;
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.Location = new System.Drawing.Point(672, 3);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(51, 42);
            this.update.TabIndex = 16;
            this.update.UseVisualStyleBackColor = false;
            // 
            // delete
            // 
            this.delete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.delete.BackColor = System.Drawing.Color.White;
            this.delete.BackgroundImage = global::Hotel_Project.Properties.Resources.delete;
            this.delete.FlatAppearance.BorderSize = 0;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Location = new System.Drawing.Point(757, 3);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(53, 46);
            this.delete.TabIndex = 15;
            this.delete.UseVisualStyleBackColor = false;
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Location = new System.Drawing.Point(440, 14);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(74, 25);
            this.address.TabIndex = 14;
            this.address.Text = "address";
            // 
            // classement
            // 
            this.classement.AutoSize = true;
            this.classement.Location = new System.Drawing.Point(305, 14);
            this.classement.Name = "classement";
            this.classement.Size = new System.Drawing.Size(99, 25);
            this.classement.TabIndex = 13;
            this.classement.Text = "classement";
            // 
            // num_tel
            // 
            this.num_tel.AutoSize = true;
            this.num_tel.Location = new System.Drawing.Point(200, 12);
            this.num_tel.Name = "num_tel";
            this.num_tel.Size = new System.Drawing.Size(31, 25);
            this.num_tel.TabIndex = 12;
            this.num_tel.Text = "tel";
            // 
            // hotel_title
            // 
            this.hotel_title.AutoSize = true;
            this.hotel_title.Location = new System.Drawing.Point(102, 12);
            this.hotel_title.Name = "hotel_title";
            this.hotel_title.Size = new System.Drawing.Size(41, 25);
            this.hotel_title.TabIndex = 11;
            this.hotel_title.Text = "title";
            this.hotel_title.Click += new System.EventHandler(this.title_Click);
            // 
            // Id_hotel
            // 
            this.Id_hotel.AutoSize = true;
            this.Id_hotel.Location = new System.Drawing.Point(24, 14);
            this.Id_hotel.Name = "Id_hotel";
            this.Id_hotel.Size = new System.Drawing.Size(28, 25);
            this.Id_hotel.TabIndex = 10;
            this.Id_hotel.Text = "Id";
            // 
            // hotels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(161)))), ((int)(((byte)(163)))));
            this.ClientSize = new System.Drawing.Size(876, 538);
            this.Controls.Add(this.panel1);
            this.Name = "hotels";
            this.Text = "hotels";
            this.Load += new System.EventHandler(this.hotels_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button update;
        private Button delete;
        private Label address;
        private Label classement;
        private Label num_tel;
        private Label hotel_title;
        private Label Id_hotel;
    }
}