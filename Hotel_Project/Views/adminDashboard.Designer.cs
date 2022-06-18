namespace Hotel_Project.Views
{
    partial class adminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminDashboard));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.category = new System.Windows.Forms.TabPage();
            this.rooms = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.admin = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.test = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.stars = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.Id_hotel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Num = new System.Windows.Forms.Label();
            this.hotel = new System.Windows.Forms.Label();
            this.isReserved = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.room_tel = new System.Windows.Forms.Label();
            this.Id_room = new System.Windows.Forms.Label();
            this.rooms.SuspendLayout();
            this.admin.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(161)))), ((int)(((byte)(163)))));
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1100, 606);
            this.tabPage2.TabIndex = 6;
            this.tabPage2.Text = "factures";
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(161)))), ((int)(((byte)(163)))));
            this.tabPage6.Location = new System.Drawing.Point(4, 34);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1100, 606);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "reservations";
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(161)))), ((int)(((byte)(163)))));
            this.tabPage5.Location = new System.Drawing.Point(4, 34);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1100, 606);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "employees";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(161)))), ((int)(((byte)(163)))));
            this.tabPage4.ForeColor = System.Drawing.Color.Black;
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1100, 606);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "clients";
            // 
            // category
            // 
            this.category.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(161)))), ((int)(((byte)(163)))));
            this.category.Location = new System.Drawing.Point(4, 34);
            this.category.Name = "category";
            this.category.Padding = new System.Windows.Forms.Padding(3);
            this.category.Size = new System.Drawing.Size(1100, 606);
            this.category.TabIndex = 2;
            this.category.Text = "categories";
            // 
            // rooms
            // 
            this.rooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(161)))), ((int)(((byte)(163)))));
            this.rooms.Controls.Add(this.flowLayoutPanel2);
            this.rooms.Location = new System.Drawing.Point(4, 34);
            this.rooms.Name = "rooms";
            this.rooms.Padding = new System.Windows.Forms.Padding(3);
            this.rooms.Size = new System.Drawing.Size(1100, 606);
            this.rooms.TabIndex = 1;
            this.rooms.Text = "rooms";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(133, 47);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(835, 513);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // admin
            // 
            this.admin.Controls.Add(this.tabPage1);
            this.admin.Controls.Add(this.rooms);
            this.admin.Controls.Add(this.category);
            this.admin.Controls.Add(this.tabPage4);
            this.admin.Controls.Add(this.tabPage5);
            this.admin.Controls.Add(this.tabPage6);
            this.admin.Controls.Add(this.tabPage2);
            this.admin.Location = new System.Drawing.Point(12, 0);
            this.admin.Margin = new System.Windows.Forms.Padding(0);
            this.admin.Name = "admin";
            this.admin.Padding = new System.Drawing.Point(0, 0);
            this.admin.SelectedIndex = 0;
            this.admin.Size = new System.Drawing.Size(1108, 644);
            this.admin.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(161)))), ((int)(((byte)(163)))));
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.test);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1100, 606);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "hotels";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // test
            // 
            this.test.AutoSize = true;
            this.test.Location = new System.Drawing.Point(128, 229);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(59, 25);
            this.test.TabIndex = 1;
            this.test.Text = "label2";
            this.test.Click += new System.EventHandler(this.test_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.update);
            this.panel1.Controls.Add(this.delete);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.address);
            this.panel1.Controls.Add(this.stars);
            this.panel1.Controls.Add(this.title);
            this.panel1.Controls.Add(this.Id_hotel);
            this.panel1.Location = new System.Drawing.Point(44, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(847, 51);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.White;
            this.update.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("update.BackgroundImage")));
            this.update.FlatAppearance.BorderSize = 0;
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.Location = new System.Drawing.Point(672, 3);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(51, 42);
            this.update.TabIndex = 16;
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.delete.BackColor = System.Drawing.Color.White;
            this.delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("delete.BackgroundImage")));
            this.delete.FlatAppearance.BorderSize = 0;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Location = new System.Drawing.Point(757, 3);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(53, 46);
            this.delete.TabIndex = 15;
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(440, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "address";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Location = new System.Drawing.Point(305, 14);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(99, 25);
            this.address.TabIndex = 13;
            this.address.Text = "classement";
            this.address.Click += new System.EventHandler(this.address_Click);
            // 
            // stars
            // 
            this.stars.AutoSize = true;
            this.stars.Location = new System.Drawing.Point(200, 12);
            this.stars.Name = "stars";
            this.stars.Size = new System.Drawing.Size(31, 25);
            this.stars.TabIndex = 12;
            this.stars.Text = "tel";
            this.stars.Click += new System.EventHandler(this.stars_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(102, 12);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(41, 25);
            this.title.TabIndex = 11;
            this.title.Text = "title";
            this.title.Click += new System.EventHandler(this.title_Click);
            // 
            // Id_hotel
            // 
            this.Id_hotel.AutoSize = true;
            this.Id_hotel.Location = new System.Drawing.Point(9, 14);
            this.Id_hotel.Name = "Id_hotel";
            this.Id_hotel.Size = new System.Drawing.Size(28, 25);
            this.Id_hotel.TabIndex = 10;
            this.Id_hotel.Text = "Id";
            this.Id_hotel.Click += new System.EventHandler(this.Id_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Num);
            this.panel2.Controls.Add(this.hotel);
            this.panel2.Controls.Add(this.isReserved);
            this.panel2.Controls.Add(this.price);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.room_tel);
            this.panel2.Controls.Add(this.Id_room);
            this.panel2.Location = new System.Drawing.Point(97, 278);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(906, 51);
            this.panel2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(624, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "label2";
            // 
            // Num
            // 
            this.Num.AutoSize = true;
            this.Num.Location = new System.Drawing.Point(102, 14);
            this.Num.Name = "Num";
            this.Num.Size = new System.Drawing.Size(48, 25);
            this.Num.TabIndex = 11;
            this.Num.Text = "num";
            // 
            // hotel
            // 
            this.hotel.AutoSize = true;
            this.hotel.Location = new System.Drawing.Point(536, 13);
            this.hotel.Name = "hotel";
            this.hotel.Size = new System.Drawing.Size(52, 25);
            this.hotel.TabIndex = 15;
            this.hotel.Text = "hotel";
            // 
            // isReserved
            // 
            this.isReserved.AutoSize = true;
            this.isReserved.Location = new System.Drawing.Point(400, 13);
            this.isReserved.Name = "isReserved";
            this.isReserved.Size = new System.Drawing.Size(95, 25);
            this.isReserved.TabIndex = 14;
            this.isReserved.Text = "isReserved";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Location = new System.Drawing.Point(294, 13);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(50, 25);
            this.price.TabIndex = 13;
            this.price.Text = "price";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = global::Hotel_Project.Properties.Resources.editing__1_;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(770, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 45);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(839, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 46);
            this.button2.TabIndex = 15;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // room_tel
            // 
            this.room_tel.AutoSize = true;
            this.room_tel.Location = new System.Drawing.Point(210, 13);
            this.room_tel.Name = "room_tel";
            this.room_tel.Size = new System.Drawing.Size(31, 25);
            this.room_tel.TabIndex = 12;
            this.room_tel.Text = "tel";
            // 
            // Id_room
            // 
            this.Id_room.AutoSize = true;
            this.Id_room.Location = new System.Drawing.Point(24, 14);
            this.Id_room.Name = "Id_room";
            this.Id_room.Size = new System.Drawing.Size(28, 25);
            this.Id_room.TabIndex = 10;
            this.Id_room.Text = "Id";
            // 
            // adminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(69)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(1132, 656);
            this.Controls.Add(this.admin);
            this.Name = "adminDashboard";
            this.Text = "adminDashboard";
            this.Load += new System.EventHandler(this.adminDashboard_Load);
            this.rooms.ResumeLayout(false);
            this.admin.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabPage tabPage2;
        private TabPage tabPage6;
        private TabPage tabPage5;
        private TabPage tabPage4;
        private TabPage category;
        private TabPage rooms;
        private FlowLayoutPanel flowLayoutPanel2;
        private TabControl admin;
        private TabPage tabPage1;
        private Label test;
        private Panel panel1;
        private Button update;
        private Button delete;
        private Label label1;
        private Label address;
        private Label stars;
        private Label title;
        private Label Id_hotel;
        private Panel panel2;
        private Label label2;
        private Label Num;
        private Label hotel;
        private Label isReserved;
        private Label price;
        private Button button1;
        private Button button2;
        private Label room_tel;
        private Label Id_room;
    }
}