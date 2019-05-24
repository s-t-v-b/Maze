using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace Maze
{
    /// <summary>
    /// Логика взаимодействия для create_states.xaml
    /// </summary>
    public partial class create_states : Window
    {
        public create_states()
        {
            InitializeComponent();
        }
        public int free = 10;
        public int str = 1;
        public int vit = 1;
        public int lvk = 1;
        public int ink = 1;
        public int vis = 1;
        public int luc = 1;
        private void Str_up_Click(object sender, RoutedEventArgs e)
        {
            if (free > 0 && str < 10)
            {
                free--;
                str++;
                free_tb.Text = Convert.ToString(free);
                str_tb.Text = Convert.ToString(str);
            }
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\vbv\Maze\Maze\PROT_MAZE2.MDF.mdf;Integrated Security=True;Connect Timeout=30");
        private void Vin_up_Click(object sender, RoutedEventArgs e)
        {
            if (free > 0 && vit < 10)
            {
                free--;
                vit++;
                free_tb.Text = Convert.ToString(free);
                vit_tb.Text = Convert.ToString(vit);
            }
        }

        private void Lvk_up_Click(object sender, RoutedEventArgs e)
        {
            if (free > 0 && lvk < 10)
            {
                free--;
                lvk++;
                free_tb.Text = Convert.ToString(free);
                lvk_tb.Text = Convert.ToString(lvk);
            }
        }

        private void Int_up_Click(object sender, RoutedEventArgs e)
        {
            if (free > 0 && ink < 10)
            {
                free--;
                ink++;
                free_tb.Text = Convert.ToString(free);
                int_tb.Text = Convert.ToString(ink);
            }
        }

        private void Vis_up_Click(object sender, RoutedEventArgs e)
        {
            if (free > 0 && vis < 10)
            {
                free--;
                vis++;
                free_tb.Text = Convert.ToString(free);
                vis_tb.Text = Convert.ToString(vis);
            }
        }

        private void Luc_up_Click(object sender, RoutedEventArgs e)
        {
            if (free > 0 && luc < 10)
            {
                free--;
                luc++;
                free_tb.Text = Convert.ToString(free);
                luc_tb.Text = Convert.ToString(luc);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlCommand com = new SqlCommand("insert into [States] ([str], [vit], [agl], [int], [wes], [luck], [free]) values ('"+str_tb.Text+ "','" + vit_tb.Text + "','" + lvk_tb.Text + "','" + int_tb.Text + "','" + vis_tb.Text + "','" + luc_tb.Text + "', '" + free_tb.Text + "')", con);
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
                location.prolog.start start = new location.prolog.start();
                start.Show();
                this.Close();
            }
            catch
            {
                MessageBox.Show("", "Внимание", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void Luc_down_Click(object sender, RoutedEventArgs e)
        {
            if (free >= 0 && luc>1)
            {
                free++;
                luc--;
                free_tb.Text = Convert.ToString(free);
                luc_tb.Text = Convert.ToString(luc);
            }
        }

        private void Vis_down_Click(object sender, RoutedEventArgs e)
        {
            if (free >= 0 && vis>1)
            {
                free++;
                vis--;
                free_tb.Text = Convert.ToString(free);
                vis_tb.Text = Convert.ToString(vis);
            }
        }

        private void Int_down_Click(object sender, RoutedEventArgs e)
        {
            if (free >= 0 && ink >1)
            {
                free++;
                ink--;
                free_tb.Text = Convert.ToString(free);
                int_tb.Text = Convert.ToString(ink);
            }
        }

        private void Lvk_down_Click(object sender, RoutedEventArgs e)
        {
            if (free >= 0 && lvk > 1)
            {
                free++;
                lvk--;
                free_tb.Text = Convert.ToString(free);
                lvk_tb.Text = Convert.ToString(lvk);
            }
        }

        private void Vit_down_Click(object sender, RoutedEventArgs e)
        {
            if (free >= 0 && vit > 1)
            {
                free++;
                vit--;
                free_tb.Text = Convert.ToString(free);
                vit_tb.Text = Convert.ToString(vit);
            }
        }

        private void Str_down_Click(object sender, RoutedEventArgs e)
        {
            if (free >= 0 && str >1 )
            {
                free++;
                str--;
                free_tb.Text = Convert.ToString(free);
                str_tb.Text = Convert.ToString(str);
            }
        }
    }
}
