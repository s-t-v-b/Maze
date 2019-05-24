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
using System.Windows.Shapes;

namespace Maze.location.prolog
{
    /// <summary>
    /// Логика взаимодействия для start.xaml
    /// </summary>
    public partial class start : Window
    {
        public start()
        {
            InitializeComponent();
        }

        private void Prol_tb_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        public int a = 0;
        private void Conti_Click(object sender, RoutedEventArgs e)
        {
            if (a==0)
            {
                prol_tb.Text = "Fkfjwiem";
                a++;
            }
           else if (a==1)
            {
                prol_tb.Text = "It's work!";
                a++;
            }
        }
    }
}
