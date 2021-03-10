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
using Polus.Task4.Data;

namespace Polus.Task4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Person> list = new List<Person>
            {
                new Person{Id = 1, FirstName="Яна", LastName="Петрова"},
                new Person{Id = 2, FirstName="Ольга", LastName="Семенова-Зощенко"},
                new Person{Id = 3, FirstName="Борис", LastName="Сидоров"},
                new Person{Id = 4, FirstName="Иван", LastName="Козлов"},
                new Person{Id = 5, FirstName="Сергей", LastName="Федоров"},
                new Person{Id = 6, FirstName="Прохор", LastName="Громов"},
                new Person{Id = 7, FirstName="Инна", LastName="Васницова-Водкина"},

            };
        }
    }
}
