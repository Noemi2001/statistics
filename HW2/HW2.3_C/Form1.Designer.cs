namespace HW2_3C_bis
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            N = new Label();
            label1 = new Label();
            NumberNTextBox = new TextBox();
            NumberKTextBox = new TextBox();
            CounterDataGridView = new DataGridView();
            GenerateRandomData = new Button();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)CounterDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // N
            // 
            N.AutoSize = true;
            N.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            N.ForeColor = SystemColors.ButtonHighlight;
            N.Location = new Point(38, 148);
            N.Name = "N";
            N.Size = new Size(37, 37);
            N.TabIndex = 0;
            N.Text = "N";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(38, 221);
            label1.Name = "label1";
            label1.Size = new Size(33, 37);
            label1.TabIndex = 1;
            label1.Text = "K";
            // 
            // NumberNTextBox
            // 
            NumberNTextBox.Location = new Point(129, 148);
            NumberNTextBox.Name = "NumberNTextBox";
            NumberNTextBox.Size = new Size(125, 27);
            NumberNTextBox.TabIndex = 2;
            // 
            // NumberKTextBox
            // 
            NumberKTextBox.Location = new Point(129, 231);
            NumberKTextBox.Name = "NumberKTextBox";
            NumberKTextBox.Size = new Size(125, 27);
            NumberKTextBox.TabIndex = 3;
            // 
            // CounterDataGridView
            // 
            CounterDataGridView.BackgroundColor = SystemColors.ButtonHighlight;
            CounterDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CounterDataGridView.Location = new Point(292, 42);
            CounterDataGridView.Name = "CounterDataGridView";
            CounterDataGridView.RowHeadersWidth = 51;
            CounterDataGridView.RowTemplate.Height = 29;
            CounterDataGridView.Size = new Size(605, 375);
            CounterDataGridView.TabIndex = 4;
            // 
            // GenerateRandomData
            // 
            GenerateRandomData.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            GenerateRandomData.ForeColor = Color.DarkSlateGray;
            GenerateRandomData.Location = new Point(62, 315);
            GenerateRandomData.Name = "GenerateRandomData";
            GenerateRandomData.Size = new Size(177, 50);
            GenerateRandomData.TabIndex = 5;
            GenerateRandomData.Text = "Send";
            GenerateRandomData.UseVisualStyleBackColor = true;
            GenerateRandomData.Click += GenerateRandomData_Click;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(912, 42);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(629, 375);
            chart1.TabIndex = 6;
            chart1.Text = "chart1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(1592, 738);
            Controls.Add(chart1);
            Controls.Add(GenerateRandomData);
            Controls.Add(CounterDataGridView);
            Controls.Add(NumberKTextBox);
            Controls.Add(NumberNTextBox);
            Controls.Add(label1);
            Controls.Add(N);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)CounterDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label N;
        private Label label1;
        private TextBox NumberNTextBox;
        private TextBox NumberKTextBox;
        private DataGridView CounterDataGridView;
        private Button GenerateRandomData;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}