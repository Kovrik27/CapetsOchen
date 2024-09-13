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
        private DataBase dataBase;

        public ObservableCollection<Character> characters;

        public ObservableCollection<Character> Characters
        {
            get => characters; set { characters = value;}
            
        }

        public ObservableCollection<RacesCharacters> races;

        public ObservableCollection<RacesCharacters> Races
        {
            get => races; set { races = value; }
        }

        public ObservableCollection<WeaponsCharacters> weapons;

        public ObservableCollection<WeaponsCharacters> Weapons
        {
            get => weapons; set { weapons = value; }
        }

        public Prikol()
        {
            InitializeComponent();
            DataContext = this;
            dataBase = DataBase.Get();
            Characters = new ObservableCollection<Character>(dataBase.GetCharacters());
            Races = new ObservableCollection<RacesCharacters>(dataBase.GetRacesCharacters());
            Weapons = new ObservableCollection<WeaponsCharacters>(dataBase.GetWeaponsCharacters());
        }

    }
}
