
using _10_mod3.Data;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
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

namespace _10_mod3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

            OpenFileDialog fileDialog = new OpenFileDialog { Filter = "Json files | *.json" };

            Student student = null;

            if (fileDialog.ShowDialog() != true || !File.Exists(fileDialog.FileName))
            {
                MessageBox.Show("Ошибка при открытии файла");
                Application.Current.Shutdown();
                return;
            }

            try
            {
                student = JsonSerializer.Deserialize<Student>(File.ReadAllText(fileDialog.FileName));

                if (student == null)
                {
                    MessageBox.Show("Ошибка!!!");
                    Application.Current.Shutdown();
                    return;
                }
            
            }
            catch
            {
                MessageBox.Show("Ошибка!!!");
                Application.Current.Shutdown();
            }
            
            DataContext = student;
        }
    }
}
