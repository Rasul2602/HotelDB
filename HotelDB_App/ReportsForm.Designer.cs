namespace HotelDB_App
{
    partial class ReportsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnClientReport;
        private System.Windows.Forms.Button btnEmployeeReport;
        private System.Windows.Forms.Button btnRoomReport;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btnClientReport = new System.Windows.Forms.Button();
            this.btnEmployeeReport = new System.Windows.Forms.Button();
            this.btnRoomReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClientReport
            // 
            this.btnClientReport.Location = new System.Drawing.Point(30, 30);
            this.btnClientReport.Name = "btnClientReport";
            this.btnClientReport.Size = new System.Drawing.Size(200, 50);
            this.btnClientReport.TabIndex = 0;
            this.btnClientReport.Text = "Отчет по клиентам";
            this.btnClientReport.UseVisualStyleBackColor = true;
            this.btnClientReport.Click += new System.EventHandler(this.btnClientReport_Click);
            // 
            // btnEmployeeReport
            // 
            this.btnEmployeeReport.Location = new System.Drawing.Point(30, 100);
            this.btnEmployeeReport.Name = "btnEmployeeReport";
            this.btnEmployeeReport.Size = new System.Drawing.Size(200, 50);
            this.btnEmployeeReport.TabIndex = 1;
            this.btnEmployeeReport.Text = "Отчет по сотрудникам";
            this.btnEmployeeReport.UseVisualStyleBackColor = true;
            this.btnEmployeeReport.Click += new System.EventHandler(this.btnEmployeeReport_Click);
            // 
            // btnRoomReport
            // 
            this.btnRoomReport.Location = new System.Drawing.Point(30, 170);
            this.btnRoomReport.Name = "btnRoomReport";
            this.btnRoomReport.Size = new System.Drawing.Size(200, 50);
            this.btnRoomReport.TabIndex = 2;
            this.btnRoomReport.Text = "Отчет по номерам";
            this.btnRoomReport.UseVisualStyleBackColor = true;
            this.btnRoomReport.Click += new System.EventHandler(this.btnRoomReport_Click);
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnRoomReport);
            this.Controls.Add(this.btnEmployeeReport);
            this.Controls.Add(this.btnClientReport);
            this.Name = "ReportsForm";
            this.Text = "Отчеты";
            this.ResumeLayout(false);
        }

        #endregion
    }
}
