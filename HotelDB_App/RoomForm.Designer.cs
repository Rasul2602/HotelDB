using System.Drawing;

namespace HotelDB_App
{
    partial class RoomsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewRooms;
        private System.Windows.Forms.Button btnFilterByCapacity;
        private System.Windows.Forms.Button btnResetFilter;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.Button btnDeleteRoom;

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
            this.dataGridViewRooms = new System.Windows.Forms.DataGridView();
            this.btnFilterByCapacity = new System.Windows.Forms.Button();
            this.btnResetFilter = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.btnDeleteRoom = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRooms)).BeginInit();
            this.SuspendLayout();

            // dataGridViewRooms
            this.dataGridViewRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRooms.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewRooms.Name = "dataGridViewRooms";
            this.dataGridViewRooms.Size = new System.Drawing.Size(760, 300);
            this.dataGridViewRooms.TabIndex = 0;

            // btnFilterByCapacity
            this.btnFilterByCapacity.Location = new System.Drawing.Point(12, 330);
            this.btnFilterByCapacity.Name = "btnFilterByCapacity";
            this.btnFilterByCapacity.Size = new System.Drawing.Size(150, 30);
            this.btnFilterByCapacity.TabIndex = 1;
            this.btnFilterByCapacity.Text = "Фильтр по вместимости";
            this.btnFilterByCapacity.UseVisualStyleBackColor = true;
            this.btnFilterByCapacity.Click += new System.EventHandler(this.btnFilterByCapacity_Click);

            // btnResetFilter
            this.btnResetFilter.Location = new System.Drawing.Point(168, 330);
            this.btnResetFilter.Name = "btnResetFilter";
            this.btnResetFilter.Size = new System.Drawing.Size(120, 30);
            this.btnResetFilter.TabIndex = 2;
            this.btnResetFilter.Text = "Сбросить фильтр";
            this.btnResetFilter.UseVisualStyleBackColor = true;
            this.btnResetFilter.Click += new System.EventHandler(this.btnResetFilter_Click);

            // btnAddRoom
            this.btnAddRoom.Location = new System.Drawing.Point(300, 330);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(120, 30);
            this.btnAddRoom.TabIndex = 3;
            this.btnAddRoom.Text = "Добавить";
            this.btnAddRoom.UseVisualStyleBackColor = true;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);

            // btnDeleteRoom
            this.btnDeleteRoom.Location = new System.Drawing.Point(430, 330);
            this.btnDeleteRoom.Name = "btnDeleteRoom";
            this.btnDeleteRoom.Size = new System.Drawing.Size(120, 30);
            this.btnDeleteRoom.TabIndex = 4;
            this.btnDeleteRoom.Text = "Удалить";
            this.btnDeleteRoom.UseVisualStyleBackColor = true;
            this.btnDeleteRoom.Click += new System.EventHandler(this.btnDeleteRoom_Click);

            // btnFirst
            this.btnFirst.Location = new System.Drawing.Point(12, 370);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(75, 30);
            this.btnFirst.TabIndex = 5;
            this.btnFirst.Text = "Первая";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);

            // btnPrevious
            this.btnPrevious.Location = new System.Drawing.Point(93, 370);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 30);
            this.btnPrevious.TabIndex = 6;
            this.btnPrevious.Text = "Назад";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);

            // btnNext
            this.btnNext.Location = new System.Drawing.Point(174, 370);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 30);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = "Вперед";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);

            // btnLast
            this.btnLast.Location = new System.Drawing.Point(255, 370);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(75, 30);
            this.btnLast.TabIndex = 8;
            this.btnLast.Text = "Последняя";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);

            // txtSearch
            this.txtSearch.Location = new System.Drawing.Point(336, 375);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 22);
            this.txtSearch.TabIndex = 9;
            this.txtSearch.Text = "Введите текст для поиска";
            this.txtSearch.ForeColor = Color.Gray;
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);

            // btnSearch
            this.btnSearch.Location = new System.Drawing.Point(542, 370);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 30);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Поиск";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            // btnClose
            this.btnClose.Location = new System.Drawing.Point(648, 370);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 30);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // RoomsForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeleteRoom);
            this.Controls.Add(this.btnAddRoom);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnResetFilter);
            this.Controls.Add(this.btnFilterByCapacity);
            this.Controls.Add(this.dataGridViewRooms);
            this.Name = "RoomsForm";
            this.Text = "Номера";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRooms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
