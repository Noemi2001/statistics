namespace HW2._3_C
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
            button1 = new Button();
            N = new Label();
            label1 = new Label();
            CounterDataGridView = new DataGridView();
            NumberNTextBox = new TextBox();
            NumberKTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)CounterDataGridView).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(149, 278);
            button1.Name = "button1";
            button1.Size = new Size(135, 56);
            button1.TabIndex = 0;
            button1.Text = "Send";
            button1.UseVisualStyleBackColor = true;
            button1.Click += GenerateRandomDataButton_Click;
            // 
            // N
            // 
            N.AutoSize = true;
            N.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            N.ForeColor = SystemColors.ButtonHighlight;
            N.Location = new Point(60, 104);
            N.Name = "N";
            N.Size = new Size(34, 35);
            N.TabIndex = 1;
            N.Text = "N";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(60, 177);
            label1.Name = "label1";
            label1.Size = new Size(30, 35);
            label1.TabIndex = 2;
            label1.Text = "K";
            label1.Click += label1_Click;
            // 
            // CounterDataGridView
            // 
            CounterDataGridView.BackgroundColor = SystemColors.Control;
            CounterDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CounterDataGridView.Location = new Point(412, 46);
            CounterDataGridView.Name = "CounterDataGridView";
            CounterDataGridView.RowHeadersWidth = 51;
            CounterDataGridView.RowTemplate.Height = 29;
            CounterDataGridView.Size = new Size(333, 374);
            CounterDataGridView.TabIndex = 3;
            // 
            // NumberNTextBox
            // 
            NumberNTextBox.Location = new Point(124, 112);
            NumberNTextBox.Name = "NumberNTextBox";
            NumberNTextBox.Size = new Size(200, 27);
            NumberNTextBox.TabIndex = 4;
            // 
            // NumberKTextBox
            // 
            NumberKTextBox.Location = new Point(124, 185);
            NumberKTextBox.Name = "NumberKTextBox";
            NumberKTextBox.Size = new Size(200, 27);
            NumberKTextBox.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(800, 450);
            Controls.Add(NumberKTextBox);
            Controls.Add(NumberNTextBox);
            Controls.Add(CounterDataGridView);
            Controls.Add(label1);
            Controls.Add(N);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)CounterDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label N;
        private Label label1;
        private DataGridView CounterDataGridView;
        private TextBox NumberNTextBox;
        private TextBox NumberKTextBox;
    }
}