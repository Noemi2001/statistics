namespace HW2._3_C
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GenerateRandomDataButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(NumberNTextBox.Text, out int N) && int.TryParse(NumberKTextBox.Text, out int k))
            {
                double[] data = new double[N];
                int[] counter = new int[k];

                Random random = new Random();

                for (int c = 0; c < N; c++)
                {
                    double randomNumber = random.NextDouble();
                    data[c] = randomNumber;
                }

                for (int j = 0; j < N; j++)
                {
                    for (int i = 0; i < k; i++)
                    {
                        double min = (double)i / k;
                        double max = (double)(i + 1) / k;
                        if (data[j] >= min && data[j] < max)
                        {
                            counter[i]++;
                        }
                    }
                }

                CounterDataGridView.Rows.Clear();
                CounterDataGridView.Columns.Add("Intervall", "Intervall");
                CounterDataGridView.Columns.Add("Counter", "Counter");


                for (int i = 0; i < k; i++)
                {
                    double min = (double)i / k;
                    double max = (double)(i + 1) / k;

                    CounterDataGridView.Rows.Add($"{min:F2} - {max:F2}", counter[i]);
                }
            }
            else
            {
                MessageBox.Show("Please enter valid N and K values.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}