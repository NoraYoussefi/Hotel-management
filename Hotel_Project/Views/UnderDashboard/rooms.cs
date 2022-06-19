using Hotel_Project.Data;
using Hotel_Project.Properties;
using HotelManagement.DesignTools;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotel_Project.Views.UnderDashboard.update;
using Hotel_Project.Views.UnderDashboard.add;

namespace Hotel_Project.Views.UnderDashboard
{
    public partial class rooms : Form
    {
        public rooms()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rooms_Load(object sender, EventArgs e)
        {
            Database db = new Database();
            List<Room> AllRooms = db.Rooms.Include(h => h.Hotel).Include(c => c.Category).ToList();

            int y = 55;
            foreach (Room r in AllRooms)
            {
                Panel panel1;
                BorderRaduis add_room;
                Label isReserved;
                Label price;
                Label room_tel;
                Label Num;
                Label Id_room;
                Label category;
                Label hotel;
                Panel panel2; 
                Button update;
                Button delete;

                add_room = new HotelManagement.DesignTools.BorderRaduis();
                isReserved = new System.Windows.Forms.Label();
                price = new System.Windows.Forms.Label();
                room_tel = new System.Windows.Forms.Label();
                Num = new System.Windows.Forms.Label();
                Id_room = new System.Windows.Forms.Label();
                hotel = new System.Windows.Forms.Label();
                category = new System.Windows.Forms.Label();
                panel2 = new System.Windows.Forms.Panel();
                update = new System.Windows.Forms.Button();
                delete = new System.Windows.Forms.Button();
                panel2.SuspendLayout();
                SuspendLayout();
               
        
                
                // 
                // add_room
                // 
                add_room.BackColor = System.Drawing.Color.Black;
                add_room.BackgroundColor = System.Drawing.Color.Black;
                add_room.BorderColor = System.Drawing.Color.PaleVioletRed;
                add_room.BorderRadius = 20;
                add_room.BorderSize = 0;
                add_room.FlatAppearance.BorderSize = 0;
                add_room.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                add_room.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(161)))), ((int)(((byte)(163)))));
                add_room.Location = new System.Drawing.Point(717, 5);
                add_room.Name = "add_room";
                add_room.Size = new System.Drawing.Size(175, 42);
                add_room.TabIndex = 2;
                add_room.Text = "Add room";
                add_room.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(161)))), ((int)(((byte)(163)))));
                add_room.UseVisualStyleBackColor = false;
                // 
                // isReserved
                // 
                isReserved.AutoSize = true;
                isReserved.Location = new System.Drawing.Point(419, 15);
                isReserved.Name = "isReserved";
                isReserved.Size = new System.Drawing.Size(95, 25);
                isReserved.TabIndex = 14;
                isReserved.Text = r.IsReserved.ToString();
                // 
                // price
                // 
                price.AutoSize = true;
                price.Location = new System.Drawing.Point(320, 15);
                price.Name = "price";
                price.Size = new System.Drawing.Size(50, 25);
                price.TabIndex = 13;
                price.Text = r.price.ToString();
                // 
                // room_tel
                // 
                room_tel.AutoSize = true;
                room_tel.Location = new System.Drawing.Point(220, 12);
                room_tel.Name = "room_tel";
                room_tel.Size = new System.Drawing.Size(31, 25);
                room_tel.TabIndex = 12;
                room_tel.Text = r.RoomTel.ToString();
                // 
                // Num
                // 
                Num.AutoSize = true;
                Num.Location = new System.Drawing.Point(112, 12);
                Num.Name = "Num";
                Num.Size = new System.Drawing.Size(48, 25);
                Num.TabIndex = 11;
                Num.Text = r.Num.ToString();
                // 
                // Id_room
                // 
                Id_room.AutoSize = true;
                Id_room.Location = new System.Drawing.Point(26, 14);
                Id_room.Name = "Id_room";
                Id_room.Size = new System.Drawing.Size(28, 25);
                Id_room.TabIndex = 10;
                Id_room.Text = r.Id.ToString();
                // 
                // hotel
                // 
                hotel.AutoSize = true;
                hotel.Location = new System.Drawing.Point(540, 15);
                hotel.Name = "hotel";
                hotel.Size = new System.Drawing.Size(52, 25);
                hotel.TabIndex = 15;
                hotel.Text = r.Hotel.Name.ToString();
                // 
                // category
                // 
                category.AutoSize = true;
                category.Location = new System.Drawing.Point(625, 15);
                category.Name = "category";
                category.Size = new System.Drawing.Size(81, 25);
                category.TabIndex = 16;
                category.Text = r.Category.Description.ToString();
                // 
                // panel2
                // 
                panel2.BackColor = System.Drawing.Color.White;
               /* panel2.Controls.Add(this.category);
                panel2.Controls.Add(this.Num);
                panel2.Controls.Add(this.hotel);
                panel2.Controls.Add(this.isReserved);
                panel2.Controls.Add(this.price);
                panel2.Controls.Add(this.update);
                panel2.Controls.Add(this.delete);
                panel2.Controls.Add(this.room_tel);
                panel2.Controls.Add(this.Id_room);*/
                panel2.Location = new System.Drawing.Point(31, 110 + y);
                panel2.Name = "panel2";
                panel2.Size = new System.Drawing.Size(906, 51);
                panel2.TabIndex = 3;
                // 
                // update
                // 
                update.BackColor = System.Drawing.Color.White;
                update.BackgroundImage = global::Hotel_Project.Properties.Resources.editing__1_;
                update.FlatAppearance.BorderSize = 0;
                update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                update.Location = new System.Drawing.Point(770, 3);
                update.Name = r.Id.ToString();
                update.Size = new System.Drawing.Size(48, 45);
                update.TabIndex = 16;
                update.UseVisualStyleBackColor = false;
                update.Click += (s, e) => update_room(s, e);
                // 
                // delete
                // 
                delete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                delete.BackColor = System.Drawing.Color.White;
                delete.BackgroundImage = global::Hotel_Project.Properties.Resources.delete;
                delete.FlatAppearance.BorderSize = 0;
                delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                delete.Location = new System.Drawing.Point(839, 3);
                delete.Name = "delete";
                delete.Size = new System.Drawing.Size(53, 46);
                delete.TabIndex = 15;
                delete.UseVisualStyleBackColor = false;
                delete.Click += (s, e) => delete_room(s, e, r);

                // 
                // rooms
                // 
                /* AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
                 AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                 AutoScroll = true;
                 BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(161)))), ((int)(((byte)(163)))));
                 ClientSize = new System.Drawing.Size(968, 542);
                 Controls.Add(this.panel2);

                 Controls.Add(this.panel1);
                 Name = "rooms";
                 Text = "rooms";
                 Load += new System.EventHandler(this.rooms_Load);
 */

                panel2.ResumeLayout(false);
                panel2.PerformLayout();
                ResumeLayout(false);

                panel2.Controls.Add(isReserved);
                panel2.Controls.Add(price);
                panel2.Controls.Add(room_tel);
                panel2.Controls.Add(Num);
                panel2.Controls.Add(hotel);
                panel2.Controls.Add(category);
                panel2.Controls.Add(Id_room);
                panel2.Controls.Add(update);
                panel2.Controls.Add(delete);
                this.Controls.Add(panel2);

                y = y + 55;


            }
        }

        private void update_room(object s, EventArgs e)
        {
            Database db = new Database();
            Button update = (Button)s;
            int id = Int32.Parse(update.Name.ToString());
            Room room = db.Rooms.Where(x => x.Id == id).First();

            updateRoom updateRoom = new updateRoom(room);
            updateRoom.Show();
        }

        private void delete_room(object s, EventArgs e, Room r)
        {
            Database db = new Database();
            Room room = new Room() { Id = r.Id };
            db.Rooms.Attach(room);
            db.Rooms.Remove(room);
            db.SaveChanges();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void add_room_Click(object sender, EventArgs e)
        {
            addRoom addRoom = new addRoom();
            addRoom.Show();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
