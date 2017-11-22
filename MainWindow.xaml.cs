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

namespace WPFCrypthographyExample1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btDecode_Click(object sender, RoutedEventArgs e)
        {
            string encodedWord = tbDecodeStartWord.Text;
            int key = 0;

            try
            {
                key = Convert.ToInt32(tbDecodeKey.Text);
            }
            catch (Exception exp)
            {
                MessageBox.Show("Некорректное значение ключа.", "Ошибка");
                return;
            }

            if (encodedWord.Equals("")) {
                MessageBox.Show("Некорректное значение слова.", "Ошибка");
                return;
            }

            tbDecodeResult.Text = Cryptograghy.Decode(encodedWord.ToLower(), key);
        }

        private void btEncode_Click(object sender, RoutedEventArgs e)
        {
            string word = tbEncodeStartWord.Text;
            int key = 0;

            try
            {
                key = Convert.ToInt32(tbEncodeKey.Text);
            }
            catch (Exception exp)
            {
                MessageBox.Show("Некорректное значение ключа.", "Ошибка");
                return;
            }

            if (word.Equals(""))
            {
                MessageBox.Show("Некорректное значение слова.", "Ошибка");
                return;
            }

            tbEncodeResult.Text = Cryptograghy.Encode(word.ToLower(), key);
        }
    }
}
