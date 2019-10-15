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

namespace AppMultiThreading
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

        private void Btn_Task_Click(object sender, RoutedEventArgs e)
        {
            //DoWork();
            Task.Factory.StartNew(DoWork);
        }

        private void DoWork()
        {
            //azione che crusha tutto perchè richiede parecchi calcoli(se fatto in un unico thread)
            for (int i = 1; i < 10000; i++)
            {
                for (int j = 1; j < 10000; j++)
                {

                }
            }
            Lbl_Result.Content = "Finito";
        }
    }
}
