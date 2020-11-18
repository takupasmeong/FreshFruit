# Fresh Fruit App
implementasi MVC membuat aplikasi penjualan buah.
## Functionalities
- User dapat menekan tombol Add untuk memasukkan buah kedalam keranjang.
- List buah yang telah ditambahkan akan muncul pada label bucket.
- Warning akan muncul apabila keranjang penuh.
## How Does It Works
1. Apa fungsi `BucketEventListener` ?
   <br/>Untuk mendeklarasikan function `onFailed` dan `onSucceed` yang berfungsi sebagai handle event ketika action dijalankan berhasil atau gagal.
2. Alur dan Logika Pemrograman
   <r/>Pada class `MainWindow.xaml.cs` dideklarasikan instance dari berbagai class dalam folder Model. 
```csharp
        Seller abiyu;
        public MainWindow()
        {
            InitializeComponent();

            Bucket keranjangBuah = new Bucket(2);
            BucketController bucketController = new BucketController(keranjangBuah, this);

            abiyu = new Seller("Abiyu", bucketController);

            listBoxBucket.ItemsSource = keranjangBuah.findAll();
        }
```
Kemudian pada function `onFailed` dan `onSucceed` yang muncul ketika interface `BucketEventListener` di inheritance pada class `MainWindow`, lalu diberikan perintah apabila gagal akan muncul warning dan apabila berhasil maka listbox akan di refresh.
```csharp
        public void onFailed(string message)
        {
            MessageBox.Show(message, "Warning");
        }

        public void onSucceed(string message)
        {
            listBoxBucket.Items.Refresh();
        }
```
Terdapat 4 function yang berfungsi sebagai controller pada tiap-tiap button. sebagai contoh dengan function `ButtonBanana_Click` yang berfungsi untuk mengontrol button pisang, dengan mendeklarasikan variabel pisang dari class `Fruit`, kemudian diisi dengan value string sehingga bila button diklik, akan muncul pada listbox.
```csharp
        private void ButtonBanana_Click(object sender, RoutedEventArgs e)
        {
            Fruit pisang = new Fruit("Pisang");
            abiyu.addFruit(pisang);
        }
```