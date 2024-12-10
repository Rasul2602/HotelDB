namespace HotelDB_App
{
    partial class ClientsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewClients;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Button btnApplyFilter;
        private System.Windows.Forms.TextBox txtRoomFilter;
        private System.Windows.Forms.Button btnFilterRoom;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnDeleteClient;

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
            this.dataGridViewClients = new System.Windows.Forms.DataGridView();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.btnApplyFilter = new System.Windows.Forms.Button();
            this.txtRoomFilter = new System.Windows.Forms.TextBox();
            this.btnFilterRoom = new System.Windows.Forms.Button();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.btnDeleteClient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewClients
            // 
            this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClients.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.Size = new System.Drawing.Size(760, 350);
            this.dataGridViewClients.TabIndex = 0;
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(12, 380);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(200, 22);
            this.txtFilter.TabIndex = 1;
            this.txtFilter.Text = "Введите данные для фильтрации";
            this.txtFilter.ForeColor = System.Drawing.Color.Gray;
            this.txtFilter.Enter += new System.EventHandler(this.txtFilter_Enter);
            this.txtFilter.Leave += new System.EventHandler(this.txtFilter_Leave);
            // 
            // btnApplyFilter
            // 
            this.btnApplyFilter.Location = new System.Drawing.Point(220, 380);
            this.btnApplyFilter.Name = "btnApplyFilter";
            this.btnApplyFilter.Size = new System.Drawing.Size(100, 22);
            this.btnApplyFilter.TabIndex = 2;
            this.btnApplyFilter.Text = "Фильтр";
            this.btnApplyFilter.UseVisualStyleBackColor = true;
            this.btnApplyFilter.Click += new System.EventHandler(this.btnApplyFilter_Click);
            // 
            // txtRoomFilter
            // 
            this.txtRoomFilter.Location = new System.Drawing.Point(330, 380);
            this.txtRoomFilter.Name = "txtRoomFilter";
            this.txtRoomFilter.Size = new System.Drawing.Size(200, 22);
            this.txtRoomFilter.TabIndex = 3;
            this.txtRoomFilter.Text = "Введите номер комнаты";
            this.txtRoomFilter.ForeColor = System.Drawing.Color.Gray;
            this.txtRoomFilter.Enter += new System.EventHandler(this.txtRoomFilter_Enter);
            this.txtRoomFilter.Leave += new System.EventHandler(this.txtRoomFilter_Leave);
            // 
            // btnFilterRoom
            // 
            this.btnFilterRoom.Location = new System.Drawing.Point(540, 380);
            this.btnFilterRoom.Name = "btnFilterRoom";
            this.btnFilterRoom.Size = new System.Drawing.Size(100, 22);
            this.btnFilterRoom.TabIndex = 4;
            this.btnFilterRoom.Text = "Фильтр по номеру";
            this.btnFilterRoom.UseVisualStyleBackColor = true;
            this.btnFilterRoom.Click += new System.EventHandler(this.btnFilterRoom_Click);
            // 
            // btnAddClient
            // 
            this.btnAddClient.Location = new System.Drawing.Point(12, 420);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(150, 30);
            this.btnAddClient.TabIndex = 5;
            this.btnAddClient.Text = "Добавить клиента";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.Location = new System.Drawing.Point(170, 420);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(150, 30);
            this.btnDeleteClient.TabIndex = 6;
            this.btnDeleteClient.Text = "Удалить клиента";
            this.btnDeleteClient.UseVisualStyleBackColor = true;
            this.btnDeleteClient.Click += new System.EventHandler(this.btnDeleteClient_Click);
            // 
            // ClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.btnDeleteClient);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.btnFilterRoom);
            this.Controls.Add(this.txtRoomFilter);
            this.Controls.Add(this.btnApplyFilter);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.dataGridViewClients);
            this.Name = "ClientsForm";
            this.Text = "Клиенты";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
