namespace HW4_1_C
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
            label1 = new Label();
            label2 = new Label();
            numberVariablesTextBox = new NumericUpDown();
            numberElementsTextBox = new NumericUpDown();
            tableJOIN = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            inputFieldsPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)numberVariablesTextBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numberElementsTextBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tableJOIN).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(545, 49);
            label1.Name = "label1";
            label1.Size = new Size(144, 20);
            label1.TabIndex = 0;
            label1.Text = "Number of variables";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(446, 91);
            label2.Name = "label2";
            label2.Size = new Size(243, 20);
            label2.TabIndex = 1;
            label2.Text = "Number of elements each variables";
            // 
            // numberVariablesTextBox
            // 
            numberVariablesTextBox.Location = new Point(725, 42);
            numberVariablesTextBox.Name = "numberVariablesTextBox";
            numberVariablesTextBox.Size = new Size(150, 27);
            numberVariablesTextBox.TabIndex = 2;
            // 
            // numberElementsTextBox
            // 
            numberElementsTextBox.Location = new Point(725, 84);
            numberElementsTextBox.Name = "numberElementsTextBox";
            numberElementsTextBox.Size = new Size(150, 27);
            numberElementsTextBox.TabIndex = 3;
            // 
            // tableJOIN
            // 
            tableJOIN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableJOIN.Location = new Point(164, 370);
            tableJOIN.Name = "tableJOIN";
            tableJOIN.RowHeadersWidth = 51;
            tableJOIN.RowTemplate.Height = 29;
            tableJOIN.Size = new Size(1262, 380);
            tableJOIN.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(972, 62);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Send";
            button1.UseVisualStyleBackColor = true;
            button1.Click += generateInputButton_Click;
            // 
            // button2
            // 
            button2.Location = new Point(682, 319);
            button2.Name = "button2";
            button2.Size = new Size(230, 29);
            button2.TabIndex = 6;
            button2.Text = "Send";
            button2.UseVisualStyleBackColor = true;
            button2.Click += generateDataButton_Click;
            // 
            // inputFieldsPanel
            // 
            inputFieldsPanel.Location = new Point(184, 142);
            inputFieldsPanel.Name = "inputFieldsPanel";
            inputFieldsPanel.Size = new Size(1242, 155);
            inputFieldsPanel.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1576, 865);
            Controls.Add(inputFieldsPanel);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(tableJOIN);
            Controls.Add(numberElementsTextBox);
            Controls.Add(numberVariablesTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numberVariablesTextBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)numberElementsTextBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)tableJOIN).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private NumericUpDown numberVariablesTextBox;
        private NumericUpDown numberElementsTextBox;
        private DataGridView tableJOIN;
        private Button button1;
        private Button button2;
        private Panel inputFieldsPanel;
    }
}