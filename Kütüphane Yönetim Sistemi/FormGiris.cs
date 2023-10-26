using System.Data.SqlClient;

namespace Kütüphane_Yönetim_Sistemi
{
    public partial class FormGiris : Form
    {
        FormKitaplar formKitaplar;
        public FormGiris()
        {
            InitializeComponent();
        }
        //Sql bağlantısının yapılması
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-TRVT52D;Initial Catalog=KutuphaneVTYS;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            //Giriş işlemleri
            string sifre = "";
            try
            {
                baglanti.Open();
                SqlCommand sqlKomut = new SqlCommand("SELECT Sifre FROM KutuphaneAdmin WHERE KullaniciAdi = @p1", baglanti);
                sqlKomut.Parameters.AddWithValue("@p1", textBox1.Text);
                SqlDataReader sqlDataReader = sqlKomut.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    sifre = sqlDataReader[0].ToString();
                }

                if (sifre == textBox2.Text)
                {

                    formKitaplar = new FormKitaplar();
                    this.Hide();
                    formKitaplar.Show();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı !");
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bağlantı Hatası" + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                textBox2.UseSystemPasswordChar = true;
                checkBox1.Text = "Göster";
            }
            else
            {
                textBox2.UseSystemPasswordChar = false;
                checkBox1.Text = "Gizle";
            }
        }
    }
}