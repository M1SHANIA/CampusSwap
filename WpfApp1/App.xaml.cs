using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WpfApp1.Model;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            // Здесь строка подключения может быть загружена из файла конфигурации
            var connectionString = "Data Source=myDB.db";
            var dbContext = new DatabaseContext(connectionString);
            bool isConnected = dbContext.TestConnection();
            if (isConnected)
            {
                MessageBox.Show("Подключение к базе данных успешно установлено!");
            }
            else
            {
                MessageBox.Show("Не удалось подключиться к базе данных.");
            }
            // Зарегистрируйте dbContext в вашем контейнере зависимостей
            // ...
        }
    }
}
