using System.Windows;

namespace MacoApp
{
    /// <summary>
    /// Логика взаимодействия для WindowElementAdd.xaml
    /// </summary>
    public partial class WindowElementAdd : Window
    {
        public Element Element { get; private set; }
        public WindowElementAdd(Element element)
        {
            InitializeComponent();
            Element = element;
            DataContext = Element;
        }

        void Accept_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
