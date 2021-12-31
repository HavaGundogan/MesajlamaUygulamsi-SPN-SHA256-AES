using System;
using System.IO;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Windows.Forms;
using Server;

namespace Client
{
    public partial class frmClient : Form
    {
        public frmClient()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        TcpClient client;
        NetworkStream stream;

        BinaryFormatter bf = new BinaryFormatter();
        gonderilenData msg;
        void baglantiDinle()
        {
            while (true)
            {
                

                msg = (gonderilenData)bf.Deserialize(stream);
                if (msg.AnahtarFullBinary == null && msg.cipherMesaj != null)
                {
                    txtAnahtar.Text = "";
                    txtCozulen.Text = "";
                    txtGelen.Text = "";

                    txtAnahtar.Enabled = false;
                    txtCozulen.Enabled = false;

                    txtGelen.Text = msg.cipherMesaj;
                }
                else if (msg.cipherMesaj == null)
                {
                    txtAnahtar.Text = "";
                    txtCozulen.Text = "";
                    txtGelen.Text = "";

                    lblAlinanDosyaAdi.Text = msg.dosyaAdi;
                }
                else
                {
                    txtAnahtar.Text = "";
                    txtCozulen.Text = "";
                    txtGelen.Text = "";

                    txtAnahtar.Enabled = true;
                    txtGelen.Text = msg.cipherMesaj.ToString();
                }



            }
        }
        private void frmClient_Load(object sender, EventArgs e)
        {
            client = new TcpClient("127.0.0.1", 5000);
            stream = client.GetStream();
            Thread dinleyici = new Thread(baglantiDinle);
            dinleyici.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //gonderilenData msg = new gonderilenData();
            //msg.mesaj = txtPlainText.Text;
            //bf.Serialize(stream, msg);
            //stream.Flush();

            //txtPlainText.Clear();
            //txtPlainText.Focus();
        }

        private void btnCoz_Click(object sender, EventArgs e)
        {


            // Use any sort of encoding you like. 
            if (txtAnahtar != null)
            {

                string deger = spnSifreleme.decryption(msg.CipherFullBinary, txtAnahtar.Text);
                txtCozulen.Text = deger.ToString();
            }
            else
            {
                MessageBox.Show("Lutfen anahtar bilgisi giriniz");
            }

        }

        private void lblAlinanDosyaAdi_MouseClick(object sender, MouseEventArgs e)
        {
            byte[] key = new byte[16] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
            byte[] iv = new byte[16] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

            byte[] alinanDosya = rarSifreleme.Decrypt(msg.dosya, key, iv);

            var openFileDialog1 = new SaveFileDialog();

            openFileDialog1.FileName = msg.dosyaAdi;
            openFileDialog1.Filter = "Zip (*.zip)|*.zip";
            openFileDialog1.ShowDialog();

            string diroctary = openFileDialog1.FileName;

            File.WriteAllBytes(diroctary, alinanDosya);
        }
    }
}
