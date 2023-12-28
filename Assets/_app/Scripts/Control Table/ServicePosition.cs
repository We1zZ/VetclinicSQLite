using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServicePosition
{
    DB db;

    public ServicePosition()
    {
        db = new DB();
    }
    public IEnumerable<Owners> GetAnimalsNames(string name)
    {
        return db.GetConnection().Table<Owners>().Where(x => x.First_name == name);
    }
    public Owners GetAnimalName(string name)
    {
        return db.GetConnection().Table<Owners>().Where(x => x.First_name == name).FirstOrDefault();
    }
}
