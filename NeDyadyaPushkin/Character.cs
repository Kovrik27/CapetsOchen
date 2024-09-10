using CapetsOchen.NeDyadyaPushkin;
using System.Security.RightsManagement;

[MysqlTable("NameCharacters")]
    public class Character : BaseModel
    {
    [MysqlColumn("Name")]
    public string Name { get; set; }
    [MysqlColumn("Lastname")]
    public string Lastname { get; set; }
    [MysqlRelation("RacesCharacters", "Id_Characters")]
    public List<RacesCharacters> racesCharacters { get; set; }
    
    public List<WeaponsCharacters> weaponsCharacters { get; set; }
    }

