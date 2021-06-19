namespace Genetik_Algoritma
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.cozbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cizbutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.degerbutton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.doldur = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.DimGray;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.ForeColor = System.Drawing.Color.Aquamarine;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(145, 40);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(162, 148);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.DimGray;
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox2.ForeColor = System.Drawing.Color.Aquamarine;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(326, 42);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(149, 148);
            this.listBox2.TabIndex = 1;
            // 
            // cozbutton
            // 
            this.cozbutton.BackColor = System.Drawing.Color.DimGray;
            this.cozbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cozbutton.ForeColor = System.Drawing.Color.Aquamarine;
            this.cozbutton.Location = new System.Drawing.Point(241, 221);
            this.cozbutton.Name = "cozbutton";
            this.cozbutton.Size = new System.Drawing.Size(75, 44);
            this.cozbutton.TabIndex = 3;
            this.cozbutton.Text = "Çöz";
            this.cozbutton.UseVisualStyleBackColor = false;
            this.cozbutton.Click += new System.EventHandler(this.cozbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pc:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(8, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "İterasyon Sayısı:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.DimGray;
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDown1.ForeColor = System.Drawing.Color.Aquamarine;
            this.numericUpDown1.Location = new System.Drawing.Point(30, 239);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(84, 22);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(5, 291);
            this.chart1.Name = "chart1";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Toplam";
            series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(987, 300);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cizbutton
            // 
            this.cizbutton.BackColor = System.Drawing.Color.DimGray;
            this.cizbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cizbutton.ForeColor = System.Drawing.Color.Aquamarine;
            this.cizbutton.Location = new System.Drawing.Point(326, 221);
            this.cizbutton.Name = "cizbutton";
            this.cizbutton.Size = new System.Drawing.Size(75, 44);
            this.cizbutton.TabIndex = 11;
            this.cizbutton.Text = "Çiz";
            this.cizbutton.UseVisualStyleBackColor = false;
            this.cizbutton.Click += new System.EventHandler(this.cizbutton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(478, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(298, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Maksimum Ulaştığı Küme Toplam Nokta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(491, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(285, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Minimum Ulaştığı Küme Toplam Nokta:";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.DimGray;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox3.ForeColor = System.Drawing.Color.Aquamarine;
            this.textBox3.Location = new System.Drawing.Point(773, 14);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 14;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.DimGray;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox4.ForeColor = System.Drawing.Color.Aquamarine;
            this.textBox4.Location = new System.Drawing.Point(773, 48);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 15;
            // 
            // degerbutton
            // 
            this.degerbutton.BackColor = System.Drawing.Color.DimGray;
            this.degerbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.degerbutton.ForeColor = System.Drawing.Color.Aquamarine;
            this.degerbutton.Location = new System.Drawing.Point(773, 90);
            this.degerbutton.Name = "degerbutton";
            this.degerbutton.Size = new System.Drawing.Size(100, 44);
            this.degerbutton.TabIndex = 16;
            this.degerbutton.Text = "Değer Bul";
            this.degerbutton.UseVisualStyleBackColor = false;
            this.degerbutton.Click += new System.EventHandler(this.degerbutton_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DimGray;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.Aquamarine;
            this.button3.Location = new System.Drawing.Point(952, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 35);
            this.button3.TabIndex = 17;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.MouseLeave += new System.EventHandler(this.renk2);
            this.button3.MouseHover += new System.EventHandler(this.renk);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DimGray;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ForeColor = System.Drawing.Color.Aquamarine;
            this.button4.Location = new System.Drawing.Point(906, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(40, 35);
            this.button4.TabIndex = 18;
            this.button4.Text = "-";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            this.button4.MouseLeave += new System.EventHandler(this.renk2);
            this.button4.MouseHover += new System.EventHandler(this.renk);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(333, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 18);
            this.label6.TabIndex = 19;
            this.label6.Text = "Formül Sonuçları";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(166, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 18);
            this.label7.TabIndex = 20;
            this.label7.Text = "Random Küme";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown5);
            this.groupBox1.Controls.Add(this.numericUpDown4);
            this.groupBox1.Controls.Add(this.numericUpDown3);
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Aquamarine;
            this.groupBox1.Location = new System.Drawing.Point(5, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(140, 273);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı Paneli";
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.BackColor = System.Drawing.Color.DimGray;
            this.numericUpDown5.DecimalPlaces = 2;
            this.numericUpDown5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDown5.ForeColor = System.Drawing.Color.Aquamarine;
            this.numericUpDown5.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown5.Location = new System.Drawing.Point(40, 29);
            this.numericUpDown5.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(84, 22);
            this.numericUpDown5.TabIndex = 17;
            this.numericUpDown5.Value = new decimal(new int[] {
            70,
            0,
            0,
            131072});
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.BackColor = System.Drawing.Color.DimGray;
            this.numericUpDown4.DecimalPlaces = 4;
            this.numericUpDown4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDown4.ForeColor = System.Drawing.Color.Aquamarine;
            this.numericUpDown4.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.numericUpDown4.Location = new System.Drawing.Point(40, 72);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            262144});
            this.numericUpDown4.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            262144});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(84, 22);
            this.numericUpDown4.TabIndex = 16;
            this.numericUpDown4.Value = new decimal(new int[] {
            10,
            0,
            0,
            262144});
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.BackColor = System.Drawing.Color.DimGray;
            this.numericUpDown3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDown3.ForeColor = System.Drawing.Color.Aquamarine;
            this.numericUpDown3.Location = new System.Drawing.Point(30, 133);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDown3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(84, 22);
            this.numericUpDown3.TabIndex = 15;
            this.numericUpDown3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.BackColor = System.Drawing.Color.DimGray;
            this.numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDown2.ForeColor = System.Drawing.Color.Aquamarine;
            this.numericUpDown2.Location = new System.Drawing.Point(30, 183);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(84, 22);
            this.numericUpDown2.TabIndex = 14;
            this.numericUpDown2.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(8, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 18);
            this.label12.TabIndex = 12;
            this.label12.Text = "Seçkinlik Sayısı";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(2, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 18);
            this.label9.TabIndex = 10;
            this.label9.Text = "Popülasyon Sayısı";
            // 
            // doldur
            // 
            this.doldur.BackColor = System.Drawing.Color.DimGray;
            this.doldur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.doldur.ForeColor = System.Drawing.Color.Aquamarine;
            this.doldur.Location = new System.Drawing.Point(160, 221);
            this.doldur.Name = "doldur";
            this.doldur.Size = new System.Drawing.Size(75, 44);
            this.doldur.TabIndex = 27;
            this.doldur.Text = "Doldur";
            this.doldur.UseVisualStyleBackColor = false;
            this.doldur.Click += new System.EventHandler(this.doldur_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(448, 247);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(473, 18);
            this.label10.TabIndex = 28;
            this.label10.Text = "Not: Lütfen popülasyon sayısı ile seçkinlik sayısını dengeli giriniz";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(994, 608);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.doldur);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.degerbutton);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cizbutton);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.cozbutton);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.ForeColor = System.Drawing.Color.Aquamarine;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button cozbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button cizbutton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button degerbutton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button doldur;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Label label10;
    }
}

