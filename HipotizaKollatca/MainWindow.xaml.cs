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

namespace HipotizaKollatca
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int CountOfSteps;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int temp = Convert.ToInt32(numb.Text);
            proccess.Text = "";
            result.Content = "";
            CountOfSteps = 0;
            if (temp > 0)
            {
                
                while(temp > 1)
                {
                    if ((temp % 2) == 0)
                    {
                        proccess.Text += temp.ToString() + " / 2 = " + (temp / 2).ToString() + "\r\n";
                        temp /= 2;
                    }
                    else
                    {
                        proccess.Text += temp.ToString() + " * 3 + 1 = " + (temp * 3 + 1).ToString() + "\r\n";
                        temp = temp * 3 + 1;
                    }
                    CountOfSteps++;
                }
                result.Content = "Кол-во шагов:" + CountOfSteps.ToString();
            }
        }
    }
}
