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

namespace QuadrantQuandary
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
        string stringInput = "1\r\n1";

        private void btnGo_Click(object sender, RoutedEventArgs e)
        {
            string stringInput = txbInput.Text;
            Console.WriteLine(stringInput);
            Char charRange = '\r';
            int startNewLine = stringInput.IndexOf(charRange);
            // To find last occurrence of the character use: int endIndex = stringInput.LastIndexOf(charRange);
            Console.WriteLine(startNewLine);
            int start2nd = stringInput.IndexOf(charRange)+2;
            Console.WriteLine(start2nd);
            if (start2nd == 5)
            {
                Console.WriteLine("You did a good");
            }
        }
    }
}
