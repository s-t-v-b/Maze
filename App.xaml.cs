using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Maze
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
    {
        //InitializeComponent();
        Application.LoadComponent(this, new Uri("MainWindow.xaml", UriKind.Relative));
    }
}
public partial class App : Application
    {
        public App()
        {
            // Подписались на событие, что запущен объект Application 
            this.Startup += new StartupEventHandler(App_Startup);
            // На всякий случай подписались на событие необработанных исключений
            this.DispatcherUnhandledException += App_DispatcherUnhandledException;
        }
        void App_DispatcherUnhandledException(object sender,
System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            e.Handled = true;// Продолжить выполнение
        }
        void App_Startup(object sender, StartupEventArgs e)
        {
            // Создание объекта стартового окна
            MainWindow mainWindows = new MainWindow();
            // Настраиваем объект окна
            mainWindows.Title = "НАзвание Опционально";
            // Показываем окно
            mainWindows.Show();
        }
    }
}
