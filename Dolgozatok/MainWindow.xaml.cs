using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Dolgozatok
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Dolgozat> dolgozatok = new List<Dolgozat>();
        public MainWindow()
        {
            InitializeComponent();
            dolgozatok.Add(new Dolgozat("Kiss Péter", 16, 87));
            dolgozatok.Add(new Dolgozat("Nagy Anna", 17, 92));
            dolgozatok.Add(new Dolgozat("Szabó Tamás", 16, 78));
            dolgozatok.Add(new Dolgozat("Tóth Éva", 18, 95));
            dolgozatok.Add(new Dolgozat("Varga Bence", 17, 81));
            dolgozatok.Add(new Dolgozat("Horváth Zsolt", 16, 65));
            dolgozatok.Add(new Dolgozat("Molnár Réka", 18, 89));
            dolgozatok.Add(new Dolgozat("Lakatos Dániel", 17, 72));
            dg.ItemsSource = dolgozatok;
        }

        private void Hozzaad(object sender, RoutedEventArgs e)
        {
            if (nev.Text == "" || kor.Text == "" || pont.Text == "")
            {
                MessageBox.Show("Mindent ki kell tölteni");
                return;
            }

            
            
            if (!int.TryParse(pont.Text, out int pontok)||!int.TryParse(kor.Text, out int kora))
            {
                MessageBox.Show("Csak szám lehet az életkor v a pont");
                return;
            }
            if (pontok < 0 || pontok>100)
            {
                MessageBox.Show("A pontszám csak 0 és 100 között lehet");
                return;
            }

            dolgozatok.Add(new Dolgozat(nev.Text, kora, pontok));
            dg.Items.Refresh();

            nev.Clear();
            kor.Clear();
            pont.Clear();
        }

        private void Mentes(object sender, RoutedEventArgs e)
        {

        }
    }
}