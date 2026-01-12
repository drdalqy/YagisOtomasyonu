namespace yagisotomasyonu
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridIller = new System.Windows.Forms.DataGridView();
            this.btnIlEkle = new System.Windows.Forms.Button();
            this.txtIlAdi = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvYagisGirisListe = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.cmbAy = new System.Windows.Forms.ComboBox();
            this.nudYil = new System.Windows.Forms.NumericUpDown();
            this.cmbIl = new System.Windows.Forms.ComboBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnTumunuListele = new System.Windows.Forms.Button();
            this.dgvGrafikListe = new System.Windows.Forms.DataGridView();
            this.btnGrafikGetir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudYilGrafik = new System.Windows.Forms.NumericUpDown();
            this.cmbIlGrafik = new System.Windows.Forms.ComboBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnRaporla = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.yagisDataSet1 = new yagisotomasyonu.Data.YagisDataSet();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridIller)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYagisGirisListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYil)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrafikListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYilGrafik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yagisDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(976, 507);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnGuncelle);
            this.tabPage1.Controls.Add(this.btnSil);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.dataGridIller);
            this.tabPage1.Controls.Add(this.btnIlEkle);
            this.tabPage1.Controls.Add(this.txtIlAdi);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(968, 481);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "İl İşlemleri";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGuncelle.Location = new System.Drawing.Point(293, 86);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 7;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSil.Location = new System.Drawing.Point(162, 87);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 5;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "İl giriniz:";
            // 
            // dataGridIller
            // 
            this.dataGridIller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridIller.Location = new System.Drawing.Point(8, 147);
            this.dataGridIller.Name = "dataGridIller";
            this.dataGridIller.Size = new System.Drawing.Size(561, 248);
            this.dataGridIller.TabIndex = 3;
            this.dataGridIller.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridIller_CellClick);
            // 
            // btnIlEkle
            // 
            this.btnIlEkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnIlEkle.Location = new System.Drawing.Point(23, 87);
            this.btnIlEkle.Name = "btnIlEkle";
            this.btnIlEkle.Size = new System.Drawing.Size(75, 23);
            this.btnIlEkle.TabIndex = 1;
            this.btnIlEkle.Text = "EKLE";
            this.btnIlEkle.UseVisualStyleBackColor = false;
            this.btnIlEkle.Click += new System.EventHandler(this.btnIlEkle_Click);
            // 
            // txtIlAdi
            // 
            this.txtIlAdi.Location = new System.Drawing.Point(108, 22);
            this.txtIlAdi.Name = "txtIlAdi";
            this.txtIlAdi.Size = new System.Drawing.Size(100, 20);
            this.txtIlAdi.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.dgvYagisGirisListe);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtMiktar);
            this.tabPage2.Controls.Add(this.cmbAy);
            this.tabPage2.Controls.Add(this.nudYil);
            this.tabPage2.Controls.Add(this.cmbIl);
            this.tabPage2.Controls.Add(this.btnKaydet);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(968, 481);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Aylık Yağış Girişi";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 0;
            // 
            // dgvYagisGirisListe
            // 
            this.dgvYagisGirisListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYagisGirisListe.Location = new System.Drawing.Point(378, 42);
            this.dgvYagisGirisListe.Name = "dgvYagisGirisListe";
            this.dgvYagisGirisListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvYagisGirisListe.Size = new System.Drawing.Size(552, 268);
            this.dgvYagisGirisListe.TabIndex = 10;
            this.dgvYagisGirisListe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvYagisGirisListe_CellClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Wheat;
            this.button1.Location = new System.Drawing.Point(153, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 34);
            this.button1.TabIndex = 9;
            this.button1.Text = "GÜNCELLE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Miktar giriniz(kg/m²):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ay seçiniz:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Yıl giriniz:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "İl Seçiniz:";
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(141, 211);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(100, 20);
            this.txtMiktar.TabIndex = 4;
            // 
            // cmbAy
            // 
            this.cmbAy.FormattingEnabled = true;
            this.cmbAy.Location = new System.Drawing.Point(141, 155);
            this.cmbAy.Name = "cmbAy";
            this.cmbAy.Size = new System.Drawing.Size(121, 21);
            this.cmbAy.TabIndex = 3;
            // 
            // nudYil
            // 
            this.nudYil.Location = new System.Drawing.Point(140, 101);
            this.nudYil.Maximum = new decimal(new int[] {
            2026,
            0,
            0,
            0});
            this.nudYil.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudYil.Name = "nudYil";
            this.nudYil.Size = new System.Drawing.Size(120, 20);
            this.nudYil.TabIndex = 2;
            this.nudYil.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // cmbIl
            // 
            this.cmbIl.FormattingEnabled = true;
            this.cmbIl.Location = new System.Drawing.Point(140, 42);
            this.cmbIl.Name = "cmbIl";
            this.cmbIl.Size = new System.Drawing.Size(121, 21);
            this.cmbIl.TabIndex = 1;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnKaydet.Location = new System.Drawing.Point(35, 276);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(100, 34);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnTumunuListele);
            this.tabPage3.Controls.Add(this.dgvGrafikListe);
            this.tabPage3.Controls.Add(this.btnGrafikGetir);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.nudYilGrafik);
            this.tabPage3.Controls.Add(this.cmbIlGrafik);
            this.tabPage3.Controls.Add(this.chart1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(968, 481);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Grafik";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnTumunuListele
            // 
            this.btnTumunuListele.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTumunuListele.Location = new System.Drawing.Point(471, 118);
            this.btnTumunuListele.Name = "btnTumunuListele";
            this.btnTumunuListele.Size = new System.Drawing.Size(108, 32);
            this.btnTumunuListele.TabIndex = 7;
            this.btnTumunuListele.Text = "Tümünü Listele";
            this.btnTumunuListele.UseVisualStyleBackColor = false;
            this.btnTumunuListele.Click += new System.EventHandler(this.btnTumunuListele_Click);
            // 
            // dgvGrafikListe
            // 
            this.dgvGrafikListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrafikListe.Location = new System.Drawing.Point(471, 156);
            this.dgvGrafikListe.Name = "dgvGrafikListe";
            this.dgvGrafikListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGrafikListe.Size = new System.Drawing.Size(491, 325);
            this.dgvGrafikListe.TabIndex = 6;
            this.dgvGrafikListe.SelectionChanged += new System.EventHandler(this.dgvGrafikListe_SelectionChanged);
            // 
            // btnGrafikGetir
            // 
            this.btnGrafikGetir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGrafikGetir.Location = new System.Drawing.Point(23, 114);
            this.btnGrafikGetir.Name = "btnGrafikGetir";
            this.btnGrafikGetir.Size = new System.Drawing.Size(95, 36);
            this.btnGrafikGetir.TabIndex = 5;
            this.btnGrafikGetir.Text = "Grafiği getir";
            this.btnGrafikGetir.UseVisualStyleBackColor = false;
            this.btnGrafikGetir.Click += new System.EventHandler(this.btnGrafikGetir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Yıl giriniz:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "İl seçiniz:";
            // 
            // nudYilGrafik
            // 
            this.nudYilGrafik.Location = new System.Drawing.Point(157, 74);
            this.nudYilGrafik.Maximum = new decimal(new int[] {
            2026,
            0,
            0,
            0});
            this.nudYilGrafik.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudYilGrafik.Name = "nudYilGrafik";
            this.nudYilGrafik.Size = new System.Drawing.Size(120, 20);
            this.nudYilGrafik.TabIndex = 2;
            this.nudYilGrafik.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // cmbIlGrafik
            // 
            this.cmbIlGrafik.FormattingEnabled = true;
            this.cmbIlGrafik.Location = new System.Drawing.Point(157, 31);
            this.cmbIlGrafik.Name = "cmbIlGrafik";
            this.cmbIlGrafik.Size = new System.Drawing.Size(121, 21);
            this.cmbIlGrafik.TabIndex = 1;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(-32, 156);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Yağış";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(528, 351);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnRaporla);
            this.tabPage4.Controls.Add(this.reportViewer1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(968, 481);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Rapor";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnRaporla
            // 
            this.btnRaporla.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRaporla.Location = new System.Drawing.Point(650, 6);
            this.btnRaporla.Name = "btnRaporla";
            this.btnRaporla.Size = new System.Drawing.Size(116, 26);
            this.btnRaporla.TabIndex = 1;
            this.btnRaporla.Text = "Raporu Güncelle";
            this.btnRaporla.UseVisualStyleBackColor = false;
            this.btnRaporla.Click += new System.EventHandler(this.btnRaporla_Click_1);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "yagisotomasyonu.Reports.YillikYagisRaporu.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(962, 475);
            this.reportViewer1.TabIndex = 0;
            // 
            // yagisDataSet1
            // 
            this.yagisDataSet1.DataSetName = "YagisDataSet";
            this.yagisDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 507);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "YAĞIŞ OTOMASYONU";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridIller)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYagisGirisListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYil)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrafikListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYilGrafik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.yagisDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnIlEkle;
        private System.Windows.Forms.TextBox txtIlAdi;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridIller;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ComboBox cmbIl;
        private System.Windows.Forms.NumericUpDown nudYil;
        private System.Windows.Forms.ComboBox cmbAy;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox cmbIlGrafik;
        private System.Windows.Forms.NumericUpDown nudYilGrafik;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSil;
        private Data.YagisDataSet yagisDataSet1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGrafikGetir;
        private System.Windows.Forms.DataGridView dgvGrafikListe;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvYagisGirisListe;
        private System.Windows.Forms.Button btnTumunuListele;
        private System.Windows.Forms.Button btnRaporla;
        private System.Windows.Forms.Button btnGuncelle;
    }
}

