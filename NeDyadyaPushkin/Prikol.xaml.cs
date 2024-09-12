using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace CapetsOchen.NeDyadyaPushkin
{
    /// <summary>
    /// Логика взаимодействия для Prikol.xaml
    /// </summary>
    public partial class Prikol : Window
    {
        public ObservableCollection<Character> characters;

        public ObservableCollection<Character> Characters
        {
            get => characters; set { characters = value; }
        }

        public Prikol()
        {
            InitializeComponent();
            DataContext = this;

        }

    }
}
