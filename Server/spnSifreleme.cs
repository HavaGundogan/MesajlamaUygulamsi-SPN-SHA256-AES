using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Server
{
    public static class spnSifreleme
    {
        public static object JsonConvert { get; private set; }

        public static string encryption(string _plainText,string _anahtar)
        {
            // 1) Create Process Info
            var psi = new ProcessStartInfo();
            psi.FileName = @"C:\Users\Okan\AppData\Local\Programs\Python\Python39\python.exe";


            // 2) Provide script and arguments
            var script = @"SpnEncryption.py";
            var plainText = _plainText;
            var anahtar = _anahtar;

            psi.Arguments = $"\"{script}\" \"{plainText}\" \"{anahtar}\""; // textboxa alınan verıyı buraya gec

            // 3) Process configuration
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;

            // 4) Execute process and get output

            //var errors = "";
            //var results = "";
            var result = "";
            using (var process = Process.Start(psi))
            {
                result = process.StandardOutput.ReadToEnd();
            }
            return result;
        }

        public static string decryption(string _cipherFullBinary, string _anahtarFullBinary)
        {
            // 1) Create Process Info
            var psi = new ProcessStartInfo();
            psi.FileName = @"C:\Users\Okan\AppData\Local\Programs\Python\Python39\python.exe";

            // 2) Provide script and arguments
            var script = @"SpnDecryption.py";
            string cfb = _cipherFullBinary;
            string afb = _anahtarFullBinary;


            psi.Arguments = $"\"{script}\" \"{cfb}\" \"{afb}\""; // textboxa alınan verıyı buraya gec

            // 3) Process configuration
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;

            // 4) Execute process and get output
            var results = "";

            using (var process = Process.Start(psi))
            {
                var errors = process.StandardError.ReadToEnd();
                results = process.StandardOutput.ReadToEnd();
                //if (errors != string.Empty)
                //{
                //    MessageBox.Show("hata olustu");
                //}
            }
            return results;
        }

        public static gonderilenData deSerializeJSON()
        {
            var jsonVerisi = ""; //Null hatası vermemesi için boş default değer atıyor.
            jsonVerisi =
                File.ReadAllText(@".\encryptData.json"); //Kullanicilar.json okuyup içindekileri jsonVerisi değişkenine atıyor.
            //jsonVerisini list kullanıcı tipine dönüştürüp kullancılar listesine atıyor.
            gonderilenData msg = new gonderilenData();
            msg = JsonSerializer.Deserialize<gonderilenData>(jsonVerisi);
            return msg;
        }

    }
}
