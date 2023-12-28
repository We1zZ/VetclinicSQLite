using SQLite4Unity3d;
public class Veterinarians
{
    [PrimaryKey, AutoIncrement] public int ID_Doctor { get; set; }
    public string First_name { get; set; }
    public string Last_name { get; set; }
    public float Middle_name { get; set; }
    public string Work_Schedule { get; set; }
    public string Phone { get; set; }
    public string Passport { get; set; }
    public string Specialization { get; set; }
    public int ID_List { get; set; }
}
