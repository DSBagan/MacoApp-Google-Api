using MaterialDesignColors;
using MaterialDesignMessageBox;
using MaterialDesignThemes.Wpf;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.IO;
using System.Windows;
using System.Windows.Input;


namespace MacoApp
{
    public partial class CalculationWindow : Window
    {
        SqlRequests sqlRequests = new SqlRequests();
        public ObservableCollection<ClassList> ClassLists { get; set; }
        List<ClassList> ListCalc { get; set; }

        int Count = 1;

        public int quantityBar = 0;
        public CalculationWindow()
        {
            InitializeComponent();
            Loaded += CalculationWindow_Loaded;
            SaveCalc.IsEnabled = false;
        }

        private void CalculationWindow_Loaded(object sender, RoutedEventArgs e)
        {
            ButtonSaveTxt.IsEnabled = false;
            var timer = new System.Windows.Threading.DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.IsEnabled = true;
            timer.Tick += (o, t) => { TBDate.Text = DateTime.Now.ToString(); };
            timer.Start();
        }

        private void ButtonCalc_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int count = 0;
                string queryString;
                int quantity = Int32.Parse(TextBoxColvo.Text);
                int System = Int32.Parse(ComboBoxSystem.Text);
                string side = ComboBoxSide.Text;
                int FFH = Int32.Parse(TextBoxFFH.Text);
                int FFB = Int32.Parse(TextBoxFFB.Text);
                string Lower_loop = ComboBoxLL.Text;
                string Micro_ventilation = ComboBoxMv.Text;

                if (FFH < 601)
                {
                    MaterialMessageBox.ShowDialog("Высота не может быть менее 601 мм");
                    //MessageBox.Show("Высота не может быть менее 601 мм", "Не вышло");
                    return;
                }
                else if (FFB < 400)
                {
                    MaterialMessageBox.ShowDialog("Ширина не может быть менее 400 мм");
                    return;
                }
                else if (FFH > 2350)
                {
                    MaterialMessageBox.ShowDialog("Высота не может быть более 2350 мм");
                    return;
                }
                else if (FFB > 1050)
                {
                    MaterialMessageBox.ShowDialog("Ширина не может быть ,более 1050 мм");
                    return;
                }
                if (quantity == 0)
                {
                    MaterialMessageBox.ShowDialog("Укажите корректное количество комплектов");
                    return;
                }

                queryString = sqlRequests.QueryString(System, side, FFH, FFB, Lower_loop, Micro_ventilation); //Вытаскиваем из класса команду для SQL-запроса
                quantityBar = sqlRequests.Que(); //Вытаскиваем из класса количество ответных планок

