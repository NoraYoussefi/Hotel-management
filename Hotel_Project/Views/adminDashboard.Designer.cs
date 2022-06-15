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
            this.admin = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rooms = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.category = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.admin.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.rooms.SuspendLayout();
            this.SuspendLayout();
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
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1100, 606);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "hotels";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(44, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 59);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.admin.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.rooms.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl admin;
        private TabPage tabPage1;
        private TabPage rooms;
        private TabPage category;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private TabPage tabPage2;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel panel1;
    }
}