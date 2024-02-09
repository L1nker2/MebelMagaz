namespace MebelMagaz
{
    partial class Main
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
            menuPanel = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            viewPanel = new Panel();
            button5 = new Button();
            menuPanel.SuspendLayout();
            SuspendLayout();
            // 
            // menuPanel
            // 
            menuPanel.Controls.Add(button5);
            menuPanel.Controls.Add(button4);
            menuPanel.Controls.Add(button3);
            menuPanel.Controls.Add(button2);
            menuPanel.Controls.Add(button1);
            menuPanel.Dock = DockStyle.Left;
            menuPanel.Location = new Point(0, 0);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(200, 721);
            menuPanel.TabIndex = 0;
            // 
            // button4
            // 
            button4.Location = new Point(10, 360);
            button4.Name = "button4";
            button4.Size = new Size(180, 40);
            button4.TabIndex = 3;
            button4.Text = "Услуги";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(10, 406);
            button3.Name = "button3";
            button3.Size = new Size(180, 40);
            button3.TabIndex = 2;
            button3.Text = "Товар";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(10, 452);
            button2.Name = "button2";
            button2.Size = new Size(180, 40);
            button2.TabIndex = 1;
            button2.Text = "Клиенты";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(10, 498);
            button1.Name = "button1";
            button1.Size = new Size(180, 40);
            button1.TabIndex = 0;
            button1.Text = "О программе";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // viewPanel
            // 
            viewPanel.Dock = DockStyle.Fill;
            viewPanel.Location = new Point(200, 0);
            viewPanel.Name = "viewPanel";
            viewPanel.Size = new Size(1148, 721);
            viewPanel.TabIndex = 1;
            // 
            // button5
            // 
            button5.Location = new Point(10, 314);
            button5.Name = "button5";
            button5.Size = new Size(180, 40);
            button5.TabIndex = 4;
            button5.Text = "Сделки";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 721);
            Controls.Add(viewPanel);
            Controls.Add(menuPanel);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "Main";
            Text = "Магазин мебели";
            menuPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel menuPanel;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel viewPanel;
        private Button button5;
    }
}