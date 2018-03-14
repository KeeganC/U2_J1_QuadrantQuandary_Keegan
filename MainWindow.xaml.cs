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
            int xValue, yValue;
            String strX, strY;
            string stringInput = txbInput.Text;
            //NIU Console.WriteLine(stringInput);
            Char charRange = '\r';
            int startNewLine = stringInput.IndexOf(charRange);
            // To find last occurrence of the character use: int endIndex = stringInput.LastIndexOf(charRange);
            //NIU Console.WriteLine(startNewLine);
            int start2nd = stringInput.IndexOf(charRange) + 2;
            //NIU Console.WriteLine(start2nd);
            if (start2nd == 5)
            {
                Console.WriteLine("You did a good");
            }
            //getting first coord
            strX = txbInput.Text.Substring(0, txbInput.Text.IndexOf("\r"));
            //Tryparse changes str to int
            int.TryParse(strX, out xValue);
            //second coord
            strY = txbInput.Text.Substring(txbInput.Text.IndexOf("\r") + 2, txbInput.Text.Length - txbInput.Text.IndexOf("\r") - 2);
            int.TryParse(strY, out yValue);

            //now we check if they are positive or not
            if (xValue > 0)
            {
                if (yValue > 0)
                {
                    MessageBox.Show("Quadrant 1");
                }
                else
                {
                    MessageBox.Show("Quadrant 4");
                }
            }
            else
            {
                if (yValue > 0)
                {
                    MessageBox.Show("Quadrant 2");
                }
                else
                {
                    MessageBox.Show("Quadrant 3");
                }
            }
        }
    }
}
