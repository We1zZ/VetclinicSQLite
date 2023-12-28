
using System.Collections.Generic;
using UnityEngine;

public class ServiceAnimls
{
    DB db;

    public ServiceAnimls()
    {
        db = new DB();
    }
    public IEnumerable<Animals> GetAnimalNames(string name)
    {
        return db.GetConnection().Table<Animals>().Where(x => x.Breed == name);
    }
    public Animals GetAnimalName(string name)
    {
        return db.GetConnection().Table<Animals>().Where(x => x.Breed == name).FirstOrDefault();
    }
    public IEnumerable<Animals> GetAnimalsID(int id)
    {
        return db.GetConnection().Table<Animals>().Where(x => x.ID_Pet == id);
    }
    public Animals GetAnimalID(int id)
    {
        return db.GetConnection().Table<Animals>().Where(x => x.ID_Pet == id).FirstOrDefault();
    }
}
