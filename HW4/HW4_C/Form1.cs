namespace HW4_C
{
    public partial class Form1 : Form
    {
        private Dictionary<string, int> counter = new Dictionary<string, int>();
        private Dictionary<string, int> counterH = new Dictionary<string, int>();
        private Dictionary<string, int> counterS = new Dictionary<string, int>();
        string[] lines;
        public Form1()
        {
            InitializeComponent();
        }

        private void FrequencyCalculation(object sender, EventArgs e)
        {
            string csvUrl = "https://noemi2001.github.io/statistics/HW2/dataset.csv";
            int numIntervals = int.Parse(numberIntervalsQantitativeDescreteTextBox.Text);
            int numIntervalsH = int.Parse(numberIntervalsQantitativeContinousTextBox.Text);

            var client = new System.Net.WebClient();
            string data = client.DownloadString(csvUrl);

            lines = data.Split(new char[] { '\n' });
            List<string> ages = new List<string>();
            List<string> heights = new List<string>();
            List<string> sports = new List<string>();
            string[] headers = lines[0].Split(',');

            for (int i = 1; i < lines.Length; i++)
            {
                string[] currentLine = lines[i].Split(',');
                string age = currentLine[Array.IndexOf(headers, "Age")];
                string h = currentLine[Array.IndexOf(headers, "Height\r")];
                string s = currentLine[Array.IndexOf(headers, "Sports")];
                ages.Add(age);
                heights.Add(h);
                sports.Add(s);
            }

            double max = ages.Max(a => double.Parse(a));
            double min = ages.Min(a => double.Parse(a));
            double maxH = heights.Max(h => double.Parse(h));
            double minH = heights.Min(h => double.Parse(h));

            double dimension = (max - min) / numIntervals;
            double dimensionH = (maxH - minH) / numIntervalsH;

            for (double j = min; j < max; j += dimension)
            {
                double start = j;
                double end = start + dimension;
                counter[$"{start}-{end}"] = 0;
            }

            for (double j = minH; j < maxH; j += dimensionH)
            {
                double start = j;
                double end = start + dimensionH;
                start = Math.Round(start, 2);
                end = Math.Round(end, 2);
                counterH[$"{start}-{end}"] = 0;
            }

            for (int c = 0; c < ages.Count; c++)
            {
                for (double j = min; j < max; j += dimension)
                {
                    double start = j;
                    double end = start + dimension;
                    if (double.Parse(ages[c]) >= start && double.Parse(ages[c]) < end)
                    {
                        counter[$"{start}-{end}"] += 1;
                    }
                    if (end == max && double.Parse(ages[c]) == end)
                    {
                        counter[$"{start}-{end}"] += 1;
                    }
                }
            }

            for (int c = 0; c < heights.Count; c++)
            {
                for (double j = minH; j < maxH; j += dimensionH)
                {
                    double start = j;
                    double end = start + dimensionH;
                    start = Math.Round(start, 2);
                    end = Math.Round(end, 2);
                    if (double.Parse(heights[c]) >= start && double.Parse(heights[c]) < end)
                    {
                        counterH[$"{start}-{end}"] += 1;
                    }
                    if (end == maxH && double.Parse(heights[c]) == end)
                    {
                        counterH[$"{start}-{end}"] += 1;
                    }
                }
            }

            foreach (var s in sports)
            {
                if (!counterS.ContainsKey(s))
                {
                    counterS[s] = 1;
                }
                else
                {
                    counterS[s] += 1;
                }
            }

            tableAgeDataGridView.Rows.Clear();
            tableAgeDataGridView.Columns.Clear();
            tableAgeDataGridView.Columns.Add("Age", "Age (years)");
            tableAgeDataGridView.Columns.Add("AbsoluteFrequency", "Absolute Frequency");
            tableAgeDataGridView.Columns.Add("RelativeFrequency", "Relative Frequency");
            tableAgeDataGridView.Columns.Add("PercentageFrequency", "Percentage Frequency");

            tableHeightDataGridView.Rows.Clear();
            tableHeightDataGridView.Columns.Clear();
            tableHeightDataGridView.Columns.Add("Height", "Height (m)");
            tableHeightDataGridView.Columns.Add("AbsoluteFrequency", "Absolute Frequency");
            tableHeightDataGridView.Columns.Add("RelativeFrequency", "Relative Frequency");
            tableHeightDataGridView.Columns.Add("PercentageFrequency", "Percentage Frequency");

            tableSportDataGridView.Rows.Clear();
            tableSportDataGridView.Columns.Clear();
            tableSportDataGridView.Columns.Add("Sport", "Sport");
            tableSportDataGridView.Columns.Add("AbsoluteFrequency", "Absolute Frequency");
            tableSportDataGridView.Columns.Add("RelativeFrequency", "Relative Frequency");
            tableSportDataGridView.Columns.Add("PercentageFrequency", "Percentage Frequency");

            foreach (var kvp in counter)
            {
                double relativeFrequency = 0;
                if (lines != null)
                {
                    relativeFrequency = (double)kvp.Value / lines.Count();
                }
                double percentageFrequency = relativeFrequency * 100;

                tableAgeDataGridView.Rows.Add(kvp.Key, kvp.Value, relativeFrequency.ToString("F5"), percentageFrequency.ToString("F2"));
            }

            foreach (var kvp in counterH)
            {
                double relativeFrequency = 0;
                if (lines != null)
                {
                    relativeFrequency = (double)kvp.Value / lines.Count();
                }
                double percentageFrequency = relativeFrequency * 100;

                tableHeightDataGridView.Rows.Add(kvp.Key, kvp.Value, relativeFrequency.ToString("F5"), percentageFrequency.ToString("F2"));
            }

            foreach (var kvp in counterS)
            {
                double relativeFrequency = 0;
                if (lines != null)
                {
                    relativeFrequency = (double)kvp.Value / lines.Count();
                }
                double percentageFrequency = relativeFrequency * 100;

                tableSportDataGridView.Rows.Add(kvp.Key, kvp.Value, relativeFrequency.ToString("F5"), percentageFrequency.ToString("F2"));
            }
        }

        private void Alphabetical(Dictionary<string, int> input, DataGridView dataGridView)
        {
            var keys = input.Keys.ToList();
            keys.Sort();

            var output = new Dictionary<string, int>();

            foreach (var k in keys)
            {
                output[k] = input[k];
            }

            dataGridView.Rows.Clear();

            foreach (var kvp in output)
            {
                double relativeFrequency = (double)kvp.Value / lines.Count();
                double percentageFrequency = relativeFrequency * 100;

                dataGridView.Rows.Add(kvp.Key, kvp.Value, relativeFrequency.ToString("F5"), percentageFrequency.ToString("F2"));
            }
        }

        private void Ascending(Dictionary<string, int> input, DataGridView dataGridView)
        {
            var sortedEntries = input.OrderBy(kvp => kvp.Value).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            dataGridView.Rows.Clear();

            foreach (var kvp in sortedEntries)
            {
                double relativeFrequency = (double)kvp.Value / lines.Count();
                double percentageFrequency = relativeFrequency * 100;

                dataGridView.Rows.Add(kvp.Key, kvp.Value, relativeFrequency.ToString("F5"), percentageFrequency.ToString("F2"));
            }
        }

        private void Descending(Dictionary<string, int> input, DataGridView dataGridView)
        {
            var sortedEntries = input.OrderByDescending(kvp => kvp.Value).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            dataGridView.Rows.Clear();

            foreach (var kvp in sortedEntries)
            {
                double relativeFrequency = (double)kvp.Value / lines.Count();
                double percentageFrequency = relativeFrequency * 100;

                dataGridView.Rows.Add(kvp.Key, kvp.Value, relativeFrequency.ToString("F5"), percentageFrequency.ToString("F2"));
            }
        }

        private void alphabeticalSportButton_Click(object sender, EventArgs e)
        {
            Alphabetical(counterS, tableSportDataGridView);
        }

        private void ascendingSportButton_Click(object sender, EventArgs e)
        {
            Ascending(counterS, tableSportDataGridView);
        }

        private void descendingSportButton_Click(object sender, EventArgs e)
        {
            Descending(counterS, tableSportDataGridView);
        }

        private void alphabeticalAgeButton_Click(object sender, EventArgs e)
        {
            Alphabetical(counter, tableAgeDataGridView);
        }

        private void ascendingAgeButton_Click(object sender, EventArgs e)
        {
            Ascending(counter, tableAgeDataGridView);
        }

        private void descendingAgeButton_Click(object sender, EventArgs e)
        {
            Descending(counter, tableAgeDataGridView);
        }

        private void alphabeticalHeightButton_Click(object sender, EventArgs e)
        {
            Alphabetical(counterH, tableHeightDataGridView);
        }

        private void ascendingHeightButton_Click(object sender, EventArgs e)
        {
            Ascending(counterH, tableHeightDataGridView);
        }

        private void descendingHeightButton_Click(object sender, EventArgs e)
        {
            Descending(counterH, tableHeightDataGridView);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

    }
}