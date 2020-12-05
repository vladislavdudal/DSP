namespace trDSP
{
    partial class DSP_1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButtonPoly = new System.Windows.Forms.RadioButton();
            this.radioButtonHarm = new System.Windows.Forms.RadioButton();
            this.textBoxFi = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.textBoxF = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxSignal = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxN = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label100 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.textBoxFi5 = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxFi4 = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.textBoxF5 = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.textBoxFi3 = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.textBoxA5 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBoxF4 = new System.Windows.Forms.TextBox();
            this.textBoxFi2 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBoxA4 = new System.Windows.Forms.TextBox();
            this.textBoxF3 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxFi1 = new System.Windows.Forms.TextBox();
            this.textBoxA3 = new System.Windows.Forms.TextBox();
            this.textBoxF2 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxA2 = new System.Windows.Forms.TextBox();
            this.textBoxF1 = new System.Windows.Forms.TextBox();
            this.textBoxA1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea4.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea4);
            this.chart.Location = new System.Drawing.Point(5, 7);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(1021, 309);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(5, 487);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1022, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "Рассчитать";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButtonPoly
            // 
            this.radioButtonPoly.AutoSize = true;
            this.radioButtonPoly.Location = new System.Drawing.Point(9, 365);
            this.radioButtonPoly.Name = "radioButtonPoly";
            this.radioButtonPoly.Size = new System.Drawing.Size(129, 17);
            this.radioButtonPoly.TabIndex = 11;
            this.radioButtonPoly.Text = "Полигармонический";
            this.radioButtonPoly.UseVisualStyleBackColor = true;
            // 
            // radioButtonHarm
            // 
            this.radioButtonHarm.AutoSize = true;
            this.radioButtonHarm.Checked = true;
            this.radioButtonHarm.Location = new System.Drawing.Point(9, 343);
            this.radioButtonHarm.Name = "radioButtonHarm";
            this.radioButtonHarm.Size = new System.Drawing.Size(104, 17);
            this.radioButtonHarm.TabIndex = 10;
            this.radioButtonHarm.TabStop = true;
            this.radioButtonHarm.Text = "Гармонический";
            this.radioButtonHarm.UseVisualStyleBackColor = true;
            // 
            // textBoxFi
            // 
            this.textBoxFi.Location = new System.Drawing.Point(239, 436);
            this.textBoxFi.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFi.Name = "textBoxFi";
            this.textBoxFi.Size = new System.Drawing.Size(149, 20);
            this.textBoxFi.TabIndex = 59;
            this.textBoxFi.Text = "0";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(409, 457);
            this.label40.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(86, 13);
            this.label40.TabIndex = 50;
            this.label40.Text = "5-ая гармоника";
            // 
            // textBoxF
            // 
            this.textBoxF.Location = new System.Drawing.Point(239, 395);
            this.textBoxF.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxF.Name = "textBoxF";
            this.textBoxF.Size = new System.Drawing.Size(149, 20);
            this.textBoxF.TabIndex = 58;
            this.textBoxF.Text = "2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 29;
            // 
            // comboBoxSignal
            // 
            this.comboBoxSignal.FormattingEnabled = true;
            this.comboBoxSignal.Items.AddRange(new object[] {
            "Синусоидальный",
            "Пилообразный",
            "Треугольный",
            "Дополнительный"});
            this.comboBoxSignal.Location = new System.Drawing.Point(9, 440);
            this.comboBoxSignal.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxSignal.Name = "comboBoxSignal";
            this.comboBoxSignal.Size = new System.Drawing.Size(172, 21);
            this.comboBoxSignal.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(221, 408);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 23;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(409, 429);
            this.label39.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(86, 13);
            this.label39.TabIndex = 56;
            this.label39.Text = "4-ая гармоника";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(239, 352);
            this.textBoxA.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(149, 20);
            this.textBoxA.TabIndex = 43;
            this.textBoxA.Text = "10";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.89076F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label37.Location = new System.Drawing.Point(6, 389);
            this.label37.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(19, 18);
            this.label37.TabIndex = 28;
            this.label37.Text = "N";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 19;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(409, 401);
            this.label38.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(86, 13);
            this.label38.TabIndex = 57;
            this.label38.Text = "3-ая гармоника";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 436);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "φ";
            // 
            // comboBoxN
            // 
            this.comboBoxN.AutoCompleteCustomSource.AddRange(new string[] {
            "512",
            "1024",
            "2048"});
            this.comboBoxN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxN.FormattingEnabled = true;
            this.comboBoxN.Items.AddRange(new object[] {
            "512",
            "1024",
            "2048"});
            this.comboBoxN.Location = new System.Drawing.Point(9, 411);
            this.comboBoxN.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxN.Name = "comboBoxN";
            this.comboBoxN.Size = new System.Drawing.Size(172, 21);
            this.comboBoxN.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "f";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(409, 375);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(86, 13);
            this.label19.TabIndex = 55;
            this.label19.Text = "2-ая гармоника";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "A";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(949, 332);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 13);
            this.label12.TabIndex = 54;
            this.label12.Text = "φ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(758, 333);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(10, 13);
            this.label11.TabIndex = 53;
            this.label11.Text = "f";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(543, 332);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 13);
            this.label10.TabIndex = 52;
            this.label10.Text = "A";
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.Location = new System.Drawing.Point(409, 349);
            this.label100.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(86, 13);
            this.label100.TabIndex = 51;
            this.label100.Text = "1-ая гармоника";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(850, 471);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(0, 13);
            this.label31.TabIndex = 31;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(854, 440);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(0, 13);
            this.label25.TabIndex = 32;
            // 
            // textBoxFi5
            // 
            this.textBoxFi5.Location = new System.Drawing.Point(878, 455);
            this.textBoxFi5.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFi5.Name = "textBoxFi5";
            this.textBoxFi5.Size = new System.Drawing.Size(149, 20);
            this.textBoxFi5.TabIndex = 49;
            this.textBoxFi5.Text = "0";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(673, 476);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(0, 13);
            this.label32.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(859, 359);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 30;
            // 
            // textBoxFi4
            // 
            this.textBoxFi4.Location = new System.Drawing.Point(877, 426);
            this.textBoxFi4.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFi4.Name = "textBoxFi4";
            this.textBoxFi4.Size = new System.Drawing.Size(149, 20);
            this.textBoxFi4.TabIndex = 46;
            this.textBoxFi4.Text = "0";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(491, 465);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(0, 13);
            this.label33.TabIndex = 18;
            // 
            // textBoxF5
            // 
            this.textBoxF5.Location = new System.Drawing.Point(699, 455);
            this.textBoxF5.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxF5.Name = "textBoxF5";
            this.textBoxF5.Size = new System.Drawing.Size(149, 20);
            this.textBoxF5.TabIndex = 45;
            this.textBoxF5.Text = "2";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(676, 448);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(0, 13);
            this.label26.TabIndex = 21;
            // 
            // textBoxFi3
            // 
            this.textBoxFi3.Location = new System.Drawing.Point(877, 400);
            this.textBoxFi3.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFi3.Name = "textBoxFi3";
            this.textBoxFi3.Size = new System.Drawing.Size(149, 20);
            this.textBoxFi3.TabIndex = 44;
            this.textBoxFi3.Text = "0";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(495, 444);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(0, 13);
            this.label27.TabIndex = 17;
            // 
            // textBoxA5
            // 
            this.textBoxA5.Location = new System.Drawing.Point(519, 455);
            this.textBoxA5.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxA5.Name = "textBoxA5";
            this.textBoxA5.Size = new System.Drawing.Size(149, 20);
            this.textBoxA5.TabIndex = 42;
            this.textBoxA5.Text = "10";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(920, 385);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(0, 13);
            this.label20.TabIndex = 26;
            // 
            // textBoxF4
            // 
            this.textBoxF4.Location = new System.Drawing.Point(699, 431);
            this.textBoxF4.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxF4.Name = "textBoxF4";
            this.textBoxF4.Size = new System.Drawing.Size(149, 20);
            this.textBoxF4.TabIndex = 33;
            this.textBoxF4.Text = "2";
            // 
            // textBoxFi2
            // 
            this.textBoxFi2.Location = new System.Drawing.Point(877, 375);
            this.textBoxFi2.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFi2.Name = "textBoxFi2";
            this.textBoxFi2.Size = new System.Drawing.Size(149, 20);
            this.textBoxFi2.TabIndex = 34;
            this.textBoxFi2.Text = "0";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(497, 416);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(0, 13);
            this.label21.TabIndex = 16;
            // 
            // textBoxA4
            // 
            this.textBoxA4.Location = new System.Drawing.Point(518, 426);
            this.textBoxA4.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxA4.Name = "textBoxA4";
            this.textBoxA4.Size = new System.Drawing.Size(149, 20);
            this.textBoxA4.TabIndex = 41;
            this.textBoxA4.Text = "10";
            // 
            // textBoxF3
            // 
            this.textBoxF3.Location = new System.Drawing.Point(699, 403);
            this.textBoxF3.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxF3.Name = "textBoxF3";
            this.textBoxF3.Size = new System.Drawing.Size(149, 20);
            this.textBoxF3.TabIndex = 35;
            this.textBoxF3.Text = "2";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(678, 388);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 13);
            this.label14.TabIndex = 25;
            // 
            // textBoxFi1
            // 
            this.textBoxFi1.Location = new System.Drawing.Point(877, 349);
            this.textBoxFi1.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFi1.Name = "textBoxFi1";
            this.textBoxFi1.Size = new System.Drawing.Size(149, 20);
            this.textBoxFi1.TabIndex = 36;
            this.textBoxFi1.Text = "0";
            // 
            // textBoxA3
            // 
            this.textBoxA3.Location = new System.Drawing.Point(518, 399);
            this.textBoxA3.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxA3.Name = "textBoxA3";
            this.textBoxA3.Size = new System.Drawing.Size(149, 20);
            this.textBoxA3.TabIndex = 37;
            this.textBoxA3.Text = "10";
            // 
            // textBoxF2
            // 
            this.textBoxF2.Location = new System.Drawing.Point(699, 375);
            this.textBoxF2.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxF2.Name = "textBoxF2";
            this.textBoxF2.Size = new System.Drawing.Size(149, 20);
            this.textBoxF2.TabIndex = 38;
            this.textBoxF2.Text = "2";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(496, 388);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 13);
            this.label15.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(681, 362);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 24;
            // 
            // textBoxA2
            // 
            this.textBoxA2.Location = new System.Drawing.Point(518, 375);
            this.textBoxA2.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxA2.Name = "textBoxA2";
            this.textBoxA2.Size = new System.Drawing.Size(149, 20);
            this.textBoxA2.TabIndex = 39;
            this.textBoxA2.Text = "10";
            // 
            // textBoxF1
            // 
            this.textBoxF1.Location = new System.Drawing.Point(699, 349);
            this.textBoxF1.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxF1.Name = "textBoxF1";
            this.textBoxF1.Size = new System.Drawing.Size(149, 20);
            this.textBoxF1.TabIndex = 40;
            this.textBoxF1.Text = "2";
            // 
            // textBoxA1
            // 
            this.textBoxA1.Location = new System.Drawing.Point(518, 349);
            this.textBoxA1.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxA1.Name = "textBoxA1";
            this.textBoxA1.Size = new System.Drawing.Size(149, 20);
            this.textBoxA1.TabIndex = 47;
            this.textBoxA1.Text = "10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(500, 362);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 20;
            // 
            // DSP_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1034, 527);
            this.Controls.Add(this.radioButtonPoly);
            this.Controls.Add(this.radioButtonHarm);
            this.Controls.Add(this.textBoxFi);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.textBoxF);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxSignal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label100);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.textBoxFi5);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxFi4);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.textBoxF5);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.textBoxFi3);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.textBoxA5);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.textBoxF4);
            this.Controls.Add(this.textBoxFi2);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.textBoxA4);
            this.Controls.Add(this.textBoxF3);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBoxFi1);
            this.Controls.Add(this.textBoxA3);
            this.Controls.Add(this.textBoxF2);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxA2);
            this.Controls.Add(this.textBoxF1);
            this.Controls.Add(this.textBoxA1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart);
            this.Name = "DSP_1";
            this.Text = "Лаб1";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButtonPoly;
        private System.Windows.Forms.RadioButton radioButtonHarm;
        private System.Windows.Forms.TextBox textBoxFi;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TextBox textBoxF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxSignal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox textBoxFi5;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxFi4;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox textBoxF5;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox textBoxFi3;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox textBoxA5;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBoxF4;
        private System.Windows.Forms.TextBox textBoxFi2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBoxA4;
        private System.Windows.Forms.TextBox textBoxF3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxFi1;
        private System.Windows.Forms.TextBox textBoxA3;
        private System.Windows.Forms.TextBox textBoxF2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxA2;
        private System.Windows.Forms.TextBox textBoxF1;
        private System.Windows.Forms.TextBox textBoxA1;
        private System.Windows.Forms.Label label9;
    }
}