                using (var connection = new SqliteConnection("Data Source=Macoapp.db"))
                {
                    ObservableCollection<ClassList> collection = null; //Обнуляем коллекцию для нового расчета
                    collection = new ObservableCollection<ClassList>();
                    GridList.ItemsSource = collection;
                    connection.Open();
                    SqliteCommand command = new SqliteCommand(queryString, connection);
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows) // если есть данные
                        {
                            while (reader.Read())   // построчно считываем данные
                            {
                                count++;
                                //Записываем данные в объект класса и ,тем самым, передаём в таблицу
                                if (reader.GetValue(2).ToString() == "34623" || reader.GetValue(2).ToString() == "34850")
                                {
                                    collection.Add(new ClassList() { Id = count, Article = "" + reader.GetValue(2).ToString(), Name = "" + reader.GetValue(1).ToString(), Quantity = (int.Parse(reader.GetValue(3).ToString()) * quantity) * quantityBar });

                                }
                                else
                                {
                                    collection.Add(new ClassList() { Id = count, Article = "" + reader.GetValue(2).ToString(), Name = "" + reader.GetValue(1).ToString(), Quantity = (int.Parse(reader.GetValue(3).ToString()) * quantity) });
                                }
                            }
                        }
                    }
                    connection.Close();
                }
                SaveCalc.IsEnabled = true;
            }
            catch (Exception)
            {
                //MaterialMessageBox.ShowDialog("Одно или несколько полей пустое");
                return;
            }
        }

        private void SaveCalc_Click(object sender, RoutedEventArgs e)
        {
            string queryString;
            int quantity = Int32.Parse(TextBoxColvo.Text);
            int System = Int32.Parse(ComboBoxSystem.Text);
            string side = ComboBoxSide.Text;
            int FFH = Int32.Parse(TextBoxFFH.Text);
            int FFB = Int32.Parse(TextBoxFFB.Text);
            string Lower_loop = ComboBoxLL.Text;
            string Micro_ventilation = ComboBoxMv.Text;

            string Article;
            string Name;
            int Qantity;

            LBListCalc.Items.Add("" + Count + ". " + TextBoxFFB.Text + "/" + TextBoxFFH.Text + ", " + ComboBoxSystem.Text + "я, Откр. " + ComboBoxSide.Text + ", Ниж. петл.- " + ComboBoxLL.Text);
            Count++;
            queryString = sqlRequests.QueryString(System, side, FFH, FFB, Lower_loop, Micro_ventilation); //Вытаскиваем из класса команду для SQL-запроса
            quantityBar = sqlRequests.Que(); //Вытаскиваем из класса количество ответных планок

            using (var connection = new SqliteConnection("Data Source=Macoapp.db"))
            {
                ObservableCollection<ClassList> collection = null; //Обнуляем коллекцию для нового расчета
                collection = new ObservableCollection<ClassList>();
                GridList.ItemsSource = collection;
                connection.Open();
                SqliteCommand command = new SqliteCommand(queryString, connection);
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Article = reader.GetValue(2).ToString();
                            Name = reader.GetValue(1).ToString();
                            Qantity = (int.Parse(reader.GetValue(3).ToString()));

                            int article = Article.Length;
                            int name = Name.Length;
                            //Записываем данные в LBList
                            if (Article == "34623" || Article == "34850")
                            {
                                if (article < 10)
                                {
                                    for (int i = 0; i < 10 - article; i++)
                                    {
                                        Article += " ";
                                    }
                                }
                                Qantity = (Qantity * quantity) * quantityBar;
                                LBList.Items.Add("" + Article + "                                                       " + Qantity);
                            }
                            else
                            {
                                if (article < 10)
                                {
                                    for (int i = 0; i < 10 - article; i++)
                                    {
                                        Article += " ";
                                    }
                                }
                                Qantity = (Qantity * quantity);
                                LBList.Items.Add("" + Article + "                                                       " + Qantity);
                            }
                        }
                    }
                }
                connection.Close();
            }
            ButtonSaveTxt.IsEnabled = true;
            SaveCalc.IsEnabled = false;
            TextBoxColvo.Text = "1";
        }


        //ввод только цифр в текстбоксы
        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            SaveCalc.IsEnabled = false;
            int val;
            if (!Int32.TryParse(e.Text, out val) && e.Text != "-")
            {
                e.Handled = true; // отклоняем ввод
            }
        }
        //ввод только цифр в текстбоксы (пробел тоже нам не нужен)
        private void TextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            SaveCalc.IsEnabled = false;
            if (e.Key == Key.Space)
            {
                e.Handled = true; // если пробел, отклоняем ввод
            }
        }
        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            EntryiWindow entryiWindow = new EntryiWindow();
            entryiWindow.Show();
            this.Close();
        }

        //Сохранение расчета в файл
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Code.Text == "")
            {
                MaterialMessageBox.ShowDialog("Введите шифр фирмы");
                return;
                
            }

            if (LBList.Items == null)
            {
                MaterialMessageBox.ShowDialog("Сначала произведите расчет, нечего сохранять.");
                return;
            }

            else
            {
                // Проверяем есть ли на диске C папка, если нет- создаем
                Directory.CreateDirectory(@"C:\FURNMACO\");
                String date = DateTime.Now.ToString(" dd.MM.yyyy HH-mm-ss");
                int CTlangth = Code.Text.Length;
                if (CTlangth < 6)
                {
                    for (int i = 0; i < 6-CTlangth; i++)
                    {
                        Code.Text = "0" + Code.Text;
                    }
                }
                FileStream fs = new FileStream(@"C:\FURNMACO\" + "Z" + Code.Text + " " + date + ".txt", FileMode.Create); //Присваеваем имя файлу
                StreamWriter streamWriter = new StreamWriter(fs);

                streamWriter.WriteLine("                    Шифр фирмы " + Code.Text);
                streamWriter.WriteLine("                    Фирма 123");
                streamWriter.WriteLine("                    Заявка №");
                streamWriter.WriteLine("                    Название");
                streamWriter.WriteLine("                    Дата заявки" + date);
                streamWriter.WriteLine("--------------------------------------------------------------------------------");
                streamWriter.WriteLine("    Артикул                       Название                      Кол.  Ед.изм.");
                streamWriter.WriteLine("--------------------------------------------------------------------------------");

                try
                {
                    for (int i = 0; i < LBList.Items.Count; i++)
                    {
                        streamWriter.WriteLine("" + LBList.Items[i]);
                    }
                    
                    streamWriter.WriteLine("--------------------------------------------------------------------------------");
                    streamWriter.WriteLine();
                    streamWriter.WriteLine("                    Заявку составил________________________");
                    streamWriter.Close();
                    fs.Close();


                    MaterialMessageBox.ShowDialog("Файл успешно сохранен");                  
                }
                catch
                {
                    MaterialMessageBox.ShowDialog("Ошибка при сохранении файла!");
                }
                LBListCalc.Items.Clear();
                LBList.Items.Clear();
                Count = 1;
            }
            ButtonSaveTxt.IsEnabled = false;
        }
    }
}
