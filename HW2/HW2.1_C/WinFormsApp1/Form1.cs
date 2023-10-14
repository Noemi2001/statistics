using System.Net;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            const string csvUrl = "https://noemi2001.github.io/statistics/HW2/dataset.csv";

            using (var webClient = new WebClient())
            {
                var csvData = webClient.DownloadString(csvUrl);
                var lines = csvData.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                var result = new List<string[]>();
                var headers = lines[0].Split(',');

                var joinLines = 0;

                var columnData = new Dictionary<string, Dictionary<string, int>>();
                var distribuzioneCongiunta = new Dictionary<string, int>();

                foreach (var header in headers)
                {
                    columnData[header] = new Dictionary<string, int>();
                }

                for (int i = 1; i < lines.Length; i++)
                {
                    var currentLine = lines[i].Split(',');
                    var age = currentLine[Array.IndexOf(headers, "Age")];
                    var sport = currentLine[Array.IndexOf(headers, "Sports")];

                    for (int j = 0; j < headers.Length; j++)
                    {
                        var header = headers[j];
                        var cellValue = currentLine[j];

                        if (cellValue != "-")
                        {
                            if (columnData[header].ContainsKey(cellValue))
                            {
                                columnData[header][cellValue] += 1;
                            }
                            else
                            {
                                columnData[header][cellValue] = 1;
                            }
                        }
                    }

                    if (!string.IsNullOrWhiteSpace(age) && !string.IsNullOrWhiteSpace(sport) && age != "-" && sport != "-")
                    {
                        var chiave = $"{age}-{sport}";
                        if (distribuzioneCongiunta.ContainsKey(chiave))
                        {
                            distribuzioneCongiunta[chiave] += 1;
                        }
                        else
                        {
                            distribuzioneCongiunta[chiave] = 1;
                        }
                        joinLines += 1;
                    }
                }

                DisplayData(columnData, distribuzioneCongiunta, joinLines);
            }
        }
        private void DisplayData(Dictionary<string, Dictionary<string, int>> columnData, Dictionary<string, int> distribuzioneCongiunta, int joinLines)
        {

            dataGridViewAge.Rows.Clear();
            dataGridViewAge.Columns.Clear();
            dataGridViewAge.Columns.Add("Age", "Age (years)");
            dataGridViewAge.Columns.Add("AbsoluteFrequency", "Absolute Frequency");
            dataGridViewAge.Columns.Add("RelativeFrequency", "Relative Frequency");
            dataGridViewAge.Columns.Add("PercentageFrequency", "Percentage Frequency");

            foreach (var item in columnData["Age"])
            {
                dataGridViewAge.Rows.Add(item.Key, item.Value, (double)item.Value / joinLines, ((double)item.Value / joinLines) * 100);
            }

            dataGridViewHeight.Rows.Clear();
            dataGridViewHeight.Columns.Clear();
            dataGridViewHeight.Columns.Add("Height", "Height (m)");
            dataGridViewHeight.Columns.Add("AbsoluteFrequency", "Absolute Frequency");
            dataGridViewHeight.Columns.Add("RelativeFrequency", "Relative Frequency");
            dataGridViewHeight.Columns.Add("PercentageFrequency", "Percentage Frequency");

            foreach (var item in columnData["Height"])
            {
                dataGridViewHeight.Rows.Add(item.Key, item.Value, (double)item.Value / joinLines, ((double)item.Value / joinLines) * 100);
            }

            dataGridViewSport.Rows.Clear();
            dataGridViewSport.Columns.Clear();
            dataGridViewSport.Columns.Add("Sport", "Sport");
            dataGridViewSport.Columns.Add("AbsoluteFrequency", "Absolute Frequency");
            dataGridViewSport.Columns.Add("RelativeFrequency", "Relative Frequency");
            dataGridViewSport.Columns.Add("PercentageFrequency", "Percentage Frequency");

            foreach (var item in columnData["Sports"])
            {
                dataGridViewSport.Rows.Add(item.Key, item.Value, (double)item.Value / joinLines, ((double)item.Value / joinLines) * 100);
            }

            dataGridViewJoin.Rows.Clear();
            dataGridViewJoin.Columns.Clear();
            dataGridViewJoin.Columns.Add("AgeSport", "Age - Sport");
            dataGridViewJoin.Columns.Add("AbsoluteFrequency", "Absolute Frequency");
            dataGridViewJoin.Columns.Add("RelativeFrequency", "Relative Frequency");
            dataGridViewJoin.Columns.Add("PercentageFrequency", "Percentage Frequency");

            foreach (var item in distribuzioneCongiunta)
            {
                dataGridViewJoin.Rows.Add(item.Key, item.Value, (double)item.Value / joinLines, ((double)item.Value / joinLines) * 100);
            }
        }

        private void dataGridViewSport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}