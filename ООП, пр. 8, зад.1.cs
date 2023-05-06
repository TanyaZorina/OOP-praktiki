namespace Lesson_Lab8_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int[] Arr = new int[10];

        private void BtnNewArr_Click(object sender, EventArgs e)
        {
            int n = 10;
            int a = int.Parse(TxtMin.Text);
            int b = int.Parse(TxtMax.Text);
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                Arr[i] = r.Next(a, b);
                LblArr.Text += Arr[i];
                if (i != n) LblArr.Text += ", ";
            }
            BtnSort.Enabled = true;
        }

        private int MinNumber(int[] x, int m)
        {
            int min = x[m];
            int MinN = m;
            for (int i = m; i < x.Length; i++)
            {
                if (x[i] < min)
                {
                    min = x[i];
                    MinN = i;
                }
            }
            return MinN;
        }

        private void BtnSort_Click(object sender, EventArgs e)
        {
            int k, t;
            for (int i = 0; i < Arr.Length; i++)
            {
                k = MinNumber(Arr, i);
                t = Arr[i];
                Arr[i] = Arr[k];
                Arr[k] = t;
                LblResult.Text += Arr[i];
                if (i != Arr.Length - 1) { LblResult.Text += ", "; }
            }
            BtnSort.Enabled = false;
        }
        private void ClearFields()
        {
            LblArr.Text = "";
            LblResult.Text = "";
            BtnSort.Enabled = false;
        }
    }
}