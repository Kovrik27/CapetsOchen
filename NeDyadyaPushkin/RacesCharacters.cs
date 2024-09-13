using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapetsOchen.NeDyadyaPushkin
{
    [MysqlTable ("RacesCharacters")]
    public class RacesCharacters
    {
        [MysqlColumn("Title")]
        public string Title { get; set; }
        [MysqlColumn("Id_Character")]
        public int IDCharacter {  get; set; } 
    }
}
