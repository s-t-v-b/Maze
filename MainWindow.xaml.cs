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
using System.Data.SqlClient;

namespace Maze
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        

        private void Exit_B_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\vbv\Maze\Maze\PROT_MAZE2.MDF.mdf;Integrated Security=True;Connect Timeout=30");
        private void New_g_b_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlCommand com = new SqlCommand("Select [id_hero] from [Hero] where id_hero = 1 ", con);
                con.Open();
                SqlDataReader reader = com.ExecuteReader();
                if (reader.HasRows)
                {
                    MessageBoxResult result = MessageBox.Show("Для создание персонажа надо удалить имеющегося", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                    if (result == MessageBoxResult.Yes)
                    {
                        reader.Close();
                        con.Close();
                        SqlCommand comd = new SqlCommand("Delete from [Hero] where [id_hero]='1'", con);
                        con.Open();
                        comd.ExecuteNonQuery();
                        con.Close();
                        this.Hide();
                        create cr = new create();
                        cr.Show();
                    }
                }
                else
                {
                    this.Hide();
                    create cr = new create();
                    cr.Show();
                }
                reader.Close();
                con.Close();
                
            }
            catch
            {
                MessageBox.Show("", "Внимание",MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
