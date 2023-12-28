using SQLite4Unity3d;
public class Visiting
{
    [PrimaryKey, AutoIncrement] 
    public int ID_Visit{ get; set; }
    public string Date_and_time { get; set; }
    public int Doctor_ID { get; set; }
}
