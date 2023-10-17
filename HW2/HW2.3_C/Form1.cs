using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;

namespace HW2_3C_bis
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

        private void GenerateRandomData_Click(object sender, EventArgs e)
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
                CounterDataGridView.Columns.Clear();
                CounterDataGridView.Columns.Add("Intervall", "Intervall");
                CounterDataGridView.Columns.Add("Counter", "Counter");

                chart1.Series.Clear();

                for (int i = 0; i < k; i++)
                {
                    double min = (double)i / k;
                    double max = (double)(i + 1) / k;

                    CounterDataGridView.Rows.Add($"{min:F2} - {max:F2}", counter[i]);

                    chart1.Series.Add($"{min:F2} - {max:F2}");
                    chart1.Series[$"{min:F2} - {max:F2}"].Points.AddXY("intervall", counter[i]);
                    chart1.ChartAreas[0].AxisY.Maximum = counter.Max() + (10* counter.Max())/100;

                }

                chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
            }
            else
            {
                MessageBox.Show("Please enter valid N and K values.");
            }
        }
    }
}