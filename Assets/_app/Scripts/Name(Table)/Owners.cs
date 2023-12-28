using SQLite4Unity3d;
public class Owners
{
    [PrimaryKey, AutoIncrement] 
    public int ID_Owners { get; set; }
    public string First_name { get; set; }
    public string Last_name { get; set; }
    public string Midle_name { get; set; }
    public string Phone { get; set; }
    public int Pet_ID { get; set; } 
}
