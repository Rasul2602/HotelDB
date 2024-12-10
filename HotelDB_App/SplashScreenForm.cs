using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HotelDB_App
{
    public partial class SplashScreenForm : Form
    {
        private Timer timer;

        public SplashScreenForm()
        {
            InitializeComponent();
            InitializeTimer();
        }

        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 50; // Интервал обновления прогресса (в миллисекундах)
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (progressBar.Value < progressBar.Maximum)
            {
                progressBar.Value += 1;
            }
            else
            {
                timer.Stop();
                this.Close(); // Закрываем заставку
            }
        }
    }
}
