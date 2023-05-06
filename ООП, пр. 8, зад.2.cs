namespace Lesson_Lab8_2
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

        static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
        static void InsertionSort(int[] inArray)
        {
            int x;
            int j;
            for (int i = 1; i < inArray.Length; i++)
            {
                x = inArray[i];
                j = i;
                while (j > 0 && inArray[j - 1] > x)
                {
                    Swap(inArray, j, j - 1);
                    j -= 1;
                }
                inArray[j] = x;
            }
        }

        private void BtnSort_Click(object sender, EventArgs e)
        {
            InsertionSort(Arr);
            for (int i = 0; i < Arr.Length; i++)
            {
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