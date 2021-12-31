using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Server.Testler
{
    [TestFixture]
    class UnitTestler
    {
        [Test]
        public void spnTest() //1. unit test
        {
            spnSifreleme.encryption("test mesaj", "anahtar");
            gonderilenData msg = new gonderilenData();
            msg = spnSifreleme.deSerializeJSON();

            Assert.AreEqual("test mesaj", spnSifreleme.decryption(msg.CipherFullBinary, msg.AnahtarFullBinary));
        }

        [Test]
        public void sha256Test() //2. unit test
        {
            HashAlgoritmasi ha = new HashAlgoritmasi();
            gonderilenData msg = new gonderilenData();
            msg.cipherMesaj = ha.Sha256Enc("test mesaj");

            Assert.AreEqual("9559c25ff3f5c22bf506e7faa7ca0451ffdaa4d50be65c92d7ee35474199a385", msg.cipherMesaj);
        }

        [Test]
        public void baglantiTest() //3. unit test
        {
            frmServer frm = new frmServer();
            Socket socket;
            NetworkStream stream;
            TcpListener listener;

            listener = new TcpListener(5000);
            listener.Start();

            socket = listener.AcceptSocket();
            stream = new NetworkStream(socket);
            Thread dinle = new Thread(frm.soketDinle);
            dinle.Start();

            string dir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName;

            dir = dir + @"Client\bin\Debug\net5.0-windows\Client.exe";

            Process.Start(dir);

            Assert.AreEqual(true, socket.Connected);
        }

        [Test]
        public void doyaZipleme() //4. unit test
        {
            byte[] key = new byte[16] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
            byte[] iv = new byte[16] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

            byte[] bytes = Encoding.ASCII.GetBytes("test mesaj");

            byte[] sifreliByte = rarSifreleme.Encrypt(bytes, key, iv);


            Assert.AreEqual("test mesaj", rarSifreleme.Decrypt(bytes, key, iv));
        }

        public void shaKarakterUzunluğu() //5. unit test
        {
            HashAlgoritmasi ha = new HashAlgoritmasi();
            gonderilenData msg = new gonderilenData();
            msg.cipherMesaj = ha.Sha256Enc("test mesaj");

            Assert.AreEqual(64, msg.cipherMesaj.Length);
        }
    }
}
