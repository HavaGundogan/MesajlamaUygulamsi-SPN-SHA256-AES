using System;

namespace Server
{
    [Serializable]
    public class gonderilenData
    {
        public string mesaj { get; set; }
        public string cipherMesaj { get; set; }
        public string CipherFullBinary { get; set; }
        public string AnahtarFullBinary { get; set; }
        public byte[] dosya { get; set; }
        public string dosyaAdi { get; set; }
    }
}
