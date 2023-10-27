namespace HW4_C
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
            tableAgeDataGridView = new DataGridView();
            tableHeightDataGridView = new DataGridView();
            tableSportDataGridView = new DataGridView();
            button2 = new Button();
            numberIntervalsQantitativeDescreteTextBox = new NumericUpDown();
            numberIntervalsQantitativeContinousTextBox = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            alphabeticalSportButton = new Button();
            ascendingSportButton = new Button();
            descendingSportButton = new Button();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            ((System.ComponentModel.ISupportInitialize)tableAgeDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tableHeightDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tableSportDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numberIntervalsQantitativeDescreteTextBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numberIntervalsQantitativeContinousTextBox).BeginInit();
            SuspendLayout();
            // 
            // tableAgeDataGridView
            // 
            tableAgeDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableAgeDataGridView.Location = new Point(29, 230);
            tableAgeDataGridView.Name = "tableAgeDataGridView";
            tableAgeDataGridView.RowHeadersWidth = 51;
            tableAgeDataGridView.RowTemplate.Height = 29;
            tableAgeDataGridView.Size = new Size(490, 277);
            tableAgeDataGridView.TabIndex = 0;
            // 
            // tableHeightDataGridView
            // 
            tableHeightDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableHeightDataGridView.Location = new Point(545, 230);
            tableHeightDataGridView.Name = "tableHeightDataGridView";
            tableHeightDataGridView.RowHeadersWidth = 51;
            tableHeightDataGridView.RowTemplate.Height = 29;
            tableHeightDataGridView.Size = new Size(484, 277);
            tableHeightDataGridView.TabIndex = 1;
            tableHeightDataGridView.CellContentClick += dataGridView2_CellContentClick;
            // 
            // tableSportDataGridView
            // 
            tableSportDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableSportDataGridView.Location = new Point(1059, 230);
            tableSportDataGridView.Name = "tableSportDataGridView";
            tableSportDataGridView.RowHeadersWidth = 51;
            tableSportDataGridView.RowTemplate.Height = 29;
            tableSportDataGridView.Size = new Size(485, 277);
            tableSportDataGridView.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(461, 102);
            button2.Name = "button2";
            button2.Size = new Size(130, 48);
            button2.TabIndex = 4;
            button2.Text = "send";
            button2.UseVisualStyleBackColor = true;
            button2.Click += FrequencyCalculation;
            // 
            // numberIntervalsQantitativeDescreteTextBox
            // 
            numberIntervalsQantitativeDescreteTextBox.Location = new Point(196, 79);
            numberIntervalsQantitativeDescreteTextBox.Name = "numberIntervalsQantitativeDescreteTextBox";
            numberIntervalsQantitativeDescreteTextBox.Size = new Size(150, 27);
            numberIntervalsQantitativeDescreteTextBox.TabIndex = 6;
            // 
            // numberIntervalsQantitativeContinousTextBox
            // 
            numberIntervalsQantitativeContinousTextBox.Location = new Point(697, 79);
            numberIntervalsQantitativeContinousTextBox.Name = "numberIntervalsQantitativeContinousTextBox";
            numberIntervalsQantitativeContinousTextBox.Size = new Size(150, 27);
            numberIntervalsQantitativeContinousTextBox.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(210, 56);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 9;
            label1.Text = "intervals number\r\n";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(711, 56);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 10;
            label2.Text = "intervals number\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(114, 9);
            label3.Name = "label3";
            label3.Size = new Size(370, 37);
            label3.TabIndex = 11;
            label3.Text = "Quantitative descrete variable";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(593, 9);
            label4.Name = "label4";
            label4.Size = new Size(387, 37);
            label4.TabIndex = 12;
            label4.Text = "Quantitative continous variable";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(1186, 9);
            label5.Name = "label5";
            label5.Size = new Size(247, 37);
            label5.TabIndex = 13;
            label5.Text = "Qualitative variable";
            // 
            // alphabeticalSportButton
            // 
            alphabeticalSportButton.Location = new Point(1221, 67);
            alphabeticalSportButton.Name = "alphabeticalSportButton";
            alphabeticalSportButton.Size = new Size(175, 29);
            alphabeticalSportButton.TabIndex = 14;
            alphabeticalSportButton.Text = "alphabetic order";
            alphabeticalSportButton.UseVisualStyleBackColor = true;
            alphabeticalSportButton.Click += alphabeticalSportButton_Click;
            // 
            // ascendingSportButton
            // 
            ascendingSportButton.Location = new Point(1221, 102);
            ascendingSportButton.Name = "ascendingSportButton";
            ascendingSportButton.Size = new Size(175, 29);
            ascendingSportButton.TabIndex = 15;
            ascendingSportButton.Text = "ascendant order";
            ascendingSportButton.UseVisualStyleBackColor = true;
            ascendingSportButton.Click += ascendingSportButton_Click;
            // 
            // descendingSportButton
            // 
            descendingSportButton.Location = new Point(1221, 137);
            descendingSportButton.Name = "descendingSportButton";
            descendingSportButton.Size = new Size(175, 29);
            descendingSportButton.TabIndex = 16;
            descendingSportButton.Text = "descendant order";
            descendingSportButton.UseVisualStyleBackColor = true;
            descendingSportButton.Click += descendingSportButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(687, 148);
            button1.Name = "button1";
            button1.Size = new Size(175, 29);
            button1.TabIndex = 17;
            button1.Text = "key order";
            button1.UseVisualStyleBackColor = true;
            button1.Click += alphabeticalHeightButton_Click;
            // 
            // button3
            // 
            button3.Location = new Point(593, 183);
            button3.Name = "button3";
            button3.Size = new Size(175, 29);
            button3.TabIndex = 18;
            button3.Text = "ascendant order";
            button3.UseVisualStyleBackColor = true;
            button3.Click += ascendingHeightButton_Click;
            // 
            // button4
            // 
            button4.Location = new Point(774, 183);
            button4.Name = "button4";
            button4.Size = new Size(175, 29);
            button4.TabIndex = 19;
            button4.Text = "descendant order";
            button4.UseVisualStyleBackColor = true;
            button4.Click += descendingHeightButton_Click;
            // 
            // button5
            // 
            button5.Location = new Point(273, 183);
            button5.Name = "button5";
            button5.Size = new Size(175, 29);
            button5.TabIndex = 22;
            button5.Text = "descendant order";
            button5.UseVisualStyleBackColor = true;
            button5.Click += descendingAgeButton_Click;
            // 
            // button6
            // 
            button6.Location = new Point(92, 183);
            button6.Name = "button6";
            button6.Size = new Size(175, 29);
            button6.TabIndex = 21;
            button6.Text = "ascendant order";
            button6.UseVisualStyleBackColor = true;
            button6.Click += ascendingAgeButton_Click;
            // 
            // button7
            // 
            button7.Location = new Point(186, 148);
            button7.Name = "button7";
            button7.Size = new Size(175, 29);
            button7.TabIndex = 20;
            button7.Text = "key order";
            button7.UseVisualStyleBackColor = true;
            button7.Click += alphabeticalAgeButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1569, 656);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(descendingSportButton);
            Controls.Add(ascendingSportButton);
            Controls.Add(alphabeticalSportButton);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numberIntervalsQantitativeContinousTextBox);
            Controls.Add(numberIntervalsQantitativeDescreteTextBox);
            Controls.Add(button2);
            Controls.Add(tableSportDataGridView);
            Controls.Add(tableHeightDataGridView);
            Controls.Add(tableAgeDataGridView);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)tableAgeDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)tableHeightDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)tableSportDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)numberIntervalsQantitativeDescreteTextBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)numberIntervalsQantitativeContinousTextBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tableAgeDataGridView;
        private DataGridView tableHeightDataGridView;
        private DataGridView tableSportDataGridView;
        private Button button2;
        private NumericUpDown numberIntervalsQantitativeDescreteTextBox;
        private NumericUpDown numberIntervalsQantitativeContinousTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button alphabeticalSportButton;
        private Button ascendingSportButton;
        private Button descendingSportButton;
        private Button button1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
    }
}