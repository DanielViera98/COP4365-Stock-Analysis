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
            comboBox_StartDay = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            comboBox_StartMonth = new ComboBox();
            comboBox_StartYear = new ComboBox();
            comboBox_EndYear = new ComboBox();
            comboBox_EndMonth = new ComboBox();
            comboBox_EndDay = new ComboBox();
            button_UpdateDates = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label6 = new Label();
            label10 = new Label();
            label11 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox_ticker
            // 
            comboBox_ticker.FormattingEnabled = true;
            comboBox_ticker.Location = new Point(72, 5);
            comboBox_ticker.Margin = new Padding(5);
            comboBox_ticker.Name = "comboBox_ticker";
            comboBox_ticker.Size = new Size(100, 33);
            comboBox_ticker.Sorted = true;
            comboBox_ticker.TabIndex = 0;
            // 
            // comboBox_period
            // 
            comboBox_period.FormattingEnabled = true;
            comboBox_period.Items.AddRange(new object[] { "Minute", "10 Minutes", "Hour", "Week", "Month", "6 Months", "Year" });
            comboBox_period.Location = new Point(72, 48);
            comboBox_period.Margin = new Padding(5);
            comboBox_period.Name = "comboBox_period";
            comboBox_period.Size = new Size(100, 33);
            comboBox_period.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 8);
            label1.Margin = new Padding(5);
            label1.Name = "label1";
            label1.Size = new Size(57, 25);
            label1.TabIndex = 2;
            label1.Text = "Ticker";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 51);
            label2.Margin = new Padding(5);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 3;
            label2.Text = "Period";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(59, 321);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(249, 309);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(434, 321);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(585, 321);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 31);
            textBox4.TabIndex = 7;
            // 
            // comboBox_StartDay
            // 
            comboBox_StartDay.FormattingEnabled = true;
            comboBox_StartDay.Location = new Point(103, 38);
            comboBox_StartDay.Name = "comboBox_StartDay";
            comboBox_StartDay.Size = new Size(80, 33);
            comboBox_StartDay.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 41);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 11;
            label3.Text = "Start Time";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 115);
            label4.Name = "label4";
            label4.Size = new Size(85, 25);
            label4.TabIndex = 12;
            label4.Text = "End Time";
            // 
            // comboBox_StartMonth
            // 
            comboBox_StartMonth.FormattingEnabled = true;
            comboBox_StartMonth.Location = new Point(189, 38);
            comboBox_StartMonth.Name = "comboBox_StartMonth";
            comboBox_StartMonth.Size = new Size(80, 33);
            comboBox_StartMonth.TabIndex = 13;
            // 
            // comboBox_StartYear
            // 
            comboBox_StartYear.FormattingEnabled = true;
            comboBox_StartYear.Location = new Point(275, 38);
            comboBox_StartYear.Name = "comboBox_StartYear";
            comboBox_StartYear.Size = new Size(80, 33);
            comboBox_StartYear.TabIndex = 14;
            // 
            // comboBox_EndYear
            // 
            comboBox_EndYear.FormattingEnabled = true;
            comboBox_EndYear.Location = new Point(275, 112);
            comboBox_EndYear.Name = "comboBox_EndYear";
            comboBox_EndYear.Size = new Size(80, 33);
            comboBox_EndYear.TabIndex = 18;
            // 
            // comboBox_EndMonth
            // 
            comboBox_EndMonth.FormattingEnabled = true;
            comboBox_EndMonth.Location = new Point(189, 112);
            comboBox_EndMonth.Name = "comboBox_EndMonth";
            comboBox_EndMonth.Size = new Size(80, 33);
            comboBox_EndMonth.TabIndex = 17;
            // 
            // comboBox_EndDay
            // 
            comboBox_EndDay.FormattingEnabled = true;
            comboBox_EndDay.Location = new Point(103, 112);
            comboBox_EndDay.Name = "comboBox_EndDay";
            comboBox_EndDay.Size = new Size(80, 33);
            comboBox_EndDay.TabIndex = 16;
            // 
            // button_UpdateDates
            // 
            button_UpdateDates.Location = new Point(9, 91);
            button_UpdateDates.Margin = new Padding(5);
            button_UpdateDates.Name = "button_UpdateDates";
            button_UpdateDates.Size = new Size(163, 34);
            button_UpdateDates.TabIndex = 20;
            button_UpdateDates.Text = "Get Dates";
            button_UpdateDates.UseVisualStyleBackColor = true;
            button_UpdateDates.Click += button_UpdateDates_Click;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(comboBox_ticker);
            panel1.Controls.Add(button_UpdateDates);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(comboBox_period);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(179, 132);
            panel1.TabIndex = 22;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label6);
            panel2.Controls.Add(comboBox_StartMonth);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(comboBox_StartDay);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(comboBox_StartYear);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(comboBox_EndYear);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(comboBox_EndMonth);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(comboBox_EndDay);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(12, 146);
            panel2.Name = "panel2";
            panel2.Size = new Size(368, 159);
            panel2.TabIndex = 23;
            // 
            // label7
            // 
            label7.Location = new Point(103, 5);
            label7.Margin = new Padding(5);
            label7.Name = "label7";
            label7.Size = new Size(80, 25);
            label7.TabIndex = 21;
            label7.Text = "Day";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Location = new Point(185, 5);
            label8.Margin = new Padding(5);
            label8.Name = "label8";
            label8.Size = new Size(80, 25);
            label8.TabIndex = 24;
            label8.Text = "Month";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.Location = new Point(275, 5);
            label9.Margin = new Padding(5);
            label9.Name = "label9";
            label9.Size = new Size(80, 25);
            label9.TabIndex = 25;
            label9.Text = "Year";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Location = new Point(275, 79);
            label6.Margin = new Padding(5);
            label6.Name = "label6";
            label6.Size = new Size(80, 25);
            label6.TabIndex = 28;
            label6.Text = "Year";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.Location = new Point(189, 79);
            label10.Margin = new Padding(5);
            label10.Name = "label10";
            label10.Size = new Size(80, 25);
            label10.TabIndex = 27;
            label10.Text = "Month";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.Location = new Point(103, 79);
            label11.Margin = new Padding(5);
            label11.Name = "label11";
            label11.Size = new Size(80, 25);
            label11.TabIndex = 26;
            label11.Text = "Day";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form_entry
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form_entry";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private ComboBox comboBox_StartDay;
        private Label label3;
        private Label label4;
        private ComboBox comboBox_StartMonth;
        private ComboBox comboBox_StartYear;
        private ComboBox comboBox_EndYear;
        private ComboBox comboBox_EndMonth;
        private ComboBox comboBox_EndDay;
        private Button button_UpdateDates;
        private Panel panel1;
        private Panel panel2;
        private Label label7;
        private Label label6;
        private Label label10;
        private Label label11;
        private Label label9;
        private Label label8;
    }
}