namespace HotelDB_App
{
    partial class AddClientForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblPassport;
        private System.Windows.Forms.TextBox txtPassport;
        private System.Windows.Forms.Label lblCheckInDate;
        private System.Windows.Forms.DateTimePicker dtpCheckInDate;
        private System.Windows.Forms.Label lblCheckOutDate;
        private System.Windows.Forms.DateTimePicker dtpCheckOutDate;
        private System.Windows.Forms.Label lblRoomID;
        private System.Windows.Forms.TextBox txtRoomID;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Button btnSave;

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
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblPassport = new System.Windows.Forms.Label();
            this.txtPassport = new System.Windows.Forms.TextBox();
            this.lblCheckInDate = new System.Windows.Forms.Label();
            this.dtpCheckInDate = new System.Windows.Forms.DateTimePicker();
            this.lblCheckOutDate = new System.Windows.Forms.Label();
            this.dtpCheckOutDate = new System.Windows.Forms.DateTimePicker();
            this.lblRoomID = new System.Windows.Forms.Label();
            this.txtRoomID = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFullName
            // 
            this.lblFullName.Location = new System.Drawing.Point(12, 12);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(100, 23);
            this.lblFullName.Text = "ФИО клиента:";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(150, 12);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(260, 22);
            this.txtFullName.TabIndex = 0;
            // 
            // lblPassport
            // 
            this.lblPassport.Location = new System.Drawing.Point(12, 50);
            this.lblPassport.Name = "lblPassport";
            this.lblPassport.Size = new System.Drawing.Size(100, 23);
            this.lblPassport.Text = "Паспорт:";
            // 
            // txtPassport
            // 
            this.txtPassport.Location = new System.Drawing.Point(150, 50);
            this.txtPassport.Name = "txtPassport";
            this.txtPassport.Size = new System.Drawing.Size(260, 22);
            this.txtPassport.TabIndex = 1;
            // 
            // lblCheckInDate
            // 
            this.lblCheckInDate.Location = new System.Drawing.Point(12, 90);
            this.lblCheckInDate.Name = "lblCheckInDate";
            this.lblCheckInDate.Size = new System.Drawing.Size(100, 23);
            this.lblCheckInDate.Text = "Дата заезда:";
            // 
            // dtpCheckInDate
            // 
            this.dtpCheckInDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheckInDate.Location = new System.Drawing.Point(150, 90);
            this.dtpCheckInDate.Name = "dtpCheckInDate";
            this.dtpCheckInDate.Size = new System.Drawing.Size(260, 22);
            this.dtpCheckInDate.TabIndex = 2;
            // 
            // lblCheckOutDate
            // 
            this.lblCheckOutDate.Location = new System.Drawing.Point(12, 130);
            this.lblCheckOutDate.Name = "lblCheckOutDate";
            this.lblCheckOutDate.Size = new System.Drawing.Size(100, 23);
            this.lblCheckOutDate.Text = "Дата выезда:";
            // 
            // dtpCheckOutDate
            // 
            this.dtpCheckOutDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheckOutDate.Location = new System.Drawing.Point(150, 130);
            this.dtpCheckOutDate.Name = "dtpCheckOutDate";
            this.dtpCheckOutDate.Size = new System.Drawing.Size(260, 22);
            this.dtpCheckOutDate.TabIndex = 3;
            // 
            // lblRoomID
            // 
            this.lblRoomID.Location = new System.Drawing.Point(12, 170);
            this.lblRoomID.Name = "lblRoomID";
            this.lblRoomID.Size = new System.Drawing.Size(100, 23);
            this.lblRoomID.Text = "ID номера:";
            // 
            // txtRoomID
            // 
            this.txtRoomID.Location = new System.Drawing.Point(150, 170);
            this.txtRoomID.Name = "txtRoomID";
            this.txtRoomID.Size = new System.Drawing.Size(260, 22);
            this.txtRoomID.TabIndex = 4;
            // 
            // lblCost
            // 
            this.lblCost.Location = new System.Drawing.Point(12, 210);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(100, 23);
            this.lblCost.Text = "Стоимость:";
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(150, 210);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(260, 22);
            this.txtCost.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(150, 250);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(260, 30);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AddClientForm
            // 
            this.ClientSize = new System.Drawing.Size(450, 300);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.txtRoomID);
            this.Controls.Add(this.lblRoomID);
            this.Controls.Add(this.dtpCheckOutDate);
            this.Controls.Add(this.lblCheckOutDate);
            this.Controls.Add(this.dtpCheckInDate);
            this.Controls.Add(this.lblCheckInDate);
            this.Controls.Add(this.txtPassport);
            this.Controls.Add(this.lblPassport);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lblFullName);
            this.Name = "AddClientForm";
            this.Text = "Добавить клиента";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
