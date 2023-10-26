using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüphane_Yönetim_Sistemi
{
    public partial class FormKitaplar : Form
    {
        //Sql bağlantısının yapılması
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-TRVT52D;Initial Catalog=KutuphaneVTYS;Integrated Security=True");
        public FormKitaplar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Kitap ekleme kodları
            try
            {
                baglanti.Open();

                SqlCommand sqlCommand = new SqlCommand("INSERT INTO Kitaplar  (KitapAdi,YazarAdi,ISBN,Durum,KitapTurKod) VALUES (@P1,@P2,@P3,@P4,@P5)", baglanti);
                sqlCommand.Parameters.AddWithValue("@P1", textBox2.Text);
                sqlCommand.Parameters.AddWithValue("@P2", textBox3.Text);
                sqlCommand.Parameters.AddWithValue("@P3", textBox4.Text);
                sqlCommand.Parameters.AddWithValue("@P4", "True");
                sqlCommand.Parameters.AddWithValue("@P5", textBox6.Text);

                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kitap eklenirken bir hata meydana geldi,lütfen veritabanını kontrol edin !" + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
            verileriGoster();
        }

        private void verileriGoster()
        //Databaseden veri çekme ve tablo oluşturma
        {
            try
            {
                string q = "SELECT * FROM Kitaplar";
                SqlDataAdapter da = new SqlDataAdapter(q, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FormKitaplar_Load(object sender, EventArgs e)
        {
            verileriGoster();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        //Data kısmının seçim iplementasyonu 
        {
            label11.Text = "0";
            int secilensatir = dataGridView1.SelectedCells[0].RowIndex;
            label2.Text = dataGridView1.Rows[secilensatir].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secilensatir].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[secilensatir].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[secilensatir].Cells[3].Value.ToString();
            textBox6.Text = dataGridView1.Rows[secilensatir].Cells[7].Value.ToString();

            textBox1.Text = dataGridView1.Rows[secilensatir].Cells[5].Value.ToString();
            if (dataGridView1.Rows[secilensatir].Cells[6].Value != DBNull.Value)
                dateTimePicker1.Value = (DateTime)dataGridView1.Rows[secilensatir].Cells[6].Value;
        }

        private void button1_Click(object sender, EventArgs e)
        //Kitap güncelleme işlemleri
        {
            try
            {
                baglanti.Open();
                SqlCommand sqlCommand = new SqlCommand("UPDATE Kitaplar SET KitapAdi=@P1,YazarAdi=@P2,ISBN=@P3,KitapTurKod=@P5 WHERE ID=@P6", baglanti);
                sqlCommand.Parameters.AddWithValue("@P1", textBox2.Text);
                sqlCommand.Parameters.AddWithValue("@P2", textBox3.Text);
                sqlCommand.Parameters.AddWithValue("@P3", textBox4.Text);
                sqlCommand.Parameters.AddWithValue("@P5", textBox6.Text);
                sqlCommand.Parameters.AddWithValue("@P6", label2.Text);

                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Parametreler güncellenirken hata meydana geldi !", ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
            verileriGoster();
        }

        private void button5_Click(object sender, EventArgs e)
        //Ödünç işlemleri
        {
            if (label2.Text != "-")
            {
                try
                {
                    baglanti.Open();

                    SqlCommand sqlCommand = new SqlCommand("UPDATE Kitaplar SET OduncAlan=@P1,OduncTarihi=@P2,Durum=@P3 WHERE ID=@P4", baglanti);
                    sqlCommand.Parameters.AddWithValue("@P1", textBox1.Text);
                    sqlCommand.Parameters.Add("@P2", SqlDbType.Date).Value = dateTimePicker1.Value.Date;
                    sqlCommand.Parameters.AddWithValue("@P3", "False");
                    sqlCommand.Parameters.AddWithValue("@P4", label2.Text);

                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kitap ödünç sırasında bir hatayla karşılaştık !" + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }
                verileriGoster();
            }
            else
            {
                MessageBox.Show("Lütfen bir kitap seçiniz !");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label2.Text != "-")
            {
                DateTime bugununtarihi = DateTime.Now;
                int gunFarki = (int)(bugununtarihi - dateTimePicker1.Value.Date).TotalDays;
                if (gunFarki > 10)
                {
                    int ceza = (gunFarki - 10) * 1;
                    label11.Text = Convert.ToString(ceza);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label2.Text != "-")
            {
                try
                {
                    baglanti.Open();
                    SqlCommand sqlCommand = new SqlCommand("UPDATE Kitaplar SET OduncAlan=@P1,OduncTarihi=@P2,Durum=@P3 WHERE ID=@P4", baglanti);

                    sqlCommand.Parameters.AddWithValue("@P1", "");
                    sqlCommand.Parameters.Add("@P2", SqlDbType.Date).Value = DBNull.Value;
                    sqlCommand.Parameters.AddWithValue("@P3", "False");
                    sqlCommand.Parameters.AddWithValue("@P4", label2.Text);
                    textBox1.Text = "";

                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kitap iade sırasında bir hata meydana geldi !", ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }
                verileriGoster();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label2.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox6.Text = " ";
            textBox1.Text = " ";
        }

        private void FormKitaplar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }

}
