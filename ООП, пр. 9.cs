namespace Lesson_Lab9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private int NumberSymbols(string stroka, string symbol)
        {
            int k = 0;

            for (int i = 0, j = 0; i < stroka.Length; i++)
            {
                if (stroka[i] == symbol[0])
                    j++;
                if (j == symbol.Length)
                {
                    k++;
                    j = 0;
                }
            }
            return k;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TxtKolvo.Text = NumberSymbols(TxtString.Text, TxtS.Text).ToString();
        }
    }
}