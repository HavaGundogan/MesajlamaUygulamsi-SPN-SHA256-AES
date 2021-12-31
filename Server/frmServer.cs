using System;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Windows.Forms;

namespace Server
{
    public partial class frmServer : Form
    {
        public frmServer()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        Socket socket;
        NetworkStream stream;
        TcpListener listener;

        private void frmServer_Load(object sender, EventArgs e)
        {
            radioSpn.Checked = true;
            listener = new TcpListener(5000);
            listener.Start();

            socket = listener.AcceptSocket();
            stream = new NetworkStream(socket);
            Thread dinle = new Thread(soketDinle);
            dinle.Start();
        }

        BinaryFormatter bf = new BinaryFormatter();
        public void soketDinle()
        {
            while (socket.Connected)
            {
                gonderilenData alinan = (gonderilenData) bf.Deserialize(stream);
                //txtGelen.Text = alinan.ToString();
            }
        }

        private void btnMesajGonder_Click(object sender, EventArgs e)
        {
            if (radioSpn.Checked)
            {
                txtAnahtar.Enabled = true;
                spnSifreleme.encryption(txtGiden.Text, txtAnahtar.Text);
                gonderilenData msg = new gonderilenData();
                msg = spnSifreleme.deSerializeJSON();
                bf.Serialize(stream, msg);
                stream.Flush();
            }
            else if (radioSha.Checked)
            {
                
                HashAlgoritmasi ha = new HashAlgoritmasi();
                gonderilenData msg = new gonderilenData();
                msg.cipherMesaj = ha.Sha256Enc(txtGiden.Text);
                bf.Serialize(stream, msg);
                stream.Flush();
            }


            txtAnahtar.Clear();
            txtGiden.Clear();
            txtGiden.Focus();
        }

        private void radioSpn_Click(object sender, EventArgs e)
        {
            txtAnahtar.Enabled = true;
        }

        private void radioSha_Click(object sender, EventArgs e)
        {
            txtAnahtar.Enabled = false;
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            var sifreliRar = rarSifreleme.sikistir();

            gonderilenData msg = new gonderilenData();
            msg.dosya = sifreliRar.Item1;
            msg.dosyaAdi = sifreliRar.Item2;
            bf.Serialize(stream, msg);
            stream.Flush();
            txtDosyaAdi.Text = sifreliRar.Item2;
        }
    }
}
