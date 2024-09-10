public abstract class BaseModel
{
    [MysqlColumn("ID")]
    public int ID { get; set; }
    [MysqlColumn("create_hash")]
    public string Hash { get; set; }
}
