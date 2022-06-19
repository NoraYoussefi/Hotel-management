namespace Hotel_Project.Views.UnderDashboard
{
    partial class users
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.add_room = new HotelManagement.DesignTools.BorderRaduis();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(163, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "CIN";
            // 
            // add_room
            // 
            this.add_room.BackColor = System.Drawing.Color.Black;
            this.add_room.BackgroundColor = System.Drawing.Color.Black;
            this.add_room.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.add_room.BorderRadius = 20;
            this.add_room.BorderSize = 0;
            this.add_room.FlatAppearance.BorderSize = 0;
            this.add_room.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_room.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(161)))), ((int)(((byte)(163)))));
            this.add_room.Location = new System.Drawing.Point(772, 6);
            this.add_room.Name = "add_room";
            this.add_room.Size = new System.Drawing.Size(105, 42);
            this.add_room.TabIndex = 2;
            this.add_room.Text = "Add User";
            this.add_room.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(161)))), ((int)(((byte)(163)))));
            this.add_room.UseVisualStyleBackColor = false;
            this.add_room.Click += new System.EventHandler(this.add_room_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "tel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(498, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "city";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "country";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(552, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(103, 25);
            this.label15.TabIndex = 24;
            this.label15.Text = "Postal code";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(595, 15);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 25);
            this.label16.TabIndex = 25;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(671, 15);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(46, 25);
            this.label17.TabIndex = 26;
            this.label17.Text = "Role";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(69)))), ((int)(((byte)(77)))));
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.add_room);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.ForeColor = System.Drawing.Color.Snow;
            this.panel1.Location = new System.Drawing.Point(7, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(880, 56);
            this.panel1.TabIndex = 3;
            // 
            // users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(161)))), ((int)(((byte)(163)))));
            this.ClientSize = new System.Drawing.Size(899, 538);
            this.Controls.Add(this.panel1);
            this.Name = "users";
            this.Text = "employees";
            this.Load += new System.EventHandler(this.users_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label5;
        private HotelManagement.DesignTools.BorderRaduis add_room;
        private Label label3;
        private Label label1;
        private Label label2;
        private Label label15;
        private Label label16;
        private Label label17;
        private Panel panel1;
    }
}