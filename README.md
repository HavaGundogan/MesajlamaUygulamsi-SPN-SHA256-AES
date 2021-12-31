

# Mesajlasma Uygulamsi

<!-- Icindekiler -->
<details open="open">
  <summary>Icindekiler</summary>
  <ol>
    <li><a href="#aciklama">Aciklama</a></li>
    <li>
      <a href="#baslarken">Baslarken</a>
      <ul>
        <li><a href="#geresinimler">Geresinimler</a></li>
        <li><a href="#yukleme">Yukleme</a></li>
      </ul>
    </li>
    <li><a href="#kullanim">Kullanim</a></li>
  </ol>
</details>    

Mesajlasma Uygulamsi şifreli şekilde iki uygulama arası mesaj ve dosya gönderebileceğiniz bir uygulamadır.

## Aciklama
Uyulama Visual Studio 2019 ile gelistirilmistir. Python teknolojisinden yararlanarak gelistirilmiştir.

## Baslarken

### Geresinimler

Visual Studio 2019 ile hazirlanmistir ve Visual Studio 2019'u indirip kullanabilirsiniz. Visual Studio 2019 indirmek icin: [[Visual Studio 2019]](https://visualstudio.microsoft.com/tr/downloads/)
Sisteminizde Python'un yüklü olması gerekmektedir. Python'u indirmek icin: [[Python]](https://www.python.org/downloads/)

### Yukleme
* Depoyu klonlayin
   ```sh
   git clone https://gitlab.com/Cinoxil/alim-satim-uygulamasi.git
   ```

## Kullanim
* İlk önce proje dosyası içerisindeki YazılımSınamaÖdev\Client\Server\bin\Debug\net5.0-windows\Server.exe yi çalıştırmanız ardından projeyi çalıştırmanız gerekmektedir.
* spnSifreleme classının içindeki psi.FileName değişkenine python.exe pathini vermelisiniz.
```python
psi.FileName = @"C:\Users\Okan\AppData\Local\Programs\Python\Python39\python.exe";
```
