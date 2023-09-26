using System.Diagnostics;

namespace COP4365
{
    partial class Form_entry
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
            comboBox_ticker = new ComboBox();
            comboBox_period = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // comboBox_ticker
            // 
            comboBox_ticker.FormattingEnabled = true;
            comboBox_ticker.Location = new Point(220, 89);
            comboBox_ticker.Name = "comboBox_ticker";
            comboBox_ticker.Size = new Size(182, 33);
            comboBox_ticker.Sorted = true;
            comboBox_ticker.TabIndex = 0;
            // 
            // comboBox_period
            // 
            comboBox_period.FormattingEnabled = true;
            comboBox_period.Items.AddRange(new object[] { "Minute", "10 Minutes", "Hour", "Week", "Month", "6 Months", "Year" });
            comboBox_period.Location = new Point(588, 89);
            comboBox_period.Name = "comboBox_period";
            comboBox_period.Size = new Size(114, 33);
            comboBox_period.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(155, 92);
            label1.Name = "label1";
            label1.Size = new Size(57, 25);
            label1.TabIndex = 2;
            label1.Text = "Ticker";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(525, 92);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 3;
            label2.Text = "Period";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(62, 260);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(252, 248);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(481, 197);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(552, 234);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 31);
            textBox4.TabIndex = 7;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(502, 297);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(150, 31);
            textBox5.TabIndex = 8;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(220, 144);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.Sorted = true;
            comboBox1.TabIndex = 9;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(520, 144);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(182, 33);
            comboBox2.Sorted = true;
            comboBox2.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(157, 147);
            label3.Name = "label3";
            label3.Size = new Size(57, 25);
            label3.TabIndex = 11;
            label3.Text = "Ticker";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(457, 147);
            label4.Name = "label4";
            label4.Size = new Size(57, 25);
            label4.TabIndex = 12;
            label4.Text = "Ticker";
            // 
            // Form_entry
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox_period);
            Controls.Add(comboBox_ticker);
            Name = "Form_entry";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox_ticker;
        private ComboBox comboBox_period;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label3;
        private Label label4;
    }
}