namespace HotelDB_App
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnRooms;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.CheckBox chkDarkTheme;
        private System.Windows.Forms.PictureBox pictureBoxLogo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.btnClients = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnRooms = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.chkDarkTheme = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = System.Drawing.Image.FromFile("C:\\Users\\Mr_robot\\source\\repos\\HotelDB_App\\HotelDB_App\\Hotel.png"); // Path to your image
            this.pictureBoxLogo.Location = new System.Drawing.Point(150, 20); // Center the image
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(200, 100);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // btnClients
            // 
            this.btnClients.Location = new System.Drawing.Point(150, 140);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(200, 50);
            this.btnClients.TabIndex = 1;
            this.btnClients.Text = "Клиенты";
            this.btnClients.UseVisualStyleBackColor = true;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.Location = new System.Drawing.Point(150, 200);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(200, 50);
            this.btnEmployees.TabIndex = 2;
            this.btnEmployees.Text = "Сотрудники";
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // btnRooms
            // 
            this.btnRooms.Location = new System.Drawing.Point(150, 260);
            this.btnRooms.Name = "btnRooms";
            this.btnRooms.Size = new System.Drawing.Size(200, 50);
            this.btnRooms.TabIndex = 3;
            this.btnRooms.Text = "Номера";
            this.btnRooms.UseVisualStyleBackColor = true;
            this.btnRooms.Click += new System.EventHandler(this.btnRooms_Click);
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(150, 320);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(200, 50);
            this.btnReports.TabIndex = 4;
            this.btnReports.Text = "Отчеты";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(150, 380);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 50);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // chkDarkTheme
            // 
            this.chkDarkTheme.AutoSize = true;
            this.chkDarkTheme.Location = new System.Drawing.Point(12, 12);
            this.chkDarkTheme.Name = "chkDarkTheme";
            this.chkDarkTheme.Size = new System.Drawing.Size(117, 20);
            this.chkDarkTheme.TabIndex = 6;
            this.chkDarkTheme.Text = "Темная тема";
            this.chkDarkTheme.UseVisualStyleBackColor = true;
            this.chkDarkTheme.CheckedChanged += new System.EventHandler(this.chkDarkTheme_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.chkDarkTheme);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnRooms);
            this.Controls.Add(this.btnEmployees);
            this.Controls.Add(this.btnClients);
            this.Controls.Add(this.pictureBoxLogo);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Управление Гостиницей";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
