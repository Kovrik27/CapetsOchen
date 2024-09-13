using ConsoleApp47;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CapetsOchen.NeDyadyaPushkin
{
    public static class BDRojaet
    {
        public static List<Character> GetCharacters(this DataBase database)
        {
            return MysqlTools.SimpleSelectFromTable<Character>();
        }

        public static Character GetCharacterByID(this DataBase database, int id)
        {
            return MysqlTools.SelectRowFromTable<Character>(id);
        }

        public static List<RacesCharacters> GetRacesCharacters(this DataBase database) 
        {
            return MysqlTools.SimpleSelectFromTable<RacesCharacters>();
        }

        public static List<WeaponsCharacters> GetWeaponsCharacters(this DataBase database)
        {
            return MysqlTools.SimpleSelectFromTable<WeaponsCharacters>();
        }

    }
}
