namespace MebelMagaz
{
    partial class ContractForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            label3 = new Label();
            comboBox3 = new ComboBox();
            label2 = new Label();
            comboBox2 = new ComboBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1124, 420);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(12, 669);
            button1.Name = "button1";
            button1.Size = new Size(140, 40);
            button1.TabIndex = 1;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(158, 669);
            button2.Name = "button2";
            button2.Size = new Size(140, 40);
            button2.TabIndex = 2;
            button2.Text = "Удалить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(comboBox3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(button3);
            panel1.Location = new Point(304, 438);
            panel1.Name = "panel1";
            panel1.Size = new Size(299, 271);
            panel1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 10);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 6;
            label3.Text = "Товар";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(3, 48);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(244, 28);
            comboBox3.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 88);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 4;
            label2.Text = "Телефон клиента";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(3, 120);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(244, 28);
            comboBox2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 160);
            label1.Name = "label1";
            label1.Size = new Size(278, 20);
            label1.TabIndex = 2;
            label1.Text = "Дополнительный сервис (если нужно)";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(3, 192);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(244, 28);
            comboBox1.TabIndex = 1;
            // 
            // button3
            // 
            button3.Location = new Point(42, 226);
            button3.Name = "button3";
            button3.Size = new Size(155, 40);
            button3.TabIndex = 0;
            button3.Text = "Подтвердить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // ContractForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1148, 721);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ContractForm";
            Text = "ContractForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Panel panel1;
        private Button button3;
        private Label label3;
        private ComboBox comboBox3;
        private Label label2;
        private ComboBox comboBox2;
        private Label label1;
        private ComboBox comboBox1;
    }
}