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

namespace szinkevero
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

        public void EltarolasButton_Click(object sender, RoutedEventArgs e)
        {
            AdatokListBox.Items.Add($"({Convert.ToInt32(RedSlider.Value)},{Convert.ToInt32(GreenSlider.Value)},{Convert.ToInt32(BlueSlider.Value)})");
        }

        private void FileIrasButton_Click(object sender, RoutedEventArgs e)
        {
            using (StreamWriter writetext = new StreamWriter("szinek.csv"))
            {
                writetext.WriteLine($"({Convert.ToInt32(RedSlider.Value)},{Convert.ToInt32(GreenSlider.Value)},{Convert.ToInt32(BlueSlider.Value)})");
            }
        }

        private void BetoltesButton_Click(object sender, RoutedEventArgs e)
        {
            AdatokListBox.Items.Clear();
            using (StreamReader readtext = new StreamReader("szinek.csv"))
            {
                string sor = Convert.ToString(Console.ReadLine());
                AdatokListBox.Items.Add(sor);
            }
        }
    }
}
