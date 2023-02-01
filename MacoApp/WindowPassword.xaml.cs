using MaterialDesignMessageBox;
using System.Windows;


namespace MacoApp
{
    public partial class WindowPassword : Window
    {
        private string Login = "admin";
        private string Password = "admin";
        public WindowPassword()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (TBLogin.Text == Login && PasswordBox.Password == Password)
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
            else
            {
                MaterialMessageBox.ShowDialog("Пароль или логин введены неправильно");
                return;
            }

        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            EntryiWindow entryiWindow = new EntryiWindow();
            entryiWindow.Show();
            this.Close();
        }
    }
}
