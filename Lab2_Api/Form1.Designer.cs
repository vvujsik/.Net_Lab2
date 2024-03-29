namespace Lab2_Api
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
            buttonDownload = new Button();
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            City_text = new TextBox();
            label1 = new Label();
            button_reset = new Button();
            label3 = new Label();
            textBox_ID = new TextBox();
            button_remove = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label4 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            button4 = new Button();
            label5 = new Label();
            label6 = new Label();
            button5 = new Button();
            SuspendLayout();
            // 
            // buttonDownload
            // 
            buttonDownload.Location = new Point(724, 125);
            buttonDownload.Name = "buttonDownload";
            buttonDownload.Size = new Size(142, 54);
            buttonDownload.TabIndex = 1;
            buttonDownload.Text = "Add";
            buttonDownload.UseVisualStyleBackColor = true;
            buttonDownload.Click += buttonDownload_ClickAsync;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(28, 38);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(548, 404);
            listBox1.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(901, 220);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(142, 27);
            textBox1.TabIndex = 3;
            // 
            // City_text
            // 
            City_text.Location = new Point(724, 75);
            City_text.Name = "City_text";
            City_text.Size = new Size(142, 27);
            City_text.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(724, 52);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 5;
            label1.Text = "Nazwa miasta:";
            // 
            // button_reset
            // 
            button_reset.Location = new Point(900, 376);
            button_reset.Name = "button_reset";
            button_reset.Size = new Size(142, 29);
            button_reset.TabIndex = 7;
            button_reset.Text = "RESET BAZY";
            button_reset.UseVisualStyleBackColor = true;
            button_reset.Click += button_reset_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.Location = new Point(670, 304);
            label3.Name = "label3";
            label3.Size = new Size(29, 20);
            label3.TabIndex = 8;
            label3.Text = "ID:";
            // 
            // textBox_ID
            // 
            textBox_ID.Location = new Point(670, 327);
            textBox_ID.Name = "textBox_ID";
            textBox_ID.Size = new Size(125, 27);
            textBox_ID.TabIndex = 9;
            // 
            // button_remove
            // 
            button_remove.Location = new Point(670, 374);
            button_remove.Name = "button_remove";
            button_remove.Size = new Size(125, 29);
            button_remove.TabIndex = 10;
            button_remove.Text = "Remove by ID";
            button_remove.UseVisualStyleBackColor = true;
            button_remove.Click += button_remove_Click;
            // 
            // button1
            // 
            button1.Location = new Point(594, 73);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 11;
            button1.Text = "Temp_asc";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(594, 108);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 12;
            button2.Text = "Temp_des";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(594, 143);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 13;
            button3.Text = "ID";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label4.Location = new Point(594, 50);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 14;
            label4.Text = "Sort by:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(901, 75);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(142, 27);
            textBox2.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.Location = new Point(901, 52);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 16;
            label2.Text = "Country:";
            // 
            // button4
            // 
            button4.Location = new Point(901, 125);
            button4.Name = "button4";
            button4.Size = new Size(142, 54);
            button4.TabIndex = 17;
            button4.Text = "Average in Country";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label5.Location = new Point(900, 197);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 18;
            label5.Text = "Average:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label6.Location = new Point(28, 15);
            label6.Name = "label6";
            label6.Size = new Size(175, 20);
            label6.TabIndex = 19;
            label6.Text = "Zawartość bazy danych:";
            // 
            // button5
            // 
            button5.Location = new Point(594, 178);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 20;
            button5.Text = "Country";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1078, 458);
            Controls.Add(button5);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button4);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button_remove);
            Controls.Add(textBox_ID);
            Controls.Add(label3);
            Controls.Add(button_reset);
            Controls.Add(label1);
            Controls.Add(City_text);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Controls.Add(buttonDownload);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonDownload;
        private ListBox listBox1;
        private TextBox textBox1;
        private TextBox City_text;
        private Label label1;
        private Button button_reset;
        private Label label3;
        private TextBox textBox_ID;
        private Button button_remove;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label4;
        private TextBox textBox2;
        private Label label2;
        private Button button4;
        private Label label5;
        private Label label6;
        private Button button5;
    }
}
