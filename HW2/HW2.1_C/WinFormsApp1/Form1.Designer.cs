namespace WinFormsApp1
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
            dataGridViewAge = new DataGridView();
            dataGridViewHeight = new DataGridView();
            dataGridViewSport = new DataGridView();
            dataGridViewJoin = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSport).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewJoin).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewAge
            // 
            dataGridViewAge.BackgroundColor = Color.DarkSlateGray;
            dataGridViewAge.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAge.Location = new Point(67, 38);
            dataGridViewAge.Name = "dataGridViewAge";
            dataGridViewAge.RowHeadersWidth = 51;
            dataGridViewAge.RowTemplate.Height = 29;
            dataGridViewAge.Size = new Size(578, 255);
            dataGridViewAge.TabIndex = 0;
            // 
            // dataGridViewHeight
            // 
            dataGridViewHeight.BackgroundColor = Color.DarkSlateGray;
            dataGridViewHeight.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHeight.Location = new Point(67, 363);
            dataGridViewHeight.Name = "dataGridViewHeight";
            dataGridViewHeight.RowHeadersWidth = 51;
            dataGridViewHeight.RowTemplate.Height = 29;
            dataGridViewHeight.Size = new Size(578, 250);
            dataGridViewHeight.TabIndex = 1;
            // 
            // dataGridViewSport
            // 
            dataGridViewSport.BackgroundColor = Color.DarkSlateGray;
            dataGridViewSport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSport.Location = new Point(712, 38);
            dataGridViewSport.Name = "dataGridViewSport";
            dataGridViewSport.RowHeadersWidth = 51;
            dataGridViewSport.RowTemplate.Height = 29;
            dataGridViewSport.Size = new Size(588, 255);
            dataGridViewSport.TabIndex = 4;
            dataGridViewSport.CellContentClick += dataGridViewSport_CellContentClick;
            // 
            // dataGridViewJoin
            // 
            dataGridViewJoin.BackgroundColor = Color.DarkSlateGray;
            dataGridViewJoin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewJoin.Location = new Point(712, 363);
            dataGridViewJoin.Name = "dataGridViewJoin";
            dataGridViewJoin.RowHeadersWidth = 51;
            dataGridViewJoin.RowTemplate.Height = 29;
            dataGridViewJoin.Size = new Size(588, 250);
            dataGridViewJoin.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(314, 7);
            label1.Name = "label1";
            label1.Size = new Size(61, 28);
            label1.TabIndex = 6;
            label1.Text = "AGE";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(283, 332);
            label2.Name = "label2";
            label2.Size = new Size(103, 28);
            label2.TabIndex = 7;
            label2.Text = "HEIGHT";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Snow;
            label3.Location = new Point(972, 7);
            label3.Name = "label3";
            label3.Size = new Size(89, 28);
            label3.TabIndex = 8;
            label3.Text = "SPORT";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Snow;
            label4.Location = new Point(813, 332);
            label4.Name = "label4";
            label4.Size = new Size(396, 28);
            label4.TabIndex = 9;
            label4.Text = "join distribution: AGE and SPORT";
            label4.Click += label4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(1369, 625);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridViewJoin);
            Controls.Add(dataGridViewSport);
            Controls.Add(dataGridViewHeight);
            Controls.Add(dataGridViewAge);
            Name = "Form1";
            Text = "Form1";
            TransparencyKey = Color.FromArgb(0, 64, 64);
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAge).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSport).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewJoin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewAge;
        private DataGridView dataGridViewHeight;
        private DataGridView dataGridViewSport;
        private DataGridView dataGridViewJoin;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}