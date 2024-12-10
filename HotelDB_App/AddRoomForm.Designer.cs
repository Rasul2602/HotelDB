namespace HotelDB_App
{
    partial class AddRoomForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtRoomName;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblRoomName;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblCost;

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
            this.txtRoomName = new System.Windows.Forms.TextBox();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblRoomName = new System.Windows.Forms.Label();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // lblRoomName
            this.lblRoomName.AutoSize = true;
            this.lblRoomName.Location = new System.Drawing.Point(12, 12);
            this.lblRoomName.Name = "lblRoomName";
            this.lblRoomName.Size = new System.Drawing.Size(98, 17);
            this.lblRoomName.TabIndex = 5;
            this.lblRoomName.Text = "Название номера:";

            // txtRoomName
            this.txtRoomName.Location = new System.Drawing.Point(140, 12);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.Size = new System.Drawing.Size(260, 22);
            this.txtRoomName.TabIndex = 0;

            // lblCapacity
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Location = new System.Drawing.Point(12, 50);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(104, 17);
            this.lblCapacity.TabIndex = 6;
            this.lblCapacity.Text = "Вместимость:";

            // txtCapacity
            this.txtCapacity.Location = new System.Drawing.Point(140, 50);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(260, 22);
            this.txtCapacity.TabIndex = 1;

            // lblDescription
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(12, 90);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(83, 17);
            this.lblDescription.TabIndex = 7;
            this.lblDescription.Text = "Описание:";

            // txtDescription
            this.txtDescription.Location = new System.Drawing.Point(140, 90);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(260, 22);
            this.txtDescription.TabIndex = 2;

            // lblCost
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(12, 130);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(79, 17);
            this.lblCost.TabIndex = 8;
            this.lblCost.Text = "Стоимость:";

            // txtCost
            this.txtCost.Location = new System.Drawing.Point(140, 130);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(260, 22);
            this.txtCost.TabIndex = 3;

            // btnSave
            this.btnSave.Location = new System.Drawing.Point(140, 170);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(260, 30);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // AddRoomForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 220);
            this.Controls.Add(this.lblRoomName);
            this.Controls.Add(this.txtRoomName);
            this.Controls.Add(this.lblCapacity);
            this.Controls.Add(this.txtCapacity);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.btnSave);
            this.Name = "AddRoomForm";
            this.Text = "Добавить номер";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
