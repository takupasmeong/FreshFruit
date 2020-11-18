using FreshFruit.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FreshFruit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, BucketEventListener
    {
        Seller abiyu;
        public MainWindow()
        {
            InitializeComponent();

            Bucket keranjangBuah = new Bucket(2);
            BucketController bucketController = new BucketController(keranjangBuah, this);

            abiyu = new Seller("Abiyu", bucketController);

            listBoxBucket.ItemsSource = keranjangBuah.findAll();
        }

        public void onFailed(string message)
        {
            MessageBox.Show(message, "Warning");
        }

        public void onSucceed(string message)
        {
            listBoxBucket.Items.Refresh();
        }

        private void ButtonAnggur_Click(object sender, RoutedEventArgs e)
        {
            Fruit anggur = new Fruit("Anggur");
            abiyu.addFruit(anggur);
        }

        private void ButtonApple_Click(object sender, RoutedEventArgs e)
        {
            Fruit apel = new Fruit("Apel");
            abiyu.addFruit(apel);
        }

        private void ButtonBanana_Click(object sender, RoutedEventArgs e)
        {
            Fruit pisang = new Fruit("Pisang");
            abiyu.addFruit(pisang);
        }

        private void ButtonOrange_Click(object sender, RoutedEventArgs e)
        {
            Fruit jeruk = new Fruit("Jeruk");
            abiyu.addFruit(jeruk);
        }
    }
}
