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
    /// Логика взаимодействия для create.xaml
    /// </summary>
    public partial class create : Window
    {
        public create()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\vbv\Maze\Maze\PROT_MAZE2.MDF.mdf;Integrated Security=True;Connect Timeout=30");

        private void Create_hero_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlCommand com = new SqlCommand(@"Insert into [Hero] ([Hero_name]) values ('"+name_hero_box.Text+ "')",con);
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
                create_states states = new create_states();
                states.Show();
                this.Close();
            }
            catch
            {
                MessageBox.Show("", "Внимание", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
