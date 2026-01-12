using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace yagisotomasyonu
{
    public partial class Form1 : Form
    {
        
        YagisDBEntities db = new YagisDBEntities();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            AylariDoldur();
            VerileriYukle();
            this.reportViewer1.RefreshReport();
        }

        private void AylariDoldur()
        {
            if (cmbAy.Items.Count == 0)
            {
                string[] aylar = { "Ocak", "Şubat", "Mart", "Nisan", "Mayıs", "Haziran",
                                  "Temmuz", "Ağustos", "Eylül", "Ekim", "Kasım", "Aralık" };
                cmbAy.Items.AddRange(aylar);
            }
        }

        private void VerileriYukle()
        {
            try
            {
                var yagisListesi = db.Yagislar.Select(x => new {
                    x.YagisId,
                    IlAdi = x.Iller.IlAdi,
                    x.Yil,
                    x.Ay,
                    x.Miktar
                }).ToList();

                dataGridIller.DataSource = db.Iller.Select(x => new { x.IlId, x.IlAdi }).ToList();

                if (dgvYagisGirisListe != null)
                {
                    dgvYagisGirisListe.DataSource = null; 
                    dgvYagisGirisListe.DataSource = yagisListesi;
                }

                if (dgvGrafikListe != null)
                {
                    dgvGrafikListe.DataSource = null; 
                    dgvGrafikListe.DataSource = yagisListesi;
                }

                var iller = db.Iller.ToList();
                cmbIl.DataSource = iller;
                cmbIl.DisplayMember = "IlAdi";
                cmbIl.ValueMember = "IlId";

                cmbIlGrafik.DataSource = iller.ToList();
                cmbIlGrafik.DisplayMember = "IlAdi";
                cmbIlGrafik.ValueMember = "IlId";
            }
            catch (Exception ex) { MessageBox.Show("Hata: " + ex.Message); }
        }



        private void dataGridIller_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtIlAdi.Text = dataGridIller.Rows[e.RowIndex].Cells["IlAdi"].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridIller.CurrentRow != null && !string.IsNullOrEmpty(txtIlAdi.Text))
            {
                int seciliIlId = Convert.ToInt32(dataGridIller.CurrentRow.Cells["IlId"].Value);
                var guncellenecekIl = db.Iller.Find(seciliIlId);

                if (guncellenecekIl != null)
                {
                    guncellenecekIl.IlAdi = txtIlAdi.Text;
                    db.SaveChanges();
                    VerileriYukle();
                    MessageBox.Show("İl adı güncellendi.");
                }
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (dataGridIller.CurrentRow != null)
            {
                dynamic seciliSatir = dataGridIller.CurrentRow.DataBoundItem;
                int id = seciliSatir.IlId; 

                var silinecekIl = db.Iller.Find(id);

                if (silinecekIl != null)
                {
                    DialogResult onay = MessageBox.Show(silinecekIl.IlAdi + " ilini silmek istiyor musunuz?", "Silme Onayı", MessageBoxButtons.YesNo);
                    if (onay == DialogResult.Yes)
                    {
                        try
                        {
                            db.Iller.Remove(silinecekIl);
                            db.SaveChanges();
                            VerileriYukle(); 
                            txtIlAdi.Clear();
                            MessageBox.Show("İl başarıyla silindi.");
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Bu ile ait yağış verileri olduğu için önce o verileri silmelisiniz!");
                        }
                    }
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbAy.SelectedItem == null) { MessageBox.Show("Lütfen ay seçin!"); return; }

                Yagislar yeni = new Yagislar
                {
                    IlId = (int)cmbIl.SelectedValue,
                    Yil = (int)nudYil.Value,
                    Ay = cmbAy.SelectedItem.ToString(),
                    Miktar = int.Parse(txtMiktar.Text)
                };
                db.Yagislar.Add(yeni);
                db.SaveChanges();
                VerileriYukle();
                MessageBox.Show("Yağış verisi kaydedildi.");
            }
            catch (Exception ex) { MessageBox.Show("Hata: " + ex.Message); }
        }

        private void btnGrafikCiz_Click(object sender, EventArgs e)
        {
            int seciliIl = (int)cmbIlGrafik.SelectedValue;
            int seciliYil = (int)nudYilGrafik.Value;

            var aylikVeriler = db.Yagislar
                .Where(x => x.IlId == seciliIl && x.Yil == seciliYil)
                .ToList();

            chart1.Series["Yağış"].Points.Clear();
            chart1.Series["Yağış"].ChartType = SeriesChartType.Line;
            chart1.Series["Yağış"].BorderWidth = 3;

            foreach (var v in aylikVeriler)
            {
                chart1.Series["Yağış"].Points.AddXY(v.Ay, v.Miktar);
            }
        }

        private void btnRaporla_Click(object sender, EventArgs e)
        {
            var raporVerisi = db.Yagislar
                .GroupBy(x => new { x.Iller.IlAdi, x.Yil })
                .Select(g => new {
                    IlAdi = g.Key.IlAdi,
                    Yil = g.Key.Yil,
                    ToplamMiktar = g.Sum(y => y.Miktar)
                }).ToList();

            ReportDataSource rds = new ReportDataSource("YagisDataSet", raporVerisi);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }

        private void dgvYagisGirisListe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvYagisGirisListe.Rows[e.RowIndex];
                cmbIl.Text = row.Cells["IlAdi"].Value.ToString();
                nudYil.Value = Convert.ToDecimal(row.Cells["Yil"].Value);
                cmbAy.Text = row.Cells["Ay"].Value.ToString();
                txtMiktar.Text = row.Cells["Miktar"].Value.ToString();
            }
        }

        private void btnIlEkle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIlAdi.Text))
            {
                Iller yeniIl = new Iller { IlAdi = txtIlAdi.Text };
                db.Iller.Add(yeniIl);

                db.SaveChanges();

                VerileriYukle();

                txtIlAdi.Clear();
                MessageBox.Show(yeniIl.IlAdi + " başarıyla eklendi ve liste güncellendi.");
            }
            else
            {
                MessageBox.Show("Lütfen bir il adı giriniz!");
            }
        }

        private void btnGrafikGetir_Click(object sender, EventArgs e)
        {
            try
            {
                int seciliIlId = (int)cmbIlGrafik.SelectedValue;
                int seciliYil = (int)nudYilGrafik.Value;

                var grafikVerisi = db.Yagislar
                    .Where(x => x.IlId == seciliIlId && x.Yil == seciliYil)
                    .OrderBy(x => x.YagisId)
                    .ToList();

                dgvGrafikListe.DataSource = grafikVerisi;

                chart1.Series["Yağış"].Points.Clear();

                chart1.Series["Yağış"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chart1.Series["Yağış"].BorderWidth = 3;

                if (grafikVerisi.Count > 0)
                {
                    foreach (var veri in grafikVerisi)
                    {
                        chart1.Series["Yağış"].Points.AddXY(veri.Ay, veri.Miktar);
                    }
                }
                else
                {
                    MessageBox.Show("Seçilen il ve yıl için veri bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void dgvGrafikListe_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvGrafikListe.CurrentRow != null)
            {
                try
                {
                    
                    string seciliIlAdi = dgvGrafikListe.CurrentRow.Cells["IlAdi"].Value.ToString();
                    int seciliYil = Convert.ToInt32(dgvGrafikListe.CurrentRow.Cells["Yil"].Value);

                    var grafikVerisi = db.Yagislar
                        .Where(x => x.Iller.IlAdi == seciliIlAdi && x.Yil == seciliYil)
                        .OrderBy(x => x.YagisId)
                        .ToList();

                    chart1.Series["Yağış"].Points.Clear();
                    chart1.Series["Yağış"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

                    chart1.Titles.Clear();
                    chart1.Titles.Add(seciliIlAdi + " İli " + seciliYil + " Yılı Yağış Dağılımı");

                    foreach (var veri in grafikVerisi)
                    {
                        chart1.Series["Yağış"].Points.AddXY(veri.Ay, veri.Miktar);
                    }
                }
                catch (Exception)
                {
                }
            }
        }

        private void btnTumunuListele_Click(object sender, EventArgs e)
        {
            VerileriYukle();

            if (txtIlAdi != null) txtIlAdi.Clear();

            MessageBox.Show("Tüm kayıtlar listelendi.");
        }

        private void btnRaporla_Click_1(object sender, EventArgs e)
        {
            var raporVerisi = db.Yagislar
        .GroupBy(x => new { x.Iller.IlAdi, x.Yil })
        .Select(g => new {
            IlAdi = g.Key.IlAdi,
            Yil = g.Key.Yil,
            Toplam = g.Sum(y => y.Miktar) 
        }).ToList();

            ReportDataSource rds = new ReportDataSource("YagisDataSet", raporVerisi);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridIller.CurrentRow != null && !string.IsNullOrEmpty(txtIlAdi.Text))
            {
                
                int id = Convert.ToInt32(dataGridIller.CurrentRow.Cells[0].Value);

               
                var guncellenecekIl = db.Iller.Find(id);

                if (guncellenecekIl != null)
                {
                   
                    guncellenecekIl.IlAdi = txtIlAdi.Text;

                    db.SaveChanges(); 
                    VerileriYukle();  
                    txtIlAdi.Clear();
                    MessageBox.Show("İl adı başarıyla güncellendi.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen listeden bir il seçin ve yeni adını kutuya yazın.");
            }
        }



        
    }
}