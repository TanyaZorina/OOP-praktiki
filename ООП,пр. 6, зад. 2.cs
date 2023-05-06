namespace Lab6_2
{
    public partial class Lab7 : Form
    {
        public Lab7()
        {
            InitializeComponent();

           
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            int counter = 0;
            double sum = 0;
            double summand = 0.0;
            double x;
            double precision;

            bool f = false;
            if (double.TryParse(TxtPrecision.Text, out precision))
            {
                f = true;
                while (f && Math.Abs(summand) > precision) ;
            }

            do
            {
                counter++;
                if (double.TryParse(TxtX.Text, out x))
                {
                    summand = double.Parse(TxtX.Text) / counter;
                }
                sum += summand;
            }
            while (Math.Abs(summand) > double.Parse(TxtPrecision.Text));

            LblResult.Text = "сумма = " + sum + ", количество = " + counter;

            if (f)
            {
                LblResult.Text = "сумма = " + sum + ", количество = " + counter;
            }
            else
            {
                MessageBox.Show("¬ведите числовое значение!");
            }

        }
    }
}