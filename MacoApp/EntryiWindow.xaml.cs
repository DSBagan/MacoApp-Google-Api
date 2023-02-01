using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Reflection;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Media;

namespace MacoApp
{
    public partial class EntryiWindow : Window
    {
        WorkGoogleDrive workGoogleDrive = new WorkGoogleDrive();
        static string path = new FileInfo(Assembly.GetEntryAssembly().Location).Directory.ToString()+"\\Macoapp.db";

        public EntryiWindow()
        {
            InitializeComponent();       
            Loaded += EntryiWindow_Loaded;
        }
        private bool CheckNet() // Проверка подключения к сети
        {
            bool stats;
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable() == true)
            {
                stats = true;
                IntOff.Visibility = Visibility.Collapsed;
                IntOn.Visibility = Visibility.Visible;
            }
            else
            {
                stats = false;
                IntOn.Visibility = Visibility.Collapsed;
                IntOff.Visibility = Visibility.Visible;
            }
            return stats;
        }

        private void EntryiWindow_Loaded(object sender, RoutedEventArgs e)
        {
            if (CheckNet() == true)  // Проверяем подключение к сети
            {
                try
                {
                    //Если доступ к сети есть, то удаляем файл с БД и далее качаем новый
                    FileInfo fileInf = new FileInfo(path);
                    if (fileInf.Exists)
                    {
                        fileInf.Delete();                   
                    }
                }
                catch (System.Exception)
                {                   
                    return;
                }
                WebClient webClient = new WebClient();
                //Качаем БД с Google Drive
                webClient.DownloadFile("Ссылка на файл в гугл диске", path);
                webClient.Dispose();

            }
            else 
            {
                return;
            }
        }

        private void ButtonEditor_Click(object sender, RoutedEventArgs e)
        {
            WindowPassword windowPassword = new WindowPassword();
            windowPassword.Show();
            this.Close();

        }

        private void ButtonCalculation_Click(object sender, RoutedEventArgs e)
        {
            CalculationWindow calculationWindow = new CalculationWindow();
            calculationWindow.Show();
            this.Close();
        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            workGoogleDrive.DeleteFile("123");
        }
    }
}