using SQLite4Unity3d;
public class Sick_leave
{
    [PrimaryKey, AutoIncrement] public int ID_List { get; set; }
    public string Description_of_symptoms { get; set; }
    public string Diagnosis { get; set; }
    public string Service_name { get; set; }
    public int Cost { get; set; }   
    public int Owners_ID { get; set; }
    public int Visiting_ID { get; set; }
}
