using UnityEngine;

public class MonoVisit : MonoBehaviour
{
    private Service _service;
    [SerializeField] private Canvas _canvas;
    [SerializeField] private TableRecord _table;
    void Start()
    {
        _service = new Service();
    }
    public void OnAddOnwers(string first, string last, string middle, string phone, string species, string breed, string gender, string brith, string diagnosis, string dos, string service, int cost, int veterinar_id, int visiting_id)
    {
        int nextId = _service.GetNextOwnerId();
        Debug.Log("-----OnAddOwners-----");
        Animals animals = new Animals
        {
            ID_Pet = nextId,
            Veterinarians_ID = veterinar_id,
            Species = species,
            Breed = breed,
            Gender = gender,
            Data_of_Birth = brith
        };

        int animalId = _service.Add(animals);

        Owners owner = new Owners
        {
            ID_Owners = nextId,
            Pet_ID = animalId,
            First_name = first,
            Last_name = last,
            Midle_name = middle,
            Phone = phone,
        };
        int onwerid = _service.Add(owner);
        Sick_leave stick = new Sick_leave
        {
            Owners_ID = onwerid,
            Diagnosis = diagnosis,
            Description_of_symptoms = dos,
            Cost = cost,
            Service_name = service,
            Visiting_ID = visiting_id,     
        };
        _service.Add(stick);
        _table.AddRecord(owner, stick);
        _canvas.enabled = false;
    }
}
