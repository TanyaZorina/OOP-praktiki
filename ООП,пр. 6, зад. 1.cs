namespace Lab6_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Tmr_Tick(object sender, EventArgs e)
        {
            Pct.Left = Pct.Left + 20;
            if (Pct.Left + Pct.Width + 20 > this.ClientSize.Width)
            {
                Tmr.Enabled = true;
            }
            else
            {
                Pct.Left += 20;
            }
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            Tmr.Enabled = !Tmr.Enabled;
            BtnStart.Text = Tmr.Enabled ? "Стоп" : "Старт";
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}