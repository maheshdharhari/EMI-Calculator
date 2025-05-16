namespace EMI_Calculator
{
    partial class Form1
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
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxOpeningBalance = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxInterestRateThird = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DateTimePickerEMI = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.DateTimePickerInterestRateFirst = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxInterestRateFirst = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DateTimePickerInterestRateSecond = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxInterestRateSecond = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textEMI = new System.Windows.Forms.TextBox();
            this.DateTimePickerInterestRateThird = new System.Windows.Forms.DateTimePicker();
            this.textBoxPreviousInterest = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnCalculate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCalculate.Location = new System.Drawing.Point(561, 133);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(75, 35);
            this.BtnCalculate.TabIndex = 0;
            this.BtnCalculate.Text = "&OK";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "&Pricipal Amount";
            // 
            // textBoxOpeningBalance
            // 
            this.textBoxOpeningBalance.Location = new System.Drawing.Point(117, 3);
            this.textBoxOpeningBalance.Name = "textBoxOpeningBalance";
            this.textBoxOpeningBalance.Size = new System.Drawing.Size(159, 20);
            this.textBoxOpeningBalance.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxOpeningBalance, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxInterestRateFirst, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxInterestRateSecond, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.DateTimePickerInterestRateThird, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.DateTimePickerInterestRateSecond, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label10, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.DateTimePickerInterestRateFirst, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label8, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.DateTimePickerEMI, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxPreviousInterest, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label11, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.textEMI, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxInterestRateThird, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.BtnCalculate, 3, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(639, 171);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Interest Rate &Third";
            // 
            // textBoxInterestRateThird
            // 
            this.textBoxInterestRateThird.Location = new System.Drawing.Point(117, 107);
            this.textBoxInterestRateThird.Name = "textBoxInterestRateThird";
            this.textBoxInterestRateThird.Size = new System.Drawing.Size(159, 20);
            this.textBoxInterestRateThird.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(282, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "EMI Date";
            // 
            // DateTimePickerEMI
            // 
            this.DateTimePickerEMI.Location = new System.Drawing.Point(400, 29);
            this.DateTimePickerEMI.Name = "DateTimePickerEMI";
            this.DateTimePickerEMI.Size = new System.Drawing.Size(230, 20);
            this.DateTimePickerEMI.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(282, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Interest &Date";
            // 
            // DateTimePickerInterestRateFirst
            // 
            this.DateTimePickerInterestRateFirst.Location = new System.Drawing.Point(400, 55);
            this.DateTimePickerInterestRateFirst.Name = "DateTimePickerInterestRateFirst";
            this.DateTimePickerInterestRateFirst.Size = new System.Drawing.Size(230, 20);
            this.DateTimePickerInterestRateFirst.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Interest Rate &First";
            // 
            // textBoxInterestRateFirst
            // 
            this.textBoxInterestRateFirst.Location = new System.Drawing.Point(117, 55);
            this.textBoxInterestRateFirst.Name = "textBoxInterestRateFirst";
            this.textBoxInterestRateFirst.Size = new System.Drawing.Size(159, 20);
            this.textBoxInterestRateFirst.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(282, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "&Interest Date";
            // 
            // DateTimePickerInterestRateSecond
            // 
            this.DateTimePickerInterestRateSecond.Location = new System.Drawing.Point(400, 81);
            this.DateTimePickerInterestRateSecond.Name = "DateTimePickerInterestRateSecond";
            this.DateTimePickerInterestRateSecond.Size = new System.Drawing.Size(230, 20);
            this.DateTimePickerInterestRateSecond.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Interest Rate &Second";
            // 
            // textBoxInterestRateSecond
            // 
            this.textBoxInterestRateSecond.Location = new System.Drawing.Point(117, 81);
            this.textBoxInterestRateSecond.Name = "textBoxInterestRateSecond";
            this.textBoxInterestRateSecond.Size = new System.Drawing.Size(159, 20);
            this.textBoxInterestRateSecond.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "&EMI";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(282, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "I&nterest Date";
            // 
            // textEMI
            // 
            this.textEMI.Location = new System.Drawing.Point(117, 29);
            this.textEMI.Name = "textEMI";
            this.textEMI.Size = new System.Drawing.Size(159, 20);
            this.textEMI.TabIndex = 6;
            // 
            // DateTimePickerInterestRateThird
            // 
            this.DateTimePickerInterestRateThird.Location = new System.Drawing.Point(400, 107);
            this.DateTimePickerInterestRateThird.Name = "DateTimePickerInterestRateThird";
            this.DateTimePickerInterestRateThird.Size = new System.Drawing.Size(230, 20);
            this.DateTimePickerInterestRateThird.TabIndex = 20;
            // 
            // textBoxPreviousInterest
            // 
            this.textBoxPreviousInterest.Location = new System.Drawing.Point(400, 3);
            this.textBoxPreviousInterest.Name = "textBoxPreviousInterest";
            this.textBoxPreviousInterest.Size = new System.Drawing.Size(230, 20);
            this.textBoxPreviousInterest.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(282, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Previous Interest &Rate";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 197);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "EMI Calculator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxOpeningBalance;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxInterestRateThird;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textEMI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DateTimePickerEMI;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxInterestRateFirst;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxInterestRateSecond;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker DateTimePickerInterestRateFirst;
        private System.Windows.Forms.DateTimePicker DateTimePickerInterestRateSecond;
        private System.Windows.Forms.DateTimePicker DateTimePickerInterestRateThird;
        private System.Windows.Forms.TextBox textBoxPreviousInterest;
        private System.Windows.Forms.Label label11;
    }
}

