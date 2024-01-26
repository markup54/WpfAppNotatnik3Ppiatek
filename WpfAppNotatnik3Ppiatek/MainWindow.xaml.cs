using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace WpfAppNotatnik3Ppiatek
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Zamknij_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Autorem jest klasa 3P", "Informacje o autorze");
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            wpis_txt.Background = Brushes.Bisque;
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            wpis_txt.Background = Brushes.LightBlue;
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            wpis_txt.Background = Brushes.LightPink;
        }

        private void MenuItem_Checked(object sender, RoutedEventArgs e)
        {
            wpis_txt.Background = Brushes.Black;
            wpis_txt.Foreground = Brushes.White;
        }

        private void MenuItem_Unchecked(object sender, RoutedEventArgs e)
        {
            wpis_txt.Background =Brushes.White ;
            wpis_txt.Foreground = Brushes.Black;
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            if(wpis_txt.Text.Length > 0)
            {
               var Rezultat =  MessageBox.Show("Zostanie usunięty wpis, czy na pewno tego chcesz?",
                   "Pytanie",
                    MessageBoxButton.YesNo, MessageBoxImage.Question);
                if(Rezultat == MessageBoxResult.Yes)
                {
                    wpis_txt.Text = string.Empty;
                }
            }
       
        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            //https://learn.microsoft.com/pl-pl/dotnet/desktop/wpf/windows/how-to-open-common-system-dialog-box?view=netdesktop-8.0
            var oknoDialowe = new OpenFileDialog();
            oknoDialowe.Filter = "PlainText | *.txt";
            if(oknoDialowe.ShowDialog() == true)
            {
                string nazwaPliku = oknoDialowe.FileName;
                wpis_txt.Text = File.ReadAllText(nazwaPliku);
            }
        }

        private void MenuItem_Click_6(object sender, RoutedEventArgs e)
        {
            var oknoDialogowe = new SaveFileDialog();
            oknoDialogowe.Filter = "PlainText| *.txt";
            if(oknoDialogowe.ShowDialog() == true)
            {
                string nazwaPliku = oknoDialogowe.FileName;
                File.WriteAllText(nazwaPliku,wpis_txt.Text);
            }
        }
    }
}
