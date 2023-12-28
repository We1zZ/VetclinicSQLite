using SQLite4Unity3d;

public class Animals
{
    [PrimaryKey, AutoIncrement]
    public int ID_Pet { get; set; }
    public string Species { get; set; }
    public string Breed { get; set; }
    public string Gender { get; set; }
    public string Data_of_Birth { get; set; }
    public int Veterinarians_ID { get; set; }
}
